using RimWorld;

namespace PyrinthStove
{
    public class CompProperties_Refuelable_ConfigurableBoiler : CompProperties_Refuelable
    {
        public CompProperties_Refuelable_ConfigurableBoiler() => this.compClass = typeof (CompRefuelableConfigurableBoiler);
    }
}