using System.Reflection;
using CalamityMod.Items.Placeables.Furniture.DevPaintings;
using CalamityMod.UI.DraedonSummoning;
using CalamityRuTranslate.Common;
using CalamityRuTranslate.Common.Utilities;
using CalamityRuTranslate.Core.Config;
using ReLogic.Content;
using ReLogic.Graphics;
using Terraria.ModLoader;

namespace CalamityRuTranslate.Mods.CalamityMod;

public class CalamityModSystem : ModSystem
{
    private static Asset<DynamicSpriteFont> _codebreakerFont;

    public override bool IsLoadingEnabled(Mod mod)
    {
        return ModInstances.Calamity != null && TRuConfig.Instance.CalamityModLocalization && TranslationHelper.IsRussianLanguage;
    }

    public override void Load()
    {
        _codebreakerFont ??= Mod.Assets.Request<DynamicSpriteFont>("Assets/Fonts/Item_Stack", AssetRequestMode.ImmediateLoad);
    }

    public override void PostSetupContent()
    {
        ThankYouPainting.devList.RemoveAt(0);
        ThankYouPainting.devList.Insert(0, "Fabsol, основатель и владелец мода");
        
        DynamicSpriteFont replaceFont = TRuConfig.Instance.NewRussianTerrariaFont
            ? Mod.Assets.Request<DynamicSpriteFont>("Assets/Fonts/Item_Stack").Value
            : _codebreakerFont.Value;
        
        PropertyInfo dialogueFont = typeof(CodebreakerUI).GetCachedProperty("DialogFont");
        dialogueFont.SetValue(null, replaceFont);
    }
}