using Blasphemous.ModdingAPI;

namespace Blasphemous.Framework.UI;

/// <summary>
/// Handles initializing and creating UI
/// </summary>
public class UIFramework : BlasMod
{
    internal UIFramework() : base(ModInfo.MOD_ID, ModInfo.MOD_NAME, ModInfo.MOD_AUTHOR, ModInfo.MOD_VERSION) { }

    protected override void OnInitialize()
    {
        LogError($"{ModInfo.MOD_NAME} has been initialized");
    }
}
