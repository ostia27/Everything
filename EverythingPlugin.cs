using BepInEx;
using BepInEx.Logging;
using HarmonyLib;

namespace Everything
{

    [BepInPlugin(MyGUID, PluginName, VersionString)]
    public class EverythingPlugin : BaseUnityPlugin
    {
        private const string MyGUID = "com.ostia.Everything";
        private const string PluginName = "Everything";
        private const string VersionString = "1.0.1";

        private static readonly Harmony Harmony = new Harmony(MyGUID);
        public static ManualLogSource Log = new ManualLogSource(PluginName);

        /// <summary>
        /// Initialize the configuration settings and patch methods
        /// </summary>
        private void Awake()
        {

            // Apply all of our patches
            Logger.LogInfo($"PluginName: {PluginName}, VersionString: {VersionString} is loading...");
            Harmony.PatchAll();
            Logger.LogInfo($"PluginName: {PluginName}, VersionString: {VersionString} is loaded.");

            // Sets up our static Log, so it can be used elsewhere in code.
            // .e.g.
            // EverythingPlugin.Log.LogDebug("Debug Message to BepInEx log file");
            Log = Logger;
        }
    }
}
