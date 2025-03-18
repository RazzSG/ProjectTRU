using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using Mono.Cecil.Cil;
using MonoMod.Cil;
using Terraria.Localization;
using Terraria.ModLoader;

namespace CalamityRuTranslate.Common.Utilities;

internal static class TranslationHelper
{
    internal static bool IsRussianLanguage => LanguageManager.Instance.ActiveCulture == GameCulture.FromCultureName(GameCulture.CultureName.Russian);

    internal static void ModifyIL(ILContext il, string orig, string replace, int iterations = 1)
    {
        ILCursor cursor = new ILCursor(il);

        for (int i = 0; i < iterations; i++)
        {
            if (!cursor.TryGotoNext(MoveType.After,x => x.MatchLdstr(orig)))
            {
                throw new Exception($"[IL] Не удалось заменить '{orig}' на '{replace}' в методе [c/70FF8D:{il.Method.Name}]!");
            }
        }

        cursor.Emit(OpCodes.Pop);
        cursor.Emit(OpCodes.Ldstr, replace);
    }

    internal static void ModifyIL(ILContext il, int orig, int replace, int iterations = 1)
    {
        ILCursor cursor = new ILCursor(il);

        for (int i = 0; i < iterations; i++)
        {
            if (!cursor.TryGotoNext(MoveType.After, x => x.MatchLdcI4(orig)))
            {
                throw new Exception($"[IL] Не удалось заменить '{orig}' на '{replace}' в методе [c/70FF8D:{il.Method.Name}]");
            }
        }

        cursor.Emit(OpCodes.Pop);
        cursor.Emit(OpCodes.Ldc_I4, replace);
    }

    internal static void ModifyIL(ILContext il, float orig, float replace, int iterations = 1)
    {
        ILCursor cursor = new ILCursor(il);

        for (int i = 0; i < iterations; i++)
        {
            if (!cursor.TryGotoNext(MoveType.After, x => x.MatchLdcR4(orig)))
            {
                throw new Exception($"[IL] Не удалось заменить '{orig}' на '{replace}' в методе [c/70FF8D:{il.Method.Name}]");
            }
        }

        cursor.Emit(OpCodes.Pop);
        cursor.Emit(OpCodes.Ldc_R4, replace);
    }
    
    internal static void ModifyIL(ILContext il, double orig, double replace, int iterations = 1)
    {
        ILCursor cursor = new ILCursor(il);

        for (int i = 0; i < iterations; i++)
        {
            if (!cursor.TryGotoNext(MoveType.After, x => x.MatchLdcR8(orig)))
            {
                throw new Exception($"[IL] Не удалось заменить '{orig}' на '{replace}' в методе [c/70FF8D:{il.Method.Name}]");
            }
        }

        cursor.Emit(OpCodes.Pop);
        cursor.Emit(OpCodes.Ldc_R8, replace);
    }
    
    internal static void ModifyIL(ILContext il, FieldInfo orig, FieldInfo replace, int iterations = 1)
    {
        ILCursor cursor = new ILCursor(il);

        for (int i = 0; i < iterations; i++)
        {
            if (!cursor.TryGotoNext(MoveType.After, x => x.MatchLdsflda(orig)))
            {
                throw new Exception($"[IL] Не удалось заменить '{orig}' на '{replace}' в методе [c/70FF8D:{il.Method.Name}]");
            }
        }

        cursor.Emit(OpCodes.Pop);
        cursor.Emit(OpCodes.Ldsflda, replace);
    }

    internal static void WikithisRedirect(string[] ids, string wikiPage, bool isItem = true)
    {
        foreach (var id in ids)
        {
            int type = isItem
                ? ModContent.Find<ModItem>("CalamityMod", id).Type
                : ModContent.Find<ModNPC>("CalamityMod", id).Type;
            ModInstances.Wikithis.Call(isItem ? 1 : 2, type, wikiPage, GameCulture.CultureName.Russian);
        }
    }

    internal static void WikithisRedirect(string id, string wikiPage, bool isItem = true)
    {
        int type = isItem
            ? ModContent.Find<ModItem>("CalamityMod", id).Type
            : ModContent.Find<ModNPC>("CalamityMod", id).Type;
        ModInstances.Wikithis.Call(isItem ? 1 : 2, type, wikiPage, GameCulture.CultureName.Russian);
    }

    internal static string GetTextValue(string name, string suffix)
    {
        return Language.GetTextValue(GetTextFromModItem(name, suffix).Key);
    }
    
    internal static string GetTextValue(string name, string suffix, params object[] args)
    {
        return Language.GetTextValue(GetTextFromModItem(name, suffix).Key, args);
    }
    
    internal static LocalizedText GetTextFromModItem(string name, string suffix)
    {
        return ModContent.GetModItem(ModContent.Find<ModItem>(name).Type).GetLocalization(suffix);
    }

    internal static int GetItemID(string fullName)
    {
        return ModContent.Find<ModItem>(fullName).Type;
    }
    
    internal static LocalizedText GetText(string key)
    {
        return Language.GetOrRegister("Mods." + key);
    }
    
    public static List<int> GetItemTypesFromMod(string[] itemNames, string modName)
    {
        return itemNames
            .Select(itemName =>
            {
                ModContent.TryFind($"{modName}/{itemName}", out ModItem modItem);
                return modItem;
            })
            .Where(modItem => modItem != null)
            .Select(modItem => modItem.Type)
            .ToList();
    }
}