using HarmonyLib;
using System.Reflection;
using Verse;

namespace Plants_No_Rest
{
    public class Controller : Mod
    {
        public Controller(ModContentPack content) : base(content)
        {
            Harmony harmony = new Harmony("com.firefox.plantsnorest");
            harmony.PatchAll(Assembly.GetExecutingAssembly());
        }
    }
}
