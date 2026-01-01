using CalamityRuTranslate.Common;
using CalamityRuTranslate.Common.Utilities;
using CalamityRuTranslate.Core.Config;
using Redemption.NPCs.Bosses.KSIII;
using Redemption.NPCs.Friendly.SpiritSummons;
using Redemption.NPCs.HM;
using Redemption.NPCs.PreHM;
using Terraria;
using Terraria.GameContent.Bestiary;
using Terraria.ModLoader;

namespace CalamityRuTranslate.Mods.Redemption;

public class RedemptionGlobalNPC : GlobalNPC
{
    public override bool IsLoadingEnabled(Mod mod)
    {
        return TranslationHelper.IsRussianLanguage && TRuConfig.Instance.RedemptionLocalization && ModInstances.Redemption != null;
    }

    public override void ModifyTypeName(NPC npc, ref string typeName)
    {
        string playerName = Main.LocalPlayer.name;
        
        if (npc.type == ModContent.NPCType<EpidotrianSkeleton_SS>())
        {
            typeName = $"Голем из древней каменной глади игрока {playerName}";
        }
        
        if (npc.type == ModContent.NPCType<EpidotrianSkeleton_SS>())
        {
            typeName = $"Скелет-эпидотриец игрока {playerName}";
        }
        
        if (npc.type == ModContent.NPCType<ForestNymph_SS>())
        {
            typeName = $"Лесная нифма игрока {playerName}";
        }
        
        if (npc.type == ModContent.NPCType<MossyGoliath_SS>())
        {
            typeName = $"Мшистый голиаф игрока {playerName}";
        }
        
        if (npc.type == ModContent.NPCType<SkeletonAssassin_SS>())
        {
            typeName = $"Скелет-убийца игрока {playerName}";
        }
        
        if (npc.type == ModContent.NPCType<SkeletonDuelist_SS>())
        {
            typeName = $"Скелет-дуэлянт игрока {playerName}";
        }
        
        if (npc.type == ModContent.NPCType<SkeletonFlagbearer_SS>())
        {
            typeName = $"Скелет-знаменосец игрока {playerName}";
        }
        
        if (npc.type == ModContent.NPCType<SkeletonNoble_SS>())
        {
            typeName = $"Скелет-аристократ игрока {playerName}";
        }
        
        if (npc.type == ModContent.NPCType<SkeletonWanderer_SS>())
        {
            typeName = $"Скелет-странник игрока {playerName}";
        }
        
        if (npc.type == ModContent.NPCType<SkeletonWarden_SS>())
        {
            typeName = $"Скелет-страж игрока {playerName}";
        }
        
        if (npc.type == ModContent.NPCType<Blobble>())
        {
            if (npc.GivenName == "Serbble")
                npc.GivenName = "Сербень";
        }
    }
}