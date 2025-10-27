using BepInEx;
using UNO.Common;

namespace UNO
{
    [BepInPlugin(Manifest.PluginGUID, Manifest.PluginName, Manifest.PluginVersion)]
    [BepInDependency(Jotunn.Main.ModGuid)]
    //[NetworkCompatibility(CompatibilityLevel.EveryoneMustHaveMod, VersionStrictness.Minor)]
    internal class UNOMod : BaseUnityPlugin
    {
        void Awake()
        {
            Jotunn.Logger.LogInfo("UNO has landed");
        }
    }
}