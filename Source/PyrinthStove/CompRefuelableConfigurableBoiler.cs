using RimWorld;
using Verse;

namespace PyrinthStove
{
    public class CompRefuelableConfigurableBoiler : CompRefuelable
    {
        public new CompProperties_Refuelable_ConfigurableBoiler Props => (CompProperties_Refuelable_ConfigurableBoiler) this.props;
        
        public override void CompTick()
        {
            if (!PyrinthStoveModSettings.fuelConsumptionForBoiler)
                return;
            base.CompTick();
        }

        public override string CompInspectStringExtra()
        {
            var inspect = base.CompInspectStringExtra();
            if (!PyrinthStoveModSettings.fuelConsumptionForBoiler)
                inspect = (string) (inspect + ("\n" + "PyrinthStoveModSettings_TurnedOff_Inspect".Translate()));
            return inspect;
        }
        
    }
}