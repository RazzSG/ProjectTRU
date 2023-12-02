using System.Reflection;
using CalamityRuTranslate.Common;
using CalamityRuTranslate.Common.Utilities;
using CalamityRuTranslate.Core.MonoMod;
using InfernumMode.Content.Items.Misc;
using MonoMod.Cil;

namespace CalamityRuTranslate.Mods.InfernumMode.MonoMod;

public class SakuraBudPatch : ILPatcher
{
    public override bool AutoLoad => ModInstances.Infernum != null && ModInstances.Calamity != null && TranslationHelper.IsRussianLanguage;
    
    public override MethodInfo ModifiedMethod => typeof(SakuraBud).GetCachedMethod(nameof(SakuraBud.PreDrawTooltipLine));

    public override ILContext.Manipulator PatchMethod { get; } = il =>
    {
        TranslationHelper.ModifyIL(il, "You feel", "Вы ощущаете");
        TranslationHelper.ModifyIL(il, "You feel a ", "Вы ощущаете присутствие ");
        TranslationHelper.ModifyIL(il, "guiding spirit", "направляющего духа");
        TranslationHelper.ModifyIL(il, " trying to lead you the bloom’s home", ", который пытается провести вас к месту расцвета");
        TranslationHelper.ModifyIL(il, "Maybe you", "Может быть");
        TranslationHelper.ModifyIL(il, "The spirit is trying to draw your attention to the ", "Дух пытается привлечь ваше внимание к ");
        TranslationHelper.ModifyIL(il, "water", "воде");
        TranslationHelper.ModifyIL(il, "Maybe you should follow its call?", "Может быть, стоит ответить на его зов?");
    };
}