using RimWorld;
using Verse;

namespace IdleAlertExclusions
{
    public class PawnColumnWorker_IdleAlert : PawnColumnWorker_Checkbox
    {
        protected override bool GetValue(Pawn pawn)
        {
            return !IdleExclusionStore.Excluded.Contains(pawn);
        }

        protected override void SetValue(Pawn pawn, bool value, PawnTable table)
        {
            if (value)
            {
                IdleExclusionStore.Excluded.Remove(pawn);
            }
            else
            {
                IdleExclusionStore.Excluded.Add(pawn);
            }
        }

        protected override string GetTip(Pawn pawn)
        {
            return "IdleAlertExclusions.CellTip".Translate(pawn.NameShortColored);
        }
    }
}
