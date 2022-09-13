using Field.General;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Field.Models;
using System.Security.AccessControl;

namespace Field.Textures
{
    public class DestinyToUnityBuiltin
    {
        private StringReader hlsl;
        private StringBuilder unityBuiltin;

        private StringBuilder properties;
        private StringBuilder vars;
        private StringBuilder calculations;
        
        private bool bOpacityEnabled = false;
        private List<Texture> textures = new List<Texture>();
        private List<int> samplers = new List<int>();
        private List<Cbuffer> cbuffers = new List<Cbuffer>();
        private List<Input> inputs = new List<Input>();
        private List<Output> outputs = new List<Output>();

        public string HlslToBuiltinShader(Material material, string hlslText, bool bIsVertexShader)
        {

            hlsl = new StringReader(hlslText);
            unityBuiltin = new StringBuilder();

            properties = new StringBuilder();
            vars = new StringBuilder();
            calculations = new StringBuilder();

            unityBuiltin.Append(String.Join('\n', File.ReadAllLines("UnityImportThings/DefaultBuiltin.txt")));
            ProcessHlslData();

            //properties
            AddProperties();

            //vars
            WriteCbuffers(material, bIsVertexShader);
            vars.AppendLine();
            WriteThoseStaticFloats(bIsVertexShader);
            vars.AppendLine();
            WriteSamplers();

            //calculations
            hlsl = new StringReader(hlslText);
            bool success = ConvertInstructions();

            


            if (!success)
            {
                return "";
            }

            //replace things
            unityBuiltin.Replace("replaceWithTitle", $"{material.Hash}_builtin");
            unityBuiltin.Replace("//replaceWithProperties", properties.ToString());
            unityBuiltin.Replace("//replaceWithVars", vars.ToString());
            unityBuiltin.Replace("//replaceWithCalculations", calculations.ToString());

            //Console.WriteLine("Did it");
            return unityBuiltin.ToString();
        }

        private void AddProperties()
        {
            for(int i = 0; i < textures.Count; i++)
            {
                properties.AppendLine($"_t{i}(\"_t_{i}\", 2D) = \"\" {{}}");
            }
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
                vars.AppendLine($"static {cbuffer.Type} {cbuffer.Variable}[{cbuffer.Count}] = ").AppendLine("{");

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
                            if (data == null) vars.AppendLine("    float4(0.0, 0.0, 0.0, 0.0),");
                            else
                            {
                                try
                                {
                                    if (data[i] is Vector4)
                                    {
                                        vars.AppendLine($"    float4({data[i].X}, {data[i].Y}, {data[i].Z}, {data[i].W}),");
                                    }
                                    else
                                    {
                                        var x = data[i].Unk00.X; // really bad but required
                                        vars.AppendLine($"    float4({x}, {data[i].Unk00.Y}, {data[i].Unk00.Z}, {data[i].Unk00.W}),");
                                    }
                                }
                                catch (Exception e)  // figure out whats up here, taniks breaks it
                                {
                                    vars.AppendLine("    float4(0.0, 0.0, 0.0, 0.0),");
                                }
                            }
                            break;
                        case "float3":
                            if (data == null) vars.AppendLine("    float3(0.0, 0.0, 0.0),");
                            else vars.AppendLine($"    float3({data[i].Unk00.X}, {data[i].Unk00.Y}, {data[i].Unk00.Z}),");
                            break;
                        case "float":
                            if (data == null) vars.AppendLine("    float(0.0),");
                            else vars.AppendLine($"    float4({data[i].Unk00}),");
                            break;
                        default:
                            throw new NotImplementedException();
                    }
                }
                //cut off the last comma because lmao unity
                vars.Remove(vars.Length - 3, 2);
                vars.AppendLine("};");
            }
        }
        private void WriteThoseStaticFloats(bool bIsVertexShader)
        {
            //Write in the v things (why this is inside the function definition instead of outside i don't know)
            if (!bIsVertexShader)
            {
                foreach (var i in inputs)
                {
                    if (i.Type == "float4")
                    {
                        vars.AppendLine($"static {i.Type} {i.Variable} = " + "{1, 1, 1, 1};\n");
                    }
                    else if (i.Type == "float3")
                    {
                        vars.AppendLine($"static {i.Type} {i.Variable} = " + "{1, 1, 1};\n");
                    }
                    else if (i.Type == "uint")
                    {
                        vars.AppendLine($"static {i.Type} {i.Variable} = " + "1;\n");
                    }
                }
            }
        }
        private void WriteSamplers()
        {
            for(int i = 0; i < textures.Count; i++)
            {
                vars.AppendLine($"sampler2D _t{i};");
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
                    else
                    {
                        //replace sample with tex2d
                        if(line.Contains("Sample("))
                        {
                            line = ConvertSample(line);
                        }
                        calculations.AppendLine(line);
                    }
                }
            } while (line != null);

            return true;
        }

        string ConvertSample(string toConvert)
        {
            //example of before and after
            //r1.xyz = t3.Sample(s1_s, r0.xy).xyz;
            //r1.xyz = tex2D(_t3, r0.xy).xyz;


            string[] splitSides = toConvert.Replace(" ", "").Split('=');
            string toSample = "_" + splitSides[1].Split('.')[0];
            string secondHalf = splitSides[1].Split(',')[1];

            string convertedString = $"{splitSides[0]} = tex2D({toSample}, {secondHalf}";
            return convertedString;
        }

    }
}
