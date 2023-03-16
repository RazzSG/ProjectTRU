﻿using CalamityMod.NPCs.ExoMechs.Apollo;
using CalamityMod.NPCs.ExoMechs.Ares;
using CalamityMod.NPCs.ExoMechs.Artemis;
using CalamityMod.NPCs.ExoMechs.Thanatos;
using CalamityMod.NPCs.Polterghast;
using CalamityMod.NPCs.Yharon;
using CalamityRuTranslate.Common;
using CalamityRuTranslate.Common.Utilities;
using Terraria;
using Terraria.ModLoader;

namespace CalamityRuTranslate.Mods.CalamityMod.GlobalModifications;

public class CalamityModeGlobalNPC : GlobalNPC
{
    public override bool IsLoadingEnabled(Mod mod)
    {
        return ModsCall.Calamity != null && TranslationHelper.IsRussianLanguage;
    }
    
    public override void ModifyTypeName(NPC npc, ref string typeName)
    {
        if (npc.type == ModContent.NPCType<Apollo>())
        {
            if (typeName == "Corrosive Eye of XB-в€ћ Hekate")
            {
                typeName = "Едкий глаз ХВ-в€ћ Гекаты";
            }
        }
        
        if (npc.type == ModContent.NPCType<AresBody>())
        {
            if (typeName == "XB-в€ћ Hekate")
            {
                typeName = "ХВ-в€ћ Геката";
            }
        }
        
        if (npc.type == ModContent.NPCType<AresGaussNuke>())
        {
            if (typeName == "XB-∞ Hekate Gauss Nuke")
            {
                typeName = "Ядерная Гаусс-пушка ХВ-∞ Гекаты";
            }
        }
        
        if (npc.type == ModContent.NPCType<AresLaserCannon>())
        {
            if (typeName == "XB-∞ Hekate Laser Cannon")
            {
                typeName = "Лазерная пушка ХВ-∞ Гекаты";
            }
        }
        
        if (npc.type == ModContent.NPCType<AresPlasmaFlamethrower>())
        {
            if (typeName == "XB-∞ Hekate Plasma Flamethrower")
            {
                typeName = "Плазмомёт ХВ-∞ Гекаты";
            }
        }
        
        if (npc.type == ModContent.NPCType<AresTeslaCannon>())
        {
            if (typeName == "XB-∞ Hekate Tesla Cannon")
            {
                typeName = "Тесла-пушка ХВ-∞ Гекаты";
            }
        }
        
        if (npc.type == ModContent.NPCType<Artemis>())
        {
            if (typeName == "Blazing Eye of XB-в€ћ Hekate")
            {
                typeName = "Пылающий глаз ХВ-в€ћ Гекаты";
            }
        }
        
        if (npc.type == ModContent.NPCType<ThanatosBody1>())
        {
            if (typeName == "Spine of XB-∞ Hekate")
            {
                typeName = "Хребет ХВ-∞ Гекаты";
            }
        }
        
        if (npc.type == ModContent.NPCType<ThanatosBody2>())
        {
            if (typeName == "Spine of XB-∞ Hekate")
            {
                typeName = "Хребет ХВ-∞ Гекаты";
            }
        }
        
        if (npc.type == ModContent.NPCType<ThanatosHead>())
        {
            if (typeName == "Spine of XB-∞ Hekate")
            {
                typeName = "Хребет ХВ-∞ Гекаты";
            }
        }
        
        if (npc.type == ModContent.NPCType<ThanatosTail>())
        {
            if (typeName == "Spine of XB-∞ Hekate")
            {
                typeName = "Хребет ХВ-∞ Гекаты";
            }
        }
        
        if (npc.type == ModContent.NPCType<Polterghast>())
        {
            if (typeName == "Necroghast")
            {
                typeName = "Некрогаст";
            }
            if (typeName == "Necroplasm")
            {
                typeName = "Некроплазм";
            }
            if (typeName == "Polterghast")
            {
                typeName = "Полтергаст";
            }
        }
        
        if (npc.type == ModContent.NPCType<Yharon>())
        {
            if (typeName == "Yharon, Resplendent Phoenix")
            {
                typeName = "Ярон, Восходящий феникс";
            }
        }
    }
}