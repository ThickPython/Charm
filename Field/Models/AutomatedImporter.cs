using Field.Textures;
namespace Field.Models;
using System.Configuration;
using System.IO;

public class AutomatedImporter
{
    public enum EImportType
    {
        Static,
        Entity,
        Map
    }

    public enum ERPType //enum render pipeline type not erotic roleplay type
    {
        Builtin,
        HDRP
    }
    
    public static void SaveInteropUnrealPythonFile(string saveDirectory, string meshName, EImportType importType, ETextureFormat textureFormat, bool bSingleFolder = true)
    {
        // Copy and rename file
        File.Copy("import_to_ue5.py", $"{saveDirectory}/{meshName}_import_to_ue5.py", true);
        if (importType == EImportType.Static)
        {
            string text = File.ReadAllText($"{saveDirectory}/{meshName}_import_to_ue5.py");
            text = text.Replace("importer.import_entity()", "importer.import_static()");
            File.WriteAllText($"{saveDirectory}/{meshName}_import_to_ue5.py", text);
        }
        else if (importType == EImportType.Map)
        {
            string text = File.ReadAllText($"{saveDirectory}/{meshName}_import_to_ue5.py");
            text = text.Replace("b_unique_folder=False", $"b_unique_folder={!bSingleFolder}");
            text = text.Replace("importer.import_entity()", "importer.import_map()");
            File.WriteAllText($"{saveDirectory}/{meshName}_import_to_ue5.py", text);
        }
        // change extension
        string textExtensions = File.ReadAllText($"{saveDirectory}/{meshName}_import_to_ue5.py");
        switch (textureFormat)
        {
            case ETextureFormat.PNG:
                textExtensions = textExtensions.Replace(".dds", ".png");
                break;
            case ETextureFormat.TGA:
                textExtensions = textExtensions.Replace(".dds", ".tga");
                break;
        }
        File.WriteAllText($"{saveDirectory}/{meshName}_import_to_ue5.py", textExtensions);
    }

    public static void SaveInteropUnityFile(string saveDirectory, string unityDirectory, string meshName, bool enableLods, ERPType rpType, EImportType importType, ETextureFormat textureFormat, bool bSingleFolder = true)
    {
        //Copy and rename file and class (lul unity no script support)
        File.Copy("UnityImportThings/charm_to_unity.txt", $"{unityDirectory}/{meshName}_charm_to_unity.cs", true);

        //Change class name
        string text = File.ReadAllText($"{unityDirectory}/{meshName}_charm_to_unity.cs");
        text = text.Replace("CharmToUnityWindowClass", $"CharmToUnityWindow_{meshName}");

        text = text.Replace("replaceTextureTypeExtentionPleaseThanks", ".dds");
        switch (textureFormat)
        {
            case ETextureFormat.PNG:
                text = text.Replace(".dds", ".png");
                break;
            case ETextureFormat.TGA:
                text = text.Replace(".dds", ".tga");
                break;
            
        }

        text = text.Replace("replacePathToUCAbsolute", unityDirectory);

        //set path to charm contents (unlike the py script, this has to be in the unity contents folder)
        text = text.Replace("replacePathToCharmContentsPleaseThanks", saveDirectory.Replace('\\', '/'));

        //set static/map
        if(importType == EImportType.Map) { text = text.Replace("public int importType = 0;", "public int importType = 1;"); }

        //set lods
        if(enableLods) { text = text.Replace("bool createLodGroups = false;", "bool createLodGroups = true;");  }

        //set shadertype
        if(rpType == ERPType.Builtin)
        {
            Directory.Delete(saveDirectory + "/UnityHDRPShaders", true);
            Directory.Move(saveDirectory + "/UnityBuiltinShaders", saveDirectory + "/UnityShaders");
        } else if(rpType == ERPType.HDRP)
        {
            Directory.Delete(saveDirectory + "/UnityBuiltinShaders", true);
            Directory.Move(saveDirectory + "/UnityHDRPShaders", saveDirectory + "/UnityShaders");
        }

        File.WriteAllText($"{unityDirectory}/{meshName}_charm_to_unity.cs", text);

        //Copy over the default hlsl and default shadergraph and the new template and the FFFF material
        File.Copy("UnityImportThings/C2Utemplate.shadergraph", $"{unityDirectory}/C2Utemplate.shadergraph", true);
        File.Copy("UnityImportThings/DefaultHLSL.hlsl", $"{unityDirectory}/DefaultHLSL.hlsl", true);
        File.Copy("UnityImportThings/SHADERTEMPLATENEW.txt", $"{unityDirectory}/SHADERTEMPLATENEW.txt", true);
        File.Copy("UnityImportThings/BlankEmissionTemplate.mat", $"{unityDirectory}/BlankEmissionTemplate.mat", true);
    }

    public static void SaveInteropBlenderPythonFile(string saveDirectory, string meshName, EImportType importType, ETextureFormat textureFormat, bool bSingleFolder = true)
    {
        // Copy and rename file
        saveDirectory = saveDirectory.Replace("\\", "/");
        File.Copy("import_to_blender.py", $"{saveDirectory}/{meshName}_import_to_blender.py", true);
        // if (importType == EImportType.Static) TODO?
        // {
        //     string text = File.ReadAllText($"{saveDirectory}/{meshName}_import_to_blender.py");
        //     text = text.Replace("importer.import_entity()", "importer.import_static()");
        //     File.WriteAllText($"{saveDirectory}/{meshName}_import_to_blender.py", text);
        // }
        // if (importType == EImportType.Map || importType == EImportType.Entity)
        // {
        //     string text = File.ReadAllText($"{saveDirectory}/{meshName}_import_to_blender.py");
        //     text = text.Replace("MAP_HASH", $"{meshName}");
        //     text = text.Replace("OUTPUT_DIR", $"{saveDirectory}");
        //     File.WriteAllText($"{saveDirectory}/{meshName}_import_to_blender.py", text);
        // }
        //Lets just make a py for all exports now because why not
        string text = File.ReadAllText($"{saveDirectory}/{meshName}_import_to_blender.py");
        text = text.Replace("MAP_HASH", $"{meshName}");
        text = text.Replace("OUTPUT_DIR", $"{saveDirectory}");
        text = text.Replace("IMPORT_TYPE", $"{importType.ToString().Replace("EImportType.", "")}");
        File.WriteAllText($"{saveDirectory}/{meshName}_import_to_blender.py", text);

        // change extension
        string textExtensions = File.ReadAllText($"{saveDirectory}/{meshName}_import_to_blender.py");
        switch (textureFormat)
        {
            case ETextureFormat.PNG:
                textExtensions = textExtensions.Replace("TEX_EXT", ".png");
                break;
            case ETextureFormat.TGA:
                textExtensions = textExtensions.Replace("TEX_EXT", ".tga");
                break;
            default:
                textExtensions = textExtensions.Replace("TEX_EXT", ".dds");
                break;
        }
        File.WriteAllText($"{saveDirectory}/{meshName}_import_to_blender.py", textExtensions);
    }
}