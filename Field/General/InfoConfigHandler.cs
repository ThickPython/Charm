using System.Collections.Concurrent;
using System.Text.Json;
using System.Xml.Linq;
using Field.Models;
using Field.Statics;
using Field.Textures;
using Newtonsoft.Json;

namespace Field.General;

public class InfoConfigHandler
{
    public bool bOpen = false;
    private ConcurrentDictionary<string, dynamic> _config = new ConcurrentDictionary<string, dynamic>();

    public InfoConfigHandler()
    {
        ConcurrentDictionary<string, Dictionary<string, Dictionary<int, TexInfo>>> mats = new ConcurrentDictionary<string, Dictionary<string, Dictionary<int, TexInfo>>>();
        _config.TryAdd("Materials", mats);
        ConcurrentDictionary<string, string> parts = new ConcurrentDictionary<string, string>();
        _config.TryAdd("Parts", parts);
        ConcurrentDictionary<string, ConcurrentBag<JsonInstance>> instances = new ConcurrentDictionary<string, ConcurrentBag<JsonInstance>>();
        _config.TryAdd("Instances", instances);


        bOpen = true;
    }

    ConcurrentDictionary<string, Dictionary<string, List<string>>> lods;

    //stupid stuff relating to lods
    public void AddLod(string meshName, int lodLevel)
    {
        string meshGroup = meshName.Split("_")[0];
        if (!lods.Keys.Contains(meshGroup))
        {
            lods[meshGroup] = new Dictionary<string, List<string>>();
        }
        if (!lods[meshGroup].Keys.Contains(lodLevel.ToString()))
        {
            lods[meshGroup][lodLevel.ToString()] = new List<string>();
        }
        lods[meshGroup][lodLevel.ToString()].Add(meshName);
    }

    public void SubmitLodToConfig() { _config.TryAdd("LodGroups", lods); }

    public void Dispose()
    {
        if (bOpen)
        {
            _config.Clear();
            bOpen = false; 
        }
    }

    public void AddMaterial(Material material)
    {
        if (!material.Hash.IsValid())
        {
            return;
        }
        Dictionary<string, Dictionary<int, TexInfo>> textures = new Dictionary<string, Dictionary<int, TexInfo>>();
        if (!_config["Materials"].TryAdd(material.Hash, textures))
        {
            return;
        }
        Dictionary<int, TexInfo> vstex = new Dictionary<int, TexInfo>();
        textures.Add("VS", vstex);
        foreach (var vst in material.Header.VSTextures)
        {
            if (vst.Texture != null)
            {
                vstex.Add((int)vst.TextureIndex, new TexInfo {Hash = vst.Texture.Hash, SRGB = vst.Texture.IsSrgb() });
            }
        }
        Dictionary<int, TexInfo> pstex = new Dictionary<int, TexInfo>();
        textures.Add("PS", pstex);
        foreach (var pst in material.Header.PSTextures)
        {
            if (pst.Texture != null)
            {
                pstex.Add((int)pst.TextureIndex, new TexInfo {Hash = pst.Texture.Hash, SRGB = pst.Texture.IsSrgb() });
            }
        }
    }
    
    public void AddPart(Part part, string partName)
    {
        _config["Parts"].TryAdd(partName, part.Material.Hash.GetHashString());
    }

    public void SetMeshName(string meshName)
    {
        _config["MeshName"] = meshName;
    }

    public void SetUnrealInteropPath(string interopPath)
    {
        _config["UnrealInteropPath"] = new string(interopPath.Split("\\Content").Last().ToArray()).TrimStart('\\');
        if (_config["UnrealInteropPath"] == "")
        {
            _config["UnrealInteropPath"] = "Content";
        }
    }

    private struct JsonInstance
    {
        public float[] Translation;
        public float[] Rotation;
        public float Scale;
    }

    public void AddInstance(string modelHash, float scale, Vector4 quatRotation, Vector3 translation)
    {
        if (!_config["Instances"].ContainsKey(modelHash))
        {
            _config["Instances"][modelHash] = new ConcurrentBag<JsonInstance>();
        }
        _config["Instances"][modelHash].Add(new JsonInstance
        {
            Translation = new [] { translation.X, translation.Y, translation.Z },
            Rotation = new [] { quatRotation.X, quatRotation.Y, quatRotation.Z, quatRotation.W },
            Scale = scale
        });
    }

    public void AddStaticInstances(List<D2Class_406D8080> instances, string staticMesh)
    {
        foreach (var instance in instances)
        {
            AddInstance(staticMesh, instance.Scale.X, instance.Rotation, instance.Position);
        }
    }
    
    public void AddCustomTexture(string material, int index, TextureHeader texture)
    {
        if (!_config["Materials"].ContainsKey(material))
        {
            var textures = new Dictionary<string, Dictionary<int, TexInfo>>();
            textures.Add("PS",  new Dictionary<int, TexInfo>());
            _config["Materials"][material] = textures;
        }
        _config["Materials"][material]["PS"].TryAdd(index, new TexInfo { Hash = texture.Hash, SRGB = texture.IsSrgb()});
    }

    
    
    
    public void WriteToFile(string path)
    {
        // If theres only 1 part, we need to rename it + the instance to the name of the mesh (unreal imports to fbx name if only 1 mesh inside)
        if (_config["Parts"].Count == 1)
        {
            var part = _config["Parts"][_config["Parts"].Keys[0]];
            //I'm not sure what to do if it's 0, so I guess I'll leave that to fix it in the future if something breakes.
            if (_config["Instances"].Count != 0)
            {
                var instance = _config["Instances"][_config["Instances"].Keys[0]];
                _config["Instances"] = new ConcurrentDictionary<string, ConcurrentBag<JsonInstance>>();
                _config["Instances"][_config["MeshName"]] = instance;
            }
            _config["Parts"] = new ConcurrentDictionary<string, string>();
            _config["Parts"][_config["MeshName"]] = part;
        }
        string s = JsonConvert.SerializeObject(_config, Formatting.Indented);
        if (_config.ContainsKey("MeshName"))
        {
            File.WriteAllText($"{path}/{_config["MeshName"]}_info.cfg", s);
        }
        else
        {
            File.WriteAllText($"{path}/info.cfg", s);
        }
        Dispose();
    }
}

public struct TexInfo
{
    public string Hash  { get; set; }
    public bool SRGB  { get; set; }
}
