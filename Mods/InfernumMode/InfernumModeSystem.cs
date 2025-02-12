using System.Reflection;
using CalamityRuTranslate.Common;
using CalamityRuTranslate.Common.Utilities;
using CalamityRuTranslate.Core.Config;
using InfernumMode.Assets.Fonts;
using InfernumMode.Common.DataStructures;
using ReLogic.Content;
using ReLogic.Graphics;
using Terraria.Localization;
using Terraria.ModLoader;

namespace CalamityRuTranslate.Mods.InfernumMode;

public class InfernumModeSystem : ModSystem
{
    public override bool IsLoadingEnabled(Mod mod)
    {
        return ModInstances.Infernum != null && TRuConfig.Instance.InfernumModeLocalization && TranslationHelper.IsRussianLanguage;
    }

    public override void PostSetupContent()
    {
        DynamicSpriteFont bossIntroScreensFont = ModContent.Request<DynamicSpriteFont>("CalamityRuTranslate/Assets/Fonts/BossIntroScreensFont", AssetRequestMode.ImmediateLoad).Value;
        DynamicSpriteFont profanedTextFont = ModContent.Request<DynamicSpriteFont>("CalamityRuTranslate/Assets/Fonts/ProfanedText", AssetRequestMode.ImmediateLoad).Value;
        
        PropertyInfo bossIntroScreensProperty = typeof(InfernumFontRegistry).GetProperty("BossIntroScreensFont", BindingFlags.Public | BindingFlags.Static);
        bossIntroScreensProperty?.SetValue(typeof(LocalizedSpriteFont), new LocalizedSpriteFont(bossIntroScreensFont).WithLanguage(GameCulture.CultureName.Russian, bossIntroScreensFont));
        
        PropertyInfo profanedTextProperty = typeof(InfernumFontRegistry).GetProperty("ProfanedTextFont", BindingFlags.Public | BindingFlags.Static);
        profanedTextProperty?.SetValue(typeof(LocalizedSpriteFont), new LocalizedSpriteFont(profanedTextFont).WithLanguage(GameCulture.CultureName.Russian, profanedTextFont));
    }
}