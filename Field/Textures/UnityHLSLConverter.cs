using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Text;
using Field.General;
using Field.Models;

namespace Field.Textures;


public class DestinyToUnityHLSL
{
    private StringReader hlsl;
    private StringBuilder unityHLSL;
    private bool bOpacityEnabled = false;
    private List<Texture> textures = new List<Texture>();
    private List<int> samplers = new List<int>();
    private List<Cbuffer> cbuffers = new List<Cbuffer>();
    private List<Input> inputs = new List<Input>();
    private List<Output> outputs = new List<Output>();

    public string Hlsl2UnityHlsl(Material material, string hlslText, bool bIsVertexShader)
    {

        hlsl = new StringReader(hlslText);


        unityHLSL = new StringBuilder();
        bOpacityEnabled = false;
        ProcessHlslData();
        if (bOpacityEnabled)
        {
            unityHLSL.AppendLine("// masked");
        }
        // WriteTextureComments(material, bIsVertexShader);
        WriteCbuffers(material, bIsVertexShader);
        WriteFunctionDefinition(bIsVertexShader);
        hlsl = new StringReader(hlslText);
        bool success = ConvertInstructions();
        if (!success)
        {
            return "";
        }

        if (!bIsVertexShader)
        {
            AddOutputs();
        }

        WriteFooter(bIsVertexShader);
        //Console.WriteLine("Did it");
        return unityHLSL.ToString();
    }

    private void ProcessHlslData()
    {
        string line = string.Empty;
        bool bFindOpacity = false;
        do
        {
            line = hlsl.ReadLine();
            if (line != null)
            {
                if (line.Contains("r0,r1")) // at end of function definition
                {
                    bFindOpacity = true;
                }

                if (bFindOpacity)
                {
                    if (line.Contains("discard"))
                    {
                        bOpacityEnabled = true;
                        break;
                    }
                    continue;
                }

                if (line.Contains("Texture"))
                {
                    Texture texture = new Texture();
                    texture.Dimension = line.Split("<")[0];
                    texture.Type = line.Split("<")[1].Split(">")[0];

                    //unity shenanigans
                    texture.Type = texture.Type == "float4" ? "Texture2D<float4>" : texture.Type;

                    texture.Variable = line.Split("> ")[1].Split(" :")[0];
                    texture.Index = Int32.TryParse(new string(texture.Variable.Skip(1).ToArray()), out int index) ? index : -1;
                    textures.Add(texture);
                }
                else if (line.Contains("SamplerState"))
                {
                    samplers.Add(line.Split("(")[1].Split(")")[0].Last() - 48);
                }
                else if (line.Contains("cbuffer"))
                {
                    hlsl.ReadLine();
                    line = hlsl.ReadLine();
                    Cbuffer cbuffer = new Cbuffer();
                    cbuffer.Variable = "cb" + line.Split("cb")[1].Split("[")[0];
                    cbuffer.Index = Int32.TryParse(new string(cbuffer.Variable.Skip(2).ToArray()), out int index) ? index : -1;
                    cbuffer.Count = Int32.TryParse(new string(line.Split("[")[1].Split("]")[0]), out int count) ? count : -1;
                    cbuffer.Type = line.Split("cb")[0].Trim();
                    cbuffers.Add(cbuffer);
                }
                else if (line.Contains(" v") && line.Contains(" : ") && !line.Contains("?"))
                {
                    Input input = new Input();
                    input.Variable = "v" + line.Split("v")[1].Split(" : ")[0];
                    input.Index = Int32.TryParse(new string(input.Variable.Skip(1).ToArray()), out int index) ? index : -1;
                    input.Semantic = line.Split(" : ")[1].Split(",")[0];
                    input.Type = line.Split(" v")[0].Trim();
                    inputs.Add(input);
                }
                else if (line.Contains("out") && line.Contains(" : "))
                {
                    Output output = new Output();
                    output.Variable = "o" + line.Split(" o")[2].Split(" : ")[0];
                    output.Index = Int32.TryParse(new string(output.Variable.Skip(1).ToArray()), out int index) ? index : -1;
                    output.Semantic = line.Split(" : ")[1].Split(",")[0];
                    output.Type = line.Split("out ")[1].Split(" o")[0];

                    outputs.Add(output);
                }
            }

        } while (line != null);
    }

    private void WriteCbuffers(Material material, bool bIsVertexShader)
    {
        // Try to find matches, pixel shader has Unk2D0 Unk2E0 Unk2F0 Unk300 available
        foreach (var cbuffer in cbuffers)
        {
            unityHLSL.AppendLine($"static {cbuffer.Type} {cbuffer.Variable}[{cbuffer.Count}] = ").AppendLine("{");

            dynamic data = null;
            if (bIsVertexShader)
            {
                if (cbuffer.Count == material.Header.Unk90.Count)
                {
                    data = material.Header.Unk90;
                }
                else if (cbuffer.Count == material.Header.UnkA0.Count)
                {
                    data = material.Header.UnkA0;
                }
                else if (cbuffer.Count == material.Header.UnkB0.Count)
                {
                    data = material.Header.UnkB0;
                }
                else if (cbuffer.Count == material.Header.UnkC0.Count)
                {
                    data = material.Header.UnkC0;
                }
            }
            else
            {
                if (cbuffer.Count == material.Header.Unk2D0.Count)
                {
                    data = material.Header.Unk2D0;
                }
                else if (cbuffer.Count == material.Header.Unk2E0.Count)
                {
                    data = material.Header.Unk2E0;
                }
                else if (cbuffer.Count == material.Header.Unk2F0.Count)
                {
                    data = material.Header.Unk2F0;
                }
                else if (cbuffer.Count == material.Header.Unk300.Count)
                {
                    data = material.Header.Unk300;
                }
                else
                {
                    if (material.Header.PSVector4Container.Hash != 0xffff_ffff)
                    {
                        // Try the Vector4 storage file
                        DestinyFile container = new DestinyFile(PackageHandler.GetEntryReference(material.Header.PSVector4Container));
                        byte[] containerData = container.GetData();
                        int num = containerData.Length / 16;
                        if (cbuffer.Count == num)
                        {
                            List<Vector4> float4s = new List<Vector4>();
                            for (int i = 0; i < containerData.Length / 16; i++)
                            {
                                float4s.Add(StructConverter.ToStructure<Vector4>(containerData.Skip(i * 16).Take(16).ToArray()));
                            }

                            data = float4s;
                        }
                    }

                }
            }


            for (int i = 0; i < cbuffer.Count; i++)
            {
                switch (cbuffer.Type)
                {
                    case "float4":
                        if (data == null) unityHLSL.AppendLine("    float4(0.0, 0.0, 0.0, 0.0),");
                        else
                        {
                            try
                            {
                                if (data[i] is Vector4)
                                {
                                    unityHLSL.AppendLine($"    float4({data[i].X}, {data[i].Y}, {data[i].Z}, {data[i].W}),");
                                }
                                else
                                {
                                    var x = data[i].Unk00.X; // really bad but required
                                    unityHLSL.AppendLine($"    float4({x}, {data[i].Unk00.Y}, {data[i].Unk00.Z}, {data[i].Unk00.W}),");
                                }
                            }
                            catch (Exception e)  // figure out whats up here, taniks breaks it
                            {
                                unityHLSL.AppendLine("    float4(0.0, 0.0, 0.0, 0.0),");
                            }
                        }
                        break;
                    case "float3":
                        if (data == null) unityHLSL.AppendLine("    float3(0.0, 0.0, 0.0),");
                        else unityHLSL.AppendLine($"    float3({data[i].Unk00.X}, {data[i].Unk00.Y}, {data[i].Unk00.Z}),");
                        break;
                    case "float":
                        if (data == null) unityHLSL.AppendLine("    float(0.0),");
                        else unityHLSL.AppendLine($"    float4({data[i].Unk00}),");
                        break;
                    default:
                        throw new NotImplementedException();
                }
            }

            unityHLSL.AppendLine("};");
        }
    }

    /// <summary>
    /// At this point all there is is the cbuffer definition
    /// </summary>
    /// <param name="bIsVertexShader"></param>
    private void WriteFunctionDefinition(bool bIsVertexShader)
    {
        //prelim stuff first. For now, i have no clue what this stuff does, but it works so i'm leaving it in
        unityHLSL.AppendLine("#ifndef MYHLSLINCLUDE_INCLUDED").AppendLine("#define MYHLSLINCLUDE_INCLUDED");


        //Write in the v things (why this is inside the function definition instead of outside i don't know)
        if (!bIsVertexShader)
        {
            foreach (var i in inputs)
            {
                if (i.Type == "float4")
                {
                    unityHLSL.AppendLine($"static {i.Type} {i.Variable} = " + "{1, 1, 1, 1};\n");
                }
                else if (i.Type == "float3")
                {
                    unityHLSL.AppendLine($"static {i.Type} {i.Variable} = " + "{1, 1, 1};\n");
                }
                else if (i.Type == "uint")
                {
                    unityHLSL.AppendLine($"static {i.Type} {i.Variable} = " + "1;\n");
                }
            }
        }

        unityHLSL.AppendLine("#define cmp -").AppendLine("void main_float");
        unityHLSL.Append("(");
        //Explaination in function
        WriteThatDefaultGarbage();
        unityHLSL.Append(")");

        unityHLSL.AppendLine("{").AppendLine("");
        // Output render targets, todo support vertex shader
        unityHLSL.AppendLine("    float4 o0,o1,o2;");
        foreach (var i in inputs)
        {
            if (i.Type == "float4")
            {
                unityHLSL.AppendLine($"    {i.Variable}.xyzw = {i.Variable}.xyzw * tx.xyxy;");
            }
            else if (i.Type == "float3")
            {
                unityHLSL.AppendLine($"    {i.Variable}.xyz = {i.Variable}.xyz * tx.xyx;");
            }
            else if (i.Type == "uint")
            {
                unityHLSL.AppendLine($"    {i.Variable}.x = {i.Variable}.x * tx.x;");
            }
        }
               
    }

    private bool ConvertInstructions()
    {
        Dictionary<int, Texture> texDict = new Dictionary<int, Texture>();
        foreach (var texture in textures)
        {
            texDict.Add(texture.Index, texture);
        }
        List<int> sortedIndices = texDict.Keys.OrderBy(x => x).ToList();
        string line = hlsl.ReadLine();
        if (line == null)
        {
            // its a broken pixel shader that uses some kind of memory textures
            return false;
        }
        while (!line.Contains("SV_TARGET2"))
        {
            line = hlsl.ReadLine();
            if (line == null)
            {
                // its a broken pixel shader that uses some kind of memory textures
                return false;
            }
        }
        hlsl.ReadLine();
        do
        {
            line = hlsl.ReadLine();
            if (line != null)
            {
                if (line.Contains("return;"))
                {
                    break;
                }
                /* we don't do that here
                if (line.Contains("Sample"))
                {
                    var equal = line.Split("=")[0];
                    var texIndex = Int32.Parse(line.Split(".Sample")[0].Split("t")[1]);
                    var sampleIndex = Int32.Parse(line.Split("(s")[1].Split("_s,")[0]);
                    var sampleUv = line.Split(", ")[1].Split(")")[0];
                    var dotAfter = line.Split(").")[1];
                    // todo add dimension
                    unityHLSL.AppendLine($"   {equal}= Material_Texture2D_{sortedIndices.IndexOf(texIndex)}.SampleLevel(Material_Texture2D_{sampleIndex - 1}Sampler, {sampleUv}, 0).{dotAfter}");
                }

                // todo add load, levelofdetail, o0.w, discard
                else if (line.Contains("discard"))
                {
                    unityHLSL.AppendLine(line.Replace("discard", "{ output.OpacityMask = 0; return output; }"));
                }*/
                else
                {
                    unityHLSL.AppendLine(line);
                }
            }
        } while (line != null);

        return true;
    }

    /// <summary>
    /// Write the default stuff
    /// Why are there so many inputs and stuff?
    /// Because apparently unity's shadernode graph doesn't support script editing
    /// Therefore I try to automate as much as I can so that the only user interaction is
    /// Assigning this created here shader
    /// Also unused textures and sample states don't cause errors.
    /// Hopefully there isn't a shader that needs more than 30 textures
    /// </summary>
    private void WriteThatDefaultGarbage()
    {
        string inputOutputString = @"
        SamplerState s1_s,
        SamplerState s2_s,
        SamplerState s3_s,
        SamplerState s4_s,
        SamplerState s5_s,
        SamplerState s6_s,
        SamplerState s7_s,

        float2 tx,

        Texture2D<float4> t0,
        Texture2D<float4> t1,
        Texture2D<float4> t2,
        Texture2D<float4> t3,
        Texture2D<float4> t4,
        Texture2D<float4> t5,
        Texture2D<float4> t6,
        Texture2D<float4> t7,
        Texture2D<float4> t8,
        Texture2D<float4> t9,
        Texture2D<float4> t10,
        Texture2D<float4> t11,
        Texture2D<float4> t12,
        Texture2D<float4> t13,
        Texture2D<float4> t14,
        Texture2D<float4> t15,
        Texture2D<float4> t16,
        Texture2D<float4> t17,
        Texture2D<float4> t18,
        Texture2D<float4> t19,
        Texture2D<float4> t20,
        Texture2D<float4> t21,
        Texture2D<float4> t22,
        Texture2D<float4> t23,
        Texture2D<float4> t24,
        Texture2D<float4> t25,
        Texture2D<float4> t26,
        Texture2D<float4> t27,
        Texture2D<float4> t28,
        Texture2D<float4> t29,

        out float3 Base,
        out float3 Normal,
        out float Metallic,
        out float EmissiveColor,
        out float Smoothness,
        out float AO,
        out float Alpha";
        unityHLSL.AppendLine(inputOutputString);
    }

    private void AddOutputs()
    {
        string outputString = @"
        //Base and alpha
        Base = o0.xyz; 
        Alpha = o0.w;
        

        // Normal
        float3 biased_normal = o1.xyz - float3(0.5, 0.5, 0.5);
        float normal_length = length(biased_normal);
        float3 normal_in_world_space = biased_normal / normal_length;
        Normal = float3(1 - normal_in_world_space.x, normal_in_world_space.y, normal_in_world_space.z);

        //Smoothness (unity doesn't do roughness)
        float smoothness = saturate(8 * (normal_length - 0.375));
        Smoothness = 1 - smoothness;
 
            ///RT2
        Metallic = o2.x;
        EmissiveColor = (o2.y - 0.5) * 2 * 5 * Base; // the *5 is a scale to make it look good
        AO = o2.y * 2; // Texture AO
    }
        ";
        unityHLSL.AppendLine(outputString);
    }

    private void WriteFooter(bool bIsVertexShader)
    {
        unityHLSL.AppendLine("#endif");
    }
}
