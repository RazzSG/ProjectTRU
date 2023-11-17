using System;
using System.Reflection;
using CalamityRuTranslate.Common;
using CalamityRuTranslate.Common.Utilities;
using CalamityRuTranslate.Core.MonoMod;
using Fargowiltas.UI;
using MonoMod.Cil;

namespace CalamityRuTranslate.Mods.Fargowiltas.MonoMod;

public class StatButtonUIRebuildStatList : OnPatcher
{
    public override bool AutoLoad => ModsCall.Fargo != null && TranslationHelper.IsRussianLanguage;
    
    public override MethodInfo ModifiedMethod => typeof(StatSheetUI).GetCachedMethod(nameof(StatSheetUI.AddStat));
    
    private delegate void AddStatDelegate(StatSheetUI self, string text, int item = -1);

    public override Delegate Delegate => Translation;
    
    private void Translation(AddStatDelegate orig, StatSheetUI self, string text, int item = -1)
    {
        text = text
            .Replace("Melee Damage:", "Урон ближнего боя:")
            .Replace("Melee Critical:", "Шанс крит. удара ближнего боя:")
            .Replace("Melee Speed:", "Скорость атаки ближнего боя:")
            .Replace("Ranged Damage:", "Стрелковый урон:")
            .Replace("Ranged Critical:", "Стрелковый шанс крит. удара:")
            .Replace("Magic Damage:", "Магический урон:")
            .Replace("Magic Critical:", "Магический шанс крит. удара:")
            .Replace("Mana Cost Reduction:", "Расход маны:")
            .Replace("Summon Damage:", "Урон призывателя:")
            .Replace("Summon Critical:", "Шанс крит. удара призывателя:")
            .Replace("Max Minions:", "Максимальное число миньонов:")
            .Replace("Max Sentries:", "Максимальное число стражей:")
            .Replace("Armor Penetration:", "Пробивание брони:")
            .Replace("Aggro:", "Агрессия:")
            .Replace("Life:", "Здоровье:")
            .Replace("Life Regen:", "Регенерация здоровья:")
            .Replace("/sec", "/сек")
            .Replace("Mana:", "Мана:")
            .Replace("Mana Regen:", "Восстановление маны:")
            .Replace("Defense:", "Защита:")
            .Replace("Damage Reduction:", "Сопротивление урону:")
            .Replace("cap", "предел")
            .Replace("Luck:", "Удача:")
            .Replace("Fishing Quests:", "Выполненных заданий рыбака:")
            .Replace("Battle Cry:", "Боевой клич:")
            .Replace("[c/ff0000:Battle]", "[c/ff0000:Боевой]")
            .Replace("[c/00ffff:Calming]", "[c/00ffff:Успокаивающий]")
            .Replace("None", "Нет")
            .Replace("mph", "км/ч")
            .Replace("Wing Time: Yes", "Время полёта: Да")
            .Replace("Wing Time:", "Время полёта:")
            .Replace("sec", "сек")
            .Replace("Wing Max Speed:", "Максимальная скорость крыльев:")
            .Replace("Max Speed:", "Максимальная скорость:")
            .Replace("Wing Ascent Modifier:", "Модификатор взлёта крыльев:")
            .Replace("Wing Can Hover:", "Способность крыльев зависать:")
            .Replace("True", "Да")
            .Replace("False", "Нет");
        
        orig.Invoke(self, text, item);
    }
}

public class StatButtonAddStat : ILPatcher
{
    public override bool AutoLoad => ModsCall.Fargo != null && TranslationHelper.IsRussianLanguage;

    public override MethodInfo ModifiedMethod => typeof(StatSheetUI).GetCachedMethod(nameof(StatSheetUI.AddStat));

    public override ILContext.Manipulator PatchMethod { get; } = il =>
    {
        //Сдвигаем второй столбец характеристик вправо
        TranslationHelper.ModifyIL(il, 8, -102, 2);
    };
}