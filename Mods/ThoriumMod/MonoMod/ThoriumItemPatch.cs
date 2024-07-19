using System.Reflection;
using CalamityRuTranslate.Common;
using CalamityRuTranslate.Common.Utilities;
using CalamityRuTranslate.Core.Config;
using CalamityRuTranslate.Core.MonoMod;
using MonoMod.Cil;
using ThoriumMod.Items;

namespace CalamityRuTranslate.Mods.ThoriumMod.MonoMod;

public class ThoriumItemPatch : ILPatcher
{
    public override bool AutoLoad => ModInstances.Thorium != null && TRuConfig.Instance.ThoriumModLocalization && TranslationHelper.IsRussianLanguage;

    public override MethodInfo ModifiedMethod => typeof(ThoriumItem).GetCachedMethod(nameof(ThoriumItem.ModifyTooltips));

    public override ILContext.Manipulator PatchMethod { get; } = il =>
    {
        TranslationHelper.ModifyIL(il, " & ", " и ");
        TranslationHelper.ModifyIL(il, " life", " ед. здоровья");
    };
}