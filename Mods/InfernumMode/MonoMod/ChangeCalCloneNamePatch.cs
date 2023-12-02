using CalamityMod.NPCs.CalClone;
using CalamityRuTranslate.Common;
using CalamityRuTranslate.Common.Utilities;
using InfernumMode.Core.GlobalInstances.Systems;
using Terraria;
using Terraria.ModLoader;

namespace CalamityRuTranslate.Mods.InfernumMode.MonoMod;

public class ChangeCalCloneNamePatch : ILoadable
{
    public bool IsLoadingEnabled(Mod mod)
    {
        return TranslationHelper.IsRussianLanguage && ModInstances.Calamity != null && ModInstances.Infernum != null;
    }

    public void Load(Mod mod)
    {
        On_NPC.DoDeathEvents_DropBossPotionsAndHearts += ChangeName;
    }

    public void Unload()
    {
        On_NPC.DoDeathEvents_DropBossPotionsAndHearts -= ChangeName;
    }
    
    private void ChangeName(On_NPC.orig_DoDeathEvents_DropBossPotionsAndHearts orig, NPC npc, ref string typeName)
    {
        orig.Invoke(npc, ref typeName);
        
        if (npc.type == ModContent.NPCType<CalamitasClone>() && WorldSaveSystem.InfernumModeEnabled)
            typeName = "Забытая тень Каламитас";
    }
}