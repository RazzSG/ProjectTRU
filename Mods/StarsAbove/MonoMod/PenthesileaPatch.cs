﻿// using System.Reflection;
// using CalamityRuTranslate.Common;
// using CalamityRuTranslate.Common.Utilities;
// using CalamityRuTranslate.Core.MonoMod;
// using MonoMod.Cil;
// using StarsAbove;
// using StarsAbove.NPCs;
//
// namespace CalamityRuTranslate.Mods.TheStarsAbove.MonoMod;
//
// public class PenthesileaPatch : ILPatcher
// {
//     public override bool AutoLoad => ModsCall.StarsAbove != null && TranslationHelper.IsRussianLanguage;
//
//     public override MethodInfo ModifiedMethod => typeof(Penthesilea).GetCachedMethod(nameof(Penthesilea.AI));
//
//     public override ILContext.Manipulator PatchMethod { get; } = il =>
//     {
//         TranslationHelper.ModifyIL(il, typeof(StarsAboveAudio).GetField(nameof(StarsAboveAudio.Penthesilea_AlrightMyTurn)), typeof(StarsAboveSounds).GetField(nameof(StarsAboveSounds.Penthesilea_AlrightMyTurn)));
//         TranslationHelper.ModifyIL(il, typeof(StarsAboveAudio).GetField(nameof(StarsAboveAudio.Penthesilea_CutThrough)), typeof(StarsAboveSounds).GetField(nameof(StarsAboveSounds.Penthesilea_CutThrough)));
//         TranslationHelper.ModifyIL(il, typeof(StarsAboveAudio).GetField(nameof(StarsAboveAudio.Penthesilea_Enough)), typeof(StarsAboveSounds).GetField(nameof(StarsAboveSounds.Penthesilea_Enough)));
//         TranslationHelper.ModifyIL(il, typeof(StarsAboveAudio).GetField(nameof(StarsAboveAudio.Penthesilea_HowFoolish)), typeof(StarsAboveSounds).GetField(nameof(StarsAboveSounds.Penthesilea_HowFoolish)));
//         TranslationHelper.ModifyIL(il, typeof(StarsAboveAudio).GetField(nameof(StarsAboveAudio.Penthesilea_HowFun)), typeof(StarsAboveSounds).GetField(nameof(StarsAboveSounds.Penthesilea_HowFun)));
//         TranslationHelper.ModifyIL(il, typeof(StarsAboveAudio).GetField(nameof(StarsAboveAudio.Penthesilea_ISenseTheirResolve)), typeof(StarsAboveSounds).GetField(nameof(StarsAboveSounds.Penthesilea_ISenseTheirResolve)));
//         TranslationHelper.ModifyIL(il, typeof(StarsAboveAudio).GetField(nameof(StarsAboveAudio.Penthesilea_IveEnduredFarWorse)), typeof(StarsAboveSounds).GetField(nameof(StarsAboveSounds.Penthesilea_IveEnduredFarWorse)));
//         TranslationHelper.ModifyIL(il, typeof(StarsAboveAudio).GetField(nameof(StarsAboveAudio.Penthesilea_OutOfMyWay)), typeof(StarsAboveSounds).GetField(nameof(StarsAboveSounds.Penthesilea_OutOfMyWay)));
//         TranslationHelper.ModifyIL(il, typeof(StarsAboveAudio).GetField(nameof(StarsAboveAudio.Penthesilea_PenthLaugh)), typeof(StarsAboveSounds).GetField(nameof(StarsAboveSounds.Penthesilea_PenthLaugh)));
//         TranslationHelper.ModifyIL(il, typeof(StarsAboveAudio).GetField(nameof(StarsAboveAudio.Penthesilea_QuickQuick)), typeof(StarsAboveSounds).GetField(nameof(StarsAboveSounds.Penthesilea_QuickQuick)));
//         TranslationHelper.ModifyIL(il, typeof(StarsAboveAudio).GetField(nameof(StarsAboveAudio.Penthesilea_ThisllCheerMeUp)), typeof(StarsAboveSounds).GetField(nameof(StarsAboveSounds.Penthesilea_ThisllCheerMeUp)));
//         TranslationHelper.ModifyIL(il, typeof(StarsAboveAudio).GetField(nameof(StarsAboveAudio.Penthesilea_ToPieces)), typeof(StarsAboveSounds).GetField(nameof(StarsAboveSounds.Penthesilea_ToPieces)));
//         TranslationHelper.ModifyIL(il, typeof(StarsAboveAudio).GetField(nameof(StarsAboveAudio.Penthesilea_ToShreds)), typeof(StarsAboveSounds).GetField(nameof(StarsAboveSounds.Penthesilea_ToShreds)));
//         TranslationHelper.ModifyIL(il, typeof(StarsAboveAudio).GetField(nameof(StarsAboveAudio.Penthesilea_TryAgainIDareYou)), typeof(StarsAboveSounds).GetField(nameof(StarsAboveSounds.Penthesilea_TryAgainIDareYou)));
//         TranslationHelper.ModifyIL(il, typeof(StarsAboveAudio).GetField(nameof(StarsAboveAudio.Penthesilea_WithHaste)), typeof(StarsAboveSounds).GetField(nameof(StarsAboveSounds.Penthesilea_WithHaste)));
//         TranslationHelper.ModifyIL(il, typeof(StarsAboveAudio).GetField(nameof(StarsAboveAudio.Penthesilea_WhateverItTakes)), typeof(StarsAboveSounds).GetField(nameof(StarsAboveSounds.Penthesilea_WhateverItTakes)));
//         // TranslationHelper.ModifyIL(il, "You fall to the Witch of Ink...", "Вы пали перед Ведьмой чернил...");
//         // TranslationHelper.ModifyIL(il, "You've been colored with ink!", "Вас раскрасили чернилами!");
//         // TranslationHelper.ModifyIL(il, "The Garden of Avalon stifles your healing!", "Сад Авалона подавляет ваше исцеление!");
//         // TranslationHelper.ModifyIL(il, "Penth is protected by a shield of frost!", "Пентесилея защищена щитом мороза!");
//         // TranslationHelper.ModifyIL(il, "Overwhelming power surrounds you...", "Вокруг вас кипит сила...");
//         // TranslationHelper.ModifyIL(il, "You feel the next attack is truly unsurvivable!", "Вы чуствуете, следующую атаку невозможно пережить!");
//         // TranslationHelper.ModifyIL(il, "Concentrativity", "Концентративность");
//         // TranslationHelper.ModifyIL(il, "Heavensfall", "Небесный водопад");
//         // TranslationHelper.ModifyIL(il, "Heavensfall", "Небесный водопад", 2);
//         // TranslationHelper.ModifyIL(il, "Heavensfall", "Небесный водопад", 3);
//         // TranslationHelper.ModifyIL(il, "Rend Heaven", "Разрыв небес");
//         // TranslationHelper.ModifyIL(il, "Rend Heaven", "Разрыв небес", 2);
//         // TranslationHelper.ModifyIL(il, "Rend Heaven", "Разрыв небес", 3);
//         // TranslationHelper.ModifyIL(il, "Rend Heaven", "Разрыв небес", 4);
//         // TranslationHelper.ModifyIL(il, "Rend Heaven", "Разрыв небес", 5);
//         // TranslationHelper.ModifyIL(il, "Rend Heaven", "Разрыв небес", 6);
//         // TranslationHelper.ModifyIL(il, "A World Rent Asunder", "Разорванный мир");
//         // TranslationHelper.ModifyIL(il, "Surpassing Infinity", "За пределами бесконечности");
//         // TranslationHelper.ModifyIL(il, "Ascendance", "Вознесение");
//         // TranslationHelper.ModifyIL(il, "Ascendance", "Вознесение", 2);
//         // TranslationHelper.ModifyIL(il, "The Flood Of Light", "Поток Света");
//         // TranslationHelper.ModifyIL(il, "Coruscant Saber", "Корусантская сабля");
//         // TranslationHelper.ModifyIL(il, "Coruscant Saber II", "Корусантская сабля II");
//         // TranslationHelper.ModifyIL(il, "Coruscant Saber II", "Корусантская сабля II", 2);
//         // TranslationHelper.ModifyIL(il, "Coruscant Saber II", "Корусантская сабля II", 3);
//         // TranslationHelper.ModifyIL(il, "Blotted Whims", "Запятнанная блажь");
//         // TranslationHelper.ModifyIL(il, "Blotted Whims", "Запятнанная блажь", 2);
//         // TranslationHelper.ModifyIL(il, "Blotted Whims", "Запятнанная блажь", 3);
//         // TranslationHelper.ModifyIL(il, "Blotted Whims", "Запятнанная блажь", 4);
//         // TranslationHelper.ModifyIL(il, "Blotted Whims", "Запятнанная блажь", 5);
//         // TranslationHelper.ModifyIL(il, "Blotted Whims", "Запятнанная блажь", 6);
//         // TranslationHelper.ModifyIL(il, "Blotted Whims", "Запятнанная блажь", 7);
//         // TranslationHelper.ModifyIL(il, "Blotted Whims", "Запятнанная блажь", 8);
//         // TranslationHelper.ModifyIL(il, "Blotted Whims", "Запятнанная блажь", 9);
//         // TranslationHelper.ModifyIL(il, "Sanctified Slaughter", "Освящённая резня");
//         // TranslationHelper.ModifyIL(il, "Perfect Strokes", "Идеальные штрихи");
//         // TranslationHelper.ModifyIL(il, "Perfect Strokes", "Идеальные штрихи", 2);
//         // TranslationHelper.ModifyIL(il, "Perfect Strokes", "Идеальные штрихи", 3);
//         // TranslationHelper.ModifyIL(il, "Perfect Strokes", "Идеальные штрихи", 4);
//         // TranslationHelper.ModifyIL(il, "Perfect Strokes", "Идеальные штрихи", 5);
//         // TranslationHelper.ModifyIL(il, "Sanctified Slaughter II", "Освящённая резня II");
//         // TranslationHelper.ModifyIL(il, "Sanctified Slaughter II", "Освящённая резня II", 2);
//         // TranslationHelper.ModifyIL(il, "Thousand Strikes", "Тысяча ударов");
//         // TranslationHelper.ModifyIL(il, "Thousand Strikes", "Тысяча ударов", 2);
//         // TranslationHelper.ModifyIL(il, "Thousand Strikes", "Тысяча ударов", 3);
//         // TranslationHelper.ModifyIL(il, "Thousand Strikes ", "Тысяча ударов ");
//         // TranslationHelper.ModifyIL(il, "Thousand Strikes ", "Тысяча ударов ", 2);
//         // TranslationHelper.ModifyIL(il, "Thousand Strikes ", "Тысяча ударов ", 3);
//         // TranslationHelper.ModifyIL(il, "Blazing Skies II", "Пылающее небо II");
//         // TranslationHelper.ModifyIL(il, "Blazing Skies II", "Пылающее небо II", 2);
//         // TranslationHelper.ModifyIL(il, "Blazing Skies II", "Пылающее небо II", 3);
//         // TranslationHelper.ModifyIL(il, "The Bitter End", "Горький конец");
//         // TranslationHelper.ModifyIL(il, "Synaptic Static", "Синаптическая статика");
//         // TranslationHelper.ModifyIL(il, "Synaptic Static", "Синаптическая статика", 2);
//         // TranslationHelper.ModifyIL(il, "Synaptic Static", "Синаптическая статика", 3);
//         // TranslationHelper.ModifyIL(il, "Absolute Fire III", "Абсолютный огонь III");
//         // TranslationHelper.ModifyIL(il, "Absolute Blizzard III", "Абсолютная метель III");
//         // TranslationHelper.ModifyIL(il, "Absolute Blizzard III", "Абсолютная метель III", 2);
//         // TranslationHelper.ModifyIL(il, "Absolute Blizzard III", "Абсолютная метель III", 3);
//         // TranslationHelper.ModifyIL(il, "Terror Unleashed", "Освобождённый ужас");
//         // TranslationHelper.ModifyIL(il, "A Dash of Chaos", "Рывок хаоса");
//         // TranslationHelper.ModifyIL(il, "A Dash of Chaos", "Рывок хаоса", 2);
//         // TranslationHelper.ModifyIL(il, "A Dash of Chaos", "Рывок хаоса", 3);
//         // TranslationHelper.ModifyIL(il, "A Dash of Chaos", "Рывок хаоса", 4);
//         // TranslationHelper.ModifyIL(il, "A Dash of Chaos", "Рывок хаоса", 5);
//         // TranslationHelper.ModifyIL(il, "A Dash of Chaos", "Рывок хаоса", 6);
//         // TranslationHelper.ModifyIL(il, "A Dash of Chaos", "Рывок хаоса", 7);
//         // TranslationHelper.ModifyIL(il, "A Dash of Chaos", "Рывок хаоса", 8);
//         // TranslationHelper.ModifyIL(il, "A Dash of Chaos", "Рывок хаоса", 9);
//         // TranslationHelper.ModifyIL(il, "A Dash of Chaos", "Рывок хаоса", 10);
//         // TranslationHelper.ModifyIL(il, "Ink Over", "Вездесущие чернила");
//         // TranslationHelper.ModifyIL(il, "Ink Over", "Вездесущие чернила", 2);
//         // TranslationHelper.ModifyIL(il, "Ink Over", "Вездесущие чернила", 3);
//         // TranslationHelper.ModifyIL(il, "Ink Over", "Вездесущие чернила", 4);
//         // TranslationHelper.ModifyIL(il, "Ink Over", "Вездесущие чернила", 5);
//         // TranslationHelper.ModifyIL(il, "Ink Over", "Вездесущие чернила", 6);
//         // TranslationHelper.ModifyIL(il, "Ink Over", "Вездесущие чернила", 7);
//         // TranslationHelper.ModifyIL(il, "Ink Over", "Вездесущие чернила", 8);
//         // TranslationHelper.ModifyIL(il, "Ink Over", "Вездесущие чернила", 9);
//         // TranslationHelper.ModifyIL(il, "Ink Over", "Вездесущие чернила", 10);
//         // TranslationHelper.ModifyIL(il, "Ink Over", "Вездесущие чернила", 11);
//         // TranslationHelper.ModifyIL(il, "Ink Over", "Вездесущие чернила", 12);
//         // TranslationHelper.ModifyIL(il, "Ink Over", "Вездесущие чернила", 13);
//         // TranslationHelper.ModifyIL(il, "Ink Over", "Вездесущие чернила", 14);
//         // TranslationHelper.ModifyIL(il, "The Garden of Avalon", "Сад Авалона");
//         // TranslationHelper.ModifyIL(il, "The Garden of Avalon", "Сад Авалона", 2);
//         // TranslationHelper.ModifyIL(il, "The Garden of Avalon", "Сад Авалона", 3);
//         // TranslationHelper.ModifyIL(il, "Gravitational Anomaly", "Гравитационная аномалия");
//         // TranslationHelper.ModifyIL(il, "Gravitational Anomaly", "Гравитационная аномалия", 2);
//         // TranslationHelper.ModifyIL(il, "Gravitational Anomaly", "Гравитационная аномалия", 3);
//         // TranslationHelper.ModifyIL(il, "Ars Laevateinn", "Арс Леватейн");
//         // TranslationHelper.ModifyIL(il, "Painted Attendants", "Нарисованные слуги");
//         // TranslationHelper.ModifyIL(il, "Painted Attendants", "Нарисованные слуги", 2);
//         // TranslationHelper.ModifyIL(il, "Painted Attendants", "Нарисованные слуги", 3);
//         // TranslationHelper.ModifyIL(il, "Painted Attendants", "Нарисованные слуги", 4);
//         // TranslationHelper.ModifyIL(il, "Painted Attendants", "Нарисованные слуги", 5);
//         // TranslationHelper.ModifyIL(il, "Painted Attendants", "Нарисованные слуги", 6);
//         // TranslationHelper.ModifyIL(il, "Painted Attendants", "Нарисованные слуги", 7);
//         // TranslationHelper.ModifyIL(il, "Aegis of Frost", "Эгида мороза");
//         // TranslationHelper.ModifyIL(il, "Aegis of Frost", "Эгида мороза", 2);
//         // TranslationHelper.ModifyIL(il, "Aegis of Frost", "Эгида мороза", 3);
//         // TranslationHelper.ModifyIL(il, "Absolute Thunder IV", "Абсолютная гроза IV");
//         // TranslationHelper.ModifyIL(il, "Quintuplecast", "Пятикратное заклинание");
//         // TranslationHelper.ModifyIL(il, "Absolute Holy", "Абсолютная святость");
//         // TranslationHelper.ModifyIL(il, "Crack The Sky", "Расколоть небо");
//         // TranslationHelper.ModifyIL(il, "Crack The Sky", "Расколоть небо", 2);
//         // TranslationHelper.ModifyIL(il, "Crack The Sky", "Расколоть небо", 3);
//         // TranslationHelper.ModifyIL(il, "Linear Mystics", "Линейные мистики");
//         // TranslationHelper.ModifyIL(il, "Linear Mystics", "Линейные мистики", 2);
//         // TranslationHelper.ModifyIL(il, "Linear Mystics", "Линейные мистики", 3);
//         // TranslationHelper.ModifyIL(il, "Linear Mystics", "Линейные мистики", 4);
//         // TranslationHelper.ModifyIL(il, "Linear Mystics", "Линейные мистики", 5);
//         // TranslationHelper.ModifyIL(il, "Linear Mystics", "Линейные мистики", 6);
//         // TranslationHelper.ModifyIL(il, "Linear Mystics", "Линейные мистики", 7);
//         // TranslationHelper.ModifyIL(il, "Linear Mystics", "Линейные мистики", 8);
//         // TranslationHelper.ModifyIL(il, "Linear Mystics", "Линейные мистики", 9);
//         // TranslationHelper.ModifyIL(il, "Linear Mystics", "Линейные мистики", 10);
//         // TranslationHelper.ModifyIL(il, "Linear Mystics", "Линейные мистики", 11);
//         // TranslationHelper.ModifyIL(il, "Splattered Sundering", "Забрызганная скованность");
//         // TranslationHelper.ModifyIL(il, "Splattered Sundering", "Забрызганная скованность", 2);
//         // TranslationHelper.ModifyIL(il, "Splattered Sundering", "Забрызганная скованность", 3);
//         // TranslationHelper.ModifyIL(il, "Splattered Sundering", "Забрызганная скованность", 4);
//         // TranslationHelper.ModifyIL(il, "Splattered Sundering", "Забрызганная скованность", 5);
//         // TranslationHelper.ModifyIL(il, "Splattered Sundering", "Забрызганная скованность", 6);
//         // TranslationHelper.ModifyIL(il, "Splattered Sundering", "Забрызганная скованность", 7);
//         // TranslationHelper.ModifyIL(il, "Splattered Sundering", "Забрызганная скованность", 8);
//         // TranslationHelper.ModifyIL(il, "Splattered Sundering", "Забрызганная скованность", 9);
//         // TranslationHelper.ModifyIL(il, "Splattered Sundering", "Забрызганная скованность", 10);
//         // TranslationHelper.ModifyIL(il, "Splattered Sundering", "Забрызганная скованность", 11);
//         // TranslationHelper.ModifyIL(il, "Splattered Sundering", "Забрызганная скованность", 12);
//         // TranslationHelper.ModifyIL(il, "Splattered Sundering", "Забрызганная скованность", 13);
//         // TranslationHelper.ModifyIL(il, "Splattered Sundering", "Забрызганная скованность", 14);
//         // TranslationHelper.ModifyIL(il, "Splattered Sundering", "Забрызганная скованность", 15);
//         // TranslationHelper.ModifyIL(il, "Splattered Sundering", "Забрызганная скованность", 16);
//         // TranslationHelper.ModifyIL(il, "Splattered Sundering", "Забрызганная скованность", 17);
//         // TranslationHelper.ModifyIL(il, "Splattered Sundering", "Забрызганная скованность", 18);
//         // TranslationHelper.ModifyIL(il, "Splattered Sundering", "Забрызганная скованность", 19);
//         // TranslationHelper.ModifyIL(il, "Splattered Sundering", "Забрызганная скованность", 20);
//         // TranslationHelper.ModifyIL(il, "SOUL Extraction", "Извлечение ДУШИ");
//         // TranslationHelper.ModifyIL(il, "Light Rampant", "Раздолье света");
//         // TranslationHelper.ModifyIL(il, "Radiant Braver", "Сияющий храбрец");
//         // TranslationHelper.ModifyIL(il, "Meteor Shower", "Метеоритный дождь");
//         // TranslationHelper.ModifyIL(il, "Meteor Shower", "Метеоритный дождь", 2);
//         // TranslationHelper.ModifyIL(il, "Meteor Shower", "Метеоритный дождь", 3);
//         // TranslationHelper.ModifyIL(il, "Quasar Forthcoming", "Пришествие квазара");
//         // TranslationHelper.ModifyIL(il, "Quasar Forthcoming", "Пришествие квазара", 2);
//         // TranslationHelper.ModifyIL(il, "Quasar Forthcoming", "Пришествие квазара", 3);
//         // TranslationHelper.ModifyIL(il, "Spilled Violet", "Пролитый пурпур");
//         // TranslationHelper.ModifyIL(il, "Spilled Violet", "Пролитый пурпур", 2);
//         // TranslationHelper.ModifyIL(il, "Spilled Violet", "Пролитый пурпур", 3);
//         // TranslationHelper.ModifyIL(il, "Spilled Violet", "Пролитый пурпур", 4);
//         // TranslationHelper.ModifyIL(il, "Spilled Violet", "Пролитый пурпур", 5);
//         // TranslationHelper.ModifyIL(il, "Spilled Violet", "Пролитый пурпур", 6);
//         // TranslationHelper.ModifyIL(il, "Spilled Violet", "Пролитый пурпур", 7);
//         // TranslationHelper.ModifyIL(il, "Spilled Violet", "Пролитый пурпур", 8);
//         // TranslationHelper.ModifyIL(il, "Spilled Violet", "Пролитый пурпур", 9);
//         // TranslationHelper.ModifyIL(il, "Plutonic Barrage", "Плутониевый шквал");
//         // TranslationHelper.ModifyIL(il, "Theofania Inanis", "Теофаниа Инанис");
//         // TranslationHelper.ModifyIL(il, "Theofania Inanis", "Теофаниа Инанис", 2);
//         // TranslationHelper.ModifyIL(il, "Spatial Rip", "Пространственный разрыв");
//         // TranslationHelper.ModifyIL(il, "Spatial Rip", "Пространственный разрыв", 2);
//         // TranslationHelper.ModifyIL(il, "Spatial Rip", "Пространственный разрыв", 3);
//         // TranslationHelper.ModifyIL(il, "Transplacement", "Перенос");
//         // TranslationHelper.ModifyIL(il, "Transplacement", "Перенос", 2);
//         // TranslationHelper.ModifyIL(il, "Transplacement", "Перенос", 3);
//         // TranslationHelper.ModifyIL(il, "Recall", "Возврат");
//         // TranslationHelper.ModifyIL(il, "Recall", "Возврат", 2);
//         // TranslationHelper.ModifyIL(il, "Recall", "Возврат", 3);
//         // TranslationHelper.ModifyIL(il, "Relinquish", "Отказ");
//         // TranslationHelper.ModifyIL(il, "Relinquish", "Отказ", 2);
//         // TranslationHelper.ModifyIL(il, "Relinquish", "Отказ", 3);
//         // TranslationHelper.ModifyIL(il, "Nebula Channeling", "Канал туманности");
//         // TranslationHelper.ModifyIL(il, "Nebula Channeling", "Канал туманности", 2);
//         // TranslationHelper.ModifyIL(il, "Vorpal Channeling", "Вихревой канал");
//         // TranslationHelper.ModifyIL(il, "Vorpal Channeling", "Вихревой канал", 2);
//         // TranslationHelper.ModifyIL(il, "Solar Channeling", "Солнечный канал");
//         // TranslationHelper.ModifyIL(il, "Solar Channeling", "Солнечный канал", 2);
//         // TranslationHelper.ModifyIL(il, "Starlit Channeling", "Звёздный канал");
//         // TranslationHelper.ModifyIL(il, "Starlit Channeling", "Звёздный канал", 2);
//         // TranslationHelper.ModifyIL(il, "Galactic Swarm", "Галактический рой");
//         // TranslationHelper.ModifyIL(il, "Galactic Swarm", "Галактический рой", 2);
//         // TranslationHelper.ModifyIL(il, "Galactic Swarm", "Галактический рой", 3);
//         // TranslationHelper.ModifyIL(il, "Magnum Opus", "Магнум Опус");
//         // TranslationHelper.ModifyIL(il, "Magnum Opus", "Магнум Опус", 2);
//         // TranslationHelper.ModifyIL(il, "Magnum Opus", "Магнум Опус", 3);
//         // TranslationHelper.ModifyIL(il, "Magnum Opus", "Магнум Опус", 4);
//     };
// }