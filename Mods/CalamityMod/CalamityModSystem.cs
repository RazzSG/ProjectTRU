using System.Collections.Generic;
using CalamityMod.UI.DraedonSummoning;
using CalamityRuTranslate.Common;
using CalamityRuTranslate.Common.Utilities;
using CalamityRuTranslate.Core.Config;
using CalamityRuTranslate.Mods.CalamityMod.Content.Items;
using ReLogic.Graphics;
using Terraria;
using Terraria.GameContent;
using Terraria.ModLoader;

namespace CalamityRuTranslate.Mods.CalamityMod;

public class CalamityModSystem : ModSystem
{
    private DynamicSpriteFont CodebreakerFont
    {
        get
        {
            if (TRuConfig.Instance.NewRussianTerrariaFont)
                return Mod.Assets.Request<DynamicSpriteFont>("Assets/Fonts/Item_Stack").Value;
            
            return FontAssets.ItemStack.Value;
        }
    }

    public override bool IsLoadingEnabled(Mod mod)
    {
        return ModInstances.Calamity != null && TRuConfig.Instance.CalamityModLocalization && TranslationHelper.IsRussianLanguage;
    }

    public override void PostSetupContent()
    {
        if (!Main.dedServ)
        {
            _ = typeof(CodebreakerUI).SetMemberValue(nameof(CodebreakerUI.DialogFont), CodebreakerFont);
        }

        if (ModLoader.TryGetMod("BossChecklist", out Mod bossChecklist) && bossChecklist != null)
        {
            bossChecklist.Call(
            "SubmitEntryCollectibles",
            Mod,
            new Dictionary<string, object>
            {
                { "CalamityMod Yharon", ModContent.ItemType<YharonPhase2MusicBox>() }
            });
        }
    }
}