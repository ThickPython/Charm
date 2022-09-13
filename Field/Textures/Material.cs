﻿using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Text;
using Field.Entities;
using Field.General;

using File = System.IO.File;


namespace Field.Textures;

public class Material : Tag
{
    public D2Class_AA6D8080 Header;
    public static object _lock = new object();

    
    public Material(TagHash hash) : base(hash)
    {
    }

    protected override void ParseStructs()
    {
        Header = ReadHeader<D2Class_AA6D8080>();
    }
    
    public void SaveAllTextures(string saveDirectory)
    {
        foreach (var e in Header.VSTextures)
        {
            if (e.Texture == null)
            {
                continue;
            }
            // todo change to 64 bit hash?
            string path = $"{saveDirectory}/VS_{e.TextureIndex}_{e.Texture.Hash}";
            if (!File.Exists(path))
            {
                e.Texture.SavetoFile(path); 
            }
        }
        foreach (var e in Header.PSTextures)
        {
            if (e.Texture == null)
            {
                continue;
            }
            // todo change to 64 bit hash?
            string path = $"{saveDirectory}/PS_{e.TextureIndex}_{e.Texture.Hash}";
            if (!File.Exists(path + ".dds") && !File.Exists(path + ".png") && !File.Exists(path + ".tga"))
            {
                e.Texture.SavetoFile(path); 
            }
        }
    }
    
    // [DllImport("HLSLDecompiler.dll", EntryPoint = "DecompileHLSL", CallingConvention = CallingConvention.Cdecl)]
    // public static extern IntPtr DecompileHLSL(
    //     IntPtr pShaderBytecode,
    //     int BytecodeLength,
    //     out int pHlslTextLength
    // );

    public string Decompile(byte[] shaderBytecode, string? type = "ps")
    {
        // tried doing it via dll pinvoke but seemed to cause way too many problems so doing it via exe instead
        // string hlsl;
        // lock (_lock)
        // {
        //     GCHandle gcHandle = GCHandle.Alloc(shaderBytecode, GCHandleType.Pinned);
        //     IntPtr pShaderBytecode = gcHandle.AddrOfPinnedObject();
        //     IntPtr pHlslText = Marshal.AllocHGlobal(5000);
        //     int len;
        //     pHlslText = DecompileHLSL(pShaderBytecode, shaderBytecode.Length, out int pHlslTextLength);
        //     // len = Marshal.ReadInt32(pHlslTextLength);
        //     len = pHlslTextLength;
        //     hlsl = Marshal.PtrToStringUTF8(pHlslText);
        //     gcHandle.Free();
        // }
        // // Marshal.FreeHGlobal(pHlslText);
        // return hlsl;
    
        string directory = "hlsl_temp";
        string binPath = $"{directory}/ps{Hash}.bin";
        string hlslPath = $"{directory}/ps{Hash}.hlsl";

      

        if (!Directory.Exists(directory))
        {
            Directory.CreateDirectory("hlsl_temp/");
        }

        lock (_lock)
        {
            if (!File.Exists(binPath))
            {
                File.WriteAllBytes(binPath, shaderBytecode);
            } 
        }

        if (!File.Exists(hlslPath))
        {
            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.CreateNoWindow = false;
            startInfo.UseShellExecute = false;
            startInfo.FileName = "3dmigoto_shader_decomp.exe";
            startInfo.WindowStyle = ProcessWindowStyle.Hidden;
            startInfo.Arguments = $"-D {binPath}";
            using (Process exeProcess = Process.Start(startInfo))
            {
                exeProcess.WaitForExit();
            }

            if (!File.Exists(hlslPath))
            {
                throw new FileNotFoundException($"Decompilation failed for {Hash}");
            }
        }

        string hlsl = "";
        lock (_lock)
        {
            while (hlsl == "")
            {
                try  // needed for slow machines
                {
                    hlsl = File.ReadAllText(hlslPath);
                }
                catch (IOException)
                {
                    Thread.Sleep(100);
                }
            }
        }
        return hlsl;
    }

    public void SavePixelShader(string saveDirectory)
    {
        if (Header.PixelShader != null && !File.Exists($"{saveDirectory}/PS_{Hash}.usf"))
        {
            string hlsl = Decompile(Header.PixelShader.GetBytecode());

            
            string usf = new UsfConverter().HlslToUsf(this, hlsl, false);
            string vfx = new VfxConverter().HlslToVfx(this, hlsl, false);
            
            

            Directory.CreateDirectory($"{saveDirectory}/Source2");
            Directory.CreateDirectory($"{saveDirectory}/Source2/materials");
            StringBuilder vmat = new StringBuilder();
            if (usf != String.Empty || vfx != String.Empty)
            {
                try
                {
                    File.WriteAllText($"{saveDirectory}/PS_{Hash}.usf", usf);
                    File.WriteAllText($"{saveDirectory}/Source2/PS_{Hash}.vfx", vfx);
                    Console.WriteLine($"Saved pixel shader {Hash}");
                }
                catch (IOException)  // threading error
                {
                }
            }


            //do both and i'll fix it later

            //BUILTIN destiny things
            Directory.CreateDirectory($"{saveDirectory}/../UnityBuiltinShaders");
            Directory.CreateDirectory($"{saveDirectory}/../UnityHDRPShaders");
            string builtinShader = new DestinyToUnityBuiltin().HlslToBuiltinShader(this, hlsl, false);
            if(builtinShader != String.Empty)
            {
                try
                {
                    File.WriteAllText($"{saveDirectory}/../UnityBuiltinShaders/{Hash}_builtin.shader", builtinShader);
                }
                catch (IOException)
                {

                }
            }

            
            //HDRP destiny things
            //Destiny things
            string dHlsl = new DestinyToUnityHLSL().Hlsl2UnityHlsl(this, hlsl, false);
            if (dHlsl != String.Empty)
            {
                try
                {
                    File.WriteAllText($"{saveDirectory}/../UnityHDRPShaders/PS_{Hash}.hlsl", dHlsl);
                }
                catch (IOException)  // threading error
                {
                }
            }


            
            vmat.AppendLine("Layer0 \n{");
            vmat.AppendLine($"   shader \"ps_{Hash}.vfx\"");
            foreach (var e in Header.PSTextures)
            {
                if (e.Texture == null)
                {
                    continue;
                }
                //Console.WriteLine("Saving texture " + e.Texture.Hash + " " + e.TextureIndex + " " + e.Texture.IsSrgb().ToString());
                vmat.AppendLine($"  TextureT{e.TextureIndex} \"materials/Textures/PS_" + $"{e.TextureIndex}_{e.Texture.Hash}.png\"");
            }
            vmat.AppendLine("}");
            
            if(!File.Exists($"{saveDirectory}/Source2/materials/{Hash}.vmat"))
            {
                try
                {
                    File.WriteAllText($"{saveDirectory}/Source2/materials/{Hash}.vmat", vmat.ToString());
                }
                catch (IOException)  
                {
                }
            }
        }
    }
    
    public void SaveVertexShader(string saveDirectory)
    {
        if (Header.VertexShader != null && !File.Exists($"{saveDirectory}/VS_{Hash}.usf"))
        {
            string hlsl = Decompile(Header.VertexShader.GetBytecode(), "vs");
            string usf = new UsfConverter().HlslToUsf(this, hlsl, true);
            if (usf != String.Empty)
            {
                try
                {
                    File.WriteAllText($"{saveDirectory}/VS_{Hash}.usf", usf);
                    Console.WriteLine($"Saved vertex shader {Hash}");
                }
                catch (IOException)  // threading error
                {
                }
            }
        }
    }
}

[StructLayout(LayoutKind.Sequential, Size = 0x3D0)]
public struct D2Class_AA6D8080
{
    public long FileSize;
    public uint Unk08;
    public uint Unk0C;
    public uint Unk10;

    [DestinyOffset(0x70), DestinyField(FieldType.TagHash)]
    public ShaderHeader VertexShader;
    [DestinyOffset(0x78), DestinyField(FieldType.TablePointer)]
    public List<D2Class_CF6D8080> VSTextures;
    [DestinyOffset(0x90), DestinyField(FieldType.TablePointer)]
    public List<D2Class_09008080> Unk90;
    [DestinyField(FieldType.TablePointer)]
    public List<D2Class_90008080> UnkA0;
    [DestinyField(FieldType.TablePointer)]
    public List<D2Class_3F018080> UnkB0;
    [DestinyField(FieldType.TablePointer)]
    public List<D2Class_90008080> UnkC0;
    
    [DestinyOffset(0x2B0), DestinyField(FieldType.TagHash)]
    public ShaderHeader PixelShader;
    [DestinyOffset(0x2B8), DestinyField(FieldType.TablePointer)]
    public List<D2Class_CF6D8080> PSTextures;
    [DestinyOffset(0x2D0), DestinyField(FieldType.TablePointer)]
    public List<D2Class_09008080> Unk2D0;
    [DestinyField(FieldType.TablePointer)]
    public List<D2Class_90008080> Unk2E0;
    [DestinyField(FieldType.TablePointer)]
    public List<D2Class_3F018080> Unk2F0;
    [DestinyField(FieldType.TablePointer)]
    public List<D2Class_90008080> Unk300;
    [DestinyOffset(0x324)] 
    public TagHash PSVector4Container;
    
    [DestinyOffset(0x340), DestinyField(FieldType.TagHash)]
    public ShaderHeader ComputeShader;
    [DestinyOffset(0x348), DestinyField(FieldType.TablePointer)]
    public List<D2Class_CF6D8080> CSTextures;
    [DestinyOffset(0x360), DestinyField(FieldType.TablePointer)]
    public List<D2Class_09008080> Unk360;
    [DestinyField(FieldType.TablePointer)]
    public List<D2Class_90008080> Unk370;
    [DestinyField(FieldType.TablePointer)]
    public List<D2Class_3F018080> Unk380;
    [DestinyField(FieldType.TablePointer)]
    public List<D2Class_90008080> Unk390;
    
}

[StructLayout(LayoutKind.Sequential, Size = 0x18)]
public struct D2Class_CF6D8080
{
    public long TextureIndex;
    [DestinyField(FieldType.TagHash64)]
    public TextureHeader Texture;
}

[StructLayout(LayoutKind.Sequential, Size = 1)]
public struct D2Class_09008080
{
    public byte Value;
}

[StructLayout(LayoutKind.Sequential, Size = 0x10)]
public struct D2Class_3F018080
{
    [DestinyField(FieldType.TagHash64)]
    public Tag Unk00;
}
