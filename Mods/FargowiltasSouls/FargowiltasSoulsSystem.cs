using CalamityRuTranslate.Common;
using CalamityRuTranslate.Common.Utilities;
using CalamityRuTranslate.Core.Config;
using FargowiltasSouls.Content.UI;
using Terraria;
using Terraria.ModLoader;

namespace CalamityRuTranslate.Mods.FargowiltasSouls;

public class FargowiltasSoulsSystem : ModSystem
{
    public override bool IsLoadingEnabled(Mod mod)
    {
        return !Main.dedServ && ModInstances.FargowiltasSouls != null && TRuConfig.Instance.FargowiltasSoulsLocalization && TranslationHelper.IsRussianLanguage;
    }

    public override void PostSetupContent()
    {
        const float backWidth = 540f;
        SoulToggler soulToggler = FargoUIManager.SoulToggler;
        soulToggler.BackPanel.Width.Set(backWidth, 0f);
        soulToggler.InnerPanel.Width.Set(backWidth - 12f, 0f);
        soulToggler.Scrollbar.Left.Set(soulToggler.InnerPanel.Width.Pixels - soulToggler.Scrollbar.Width.Pixels - 18f, 0f);
        soulToggler.PresetPanel.Width.Set(backWidth - 10f, 0f);
        soulToggler.ToggleList.Width.Set(soulToggler.InnerPanel.Width.Pixels - soulToggler.InnerPanel.PaddingLeft * 2f - soulToggler.Scrollbar.Width.Pixels, 0f);
    }
}