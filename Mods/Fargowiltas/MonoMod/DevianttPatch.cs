using System.Reflection;
using CalamityRuTranslate.Common;
using CalamityRuTranslate.Common.Utilities;
using CalamityRuTranslate.Core.MonoMod;
using Fargowiltas.NPCs;
using MonoMod.Cil;

namespace CalamityRuTranslate.Mods.Fargowiltas.MonoMod;

public class DevianttGetChatPatch : ILPatcher
{
    public override bool AutoLoad => ModsCall.Fargo != null && TranslationHelper.IsRussianLanguage;

    public override MethodInfo ModifiedMethod => typeof(Deviantt).GetCachedMethod(nameof(Deviantt.GetChat));

    public override ILContext.Manipulator PatchMethod { get; } = il =>
    {
        TranslationHelper.ModifyIL(il, "IT'S THE FUNNY BEE WORLD!", "ВЕСЁЛЫЙ ПЧЕЛИННЫЙ МИР!");
        TranslationHelper.ModifyIL(il, "HA", "ХА");
        TranslationHelper.ModifyIL(il, "HA", "ХА", 2);
        TranslationHelper.ModifyIL(il, "HEE", "ХИ");
        TranslationHelper.ModifyIL(il, "HOO", "ХО");
        TranslationHelper.ModifyIL(il, "HEH", "ХЕХ");
        TranslationHelper.ModifyIL(il, "HAH", "ХАХ");
        TranslationHelper.ModifyIL(il, "You're making too many hearts at me! Sorry, we're only at bond level ", "С количеством сердечек перебор! Прости, но мы сейчас только на ");
        TranslationHelper.ModifyIL(il, " right now!", " уровне отношений!");
    };
}