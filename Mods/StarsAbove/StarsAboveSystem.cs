using System;
using System.Collections.Generic;
using System.Reflection;
using CalamityRuTranslate.Common;
using CalamityRuTranslate.Common.Utilities;
using CalamityRuTranslate.Core.Config;
using StarsAbove;
using StarsAbove.Systems;
using Terraria;
using Terraria.Audio;
using Terraria.ModLoader;
using Terraria.UI;

namespace CalamityRuTranslate.Mods.StarsAbove;

public partial class StarsAboveSystem : ModSystem
{
    public static ArchivePlayer ArchivePlayer => Main.LocalPlayer.GetModPlayer<ArchivePlayer>();
    public static StarsAbovePlayer StarsAbovePlayer => Main.LocalPlayer.GetModPlayer<StarsAbovePlayer>();

    public static Dictionary<SoundStyle, SoundStyle> SoundMap = new();
    
    public override bool IsLoadingEnabled(Mod mod)
    {
        return ModInstances.StarsAbove != null && TRuConfig.Instance.StarsAboveLocalization && TranslationHelper.IsRussianLanguage;
    }
    
    public override void OnModLoad()
    {
        SoundMap = CreateSoundMap();
    }

    public override void ModifyInterfaceLayers(List<GameInterfaceLayer> layers)
    {
        StellarNovasStats();
        
        if (ArchivePlayer.archiveActive && ArchivePlayer.archivePopulated)
        {
            foreach (ArchiveListing archiveListing in ArchivePlayer.VNArchiveList)
            {
                archiveListing.Name = archiveListing.Name switch
                {
                    "Intro Dialogue" => "Начальный диалог с Асфоденой",
                    "Eridani's Intro Dialogue" => "Начальный диалог с Эридани",
                    "Vagrant Post-Battle (Asphodene)" => "Скиталец после сражения (Асфодена)",
                    "Vagrant Post-Battle (Eridani)" => "Скиталец после сражения (Эридани)",
                    "The Astrolabe (Asphodene)" => "Астролябия (Асфодена)",
                    "The Astrolabe (Eridani)" => "Астролябия (Эридани)",
                    "The Observatory's Introduction" => "Введение в Обсерваторию",
                    "Yojimbo's Introduction (Asphodene)" => "Знакомство с Йодзимбо (Асфодена)",
                    "Yojimbo's Introduction (Eridani)" => "Знакомство с Йодзимбо (Эридани)",
                    "Yojimbo: About the galaxy..." => "Йодзимбо: О галактике...",
                    "Yojimbo: About the Empire..." => "Йодзимбо: Об империи...",
                    "Yojimbo: About the Ardor..." => "Йодзимбо: О Коллапсе...",
                    "Garridine's Introduction (Asphodene)" => "Знакомство с Гарридиной (Асфодена)",
                    "Garridine's Introduction (Eridani)" => "Знакомство с Гарридиной (Эридани)",
                    _ => archiveListing.Name
                };
            
                archiveListing.ListInformation = archiveListing.ListInformation switch
                {
                    "The Starfarer's introduction dialogue." => "Вступительный диалог Астры.",
                    "Perseus's introduction." => "Знакомство с Персеем.",
                    "Acquisition of the Astrolabe." => "Получение Астролябии.",
                    "Explaining Cosmic Voyages and the Astrolabe." => "Разъяснение о космических путешествиях и Астролябии.",
                    "Yojimbo, the lumenkin bounty hunter, makes his appearance." => "Появление Йодзимбо, охотника за головами из расы люменкинов.",
                    "Yojimbo's comments on the state of the galaxy." => "Комментарии Йодзимбо о положении дел в галактике.",
                    "Garridine, the lupine machinist, makes her appearance." => "Появление Гарридины, механика из волчьей расы.",
                    _ => archiveListing.ListInformation
                };
            
                archiveListing.UnlockConditions = archiveListing.UnlockConditions switch
                {
                    "Asphodene's intro dialogue." => "Вступительный диалог Асфодены.",
                    "Eridani's intro dialogue." => "Вступительный диалог Эридани.",
                    "Defeat the Vagrant of Space and Time. (Asphodene)" => "Одолейте Скитальца между измерениями (Асфодена).",
                    "Defeat the Vagrant of Space and Time. (Eridani)" => "Одолейте Скитальца между измерениями (Эридани).",
                    "Defeat the Eye of Cthulhu." => "Одолейте Глаз Ктулху.",
                    "Visit the Observatory." => "Посетите обсерваторию.",
                    "Meet Yojimbo during a Cosmic Voyage. (Asphodene)" => "Встретьте Йодзимбо во время космического путешествия (Асфодена).",
                    "Meet Yojimbo during a Cosmic Voyage. (Eridani)" => "Встретьте Йодзимбо во время космического путешествия (Эридани).",
                    "Talk to Yojimbo during a Cosmic Voyage. (Random unlock)" => "Поговорите с Йодзимбо во время космического путешествия (Случайная разблокировка).",
                    "Meet Garridine during a Cosmic Voyage. (Asphodene)" => "Встретьте Гарридину во время космического путешествия (Асфодена).",
                    "Meet Garridine during a Cosmic Voyage. (Eridani)" => "Встретьте Гарридину во время космического путешествия (Эридани).",
                    _ => archiveListing.UnlockConditions
                };
            }
        }

        if (StarsAbovePlayer.sceneID != -1 && StarsAbovePlayer.VNDialogueActive)
        {
            StarsAbovePlayer.VNDialogueVisibleName = StarsAbovePlayer.VNDialogueVisibleName switch
            {
                "Asphodene" => "Асфодена",
                "Eridani" => "Эридани",
                "Perseus" => "Персей",
                "Yojimbo" => "Йодзимбо",
                "Garridine" => "Гарридина",
                "Andyer" => "Андир",
                _ => StarsAbovePlayer.VNDialogueVisibleName
            };
        }
    }
    
    private static Dictionary<SoundStyle, SoundStyle> CreateSoundMap()
    {
        Dictionary<SoundStyle, SoundStyle> map = new Dictionary<SoundStyle, SoundStyle>();

        Type source = typeof(StarsAboveAudio);
        Type registry = typeof(StarsAboveSoundRegistry);
        StarsAboveAudio audioInstance = ModContent.GetInstance<StarsAboveAudio>();
        
        FieldInfo[] fields = source.GetFields(ReflectionHelper.UniversalFlags);

        foreach (FieldInfo field in fields)
        {
            if (field.FieldType != typeof(SoundStyle))
                continue;
            
            FieldInfo registryField = registry.GetField(field.Name, BindingFlags.Public | BindingFlags.Static);
        
            if (registryField != null)
            {
                object sourceValue = field.IsStatic ? field.GetValue(null) : field.GetValue(audioInstance);
                object registryValue = registryField.GetValue(null);

                if (sourceValue is SoundStyle original && registryValue is SoundStyle localized)
                {
                    map[original] = localized;
                }
            }
        }

        return map;
    }
}