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
            
            listingStandard.Label("PyrinthStoveModSettings_Smithy_label".Translate());

            listingStandard.Indent(gapWidth);
            listingStandard.ColumnWidth -= gapWidth;
            
            listingStandard.CheckboxLabeled(
                "PyrinthStoveModSettings_Smithy_fuelConsumptionForSmithy".Translate(),
                ref PyrinthStoveModSettings.fuelConsumptionForSmithy,
                "PyrinthStoveModSettings_Smithy_fuelConsumptionForSmithy_tooltip".Translate());
            
            listingStandard.Outdent(gapWidth);
            listingStandard.ColumnWidth += gapWidth;
            
            listingStandard.GapLine();
            
            listingStandard.Label("PyrinthStoveModSettings_Smelter_label".Translate());

            listingStandard.Indent(gapWidth);
            listingStandard.ColumnWidth -= gapWidth;
            
            listingStandard.CheckboxLabeled(
                "PyrinthStoveModSettings_Smelter_fuelConsumptionForSmelter".Translate(),
                ref PyrinthStoveModSettings.fuelConsumptionForSmelter,
                "PyrinthStoveModSettings_Smelter_fuelConsumptionForSmelter_tooltip".Translate());
            
            listingStandard.Outdent(gapWidth);
            listingStandard.ColumnWidth += gapWidth;
            
            listingStandard.GapLine();
            
            listingStandard.Label("PyrinthStoveModSettings_Crematorium_label".Translate());

            listingStandard.Indent(gapWidth);
            listingStandard.ColumnWidth -= gapWidth;
            
            listingStandard.CheckboxLabeled(
                "PyrinthStoveModSettings_Crematorium_fuelConsumptionForCrematorium".Translate(),
                ref PyrinthStoveModSettings.fuelConsumptionForCrematorium,
                "PyrinthStoveModSettings_Crematorium_fuelConsumptionForCrematorium_tooltip".Translate());            
            
            listingStandard.Outdent(gapWidth);
            listingStandard.ColumnWidth += gapWidth;
            
            listingStandard.GapLine();
            
            listingStandard.Label("PyrinthStoveModSettings_Boiler_label".Translate());

            listingStandard.Indent(gapWidth);
            listingStandard.ColumnWidth -= gapWidth;
            
            listingStandard.CheckboxLabeled(
                "PyrinthStoveModSettings_Boiler_fuelConsumptionForBoiler".Translate(),
                ref PyrinthStoveModSettings.fuelConsumptionForBoiler,
                "PyrinthStoveModSettings_Boiler_fuelConsumptionForBoiler_tooltip".Translate());
            
            listingStandard.Outdent(gapWidth);
            listingStandard.ColumnWidth += gapWidth;
            
            listingStandard.GapLine();            
            
            listingStandard.End();
            
            base.DoSettingsWindowContents(inRect);
        }

    }
}