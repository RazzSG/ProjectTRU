using System.Reflection;
using CalamityRuTranslate.Common;
using CalamityRuTranslate.Common.Utilities;
using CalamityRuTranslate.Core.MonoMod;
using Fargowiltas.UI;
using MonoMod.Cil;

namespace CalamityRuTranslate.Mods.Fargowiltas.MonoMod;

public class StatButtonPatch : ILPatcher
{
    public override bool AutoLoad => ModInstances.Fargowiltas != null && TranslationHelper.IsRussianLanguage;

    public override MethodInfo ModifiedMethod => typeof(StatButton).GetCachedMethod(nameof(StatButton.OnActivate));

    public override ILContext.Manipulator PatchMethod { get; } = il =>
    {
        TranslationHelper.ModifyIL(il, "Stat Sheet", "Таблица характеристик");
    };
}