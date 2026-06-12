using System;
using System.Collections;
using System.Collections.Generic;
using CalamityMod.UI.DialogueDisplay;
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

    public override void OnLocalizationsLoaded()
    {
        Type dialogueLoader = ModInstances.Calamity.Code.GetType("CalamityMod.Dialogues.DialogueLoader");
        IDictionary lookup = dialogueLoader?.GetMemberValue<IDictionary>("_DialogueLookup");
        
        foreach (var key in lookup.Keys)
        {
            string dialogueKey = key.ToString();
            object entry = lookup[key];

            DialogueTextData data = entry?.GetMemberValue<DialogueTextData>("Data");

            if (data?.Pages == null) continue;
            
            switch (dialogueKey)
            {
                case "Mods.CalamityMod.DevourerOfGods.Running":
                    data.Pages[0].Lines = ["[Scale(1.5):[Colors(2, 0.5, 00FFFF, FF00FF):Ты не сможешь бежать вечно!]]"];
                    data.Pages[1].Lines = ["[Shaking:[Scale(1.5):[Colors(2, 0.5, 00FFFF, FF00FF):В ЧЁМ ДЕЛО?! НОГИ БОЛЬШЕ НЕ СЛУШАЮТСЯ?!]]]"];
                    break;

                case "Mods.CalamityMod.DevourerOfGods.Phases":
                    data.Pages[0].Lines =
                    [
                        "[Scale(1.5):[Colors(2, 0.5, 00FFFF, FF00FF):Ты не бог...]]",
                        "[Scale(1.5):[Colors(2, 0.5, 00FFFF, FF00FF):Но я буду пировать твоей сущностью, несмотря ни на что!]]"
                    ];
                    data.Pages[1].Lines = ["[Scale(1.5):[Colors(2, 0.5, 00FFFF, FF00FF):Ты справился лучше большинства, но не зазнавайся!]]"];
                    data.Pages[2].Lines = ["[Scale(1.5):[Colors(2, 0.5, 00FFFF, FF00FF):Это ещё не конец, малец!]]"];
                    data.Pages[3].Lines = ["[Colors(2, 0.5, FF00FF, 00FFFF):[Shaking(5):[Scale(2): [Pause(0.33)]БОГ]]][Colors(2, 0.5, 00FFFF, FF00FF):[Shaking:[Scale(1.5): НЕ БОИТСЯ]]][Colors(2, 0.5, FF00FF, 00FFFF):[Shaking(5):[Scale(2): [Pause(0.33)]СМЕРТИ!]]]"];
                break;

                case "Mods.CalamityMod.DevourerOfGods.Death":
                    data.Pages[0].Lines = ["[Scale(1.5):[Colors(2, 0.5, 00FFFF, FF00FF):Безвкусная [Pause(0.25)]бурда.]]"];
                    data.Pages[1].Lines = ["[Scale(1.5):[Colors(2, 0.5, 00FFFF, FF00FF):Восхитительно... Пир, достойный бога!]]"];
                    data.Pages[2].Lines = ["[Scale(1.5):[Colors(2, 0.5, 00FFFF, FF00FF):И [Shaking:НЕ СМЕЙ] возвращаться!]]"];
                    data.Pages[3].Lines = ["[Shaking:[Scale(1.5):[Colors(2, 0.5, 00FFFF, FF00FF):СЛАБАК.]]]"];
                    data.Pages[4].Lines = ["[Scale(1.5):[Colors(2, 0.5, 00FFFF, FF00FF):[Shaking:ЖАЛКОЕ ЗРЕЛИЩЕ.] СТОЛЬКО БЕГАТЬ, ЧТОБЫ СДОХНУТЬ ОТ [Shaking:ОДНОГО КАСАНИЯ?!]]]"];
                    break;

                case "Mods.CalamityMod.DevourerOfGods.Head":
                    data.Pages[0].Lines = ["[Scale(1.5):[Colors(2, 0.5, 00FFFF, FF00FF):Пади ниц, червь!]]"];
                    data.Pages[1].Lines = ["[Scale(1.5):[Colors(2, 0.5, 00FFFF, FF00FF):Посмотрим, сколько ещё ты протянешь...]]"];
                    data.Pages[2].Lines = ["[Scale(1.5):[Colors(2, 0.5, 00FFFF, FF00FF):Что, уже выдыхаешься?]]"];
                    data.Pages[3].Lines = ["[Scale(1.5):[Colors(2, 0.5, 00FFFF, FF00FF):Ты падёшь, как и все остальные!]]"];
                    data.Pages[4].Lines = ["[Scale(1.5):[Colors(2, 0.5, 00FFFF, FF00FF):Сдавайся! Так будет проще для нас обоих!]]"];
                    data.Pages[5].Lines = ["[Scale(1.5):[Colors(2, 0.5, 00FFFF, FF00FF):Да дай мне уже прикончить тебя!]]"];
                    data.Pages[6].Lines = ["[Scale(1.5):[Colors(2, 0.5, 00FFFF, FF00FF):Это начинает выглядеть нелепо!..]]"];
                    data.Pages[7].Lines = ["[Scale(1.5):[Colors(2, 0.5, 00FFFF, FF00FF):Как тебе это удаётся?!]]"];
                    data.Pages[8].Lines = ["[Scale(1.5):[Colors(2, 0.5, 00FFFF, FF00FF):Ты держишь меня за дурака?!]]"];
                    data.Pages[9].Lines = ["[Scale(1.5):[Colors(2, 0.5, 00FFFF, FF00FF):Да почему ты не [Shaking:СДОХНЕШЬ?!]]]"];
                    data.Pages[10].Lines = ["[Shaking:[Scale(1.5):[Colors(2, 0.5, 00FFFF, FF00FF):ПАДИ!]]]"];
                    data.Pages[11].Lines = ["[Shaking:[Scale(1.5):[Colors(2, 0.5, 00FFFF, FF00FF):ИСЧЕЗНИ!]]]"];
                    data.Pages[12].Lines = ["[Shaking:[Scale(1.5):[Colors(2, 0.5, 00FFFF, FF00FF):УМРИ!]]]"];
                break;
                
                case "Mods.CalamityMod.EvilSmasher.CrimsonAltar":
                    data.Pages[0].Lines = ["Ты, сразивший башню из плоти...[Pause(0.25)] у нас есть предложение, достойное твоих деяний."];
                    data.Pages[1].Lines = ["Мы даруем тебе неслыханную мощь...[Pause(0.25)] [Shaking:способную стереть твоих врагов в порошок!]"];
                    data.Pages[2].Lines = ["Лишь преподнеси нам святой молот на алтарь."];
                    data.Pages[3].Lines = ["Склонись пред нами, и мы наделим тебя силой."];
                    break;
                
                case "Mods.CalamityMod.EvilSmasher.DemonAltar":
                    data.Pages[0].Lines = ["Носитель святого молота...[Pause(0.25)] [Wavy:жаждешь ли ты вкусить истинной власти?]"];
                    data.Pages[1].Lines = ["Отверзнутся очи твои...[Pause(0.25)] [Shaking:и станешь ты подобен богам!]"];
                    data.Pages[2].Lines = ["Предай нам молот сей на алтарь."];
                    data.Pages[3].Lines = ["Покорись, и ты познаешь наше безграничное могущество."];
                    break;
            }
        }
    }
}