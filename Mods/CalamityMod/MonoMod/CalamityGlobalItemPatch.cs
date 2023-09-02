using System.Reflection;
using CalamityRuTranslate.Common;
using CalamityRuTranslate.Common.Utilities;
using CalamityRuTranslate.Core.MonoMod;
using MonoMod.Cil;

namespace CalamityRuTranslate.Mods.CalamityMod.MonoMod;

public class CalamityGlobalItemPatch : ILPatcher
{
    public override bool AutoLoad => ModsCall.Calamity != null && TranslationHelper.IsRussianLanguage;
    
    public override MethodInfo ModifiedMethod => typeof(global::CalamityMod.Items.CalamityGlobalItem).GetCachedMethod("<ModifyVanillaTooltips>g__HookStatsTooltip|100_150");

    public override ILContext.Manipulator PatchMethod { get; } = il =>
    {
        TranslationHelper.ModifyIL(il, "Reach: ", "Дальность: ");
        TranslationHelper.ModifyIL(il, " tiles\n", " блоков\n");
        TranslationHelper.ModifyIL(il, "Launch Velocity: ", "Скорость вылета: ");
        TranslationHelper.ModifyIL(il, "Reelback Velocity: ", "Скорость возврата: ");
        TranslationHelper.ModifyIL(il, "Pull Velocity: ", "Скорость притягивания: ");
    };
}