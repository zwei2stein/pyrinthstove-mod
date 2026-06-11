using RimWorld;

namespace PyrinthStove
{
    public class CompProperties_Refuelable_ConfigurableSmithy : CompProperties_Refuelable
    {
        public CompProperties_Refuelable_ConfigurableSmithy() => this.compClass = typeof (CompRefuelableConfigurableSmithy);
    }
}