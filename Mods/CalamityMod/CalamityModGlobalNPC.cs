using CalamityMod.NPCs.TownNPCs;
using CalamityRuTranslate.Common;
using CalamityRuTranslate.Common.Utilities;
using CalamityRuTranslate.Core.Config;
using Terraria;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;

namespace CalamityRuTranslate.Mods.CalamityMod;

public class CalamityModGlobalNPC : GlobalNPC
{
    public override bool IsLoadingEnabled(Mod mod)
    {
        return ModInstances.Calamity != null && TRuConfig.Instance.CalamityModLocalization && TranslationHelper.IsRussianLanguage;
    }

    public override void GetChat(NPC npc, ref string chat)
    {
        string worldEvil = Language.GetTextValue("LegacyMisc." + (WorldGen.crimson ? 102 : 101));
        
        if (npc.type == NPCID.Stylist)
        {
            if (chat == Language.GetOrRegister("Mods.CalamityMod.Vanilla.StylistChat.Hardmode").Format(worldEvil))
            {
                chat = chat.Replace("Багрянец", "багряных");
                chat = chat.Replace("Искажение", "искажённых");
            }
        }
    }

    public override void OnChatButtonClicked(NPC npc, bool firstButton)
    {
        string worldEvil = Language.GetTextValue("LegacyMisc." + (WorldGen.crimson ? 102 : 101));
        
        if (npc.type == ModContent.NPCType<SEAHOE>())
        {
            if (Main.npcChatText == Language.GetOrRegister("Mods.CalamityMod.NPCs.SEAHOE.Help.PreHardmode6").Format(worldEvil))
            {
                Main.npcChatText = Main.npcChatText.Replace("Багрянец", "багрянце");
                Main.npcChatText = Main.npcChatText.Replace("Искажение", "искажении");
            }
        }
    }
}