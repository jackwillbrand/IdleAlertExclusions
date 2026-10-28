using System.Collections.Generic;
using HarmonyLib;
using RimWorld;
using Verse;

namespace IdleAlertExclusions
{
    [HarmonyPatch(typeof(Alert_ColonistsIdle), "IdleColonists", MethodType.Getter)]
    public static class Alert_ColonistsIdle_IdleColonists
    {
        public static void Postfix(ref List<Pawn> __result)
        {
            HashSet<Pawn> excluded = IdleExclusionStore.Excluded;
            __result.RemoveAll(pawn => excluded.Contains(pawn));
        }
    }
}
