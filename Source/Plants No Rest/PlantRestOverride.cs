using HarmonyLib;
using RimWorld;
using System;

namespace Plants_No_Rest
{
    class PlantRestOverride
    {

        [HarmonyPatch(typeof(Plant))]
        [HarmonyPatch("Resting", MethodType.Getter)]
        static class CharacterCardUtility_DrawCharacterCard
        {
            public static bool Prefix(ref bool __result)
            {
                __result = false;
                return false;
            }
        }
    }
}
