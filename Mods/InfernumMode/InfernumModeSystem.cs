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
    private DynamicSpriteFont BossIntroScreensFont => Mod.Assets.Request<DynamicSpriteFont>("Assets/Fonts/BossIntroScreensFont", AssetRequestMode.ImmediateLoad).Value;
    private DynamicSpriteFont ProfanedTextFont => Mod.Assets.Request<DynamicSpriteFont>("Assets/Fonts/ProfanedText", AssetRequestMode.ImmediateLoad).Value;

    public override bool IsLoadingEnabled(Mod mod)
    {
        return ModInstances.Infernum != null && TRuConfig.Instance.InfernumModeLocalization && TranslationHelper.IsRussianLanguage;
    }

    public override void PostSetupContent()
    {
        PropertyInfo bossIntroScreensProperty = typeof(InfernumFontRegistry).GetCachedProperty("BossIntroScreensFont");
        bossIntroScreensProperty?.SetValue(typeof(LocalizedSpriteFont), new LocalizedSpriteFont(BossIntroScreensFont).WithLanguage(GameCulture.CultureName.Russian, BossIntroScreensFont));
        
        PropertyInfo profanedTextProperty = typeof(InfernumFontRegistry).GetCachedProperty("ProfanedTextFont");
        profanedTextProperty?.SetValue(typeof(LocalizedSpriteFont), new LocalizedSpriteFont(ProfanedTextFont).WithLanguage(GameCulture.CultureName.Russian, ProfanedTextFont));
    }
}