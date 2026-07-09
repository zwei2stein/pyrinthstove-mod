using RimWorld;
using Verse;

namespace PyrinthStove
{
    public class CompRefuelableConfigurableSmelter : CompRefuelable
    {
        public new CompProperties_Refuelable_ConfigurableSmelter Props => (CompProperties_Refuelable_ConfigurableSmelter) this.props;
        
        public override void CompTick()
        {
            if (!PyrinthStoveModSettings.fuelConsumptionForSmelter)
                return;
            base.CompTick();
        }

        public override string CompInspectStringExtra()
        {
            var inspect = base.CompInspectStringExtra();
            if (!PyrinthStoveModSettings.fuelConsumptionForSmelter)
                inspect = (string) (inspect + ("\n" + "PyrinthStoveModSettings_TurnedOff_Inspect".Translate()));
            return inspect;
        }
        
    }
}