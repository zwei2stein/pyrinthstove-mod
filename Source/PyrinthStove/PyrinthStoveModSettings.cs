using Verse;

namespace PyrinthStove
{
    public class PyrinthStoveModSettings : ModSettings
    {
        public static bool fuelConsumptionForStove = true;
        public static bool fuelConsumptionForSmithy = true;
        public static bool fuelConsumptionForSmelter = true;
        public static bool fuelConsumptionForCrematorium = true;
        public static bool fuelConsumptionForBoiler = true;
        public static bool fuelConsumptionForSauna = true;

        public override void ExposeData()
        {
            Scribe_Values.Look(ref fuelConsumptionForStove, "fuelConsumptionForStove", true);
            Scribe_Values.Look(ref fuelConsumptionForSmithy, "fuelConsumptionForSmithy", true);
            Scribe_Values.Look(ref fuelConsumptionForSmelter, "fuelConsumptionForSmelter", true);
            Scribe_Values.Look(ref fuelConsumptionForCrematorium, "fuelConsumptionForCrematorium", true);
            Scribe_Values.Look(ref fuelConsumptionForBoiler, "fuelConsumptionForBoiler", true);
            Scribe_Values.Look(ref fuelConsumptionForSauna, "fuelConsumptionForSauna", true);
            base.ExposeData();
        }
        
        public static bool FuelConsumptionEnabled(string settingsKey)
        {
            switch (settingsKey)
            {
                case "Stove":       return fuelConsumptionForStove;
                case "Smithy":      return fuelConsumptionForSmithy;
                case "Smelter":     return fuelConsumptionForSmelter;
                case "Crematorium": return fuelConsumptionForCrematorium;
                case "Boiler":      return fuelConsumptionForBoiler;
                case "Sauna":       return fuelConsumptionForSauna;
                default:
                    Log.ErrorOnce("[PyrinthStove:] unknown settingsKey '" + settingsKey + "', returning defaut (fuel enabled)", settingsKey.GetHashCode());
                    return true;
            }
        }
    }
}