using System.Collections.Generic;
using Verse;

namespace IdleAlertExclusions
{
    public class IdleExclusionStore : GameComponent
    {
        public HashSet<Pawn> excluded = new HashSet<Pawn>();

        public IdleExclusionStore(Game game)
        {
        }

        public static HashSet<Pawn> Excluded => Current.Game.GetComponent<IdleExclusionStore>().excluded;

        public override void ExposeData()
        {
            Scribe_Collections.Look(ref excluded, "excluded", LookMode.Reference);
            if (excluded == null)
            {
                excluded = new HashSet<Pawn>();
            }
            if (Scribe.mode == LoadSaveMode.PostLoadInit)
            {
                excluded.Remove(null);
            }
        }
    }
}
