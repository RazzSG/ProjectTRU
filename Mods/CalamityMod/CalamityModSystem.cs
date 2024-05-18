using System.Reflection;
using CalamityMod.Items.Placeables.Furniture.DevPaintings;
using CalamityMod.UI.DraedonSummoning;
using CalamityRuTranslate.Common;
using CalamityRuTranslate.Common.Utilities;
using ReLogic.Graphics;
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
        
        PropertyInfo dialogueFont = typeof(CodebreakerUI).GetCachedProperty("DialogFont");
        DynamicSpriteFont replaceFont = CalamityRuTranslate.Instance.Assets.Request<DynamicSpriteFont>("Assets/Fonts/Item_Stack").Value;
        dialogueFont.SetValue(null, replaceFont);
    }
}