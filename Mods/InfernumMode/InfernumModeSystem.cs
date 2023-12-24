using System.Reflection;
using CalamityRuTranslate.Common;
using CalamityRuTranslate.Common.Utilities;
using InfernumMode.Assets.Fonts;
using InfernumMode.Common.DataStructures;
using InfernumMode.Content.Credits;
using ReLogic.Content;
using ReLogic.Graphics;
using Terraria.Localization;
using Terraria.ModLoader;

namespace CalamityRuTranslate.Mods.InfernumMode;

public class InfernumModeSystem : ModSystem
{
    public override bool IsLoadingEnabled(Mod mod)
    {
        return ModInstances.Calamity != null && ModInstances.Infernum != null && TranslationHelper.IsRussianLanguage;
    }

    public override void PostSetupContent()
    {
        DynamicSpriteFont bossIntroScreensFont = ModContent.Request<DynamicSpriteFont>("CalamityRuTranslate/Assets/Fonts/BossIntroScreensFont", AssetRequestMode.ImmediateLoad).Value;
        DynamicSpriteFont profanedTextFont = ModContent.Request<DynamicSpriteFont>("CalamityRuTranslate/Assets/Fonts/ProfanedText", AssetRequestMode.ImmediateLoad).Value;
        
        PropertyInfo bossIntroScreensProperty = typeof(InfernumFontRegistry).GetProperty("BossIntroScreensFont", BindingFlags.Public | BindingFlags.Static);
        bossIntroScreensProperty?.SetValue(typeof(LocalizedSpriteFont), new LocalizedSpriteFont(bossIntroScreensFont).WithLanguage(GameCulture.CultureName.Russian, bossIntroScreensFont));
        
        PropertyInfo profanedTextProperty = typeof(InfernumFontRegistry).GetProperty("ProfanedTextFont", BindingFlags.Public | BindingFlags.Static);
        profanedTextProperty?.SetValue(typeof(LocalizedSpriteFont), new LocalizedSpriteFont(profanedTextFont).WithLanguage(GameCulture.CultureName.Russian, profanedTextFont));

        string[] headers = typeof(CreditManager).GetFieldValue<string[]>("Headers");
        headers[0] = "Программисты";
        headers[1] = "Музыкант";
        headers[2] = "Художники";
        headers[3] = "Тестировщики";
        headers[4] = "Тестировщики";
        headers[5] = "Тестировщики";
        headers[6] = "Тестировщики";
        headers[7] = "Переводчики официального перевода";
    }
}