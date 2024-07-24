using HarmonyLib;

namespace Everything
{
    // TODO Review this file and update to your own requirements, or remove it altogether if not required

    [HarmonyPatch]
    internal class PatchNothing
    {
        /// <summary>

        [HarmonyPatch(typeof(Nothing), "Start")]
        [HarmonyPrefix]
        public static void Start_Prefix(Nothing __instance)
        {
            __instance.gameObject.AddComponent<EverythingComponent>();
            //return false;
        }
    }
}