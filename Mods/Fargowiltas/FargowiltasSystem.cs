using CalamityRuTranslate.Common;
using CalamityRuTranslate.Common.Utilities;
using Fargowiltas.UI;
using Terraria;
using Terraria.ModLoader;

namespace CalamityRuTranslate.Mods.Fargowiltas;

public class FargowiltasSystem : ModSystem
{
    public override bool IsLoadingEnabled(Mod mod)
    {
        return !Main.dedServ && ModInstances.Fargowiltas != null && TranslationHelper.IsRussianLanguage;
    }

    public override void PostSetupContent()
    {
        StatSheetUI statSheet = global::Fargowiltas.Fargowiltas.UserInterfaceManager.StatSheet;
        const float backWidth = 840f;
        
        statSheet.BackPanel.Width.Set(backWidth, 0f);
        statSheet.InnerPanel.Width.Set(backWidth - 12f, 0f);
    }
}