using RimWorld;

namespace PyrinthStove
{
    public class CompProperties_Refuelable_Configurable : CompProperties_Refuelable
    {
        public string settingsKey;

        public CompProperties_Refuelable_Configurable()
        {
            this.compClass = typeof(CompRefuelableConfigurable);
        }
    }
}