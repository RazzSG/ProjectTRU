using System.Reflection;
using CalamityRuTranslate.Common;
using CalamityRuTranslate.Common.Utilities;
using CalamityRuTranslate.Core.MonoMod;
using FargowiltasSouls.Common;
using MonoMod.Cil;

namespace CalamityRuTranslate.Mods.FargowiltasSouls.MonoMod;

public class EModeAccessorySlotPatch : ILPatcher
{
    public override bool AutoLoad => ModInstances.FargowiltasSouls != null && TranslationHelper.IsRussianLanguage;

    public override MethodInfo ModifiedMethod => typeof(EModeAccessorySlot).GetCachedMethod(nameof(EModeAccessorySlot.OnMouseHover));
    
    public override ILContext.Manipulator PatchMethod { get; } = il =>
    {
        TranslationHelper.ModifyIL(il, "Enchantment, Force or Soul", "Усиление, Сила или Душа");
        TranslationHelper.ModifyIL(il, "Social Enchantment, Force or Soul", "Внешний вид: Усиление, Сила или Душа");
    };
}