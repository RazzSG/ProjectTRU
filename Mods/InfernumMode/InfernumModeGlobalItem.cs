using System.Collections.Generic;
using CalamityMod;
using CalamityMod.Items.SummonItems;
using CalamityRuTranslate.Common;
using CalamityRuTranslate.Common.Utilities;
using InfernumMode.Content.Items.Misc;
using InfernumMode.Content.Items.Relics;
using InfernumMode.Core.GlobalInstances.Systems;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CalamityRuTranslate.Mods.InfernumMode;

public class InfernumModeGlobalItem : GlobalItem
{
    public override bool IsLoadingEnabled(Mod mod)
    {
        return ModInstances.Calamity != null && ModInstances.Infernum != null && TranslationHelper.IsRussianLanguage;
    }

    public override void ModifyTooltips(Item item, List<TooltipLine> tooltips)
    {
        if (item.type == ItemID.CelestialSigil)
        {
            ItemHelper.TranslateTooltip(tooltips, "Tooltip0", tooltip =>
            {
                tooltip.Text = "Моментально призывает Лунного лорда\nСоздаёт арену на месте игрока\nНе расходуется";
            });
        }
        else if (item.type == ModContent.ItemType<ProvidenceRelic>())
        {
            ItemHelper.TranslateTooltip(tooltips, l => l.Name == "Tooltip0", tooltip =>
            {
                tooltip.Text = WorldSaveSystem.HasBeatenInfernumNightProvBeforeDay
                    ? "Чё? Что за фигня? Саня, ты в порядке?\nТы должен был сначала победить её днём, а уже ПОСЛЕ сражаться с ней ночью!"
                    : "Это первое серьёзное препятствие после победы над Лунным лордом. Твоя триумфальная победа над ней была отнюдь не маленьким подвигом\nМожет, попробуешь сразиться с ней ещё раз, но уже ночью? Проверить свои силы в дополнительном испытании";
            });
        }
        else if (item.type == ModContent.ItemType<DraedonRelic>())
        {
            ItemHelper.TranslateTooltip(tooltips, l => l.Name == "Tooltip0", tooltip =>
            {
                tooltip.Text = DownedBossSystem.downedCalamitas
                    ? "Впечатляющее зрелище. Тобой преодолены все крупные препятствия\nГордись достигнутым, ведь теперь ты стал гораздо сильнее, нежели в начале пути"
                    : "Ты просто невероятен. Осталось последнее испытание - сражение с Ведьмой";
            });
        }
        else if (item.type == ModContent.ItemType<SupremeCalamitasRelic>())
        {
            ItemHelper.TranslateTooltip(tooltips, l => l.Name == "Tooltip0", tooltip =>
            {
                tooltip.Text = DownedBossSystem.downedExoMechs
                    ? "Впечатляющее зрелище. Тобой преодолены все крупные препятствия\nГордись достигнутым, ведь теперь ты стал гораздо сильнее, нежели в начале пути"
                    : "Ты просто невероятен. Осталось последнее испытание - встретиться лицом к лицу с космическим инженером";
            });
        }
        else if (item.type == ModContent.ItemType<ProfanedShard>())
        {
            ItemHelper.TranslateTooltip(tooltips, "Tooltip1", _ =>
            {
                tooltips.ReplaceText("Summons the Profaned Guardians when used on the cliff in the profaned garden at the far right of the underworld during day", "Призывает Осквернённых стражей при использовании днём на утёсе в Осквернённом саду, расположенном далеко справа в преисподней");
            });
            
            ItemHelper.TranslateTooltip(tooltips, l => l.Mod == "InfernumMode" && l.Name == "Warning", tooltip =>
            {
                tooltip.Text = "На данный момент в вашем мире отсутствует сад. Повторно убейте Лунного лорда, чтобы сгенерировать его\nНо сперва заберите из лаборатории схему преисподней, поскольку генерация сада может её разрушить";
            });
        }
        else if (item.type == ModContent.ItemType<ProfanedCore>())
        {
            ItemHelper.TranslateTooltip(tooltips, "Tooltip1", _ =>
            {
                tooltips.ReplaceText("Summons Providence when used at the altar in the profaned temple at the far right of the underworld", "Призывает Провиденс при использовании на алтаре в Осквернённом храме, расположенном далеко справа в преисподней");
            });
        }
        else if (item.type == ItemID.LihzahrdPowerCell)
        {
            ItemHelper.TranslateTooltip(tooltips, "Tooltip0", _ =>
            {
                tooltips.ReplaceText("Summons Golem when used at the Lihzhard Altar\nGolem summons a rectangular arena around the altar\nIf the altar is inside of the temple solid tiles within the arena are broken", "Используется на алтаре яхщеров для призыва Голема\nСоздаёт прямоугольную арену вокруг алтаря\nЕсли алтарь находится внутри Храма джунглей, то блоки внутри арены разрушаются");
            });
        }
        else if (item.type == ModContent.ItemType<EyeOfCthulhuRelic>())
        {
            ItemHelper.TranslateTooltip(tooltips, "Tooltip0", _ =>
            {
                tooltips.ReplaceText("Remember to not force yourself too much in the pursuit of victory. Take breaks if you need to.\nThe most important thing is fun.", "Запомни, что не следует нервничать или проявлять агрессию в погоне за победой. Передохни и выпей чаю\nВедь главное - это веселье");
            });
        }
        else if (item.type == ModContent.ItemType<EmpressOfLightRelic>())
        {
            ItemHelper.TranslateTooltip(tooltips, "Tooltip0", _ =>
            {
                tooltips.ReplaceText("The optional foes may at times be the most formidable. So too may they yield the greatest rewards.", "Порой необязательные враги могут быть самыми грозными. Но и награда за победу над ними порой бывает ценной");
            });
        }
        else if (item.type == ModContent.ItemType<EmpressOfLightRelic>())
        {
            ItemHelper.TranslateTooltip(tooltips, "Tooltip0", _ =>
            {
                tooltips.ReplaceText("The optional foes may at times be the most formidable. So too may they yield the greatest rewards.", "Порой необязательные враги могут быть самыми грозными. Но и награда за победу над ними порой бывает ценной");
            });
        }
        else if (item.type == ModContent.ItemType<GolemRelic>())
        {
            ItemHelper.TranslateTooltip(tooltips, "Tooltip0", _ =>
            {
                tooltips.ReplaceText("Simple methodical planning goes a long way. It will be invaluable against future obstacles.", "Тщательная подготовка и планирование тактики к бою поможет тебе в достижении цели. Это сыграет немаловажную роль в преодолении будущих препятствий");
            });
        }
        else if (item.type == ModContent.ItemType<KingSlimeRelic>())
        {
            ItemHelper.TranslateTooltip(tooltips, "Tooltip0", _ =>
            {
                tooltips.ReplaceText("Even seasoned players may struggle somewhat in the face of something new and unfamiliar. Adaptability is key.", "Перед лицом чего-то нового и незнакомого даже у опытных игроков могут возникнуть некоторые трудности. Адаптивность - вот ключ к успеху");
            });
        }
        else if (item.type == ModContent.ItemType<MoonLordRelic>())
        {
            ItemHelper.TranslateTooltip(tooltips, "Tooltip0", _ =>
            {
                tooltips.ReplaceText("You have done very well thus far.\nMay your tenacity guide you through the remaining challenges.", "Благодаря своим способностям ты достиг больших успехов\nТак пусть же твоё упорство преодолеет все остающиеся трудности");
            });
        }
        else if (item.type == ModContent.ItemType<OldDukeRelic>())
        {
            ItemHelper.TranslateTooltip(tooltips, "Tooltip0", _ =>
            {
                tooltips.ReplaceText("Difficult as the fight may be, you were wise to endure and overcome the challenge it brings.\nYou will find that the mechanics it tested will be relevant again soon.", "Какой бы трудной ни была битва, тобой была показана мудрость, с помощью которой ты выдержал и преодолел брошенный вызов\nСкоро узнаешь, что механика, которую он использовал, будет вновь актуальна");
            });
        }
        else if (item.type == ModContent.ItemType<PlanteraRelic>())
        {
            ItemHelper.TranslateTooltip(tooltips, "Tooltip0", _ =>
            {
                tooltips.ReplaceText("Be proud of your death count!\nThe more you die, the more you're learning. Keep going!", "Количество смертей - не повод унывать, гордись ими!\nПадение - мать учения. Ты растёшь над собой. Давай, продолжай в том же духе!");
            });
        }
        else if (item.type == ModContent.ItemType<SkeletronRelic>())
        {
            ItemHelper.TranslateTooltip(tooltips, "Tooltip0", _ =>
            {
                tooltips.ReplaceText("The first major roadblock. You are better now than before you faced it. Did you have fun learning its patterns?", "Вот и первое серьёзное препятствие. Сейчас ты уже более опытен, чем был до битвы с ним. Надеюсь, весело было учить паттерны?");
            });
        }
        else if (item.type == ModContent.ItemType<DevourerOfGodsRelic>())
        {
            ItemHelper.TranslateTooltip(tooltips, "Tooltip0", _ =>
            {
                tooltips.ReplaceText("Sometimes pure reaction skill is the most valuable thing to cultivate.\nYou are in the final stretch. Your determination has proven invaluable up to this point.\nMay it guide you through the last challenges.", "Иногда умение быстро реагировать - это самое ценное, что стоит развивать в себе\nСейчас ты находишься на финальном этапе. До сего момента твоя решимость была бесценной\nПусть же она поможет тебе преодолеть последние испытания");
            });
        }
        else if (item.type == ModContent.ItemType<Wayfinder>())
        {
            ItemHelper.TranslateTooltip(tooltips, "Tooltip2", tooltip =>
            {
                tooltip.Text = $"Удерживайте ЛКМ, чтобы телепортироваться к вратам\nУдерживайте ЛКМ и {KeybindSystem.WayfinderCreateKey.TooltipHotkeyString()}, чтобы установить врата в вашей позиции\nУдерживайте ЛКМ и {KeybindSystem.WayfinderDestroyKey.TooltipHotkeyString()}, чтобы убрать врата";
            });
        }
        else if (item.type == ModContent.ItemType<SandstormsCore>())
        {
            ItemHelper.TranslateTooltip(tooltips, "Tooltip0", _ =>
            {
                tooltips.ReplaceText("Opens a portal to the Lost Colosseum", "Открывает портал к Затерянному Колизею");
                tooltips.ReplaceText("Your world does not currently have a Lost Gateway. Kill the Lunatic Cultist again to generate it.", "На данный момент в вашем мире отсутствуют затерянные врата\nПовторно убейте Культиста-лунатика, чтобы сгенерировать их");
            });
        }
        else if (item.type == ModContent.ItemType<DecapoditaSprout>())
        {
            ItemHelper.TranslateTooltip(tooltips, "Tooltip1", tooltip =>
            {
                tooltip.Text = "Входит в ярость за пределами грибных пустошей";
            });
        }
        else if (item.type == ItemID.WormFood)
        {
            ItemHelper.TranslateTooltip(tooltips, "Tooltip0", _ =>
            {
                tooltips.ReplaceText(" подземного " , " ");
            });
        }
        else if (item.type == ItemID.BloodySpine)
        {
            ItemHelper.TranslateTooltip(tooltips, "Tooltip0", _ =>
            {
                tooltips.ReplaceText(" подземного ", " ");
            });
        }
        else if (item.type == ModContent.ItemType<Teratoma>())
        {
            ItemHelper.TranslateTooltip(tooltips, "Tooltip1", tooltip =>
            {
                tooltip.Text = "Входит в ярость за пределами искажения";
            });
        }
        else if (item.type == ModContent.ItemType<BloodyWormFood>())
        {
            ItemHelper.TranslateTooltip(tooltips, "Tooltip1", tooltip =>
            {
                tooltip.Text = "Входит в ярость за пределами багрянца";
            });
        }
        else if (item.type == ModContent.ItemType<Seafood>())
        {
            ItemHelper.TranslateTooltip(tooltips, "Tooltip1", tooltip =>
            {
                tooltip.Text = "Входит в ярость за пределами вод сернистого моря";
            });
        }
        else if (item.type == ModContent.ItemType<Abombination>())
        {
            ItemHelper.TranslateTooltip(tooltips, "Tooltip1", tooltip =>
            {
                tooltip.Text = "Входит в ярость за пределами подземных джунглей";
            });
        }
        else if (item.type == ModContent.ItemType<NecroplasmicBeacon>())
        {
            ItemHelper.TranslateTooltip(tooltips, "Tooltip1", tooltip =>
            {
                tooltip.Text = "Входит в ярость за пределами подземелья\nНе расходуется";
            });
        }
        else if (item.type == ModContent.ItemType<EyeofDesolation>())
        {
            ItemHelper.TranslateTooltip(tooltips, "Tooltip1", _ =>
            {
                tooltips.ReplaceText("Summons the Forgotten Shadow of Calamitas when used during nighttime", "Призывает Забытую тень Каламитас при использовании ночью");
            });
        }
        else if (item.type == ModContent.ItemType<RuneofKos>())
        {
            ItemHelper.TranslateTooltip(tooltips, l => l.Mod == "InfernumMode" && l.Name == "CVWarning", tooltip =>
            {
                tooltip.Text = "Нескончаемую пустоту можно сразить только в Архивах";
            });
        }

        ItemHelper.TranslateTooltip(tooltips, l => l.Mod == "InfernumMode" && l.Name == "Developer", tooltip =>
        {
            Color devColor = CalamityUtils.ColorSwap(Color.OrangeRed, Color.DarkRed, 2);
            tooltip.Text = "~ Предмет разработчика ~";
            tooltip.OverrideColor = devColor;
        });
    }
}
