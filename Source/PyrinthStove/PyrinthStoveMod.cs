using UnityEngine;
using Verse;

namespace PyrinthStove
{

    public class PyrinthStoveMod : Mod
    {
        
        private PyrinthStoveModSettings settings;
     
        public PyrinthStoveMod(ModContentPack content) : base(content)
        {
            this.settings = this.GetSettings<PyrinthStoveModSettings>();
        }
        
        public override string SettingsCategory()
        {
            return "PyrinthStoveModName".Translate();
        }

        public override void DoSettingsWindowContents(Rect inRect)
        {
            var listingStandard = new Listing_Standard();

            var gapWidth = 12f;

            listingStandard.Begin(inRect);

            listingStandard.GapLine();
            
            listingStandard.Label("PyrinthStoveModSettings_Stove_label".Translate());

            listingStandard.Indent(gapWidth);
            listingStandard.ColumnWidth -= gapWidth;
            
            listingStandard.CheckboxLabeled(
                "PyrinthStoveModSettings_Stove_fuelConsumptionForStove".Translate(),
                ref PyrinthStoveModSettings.fuelConsumptionForStove,
                "PyrinthStoveModSettings_Stove_fuelConsumptionForStove_tooltip".Translate());
            
            listingStandard.Outdent(gapWidth);
            listingStandard.ColumnWidth += gapWidth;
            
            listingStandard.GapLine();
            
            listingStandard.End();
            
            base.DoSettingsWindowContents(inRect);
        }

    }
}