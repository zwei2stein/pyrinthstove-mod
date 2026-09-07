using RimWorld;
using Verse;

namespace PyrinthStove
{
    public class CompRefuelableConfigurable : CompRefuelable
    {
        public new CompProperties_Refuelable_Configurable Props =>
            (CompProperties_Refuelable_Configurable) this.props;

        private bool FuelConsumptionEnabled =>
            PyrinthStoveModSettings.FuelConsumptionEnabled(this.Props.settingsKey);

        public override void CompTick()
        {
            if (!FuelConsumptionEnabled)
                return;
            base.CompTick();
        }

        public override string CompInspectStringExtra()
        {
            var inspect = base.CompInspectStringExtra();
            if (!FuelConsumptionEnabled)
            {
                if (!inspect.NullOrEmpty())
                    inspect = "\n"  + inspect;
                inspect = "PyrinthStoveModSettings_TurnedOff_Inspect".Translate().Resolve() + inspect;
            }
            return inspect;
        }
    }
}