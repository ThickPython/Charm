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
}