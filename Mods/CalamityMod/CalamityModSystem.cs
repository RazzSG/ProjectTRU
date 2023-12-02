using CalamityMod.Items.Placeables.Furniture.DevPaintings;
using CalamityRuTranslate.Common;
using CalamityRuTranslate.Common.Utilities;
using Terraria.ModLoader;

namespace CalamityRuTranslate.Mods.CalamityMod;

public class CalamityModSystem : ModSystem
{
    public override bool IsLoadingEnabled(Mod mod)
    {
        return ModInstances.Calamity != null && TranslationHelper.IsRussianLanguage;
    }

    public override void PostSetupContent()
    {
        ThankYouPainting.devList.RemoveAt(0);
        ThankYouPainting.devList.Insert(0, "Fabsol, основатель и владелец мода");
    }
}