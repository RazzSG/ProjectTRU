using CalamityMod.NPCs.CalClone;
using CalamityMod.NPCs.GreatSandShark;
using CalamityRuTranslate.Common;
using CalamityRuTranslate.Common.Utilities;
using InfernumMode.Content.BehaviorOverrides.AbyssAIs;
using InfernumMode.Content.BehaviorOverrides.BossAIs.GreatSandShark;
using InfernumMode.Core.GlobalInstances.Systems;
using Terraria;
using Terraria.GameContent.Bestiary;
using Terraria.ModLoader;

namespace CalamityRuTranslate.Mods.InfernumMode;

public class InfernumModeGlobalNPC : GlobalNPC
{
    public override bool IsLoadingEnabled(Mod mod)
    {
        return ModInstances.Calamity != null && ModInstances.Infernum != null && TranslationHelper.IsRussianLanguage;
    }
    
    public override void ModifyTypeName(NPC npc, ref string typeName)
    {
        if (WorldSaveSystem.InfernumModeEnabled)
        {
            if (npc.type == ModContent.NPCType<GreatSandShark>())
                typeName = "Таурус, Великая песчаная акула";
            
            if (npc.type == ModContent.NPCType<CalamitasClone>())
                typeName = "Забытая тень Каламитас";
            
            if (npc.type == ModContent.NPCType<Cataclysm>())
                typeName = "Забытая тень Катаклизма";
            
            if (npc.type == ModContent.NPCType<Catastrophe>())
                typeName = "Забытая тень Катастрофа";
        }
    }
    
    public override void SetBestiary(NPC npc, BestiaryDatabase database, BestiaryEntry bestiaryEntry)
    {
        if (npc.type == ModContent.NPCType<BereftVassal>())
        {
            bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
            bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement("Неутомимый страж, утративший смысл жизни. Узнав, что его король жив и здравствует, вновь обрёл волю к жизни. Он с нетерпением ждёт следующего поединка с вами."));
        }
        
        if (npc.type == ModContent.NPCType<DepthFeeder>())
        {
            bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
            bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement("Даже во всеобъемлющей враждебности бездны могут процветать разнообразные экосистемы."));
        }
        
        if (npc.type == ModContent.NPCType<Herring>())
        {
            bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
            bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement("Необычайно выносливые, эти существа каким-то образом процветают в токсичных верхних пещерах бездны. Тем не менее, они находятся в самом низу пищевой цепи."));
        }
        
        if (npc.type == ModContent.NPCType<LionfishEnemy>())
        {
            bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
            bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement("Эти крепкие рыбы редко становятся жертвами охоты в своей естественной среде обитания, полагаясь в основном на свои ядовитые шипы как для нападения, так и для защиты."));
        }
    }
}