﻿using System;
using System.Linq;
using System.Reflection;
using CalamityMod;
using CalamityRuTranslate.Common;
using CalamityRuTranslate.Common.Utilities;
using CalamityRuTranslate.Core.MonoMod;
using Terraria;

namespace CalamityRuTranslate.Mods.CalamityMod.MonoMod;

public class CalamityUtilsPatch : OnPatcher
{
    public override bool AutoLoad => ModsCall.Calamity != null && TranslationHelper.IsRussianLanguage;

    public override MethodInfo ModifiedMethod => typeof(CalamityUtils).GetCachedMethod(nameof(CalamityUtils.GenerateRandomAlphanumericString));

    private delegate string GenerateRandomAlphanumericStringDelegate(int length);

    public override Delegate Delegate { get; } = (GenerateRandomAlphanumericStringDelegate orig, int length) =>
    {
        const string alphanumericCharacters = "абвгдеёжзийклмнопрстуфхцчшщъыьэюяАБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯ0123456789";
        return new string(Enumerable.Repeat(alphanumericCharacters, length).Select(s => s[Main.rand.Next(s.Length)])
            .ToArray());
    };
}