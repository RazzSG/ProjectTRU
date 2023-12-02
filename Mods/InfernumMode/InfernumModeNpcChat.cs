using CalamityRuTranslate.Common;
using CalamityRuTranslate.Common.Utilities;
using CalamityRuTranslate.Core.NpcChatTextTranslation;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CalamityRuTranslate.Mods.InfernumMode;

public class InfernumModeNpcChat : ILoadable, INpcChatText
{
    private int Nurse => NPC.FindFirstNPC(NPCID.Nurse);
    private bool IsTalking => Main.LocalPlayer.talkNPC >= 0;
    private int TalkingNpc => Main.player[Main.myPlayer].talkNPC;
    
    public bool IsLoadingEnabled(Mod mod)
    {
       return ModInstances.Calamity != null && ModInstances.Infernum != null && TranslationHelper.IsRussianLanguage;
    }

    public void NpcChatTextTranslation()
    {
        if (!IsTalking)
            return;

        if (TalkingNpc == Nurse)
        {
            Main.npcChatText = Main.npcChatText switch
            {
                "I cannot help you. Good luck." => "Я не могу тебе помочь. Удачи.",
                _ => Main.npcChatText
            };
        }
    }
    
    public void Load(Mod mod)
    {
    }

    public void Unload()
    {
    }
}