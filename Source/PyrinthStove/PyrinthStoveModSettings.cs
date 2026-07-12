using Verse;

namespace PyrinthStove
{
    public class PyrinthStoveModSettings : ModSettings
    {
        public static bool fuelConsumptionForBoiler = true;
        public static bool fuelConsumptionForStove = true;
        public static bool fuelConsumptionForSmithy = true;
        public static bool fuelConsumptionForSmelter = true;
        public static bool fuelConsumptionForCrematorium = true;

        public override void ExposeData()
        {
            Scribe_Values.Look<bool>(ref fuelConsumptionForStove, "fuelConsumptionForStove", true);
            Scribe_Values.Look<bool>(ref fuelConsumptionForSmithy, "fuelConsumptionForSmithy", true);
            Scribe_Values.Look<bool>(ref fuelConsumptionForSmelter, "fuelConsumptionForSmelter", true);
            Scribe_Values.Look<bool>(ref fuelConsumptionForCrematorium, "fuelConsumptionForCrematorium", true);
            Scribe_Values.Look<bool>(ref fuelConsumptionForBoiler, "fuelConsumptionForBoiler", true);
            
            base.ExposeData();
        }
    }
}