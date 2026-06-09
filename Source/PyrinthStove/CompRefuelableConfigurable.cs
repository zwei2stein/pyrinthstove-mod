using RimWorld;
using Verse;

namespace PyrinthStove
{
    public class CompRefuelableConfigurable : CompRefuelable
    {
        public new CompProperties_Refuelable_Configurable Props => (CompProperties_Refuelable_Configurable) this.props;
        
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
                inspect = (string) (inspect + ("\n" + "PyrinthStoveModSettings_Stove_TurnedOff_Inspect".Translate()));
            return inspect;
        }
        
    }
}