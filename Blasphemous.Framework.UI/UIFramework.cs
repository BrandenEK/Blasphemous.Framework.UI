using Blasphemous.ModdingAPI;

namespace Blasphemous.Framework.UI;

/// <summary>
/// Handles initializing and creating UI
/// </summary>
public class UIFramework : BlasMod
{
    internal UIFramework() : base(ModInfo.MOD_ID, ModInfo.MOD_NAME, ModInfo.MOD_AUTHOR, ModInfo.MOD_VERSION) { }

    private bool _initialized = false;

    /// <summary>
    /// Initialize the fonts and parents when first loading the main menu
    /// </summary>
    protected override void OnLevelLoaded(string oldLevel, string newLevel)
    {
        if (_initialized || newLevel != "MainMenu")
            return;

        UIModder.Fonts.Initialize();
        UIModder.Parents.Initialize();
        _initialized = true;
    }
}
