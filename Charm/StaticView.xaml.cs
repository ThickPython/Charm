﻿using System.Text;
using System.Collections.Generic;
using System.IO;
using System;
using System.Security.Policy;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using Field.General;
using Field.Textures;
using Field.Models;
using Field.Statics;
using System;


namespace Charm;

public partial class StaticView : UserControl
{
    public StaticView()
    {
        InitializeComponent();
    }
    
    public async void LoadStatic(TagHash hash, ELOD detailLevel)
    {
        var container = new StaticContainer(new TagHash(hash.Hash));
        var parts = container.Load(detailLevel);
        await Task.Run(() =>
        {
            parts = container.Load(detailLevel);
        });
        MainViewModel MVM = (MainViewModel)ModelView.UCModelView.Resources["MVM"];
        MVM.Clear();
        var displayParts = MakeDisplayParts(parts);
        MVM.SetChildren(displayParts);
        MVM.Title = hash.GetHashString();
    }

    public void ExportStatic(TagHash hash, string name, EExportTypeFlag exportType)
    {
        bool lodexport = false;
        bool source2Models = ConfigHandler.GetS2VMDLExportEnabled();
        FbxHandler fbxHandler = new FbxHandler(exportType == EExportTypeFlag.Full);
        FbxHandler lodfbxHandler = new FbxHandler(exportType == EExportTypeFlag.Full);
        string savePath = ConfigHandler.GetExportSavePath();
        string meshName = hash.GetHashString();
        if (exportType == EExportTypeFlag.Full)
        {
            savePath += $"/{name}";
        }
        var container = new StaticContainer(new TagHash(hash.Hash));

        //get the lod type
        ELOD lodLevel = ConfigHandler.GetUnityLodEnabled() == true ? ELOD.All : ELOD.MostDetail;

        List<Part> parts = container.Load(lodLevel);

        
        fbxHandler.AddStaticToScene(parts, meshName);
        Directory.CreateDirectory(savePath);
        if (exportType == EExportTypeFlag.Full)
        {
            container.SaveMaterialsFromParts(savePath, parts, ConfigHandler.GetUnrealInteropEnabled());
            fbxHandler.InfoHandler.SetMeshName(meshName);
            if (ConfigHandler.GetUnrealInteropEnabled())
            {
                fbxHandler.InfoHandler.SetUnrealInteropPath(ConfigHandler.GetUnrealInteropPath());
                AutomatedImporter.SaveInteropUnrealPythonFile(savePath, meshName, AutomatedImporter.EImportType.Static, ConfigHandler.GetOutputTextureFormat());
                AutomatedImporter.SaveInteropBlenderPythonFile(savePath, meshName, AutomatedImporter.EImportType.Static, ConfigHandler.GetOutputTextureFormat());
            }
            if(ConfigHandler.GetUnityInteropEnabled())
            {
                AutomatedImporter.SaveInteropUnityFile(savePath, ConfigHandler.GetUnityInteropPath(), meshName, AutomatedImporter.EImportType.Static, ConfigHandler.GetOutputTextureFormat());
            }

            if(source2Models)
            {
                File.Copy("template.vmdl", $"{savePath}/{meshName}.vmdl", true);
                string text = File.ReadAllText($"{savePath}/{meshName}.vmdl");
                StringBuilder mats = new StringBuilder();

                // {
                //     from = ""
                //     to = "materials/"
                // },
                foreach (Part part in parts)
                {
                    mats.AppendLine("{");
                    mats.AppendLine($"    from = \"{part.Material.Hash}.vmat\"");
                    mats.AppendLine($"    to = \"materials/{part.Material.Hash}.vmat\"");
                    mats.AppendLine("},\n");
                }
                text = text.Replace("%MATERIALS%", mats.ToString());
                text = text.Replace("%FILENAME%", $"models/{meshName}.fbx");
                text = text.Replace("%MESHNAME%", meshName);

                File.WriteAllText($"{savePath}/{meshName}.vmdl", text);
            }
            
        }

        fbxHandler.ExportScene($"{savePath}/{name}.fbx");

        if(lodexport)
        {
            List<Part> lodparts = container.Load(ELOD.LeastDetail);
            Directory.CreateDirectory(savePath + "/LOD");

            foreach (Part lodpart in lodparts)
            {
                Console.WriteLine($"Exporting LOD {lodpart.DetailLevel}");
                Console.WriteLine(lodpart.Material.Hash.ToString());
            }

            lodfbxHandler.AddStaticToScene(lodparts, $"{meshName}_LOD");
            lodfbxHandler.InfoHandler.SetMeshName($"{meshName}_LOD");
            lodfbxHandler.ExportScene($"{savePath}/LOD/{name}_LOD.fbx");
        }
    }

    private List<MainViewModel.DisplayPart> MakeDisplayParts(List<Part> containerParts)
    {
        List<MainViewModel.DisplayPart> displayParts = new List<MainViewModel.DisplayPart>();
        foreach (Part part in containerParts)
        {
            MainViewModel.DisplayPart displayPart = new MainViewModel.DisplayPart();
            displayPart.BasePart = part;
            displayPart.Translations.Add(Vector3.Zero);
            displayPart.Rotations.Add(Vector4.Quaternion);
            displayPart.Scales.Add(Vector3.One);
            displayParts.Add(displayPart);
        }
        return displayParts;
    }

    private void ModelView_Loaded(object sender, RoutedEventArgs e)
    {

    }
}