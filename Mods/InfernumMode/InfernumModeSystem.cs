using CalamityRuTranslate.Common;
using CalamityRuTranslate.Common.Utilities;
using InfernumMode.Content.Credits;
using ReLogic.Content;
using ReLogic.Graphics;
using Terraria.ModLoader;

namespace CalamityRuTranslate.Mods.InfernumMode;

public class InfernumModeSystem : ModSystem
{
    public static DynamicSpriteFont BossIntroScreensFont;

    public override bool IsLoadingEnabled(Mod mod)
    {
        return ModInstances.Calamity != null && ModInstances.Infernum != null && TranslationHelper.IsRussianLanguage;
    }

    public override void PostSetupContent()
    {
        BossIntroScreensFont = Mod.Assets.Request<DynamicSpriteFont>("Assets/Fonts/BossIntroScreensFont", AssetRequestMode.ImmediateLoad).Value;

        string[] headers = typeof(CreditManager).GetFieldValue<string[]>("Headers");
        headers[0] = "Программисты";
        headers[1] = "Музыкант";
        headers[2] = "Художники";
        headers[3] = "Тестировщики";
        headers[4] = "Тестировщики";
        headers[5] = "Тестировщики";
        headers[6] = "Тестировщики";
    }
}