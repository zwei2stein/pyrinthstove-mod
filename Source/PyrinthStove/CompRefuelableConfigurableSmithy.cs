using RimWorld;
using Verse;

namespace PyrinthStove
{
    public class CompRefuelableConfigurableSmithy : CompRefuelable
    {
        public new CompProperties_Refuelable_ConfigurableSmithy Props => (CompProperties_Refuelable_ConfigurableSmithy) this.props;
        
        public override void CompTick()
        {
            if (!PyrinthStoveModSettings.fuelConsumptionForSmithy)
                return;
            base.CompTick();
        }

        public override string CompInspectStringExtra()
        {
            var inspect = base.CompInspectStringExtra();
            if (!PyrinthStoveModSettings.fuelConsumptionForSmithy)
                inspect = (string) (inspect + ("\n" + "PyrinthStoveModSettings_TurnedOff_Inspect".Translate()));
            return inspect;
        }
        
    }
}