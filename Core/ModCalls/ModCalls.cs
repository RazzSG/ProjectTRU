using System;
using System.Collections.Generic;
using CalamityRuTranslate.Core.ArmorSetBonusPreview;
using CalamityRuTranslate.Core.ItemGenderPrefixes;
using Terraria.ModLoader;

namespace CalamityRuTranslate.Core.ModCalls;

public class ModCalls
{
    public static object Call(params object[] args)
    {
        if (args is null || args.Length == 0)
            return new ArgumentException("Аргументы не могут быть пустыми!");
 
        if (args[0] is not string methodName)
            throw new ArgumentException("Первый аргумент должен быть строкой (название функции).");
        
        switch (methodName)
        {
            case "AddArmorSetBonusPreview":
                if (args.Length < 3)
                    throw new ArgumentException("Недостаточно аргументов! Ожидается: (string, int, Func<string>)");
                
                if (args[1] is not int itemID)
                    throw new ArgumentException("Второй аргумент должен быть int (itemID)");
                
                if (args[2] is not Func<string> setBonusText)
                    throw new ArgumentException("Третий аргумент должен быть Func<string> (setBonusText)");
                
                ArmorSetBonusPreviewSystem.AddSetBonusForItem(itemID, setBonusText);
                return true;
            case "AddFeminineItems":
                if (args.Length < 2)
                    throw new ArgumentException("Недостаточно аргументов! Ожидается: (string, Mod, string[])");
                
                if (args[1] is not Mod mod)
                    throw new ArgumentException("Второй аргумент должен быть экземпляр мода (Mod)");
                
                if (args[2] is not string[] feminineItems)
                    throw new ArgumentException("Третий аргумент должен быть массив (string[])");
                
                PrefixOverhaulModSystem.AddFeminineItems(mod, feminineItems);
                return true;
            case "AddNeuterItems":
                if (args.Length < 2)
                    throw new ArgumentException("Недостаточно аргументов! Ожидается: (string, Mod, string[])");
                
                if (args[1] is not Mod mod2)
                    throw new ArgumentException("Второй аргумент должен быть экземпляр мода (Mod)");
                
                if (args[2] is not string[] neuterItems)
                    throw new ArgumentException("Третий аргумент должен быть массив (string[])");
                
                PrefixOverhaulModSystem.AddNeuterItems(mod2, neuterItems);
                return true;
            case "AddPluralItems":
                if (args.Length < 2)
                    throw new ArgumentException("Недостаточно аргументов! Ожидается: (string, Mod, string[])");
                
                if (args[1] is not Mod mod3)
                    throw new ArgumentException("Второй аргумент должен быть экземпляр мода (Mod)");
                
                if (args[2] is not string[] pluralItems)
                    throw new ArgumentException("Третий аргумент должен быть массив (string[])");
                
                PrefixOverhaulModSystem.AddPluralItems(mod3, pluralItems);
                return true;
            case "AddVanillaFeminineItems":
                if (args.Length < 1)
                    throw new ArgumentException("Недостаточно аргументов! Ожидается: (string, int[])");

                if (args[1] is not int[] feminineVanillaItems)
                    throw new ArgumentException("Второй аргумент должен быть массив (int[])");
                
                PrefixOverhaulModSystem.AddFeminineItems(feminineVanillaItems);
                return true;
            case "AddVanillaNeuterItems":
                if (args.Length < 1)
                    throw new ArgumentException("Недостаточно аргументов! Ожидается: (string, int[])");

                if (args[1] is not int[] neuterVanillaItems)
                    throw new ArgumentException("Второй аргумент должен быть массив (int[])");
                
                PrefixOverhaulModSystem.AddNeuterItems(neuterVanillaItems);
                return true;
            case "AddVanillaPluralItems":
                if (args.Length < 1)
                    throw new ArgumentException("Недостаточно аргументов! Ожидается: (string, int[])");

                if (args[1] is not int[] pluralVanillaItems)
                    throw new ArgumentException("Второй аргумент должен быть массив (int[])");
                
                PrefixOverhaulModSystem.AddPluralItems(pluralVanillaItems);
                return true;
            case "RegisterPrefixes":
                if (args.Length < 2)
                    throw new ArgumentException("Недостаточно аргументов. Ожидается: (string, List<string[]>)");

                if (args[1] is not List<string[]> variations)
                    throw new ArgumentException("Второй аргумент должен быть списком массивов строк (List<string[]>)");

                for (int i = 0; i < variations.Count; i++)
                {
                    if (variations[i] == null)
                        throw new ArgumentException($"Элемент списка с индексом {i} равен null. Ожидается массив строк из 4 элементов.");

                    if (variations[i].Length != 4)
                        throw new ArgumentException($"Массив префиксов с индексом {i} должен содержать ровно 4 элемента: [мужской, женский, средний, множественный].");
                }

                PrefixOverhaulModSystem.RegisterPrefixes(variations);
                return true;
            
            default:
                throw new ArgumentException($"Неизвестное название метода: {methodName}");
        }
    }
}