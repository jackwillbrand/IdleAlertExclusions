using HarmonyLib;
using Verse;

namespace IdleAlertExclusions
{
    [StaticConstructorOnStartup]
    public static class IdleAlertExclusionsMod
    {
        static IdleAlertExclusionsMod()
        {
            new Harmony("esthyn.IdleAlertExclusions").PatchAll();
        }
    }
}
