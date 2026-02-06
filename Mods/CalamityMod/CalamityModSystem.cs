using System.Collections.Generic;
using CalamityRuTranslate.Common;
using CalamityRuTranslate.Common.Utilities;
using CalamityRuTranslate.Core.Config;
using CalamityRuTranslate.Mods.CalamityMod.Content.Items;
using Terraria.ModLoader;

namespace CalamityRuTranslate.Mods.CalamityMod;

public class CalamityModSystem : ModSystem
{
    public override bool IsLoadingEnabled(Mod mod)
    {
        return ModInstances.Calamity != null && TRuConfig.Instance.CalamityModLocalization && TranslationHelper.IsRussianLanguage;
    }

    public override void PostSetupContent()
    {
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