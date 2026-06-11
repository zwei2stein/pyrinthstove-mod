using RimWorld;

namespace PyrinthStove
{
    public class CompProperties_Refuelable_ConfigurableStove : CompProperties_Refuelable
    {
        public CompProperties_Refuelable_ConfigurableStove() => this.compClass = typeof (CompRefuelableConfigurableStove);
    }
}