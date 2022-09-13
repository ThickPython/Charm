using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Media;
using System.Windows.Controls;
using Field.Textures;

namespace Charm;

public partial class UnityConfigView : UserControl
{
    public UnityConfigView()
    {
        InitializeComponent();
    }

    public void OnControlLoaded(object sender, RoutedEventArgs e)
    {
        PopulateConfigPanel();
    }

    private void PopulateConfigPanel()
    {
        UnityConfigPanel.Children.Clear();

        TextBlock header = new TextBlock();
        header.Text = "Unity Settings";
        header.FontSize = 30;
        UnityConfigPanel.Children.Add(header);

        //Enable unity interoperability
        ConfigSettingControl cui = new ConfigSettingControl();
        cui.SettingName = "Enable Unity interop";
        bool bval2 = ConfigHandler.GetUnityInteropEnabled();
        cui.SettingValue = bval2.ToString();
        cui.ChangeButton.Click += UnityEnabled_OnClick;
        UnityConfigPanel.Children.Add(cui);

        TextBlock lbl1 = new TextBlock();
        lbl1.Text = "USE PNG FOR THE TEXTURE TYPE UNITY GETS MAD AT DDS";
        lbl1.FontSize = 15;
        UnityConfigPanel.Children.Add(lbl1);

        // Assets path
        ConfigSettingControl cpp = new ConfigSettingControl();
        cpp.SettingName = "Unity asset import path";
        var val = ConfigHandler.GetUnityInteropPath();
        cpp.SettingValue = val == "" ? "Not set" : val;
        cpp.ChangeButton.Click += UnityPath_OnClick;
        UnityConfigPanel.Children.Add(cpp);

        TextBlock lbl2 = new TextBlock();
        lbl2.Text = "MUST be inside Unity assets folder";
        lbl2.FontSize = 15;
        UnityConfigPanel.Children.Add(lbl2);

        //render pipeline things
        ConfigSettingControl chdrp = new ConfigSettingControl();
        chdrp.SettingName = "Export HDRP shaders";
        bool bhdrp = ConfigHandler.GetUnityHDRPEnabled();
        chdrp.SettingValue = bhdrp.ToString();
        chdrp.ChangeButton.Click += UnityHDRP_OnClick;
        UnityConfigPanel.Children.Add(chdrp);

        ConfigSettingControl cBuiltin = new ConfigSettingControl();
        cBuiltin.SettingName = "Export Builtin shaders";
        bool bBuiltin = ConfigHandler.GetUnityBuiltinEnabled();
        cBuiltin.SettingValue = bBuiltin.ToString();
        cBuiltin.ChangeButton.Click += UnityBI_OnClick;
        UnityConfigPanel.Children.Add(cBuiltin);

        //enable lods
        ConfigSettingControl cul = new ConfigSettingControl();
        cul.SettingName = "Enable Unity Lods";
        bool bval3 = ConfigHandler.GetUnityLodEnabled();
        cul.SettingValue = bval2.ToString();
        cul.ChangeButton.Click += UnityLod_OnClick;
        UnityConfigPanel.Children.Add(cul);



    }

    private List<ComboBoxItem> MakeEnumComboBoxItems<T>() where T : Enum
    {
        List<ComboBoxItem> items = new List<ComboBoxItem>();
        foreach (T val in Enum.GetValues(typeof(T)))
        {
            items.Add(new ComboBoxItem { Content = TagItem.GetEnumDescription(val) });
        }
        return items;
    }

    private void ConsiderShowingMainMenu()
    {
        if (ConfigHandler.DoesPathKeyExist("packagesPath") && ConfigHandler.DoesPathKeyExist("exportSavePath"))
        {
            var _mainWindow = Window.GetWindow(this) as MainWindow;
            _mainWindow.ShowMainMenu();
        }
    }

    private void UnityPath_OnClick(object sender, RoutedEventArgs e)
    {
        ConfigHandler.OpenUnityInteropPathDialog();
        PopulateConfigPanel();
        ConsiderShowingMainMenu();
    }

    private void UnityLod_OnClick(object sender, RoutedEventArgs e)
    {
        ConfigHandler.SetUnityLodEnabled(!ConfigHandler.GetUnityLodEnabled());
        PopulateConfigPanel();
    }

    private void ExportSavePath_OnClick(object sender, RoutedEventArgs e)
    {
        ConfigHandler.OpenExportSavePathDialog();
        PopulateConfigPanel();
        ConsiderShowingMainMenu();
    }

    private void UnityEnabled_OnClick(object sender, RoutedEventArgs e)
    {
        ConfigHandler.SetUnityInteropEnabled(!ConfigHandler.GetUnityInteropEnabled());
        PopulateConfigPanel();
    }

    private void UnityHDRP_OnClick(object sender, RoutedEventArgs e)
    {
        ConfigHandler.SetUnityHDRPEnabled(!ConfigHandler.GetUnityHDRPEnabled());
        ConfigHandler.SetUnityBuiltinEnabled(!ConfigHandler.GetUnityBuiltinEnabled()); //1 must be active always, at least 1 and at most 1
        PopulateConfigPanel();
    }

    private void UnityBI_OnClick(object sender, RoutedEventArgs e)
    {
        ConfigHandler.SetUnityBuiltinEnabled(!ConfigHandler.GetUnityBuiltinEnabled());
        ConfigHandler.SetUnityHDRPEnabled(!ConfigHandler.GetUnityHDRPEnabled());
        PopulateConfigPanel();
    }
}