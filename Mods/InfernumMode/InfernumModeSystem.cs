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
        _ = typeof(InfernumFontRegistry).SetMemberValue("BossIntroScreensFont", new LocalizedSpriteFont(BossIntroScreensFont).WithLanguage(GameCulture.CultureName.Russian, BossIntroScreensFont));
        _ = typeof(InfernumFontRegistry).SetMemberValue("ProfanedTextFont", new LocalizedSpriteFont(ProfanedTextFont).WithLanguage(GameCulture.CultureName.Russian, ProfanedTextFont));
    }
}