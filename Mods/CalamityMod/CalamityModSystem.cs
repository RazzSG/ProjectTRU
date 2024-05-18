using System.Reflection;
using CalamityMod.Items.Placeables.Furniture.DevPaintings;
using CalamityMod.UI.DraedonSummoning;
using CalamityRuTranslate.Common;
using CalamityRuTranslate.Common.Utilities;
using CalamityRuTranslate.Core.Config;
using ReLogic.Content;
using ReLogic.Graphics;
using Terraria;
using Terraria.ModLoader;

namespace CalamityRuTranslate.Mods.CalamityMod;

public class CalamityModSystem : ModSystem
{
    private Asset<DynamicSpriteFont> CodebreakerFont { get; set; }

    public override void Load()
    {
        if (Main.dedServ)
            return;
        
        CodebreakerFont = Mod.Assets.Request<DynamicSpriteFont>("Assets/Fonts/Item_Stack");
    }

    public override bool IsLoadingEnabled(Mod mod)
    {
        return ModInstances.Calamity != null && TranslationHelper.IsRussianLanguage;
    }

    public override void PostSetupContent()
    {
        ThankYouPainting.devList.RemoveAt(0);
        ThankYouPainting.devList.Insert(0, "Fabsol, основатель и владелец мода");
        
        DynamicSpriteFont replaceFont = TRuConfig.Instance.NewRussianTerrariaFont
            ? Mod.Assets.Request<DynamicSpriteFont>("Assets/Fonts/Item_Stack").Value
            : CodebreakerFont.Value;
        
        PropertyInfo dialogueFont = typeof(CodebreakerUI).GetCachedProperty("DialogFont");
        dialogueFont.SetValue(null, replaceFont);
    }
}