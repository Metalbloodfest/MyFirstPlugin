using System.IO;
using System.Reflection;
using BepInEx;
using BepInEx.Configuration;
using BepInEx.IL2CPP;
using BepInEx.Logging;
using HarmonyLib;
using MyFirstPlugin.UI;
using UnhollowerRuntimeLib;
using UnityEngine;
using Object = UnityEngine.Object;

namespace MyFirstPlugin
{
    [BepInPlugin(GUID, MODNAME, VERSION)]
    public class Plugin : BasePlugin
    {
        public const string
            MODNAME = "SoulStoneMenu",
            AUTHOR = "DaSisi",
            GUID = AUTHOR + "_" + MODNAME,
            VERSION = "1.4.3";

        public Plugin()
        {
            log = Log;
        }


        public override void Load()
        {
            try
            {
                ClassInjector.RegisterTypeInIl2Cpp<Main.MyModMenu>();
                GameObject gameObject = new GameObject("DaSisiHackz");
                gameObject.AddComponent<Main.MyModMenu>();
                gameObject.hideFlags = HideFlags.HideAndDontSave;
                Object.DontDestroyOnLoad(gameObject);
            }
            catch
            {
                log.LogError("FAILED to Register Il2Cpp Type: MyMonoBehaviour!");
            }
            try
            {
                Harmony.CreateAndPatchAll(Assembly.GetExecutingAssembly(), null);
            }
            catch
            {
                log.LogError("FAILED to register patches");
            }
            log.LogInfo("Modmenu toggle keybind set to:"); //fill this in later
        }
        public static ManualLogSource log;
    }
}
