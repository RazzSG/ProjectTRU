using System;
using CalamityRuTranslate.Core.ArmorSetBonusPreview;
using CalamityRuTranslate.Core.ItemGenderPrefixes;
using Terraria.ModLoader;

namespace CalamityRuTranslate.Core.ModCalls;

public class ModCalls
{
    public static object Call(params object[] args)
    {
        if (args is null ||  args.Length == 0)
            return new ArgumentNullException("Аргументы не могут быть пустыми!");
 
        if (args[0] is not string methodName)
            throw new ArgumentException("Первый аргумент должен быть строкой (название функции).");
        
        switch (methodName)
        {
            case "AddArmorSetBonusPreview":
                if (args.Length < 3)
                    throw new ArgumentNullException("Недостаточно аргументов! Ожидается: (string, int, Func<string>)");
                
                if (args[1] is not int itemID)
                    throw new ArgumentException("Второй аргумент должен быть int (itemID)");
                
                if (args[2] is not Func<string> setBonusText)
                    throw new ArgumentException("Третий аргумент должен быть Func<string> (setBonusText)");
                
                ArmorSetBonusPreviewSystem.AddSetBonusForItem(itemID, setBonusText);
                return true;
            case "AddFeminineItems":
                if (args.Length < 2)
                    throw new ArgumentNullException("Недостаточно аргументов! Ожидается: (string, Mod, string[])");
                
                if (args[1] is not Mod mod)
                    throw new ArgumentException("Второй аргумент должен быть экземпляр мода (Mod)");
                
                if (args[2] is not string[] feminineItems)
                    throw new ArgumentException("Второй аргумент должен быть массив (string[])");
                
                PrefixOverhaulModSystem.AddFeminineItems(mod, feminineItems);
                return true;
            case "AddNeuterItems":
                if (args.Length < 2)
                    throw new ArgumentNullException("Недостаточно аргументов! Ожидается: (string, Mod, string[])");
                
                if (args[1] is not Mod mod2)
                    throw new ArgumentException("Второй аргумент должен быть экземпляр мода (Mod)");
                
                if (args[2] is not string[] neuterItems)
                    throw new ArgumentException("Второй аргумент должен быть массив (string[])");
                
                PrefixOverhaulModSystem.AddNeuterItems(mod2, neuterItems);
                return true;
            case "AddPluralItems":
                if (args.Length < 2)
                    throw new ArgumentNullException("Недостаточно аргументов! Ожидается: (string, Mod, string[])");
                
                if (args[1] is not Mod mod3)
                    throw new ArgumentException("Второй аргумент должен быть экземпляр мода (Mod)");
                
                if (args[2] is not string[] pluralItems)
                    throw new ArgumentException("Второй аргумент должен быть массив (string[])");
                
                PrefixOverhaulModSystem.AddPluralItems(mod3, pluralItems);
                return true;
            
            default:
                throw new ArgumentException($"Неизвестное название метода: {methodName}");
        }
    }
}