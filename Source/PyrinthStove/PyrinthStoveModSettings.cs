using Verse;

namespace PyrinthStove
{
    public class PyrinthStoveModSettings : ModSettings
    {
        public static bool fuelConsumptionForStove = true;
        public static bool fuelConsumptionForSmithy = true;

        public override void ExposeData()
        {
            Scribe_Values.Look<bool>(ref fuelConsumptionForStove, "fuelConsumptionForStove", true);
            Scribe_Values.Look<bool>(ref fuelConsumptionForSmithy, "fuelConsumptionForSmithy", true);
            
            base.ExposeData();
        }
    }
}