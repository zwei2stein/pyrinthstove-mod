using RimWorld;
using Verse;

namespace PyrinthStove
{
    public class CompRefuelableConfigurableStove : CompRefuelable
    {
        public new CompProperties_Refuelable_ConfigurableStove Props => (CompProperties_Refuelable_ConfigurableStove) this.props;
        
        public override void CompTick()
        {
            if (!PyrinthStoveModSettings.fuelConsumptionForStove)
                return;
            base.CompTick();
        }

        public override string CompInspectStringExtra()
        {
            var inspect = base.CompInspectStringExtra();
            if (!PyrinthStoveModSettings.fuelConsumptionForStove)
                inspect = (string) (inspect + ("\n" + "PyrinthStoveModSettings_TurnedOff_Inspect".Translate()));
            return inspect;
        }
        
    }
}