using System;
using System.Linq;
using System.Reflection;
using CalamityMod;
using CalamityRuTranslate.Common;
using CalamityRuTranslate.Common.Utilities;
using CalamityRuTranslate.Core.Config;
using CalamityRuTranslate.Core.MonoMod;
using Terraria;

namespace CalamityRuTranslate.Mods.CalamityMod.MonoMod;

public class GenerateRandomAlphanumericStringPatch : OnPatcher
{
    public override bool AutoLoad => ModInstances.Calamity != null && TRuConfig.Instance.CalamityModLocalization && TranslationHelper.IsRussianLanguage;

    public override MethodInfo ModifiedMethod => typeof(CalamityUtils).FindMethod(nameof(CalamityUtils.GenerateRandomAlphanumericString));

    public override Delegate Delegate { get; } = (Func<int, string> _, int length) =>
    {
        const string alphanumericCharacters = "абвгдеёжзийклмнопрстуфхцчшщъыьэюяАБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯ0123456789";
        return new string(Enumerable.Repeat(alphanumericCharacters, length)
            .Select(s => s[Main.rand.Next(s.Length)])
            .ToArray());
    };
}

public class ToMphPatch : OnPatcher
{
    public override bool AutoLoad => ModInstances.Calamity != null && TRuConfig.Instance.CalamityModLocalization && TranslationHelper.IsRussianLanguage;

    public override MethodInfo ModifiedMethod => typeof(CalamityUtils).FindMethod(nameof(CalamityUtils.ToMph));

    public override Delegate Delegate { get; } = (Func<float, string> _, float velocity) =>
    {
        return (velocity * 216000f / 42240f * 1.60934f).Round("N0");
    };
}

public class ToMphpsPatch : OnPatcher
{
    public override bool AutoLoad => ModInstances.Calamity != null && TRuConfig.Instance.CalamityModLocalization && TranslationHelper.IsRussianLanguage;

    public override MethodInfo ModifiedMethod => typeof(CalamityUtils).FindMethod(nameof(CalamityUtils.ToMphps));

    public override Delegate Delegate { get; } = (Func<float, string> _, float velocity) =>
    {
        return (velocity * 60f * 216000f / 42240f * 1.60934f).Round("N2");
    };
}   