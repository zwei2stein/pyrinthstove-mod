using RimWorld;
using Verse;

namespace PyrinthStove
{
    public class CompRefuelableConfigurableSauna : CompRefuelable
    {
        public new CompProperties_Refuelable_ConfigurableSauna Props => (CompProperties_Refuelable_ConfigurableSauna) this.props;
        
        public override void CompTick()
        {
            if (!PyrinthStoveModSettings.fuelConsumptionForSauna)
                return;
            base.CompTick();
        }

        public override string CompInspectStringExtra()
        {
            var inspect = base.CompInspectStringExtra();
            if (!PyrinthStoveModSettings.fuelConsumptionForSauna)
                inspect = (string) (inspect + ("\n" + "PyrinthStoveModSettings_TurnedOff_Inspect".Translate()));
            return inspect;
        }
        
    }
}