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

    public override void SetBestiary(NPC npc, BestiaryDatabase database, BestiaryEntry bestiaryEntry)
    {
        if (npc.type == ModContent.NPCType<SpaceKeeper>())
        {
            bestiaryEntry.Info[7] = new FlavorTextBestiaryInfoElement("Третья боевая единица, созданная Королём-Охотником во время его странствия, продолжавшегося миллион лет. Разработка началась после разрушительной войны с пришельцами, обратившей армию андроидов Короля-Охотника в груду металлолома. Эта единица специализируется на восстановлении других роботов с помощью наноботов.");
        }
        
        if (npc.type == ModContent.NPCType<KS3_Magnet>())
        {
            bestiaryEntry.Info[7] = new FlavorTextBestiaryInfoElement("Этот дрон преобразует снаряды в энергию для ответного огня по целям.");
        }
        
        if (npc.type == ModContent.NPCType<KS3_MissileDrone>())
        {
            bestiaryEntry.Info[7] = new FlavorTextBestiaryInfoElement("Ракетный дрон, созданный Королём-Охотником III во время его странствия, продолжавшегося миллион лет.");
        }
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
        
        if (npc.type == ModContent.NPCType<Android>())
        {
            if (npc.GivenName == "Apidroid Mk.I")
                npc.GivenName = "Апидроид М.I";
        }
        
        if (npc.type == ModContent.NPCType<Blobble>())
        {
            if (npc.GivenName == "Serbble")
                npc.GivenName = "Сербень";
        }
    }
}