using Verse;

namespace PyrinthStove
{
    public class PyrinthStoveModSettings : ModSettings
    {
        public static bool fuelConsumptionForStove = true;

        public override void ExposeData()
        {
            Scribe_Values.Look<bool>(ref fuelConsumptionForStove, "fuelConsumptionForStove", true);
            
            base.ExposeData();
        }
    }
}