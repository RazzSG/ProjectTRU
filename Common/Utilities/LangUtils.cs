﻿using System.Collections.Generic;
using System.Reflection;
using Terraria.Localization;
using Terraria.ModLoader;

namespace CalamityRuTranslate.Common.Utilities
{
    public static class LangUtils
    {
        private static Dictionary<string, ModTranslation> Translations;

        internal static string GetTextValue(string mod, string key) => GetModTextValue(CalamityRuTranslate.Instance, $"{mod}.{key}");

        internal static string GetTextValue(string mod, string key, params object[] args) => GetModTextValue(CalamityRuTranslate.Instance, $"{mod}.{key}", args);

        private static string GetModTextValue(Mod mod, string key) => Language.GetTextValue($"Mods.{mod.Name}.{key}");

        private static string GetModTextValue(Mod mod, string key, params object[] args) => Language.GetTextValue($"Mods.{mod.Name}.{key}", args);

        public static string TranslationKey(string key) => Translations[$"Mods.CalamityRuTranslate.{key}"].GetTranslation(Language.ActiveCulture);

        public static void Load()
        {
            FieldInfo translationsField = typeof(Mod).GetField("translations", BindingFlags.Instance | BindingFlags.NonPublic);
            Translations = (Dictionary<string, ModTranslation>)translationsField?.GetValue(CalamityRuTranslate.Instance);
        }

        public static void Unload()
        {
            Translations = null;
        }
    }
}