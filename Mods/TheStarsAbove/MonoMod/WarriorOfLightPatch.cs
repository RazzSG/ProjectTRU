﻿// using System.Reflection;
// using CalamityRuTranslate.Common;
// using CalamityRuTranslate.Common.Utilities;
// using CalamityRuTranslate.Core.MonoMod;
// using MonoMod.Cil;
// using StarsAbove.NPCs;
// using Terraria.ModLoader;
//
// namespace CalamityRuTranslate.Mods.TheStarsAbove.MonoMod;
//
// [JITWhenModsEnabled("StarsAbove")]
// public class WarriorOfLightPatch : Patch<ILContext.Manipulator>
// {
//     public override bool AutoLoad => ModsCall.StarsAbove != null && TranslationHelper.IsRussianLanguage;
//
//     public override MethodInfo ModifiedMethod => typeof(WarriorOfLight).GetCachedMethod(nameof(WarriorOfLight.AI));
//
//     protected override ILContext.Manipulator PatchMethod { get; } = il =>
//     {
//         TranslationHelper.ModifyIL(il, "The Warrior Of Light has won...", "Воин Света побеждает...");
//         TranslationHelper.ModifyIL(il, "The Warrior of Light is transcending his limits!", "Воин Света выходит за свои лимиты!");
//         TranslationHelper.ModifyIL(il, "The fabric of this world begins to fray!", "Ткань этого мира не выдерживает!");
//         TranslationHelper.ModifyIL(il, "Your final days have arrived...", "Ваши дни сочтены...");
//         TranslationHelper.ModifyIL(il, "Concentrativity", "Концентративность");
//         TranslationHelper.ModifyIL(il, "Concentrativity", "Концентративность", 2);
//         TranslationHelper.ModifyIL(il, "Concentrativity", "Концентративность", 3);
//         TranslationHelper.ModifyIL(il, "A World Rent Asunder", "Разорванный мир");
//         TranslationHelper.ModifyIL(il, "A World Rent Asunder", "Разорванный мир", 2);
//         TranslationHelper.ModifyIL(il, "A World Rent Asunder", "Разорванный мир", 3);
//         TranslationHelper.ModifyIL(il, "Surpassing Infinity", "За пределами бесконечности");
//         TranslationHelper.ModifyIL(il, "Surpassing Infinity", "За пределами бесконечности", 2);
//         TranslationHelper.ModifyIL(il, "Surpassing Infinity", "За пределами бесконечности", 3);
//         TranslationHelper.ModifyIL(il, "Ascendance", "Вознесение");
//         TranslationHelper.ModifyIL(il, "Ascendance", "Вознесение", 2);
//         TranslationHelper.ModifyIL(il, "Ascendance", "Вознесение", 3);
//         TranslationHelper.ModifyIL(il, "The Flood Of Light", "Поток света");
//         TranslationHelper.ModifyIL(il, "The Flood Of Light", "Поток света", 2);
//         TranslationHelper.ModifyIL(il, "Coruscant Saber", "Корусантская сабля");
//         TranslationHelper.ModifyIL(il, "Coruscant Saber", "Корусантская сабля", 2);
//         TranslationHelper.ModifyIL(il, "Coruscant Saber", "Корусантская сабля", 3);
//         TranslationHelper.ModifyIL(il, "Coruscant Saber", "Корусантская сабля", 4);
//         TranslationHelper.ModifyIL(il, "Coruscant Saber II", "Корусантская сабля II");
//         TranslationHelper.ModifyIL(il, "Coruscant Saber II", "Корусантская сабля II", 2);
//         TranslationHelper.ModifyIL(il, "Coruscant Saber II", "Корусантская сабля II", 3);
//         TranslationHelper.ModifyIL(il, "Coruscant Saber II", "Корусантская сабля II", 4);
//         TranslationHelper.ModifyIL(il, "Coruscant Saber II", "Корусантская сабля II", 5);
//         TranslationHelper.ModifyIL(il, "Coruscant Saber II", "Корусантская сабля II", 6);
//         TranslationHelper.ModifyIL(il, "Coruscant Saber II", "Корусантская сабля II", 7);
//         TranslationHelper.ModifyIL(il, "Coruscant Saber II", "Корусантская сабля II", 8);
//         TranslationHelper.ModifyIL(il, "Coruscant Saber II", "Корусантская сабля II", 9);
//         TranslationHelper.ModifyIL(il, "Coruscant Saber II", "Корусантская сабля II", 10);
//         TranslationHelper.ModifyIL(il, "Coruscant Saber II", "Корусантская сабля II", 11);
//         TranslationHelper.ModifyIL(il, "Coruscant Saber II", "Корусантская сабля II", 12);
//         TranslationHelper.ModifyIL(il, "Coruscant Saber II", "Корусантская сабля II", 13);
//         TranslationHelper.ModifyIL(il, "Coruscant Saber II", "Корусантская сабля II", 14);
//         TranslationHelper.ModifyIL(il, "Coruscant Saber II", "Корусантская сабля II", 15);
//         TranslationHelper.ModifyIL(il, "Sinpurge", "Очищение грехов");
//         TranslationHelper.ModifyIL(il, "Sinpurge", "Очищение грехов", 2);
//         TranslationHelper.ModifyIL(il, "Sinpurge", "Очищение грехов", 3);
//         TranslationHelper.ModifyIL(il, "Sinpurge", "Очищение грехов", 4);
//         TranslationHelper.ModifyIL(il, "Sinpurge", "Очищение грехов", 5);
//         TranslationHelper.ModifyIL(il, "Sinpurge II", "Очищение грехов II");
//         TranslationHelper.ModifyIL(il, "Sinpurge II", "Очищение грехов II", 2);
//         TranslationHelper.ModifyIL(il, "Sinpurge II", "Очищение грехов II", 3);
//         TranslationHelper.ModifyIL(il, "Sinpurge II", "Очищение грехов II", 4);
//         TranslationHelper.ModifyIL(il, "Sinpurge II", "Очищение грехов II", 5);
//         TranslationHelper.ModifyIL(il, "Sinpurge II", "Очищение грехов II", 6);
//         TranslationHelper.ModifyIL(il, "Sinpurge II", "Очищение грехов II", 7);
//         TranslationHelper.ModifyIL(il, "Blazing Skies", "Пылающее небо");
//         TranslationHelper.ModifyIL(il, "Blazing Skies", "Пылающее небо", 2);
//         TranslationHelper.ModifyIL(il, "Blazing Skies", "Пылающее небо", 3);
//         TranslationHelper.ModifyIL(il, "Blazing Skies", "Пылающее небо", 4);
//         TranslationHelper.ModifyIL(il, "Absolute Titanomachy", "Абсолютная титаномахия");
//         TranslationHelper.ModifyIL(il, "Absolute Titanomachy", "Абсолютная титаномахия", 2);
//         TranslationHelper.ModifyIL(il, "Absolute Titanomachy", "Абсолютная титаномахия", 3);
//         TranslationHelper.ModifyIL(il, "Absolute Titanomachy", "Абсолютная титаномахия", 4);
//         TranslationHelper.ModifyIL(il, "Absolute Titanomachy", "Абсолютная титаномахия", 5);
//         TranslationHelper.ModifyIL(il, "Absolute Titanomachy", "Абсолютная титаномахия", 6);
//         TranslationHelper.ModifyIL(il, "Blazing Skies II", "Пылающее небо II");
//         TranslationHelper.ModifyIL(il, "Blazing Skies II", "Пылающее небо II", 2);
//         TranslationHelper.ModifyIL(il, "Blazing Skies II", "Пылающее небо II", 3);
//         TranslationHelper.ModifyIL(il, "Blazing Skies II", "Пылающее небо II", 4);
//         TranslationHelper.ModifyIL(il, "Blazing Skies II", "Пылающее небо II", 5);
//         TranslationHelper.ModifyIL(il, "Blazing Skies II", "Пылающее небо II", 6);
//         TranslationHelper.ModifyIL(il, "Blazing Skies II", "Пылающее небо II", 7);
//         TranslationHelper.ModifyIL(il, "Blazing Skies II", "Пылающее небо II", 8);
//         TranslationHelper.ModifyIL(il, "The Bitter End", "Горький конец");
//         TranslationHelper.ModifyIL(il, "The Bitter End", "Горький конец", 2);
//         TranslationHelper.ModifyIL(il, "The Bitter End", "Горький конец", 3);
//         TranslationHelper.ModifyIL(il, "The Bitter End", "Горький конец", 4);
//         TranslationHelper.ModifyIL(il, "The Bitter End", "Горький конец", 5);
//         TranslationHelper.ModifyIL(il, "The Bitter End", "Горький конец", 6);
//         TranslationHelper.ModifyIL(il, "The Bitter End", "Горький конец", 7);
//         TranslationHelper.ModifyIL(il, "The Bitter End", "Горький конец", 8);
//         TranslationHelper.ModifyIL(il, "The Bitter End", "Горький конец", 9);
//         TranslationHelper.ModifyIL(il, "The Bitter End", "Горький конец", 10);
//         TranslationHelper.ModifyIL(il, "The Bitter End", "Горький конец", 11);
//         TranslationHelper.ModifyIL(il, "The Bitter End", "Горький конец", 12);
//         TranslationHelper.ModifyIL(il, "The Bitter End", "Горький конец", 13);
//         TranslationHelper.ModifyIL(il, "The Bitter End", "Горький конец", 14);
//         TranslationHelper.ModifyIL(il, "The Bitter End", "Горький конец", 15);
//         TranslationHelper.ModifyIL(il, "The Bitter End", "Горький конец", 16);
//         TranslationHelper.ModifyIL(il, "Solemn Confiteor", "Торжественный конфитеор");
//         TranslationHelper.ModifyIL(il, "Solemn Confiteor", "Торжественный конфитеор", 2);
//         TranslationHelper.ModifyIL(il, "Solemn Confiteor", "Торжественный конфитеор", 3);
//         TranslationHelper.ModifyIL(il, "Solemn Confiteor", "Торжественный конфитеор", 4);
//         TranslationHelper.ModifyIL(il, "Solemn Confiteor", "Торжественный конфитеор", 5);
//         TranslationHelper.ModifyIL(il, "Solemn Confiteor", "Торжественный конфитеор", 6);
//         TranslationHelper.ModifyIL(il, "Absolute Fire III", "Абсолютный огонь III");
//         TranslationHelper.ModifyIL(il, "Absolute Fire III", "Абсолютный огонь III", 2);
//         TranslationHelper.ModifyIL(il, "Absolute Fire III", "Абсолютный огонь III", 3);
//         TranslationHelper.ModifyIL(il, "Absolute Fire III", "Абсолютный огонь III", 4);
//         TranslationHelper.ModifyIL(il, "Absolute Fire III", "Абсолютный огонь III", 5);
//         TranslationHelper.ModifyIL(il, "Absolute Fire III", "Абсолютный огонь III", 6);
//         TranslationHelper.ModifyIL(il, "Absolute Fire III", "Абсолютный огонь III", 7);
//         TranslationHelper.ModifyIL(il, "Absolute Fire III", "Абсолютный огонь III", 8);
//         TranslationHelper.ModifyIL(il, "Absolute Blizzard III", "Абсолютная метель III");
//         TranslationHelper.ModifyIL(il, "Absolute Blizzard III", "Абсолютная метель III", 2);
//         TranslationHelper.ModifyIL(il, "Absolute Blizzard III", "Абсолютная метель III", 3);
//         TranslationHelper.ModifyIL(il, "Absolute Blizzard III", "Абсолютная метель III", 4);
//         TranslationHelper.ModifyIL(il, "Absolute Blizzard III", "Абсолютная метель III", 5);
//         TranslationHelper.ModifyIL(il, "Absolute Blizzard III", "Абсолютная метель III", 6);
//         TranslationHelper.ModifyIL(il, "Absolute Blizzard III", "Абсолютная метель III", 7);
//         TranslationHelper.ModifyIL(il, "Absolute Blizzard III", "Абсолютная метель III", 8);
//         TranslationHelper.ModifyIL(il, "Terror Unleashed", "Освобождённый ужас");
//         TranslationHelper.ModifyIL(il, "Terror Unleashed", "Освобождённый ужас", 2);
//         TranslationHelper.ModifyIL(il, "Terror Unleashed", "Освобождённый ужас", 3);
//         TranslationHelper.ModifyIL(il, "Terror Unleashed", "Освобождённый ужас", 4);
//         TranslationHelper.ModifyIL(il, "Terror Unleashed", "Освобождённый ужас", 5);
//         TranslationHelper.ModifyIL(il, "Terror Unleashed", "Освобождённый ужас", 6);
//         TranslationHelper.ModifyIL(il, "Terror Unleashed", "Освобождённый ужас", 7);
//         TranslationHelper.ModifyIL(il, "Absolute Thunder IV", "Абсолютная гроза IV");
//         TranslationHelper.ModifyIL(il, "Absolute Thunder IV", "Абсолютная гроза IV", 2);
//         TranslationHelper.ModifyIL(il, "Absolute Thunder IV", "Абсолютная гроза IV", 3);
//         TranslationHelper.ModifyIL(il, "Absolute Thunder IV", "Абсолютная гроза IV", 4);
//         TranslationHelper.ModifyIL(il, "Absolute Thunder IV", "Абсолютная гроза IV", 5);
//         TranslationHelper.ModifyIL(il, "Absolute Thunder IV", "Абсолютная гроза IV", 6);
//         TranslationHelper.ModifyIL(il, "Quintuplecast", "Пятикратное заклинание");
//         TranslationHelper.ModifyIL(il, "Quintuplecast", "Пятикратное заклинание", 2);
//         TranslationHelper.ModifyIL(il, "Quintuplecast", "Пятикратное заклинание", 3);
//         TranslationHelper.ModifyIL(il, "Quintuplecast", "Пятикратное заклинание", 4);
//         TranslationHelper.ModifyIL(il, "Quintuplecast", "Пятикратное заклинание", 5);
//         TranslationHelper.ModifyIL(il, "Quintuplecast", "Пятикратное заклинание", 6);
//         TranslationHelper.ModifyIL(il, "Quintuplecast", "Пятикратное заклинание", 7);
//         TranslationHelper.ModifyIL(il, "Absolute Holy", "Абсолютная святость");
//         TranslationHelper.ModifyIL(il, "Absolute Holy", "Абсолютная святость", 2);
//         TranslationHelper.ModifyIL(il, "Absolute Holy", "Абсолютная святость", 3);
//         TranslationHelper.ModifyIL(il, "Absolute Holy", "Абсолютная святость", 4);
//         TranslationHelper.ModifyIL(il, "Absolute Holy", "Абсолютная святость", 5);
//         TranslationHelper.ModifyIL(il, "Absolute Holy", "Абсолютная святость", 6);
//         TranslationHelper.ModifyIL(il, "Absolute Holy", "Абсолютная святость", 7);
//         TranslationHelper.ModifyIL(il, "Absolute Holy", "Абсолютная святость", 8);
//         TranslationHelper.ModifyIL(il, "Absolute Holy", "Абсолютная святость", 9);
//         TranslationHelper.ModifyIL(il, "Absolute Holy", "Абсолютная святость", 10);
//         TranslationHelper.ModifyIL(il, "Absolute Holy", "Абсолютная святость", 11);
//         TranslationHelper.ModifyIL(il, "Absolute Holy", "Абсолютная святость", 12);
//         TranslationHelper.ModifyIL(il, "To The Limit", "Круша лимиты");
//         TranslationHelper.ModifyIL(il, "To The Limit", "Круша лимиты", 2);
//         TranslationHelper.ModifyIL(il, "To The Limit", "Круша лимиты", 3);
//         TranslationHelper.ModifyIL(il, "To The Limit", "Круша лимиты", 4);
//         TranslationHelper.ModifyIL(il, "To The Limit", "Круша лимиты", 5);
//         TranslationHelper.ModifyIL(il, "To The Limit", "Круша лимиты", 6);
//         TranslationHelper.ModifyIL(il, "To The Limit", "Круша лимиты", 7);
//         TranslationHelper.ModifyIL(il, "To The Limit", "Круша лимиты", 8);
//         TranslationHelper.ModifyIL(il, "To The Limit", "Круша лимиты", 9);
//         TranslationHelper.ModifyIL(il, "To The Limit", "Круша лимиты", 10);
//         TranslationHelper.ModifyIL(il, "Absolute Rend Heaven", "Абсолютный разрыв небес");
//         TranslationHelper.ModifyIL(il, "Absolute Rend Heaven", "Абсолютный разрыв небес", 2);
//         TranslationHelper.ModifyIL(il, "Absolute Rend Heaven", "Абсолютный разрыв небес", 3);
//         TranslationHelper.ModifyIL(il, "Absolute Rend Heaven", "Абсолютный разрыв небес", 4);
//         TranslationHelper.ModifyIL(il, "Absolute Rend Heaven", "Абсолютный разрыв небес", 5);
//         TranslationHelper.ModifyIL(il, "Absolute Rend Heaven", "Абсолютный разрыв небес", 6);
//         TranslationHelper.ModifyIL(il, "Absolute Rend Heaven", "Абсолютный разрыв небес", 7);
//         TranslationHelper.ModifyIL(il, "Absolute Rend Heaven", "Абсолютный разрыв небес", 8);
//         TranslationHelper.ModifyIL(il, "Absolute Rend Heaven", "Абсолютный разрыв небес", 9);
//         TranslationHelper.ModifyIL(il, "Absolute Rend Heaven", "Абсолютный разрыв небес", 10);
//         TranslationHelper.ModifyIL(il, "Absolute Rend Heaven", "Абсолютный разрыв небес", 11);
//         TranslationHelper.ModifyIL(il, "Absolute Linear Mystics", "Абсолютные линейные мистики");
//         TranslationHelper.ModifyIL(il, "Absolute Linear Mystics", "Абсолютные линейные мистики", 2);
//         TranslationHelper.ModifyIL(il, "Absolute Linear Mystics", "Абсолютные линейные мистики", 3);
//         TranslationHelper.ModifyIL(il, "Absolute Linear Mystics", "Абсолютные линейные мистики", 4);
//         TranslationHelper.ModifyIL(il, "Absolute Linear Mystics", "Абсолютные линейные мистики", 5);
//         TranslationHelper.ModifyIL(il, "Absolute Linear Mystics", "Абсолютные линейные мистики", 6);
//         TranslationHelper.ModifyIL(il, "Absolute Linear Mystics", "Абсолютные линейные мистики", 7);
//         TranslationHelper.ModifyIL(il, "Absolute Linear Mystics", "Абсолютные линейные мистики", 8);
//         TranslationHelper.ModifyIL(il, "Absolute Linear Mystics", "Абсолютные линейные мистики", 9);
//         TranslationHelper.ModifyIL(il, "Absolute Linear Mystics", "Абсолютные линейные мистики", 10);
//         TranslationHelper.ModifyIL(il, "Unabated Radiance", "Неослабевающее сияние");
//         TranslationHelper.ModifyIL(il, "Unabated Radiance", "Неослабевающее сияние", 2);
//         TranslationHelper.ModifyIL(il, "Unabated Radiance", "Неослабевающее сияние", 3);
//         TranslationHelper.ModifyIL(il, "Unabated Radiance", "Неослабевающее сияние", 4);
//         TranslationHelper.ModifyIL(il, "Unabated Radiance", "Неослабевающее сияние", 5);
//         TranslationHelper.ModifyIL(il, "Unabated Radiance", "Неослабевающее сияние", 6);
//         TranslationHelper.ModifyIL(il, "Unabated Radiance", "Неослабевающее сияние", 7);
//         TranslationHelper.ModifyIL(il, "Unabated Radiance", "Неослабевающее сияние", 8);
//         TranslationHelper.ModifyIL(il, "Unabated Radiance", "Неослабевающее сияние", 9);
//         TranslationHelper.ModifyIL(il, "SOUL Extraction", "Извлечение ДУШИ");
//         TranslationHelper.ModifyIL(il, "SOUL Extraction", "Извлечение ДУШИ", 2);
//         TranslationHelper.ModifyIL(il, "SOUL Extraction", "Извлечение ДУШИ", 3);
//         TranslationHelper.ModifyIL(il, "SOUL Extraction", "Извлечение ДУШИ", 4);
//         TranslationHelper.ModifyIL(il, "SOUL Extraction", "Извлечение ДУШИ", 5);
//         TranslationHelper.ModifyIL(il, "SOUL Extraction", "Извлечение ДУШИ", 6);
//         TranslationHelper.ModifyIL(il, "SOUL Extraction", "Извлечение ДУШИ", 7);
//         TranslationHelper.ModifyIL(il, "Light Rampant", "Раздолье света");
//         TranslationHelper.ModifyIL(il, "Light Rampant", "Раздолье света", 2);
//         TranslationHelper.ModifyIL(il, "Light Rampant", "Раздолье света", 3);
//         TranslationHelper.ModifyIL(il, "Light Rampant", "Раздолье света", 4);
//         TranslationHelper.ModifyIL(il, "Light Rampant", "Раздолье света", 5);
//         TranslationHelper.ModifyIL(il, "Radiant Braver", "Сияющий храбрец");
//         TranslationHelper.ModifyIL(il, "Radiant Braver", "Сияющий храбрец", 2);
//         TranslationHelper.ModifyIL(il, "Radiant Braver", "Сияющий храбрец", 3);
//         TranslationHelper.ModifyIL(il, "Radiant Braver", "Сияющий храбрец", 4);
//         TranslationHelper.ModifyIL(il, "Radiant Braver", "Сияющий храбрец", 5);
//         TranslationHelper.ModifyIL(il, "Radiant Braver", "Сияющий храбрец", 6);
//         TranslationHelper.ModifyIL(il, "Radiant Desperado", "Сияющий отчаянный");
//         TranslationHelper.ModifyIL(il, "Radiant Desperado", "Сияющий отчаянный", 2);
//         TranslationHelper.ModifyIL(il, "Radiant Desperado", "Сияющий отчаянный", 3);
//         TranslationHelper.ModifyIL(il, "Radiant Desperado", "Сияющий отчаянный", 4);
//         TranslationHelper.ModifyIL(il, "Radiant Desperado", "Сияющий отчаянный", 5);
//         TranslationHelper.ModifyIL(il, "Radiant Meteor", "Лучезарный метеор");
//         TranslationHelper.ModifyIL(il, "Radiant Meteor", "Лучезарный метеор", 2);
//         TranslationHelper.ModifyIL(il, "Radiant Meteor", "Лучезарный метеор", 3);
//         TranslationHelper.ModifyIL(il, "Radiant Meteor", "Лучезарный метеор", 4);
//         TranslationHelper.ModifyIL(il, "Radiant Meteor", "Лучезарный метеор", 5);
//         TranslationHelper.ModifyIL(il, "Rays of Punishment", "Лучи расплаты");
//         TranslationHelper.ModifyIL(il, "Rays of Punishment", "Лучи расплаты", 2);
//         TranslationHelper.ModifyIL(il, "Rays of Punishment", "Лучи расплаты", 3);
//         TranslationHelper.ModifyIL(il, "Rays of Punishment", "Лучи расплаты", 4);
//         TranslationHelper.ModifyIL(il, "Rays of Punishment", "Лучи расплаты", 5);
//         TranslationHelper.ModifyIL(il, "Rays of Punishment", "Лучи расплаты", 6);
//         TranslationHelper.ModifyIL(il, "Blades of Light", "Клинки света");
//         TranslationHelper.ModifyIL(il, "Blades of Light", "Клинки света", 2);
//         TranslationHelper.ModifyIL(il, "Blades of Light", "Клинки света", 3);
//         TranslationHelper.ModifyIL(il, "Blades of Light", "Клинки света", 4);
//         TranslationHelper.ModifyIL(il, "Blades of Light", "Клинки света", 5);
//         TranslationHelper.ModifyIL(il, "Blades of Light", "Клинки света", 6);
//         TranslationHelper.ModifyIL(il, "Blades of Light", "Клинки света", 7);
//         TranslationHelper.ModifyIL(il, "Blades of Light", "Клинки света", 8);
//         TranslationHelper.ModifyIL(il, "Blades of Light", "Клинки света", 9);
//         TranslationHelper.ModifyIL(il, "Blades of Light", "Клинки света", 10);
//         TranslationHelper.ModifyIL(il, "Absolute Summoning", "Абсолютный призыв");
//         TranslationHelper.ModifyIL(il, "Absolute Summoning", "Абсолютный призыв", 2);
//         TranslationHelper.ModifyIL(il, "Absolute Summoning", "Абсолютный призыв", 3);
//         TranslationHelper.ModifyIL(il, "Absolute Summoning", "Абсолютный призыв", 4);
//         TranslationHelper.ModifyIL(il, "Absolute Summoning", "Абсолютный призыв", 5);
//         TranslationHelper.ModifyIL(il, "Absolute Summoning", "Абсолютный призыв", 6);
//         TranslationHelper.ModifyIL(il, "Absolute Summoning", "Абсолютный призыв", 7);
//         TranslationHelper.ModifyIL(il, "Absolute Summoning", "Абсолютный призыв", 8);
//         TranslationHelper.ModifyIL(il, "Absolute Summoning", "Абсолютный призыв", 9);
//         TranslationHelper.ModifyIL(il, "Unabated Refulgence", "Неослабевающая яркость");
//         TranslationHelper.ModifyIL(il, "Unabated Refulgence", "Неослабевающая яркость", 2);
//     };
// }