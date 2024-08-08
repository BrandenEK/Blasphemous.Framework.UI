using BepInEx;

namespace Blasphemous.Framework.UI;

[BepInPlugin(ModInfo.MOD_ID, ModInfo.MOD_NAME, ModInfo.MOD_VERSION)]
[BepInDependency("Blasphemous.ModdingAPI", "2.4.1")]
internal class Main : BaseUnityPlugin
{
    public static UIFramework UIFramework { get; private set; }

    private void Start()
    {
        UIFramework = new UIFramework();
    }
}
