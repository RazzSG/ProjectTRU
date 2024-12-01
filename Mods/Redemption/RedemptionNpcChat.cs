using CalamityRuTranslate.Common;
using CalamityRuTranslate.Common.Utilities;
using CalamityRuTranslate.Core.Config;
using Redemption.NPCs.Friendly;
using Terraria;
using Terraria.ModLoader;

namespace CalamityRuTranslate.Mods.Redemption;

public class RedemptionNpcChat : GlobalNPC
{
    public override bool IsLoadingEnabled(Mod mod)
    {
        return ModInstances.Redemption != null && TRuConfig.Instance.RedemptionLocalization && TranslationHelper.IsRussianLanguage;
    }

    public override void GetChat(NPC npc, ref string chat)
    {
        string GetNPCName(int type) => Main.npc[NPC.FindFirstNPC(type)].GivenName;

        if (npc.type == ModContent.NPCType<SoullessPortal>())
        {
            chat = chat switch
            {
                "You wish to escape this cursed place..." => "Ты жаждешь покинуть это проклятое место...",
                "You hear an ominous hum from the portal..." => "Из портала доносится зловещий гул...",
                _ => chat
            };
        }
        
        if (npc.type == ModContent.NPCType<TreebarkDryad>())
        {
            if (chat.Contains("Hmmmm..."))
            {
                chat = chat.Replace("Hmmmm...", "Хм-м-м...");
            }
        }
    }
}