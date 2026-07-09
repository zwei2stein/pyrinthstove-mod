using RimWorld;
using Verse;

namespace PyrinthStove
{
    public class CompRefuelableConfigurableCrematorium : CompRefuelable
    {
        public new CompProperties_Refuelable_ConfigurableCrematorium Props => (CompProperties_Refuelable_ConfigurableCrematorium) this.props;
        
        public override void CompTick()
        {
            if (!PyrinthStoveModSettings.fuelConsumptionForCrematorium)
                return;
            base.CompTick();
        }

        public override string CompInspectStringExtra()
        {
            var inspect = base.CompInspectStringExtra();
            if (!PyrinthStoveModSettings.fuelConsumptionForCrematorium)
                inspect = (string) (inspect + ("\n" + "PyrinthStoveModSettings_TurnedOff_Inspect".Translate()));
            return inspect;
        }
        
    }
}