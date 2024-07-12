using System.Reflection;
using CalamityRuTranslate.Common;
using CalamityRuTranslate.Common.Utilities;
using CalamityRuTranslate.Core.Config;
using CalamityRuTranslate.Core.MonoMod;
using MonoMod.Cil;
using StarsAbove.Buffs.Melee.BurningDesire;

namespace CalamityRuTranslate.Mods.StarsAbove.MonoMod;

public class PowerStrikeBuffPatch : ILPatcher
{
    public override bool AutoLoad => ModInstances.StarsAbove != null && TRuConfig.Instance.StarsAboveLocalization && TranslationHelper.IsRussianLanguage;
        
    public override MethodInfo ModifiedMethod => typeof(PowerStrikeBuff).GetCachedMethod(nameof(PowerStrikeBuff.ModifyBuffText));

    public override ILContext.Manipulator PatchMethod { get; } = il =>
    {
        TranslationHelper.ModifyIL(il, "BuffDescription.PowerStrikeBuff", "Buffs.PowerStrikeBuff.Description");
    };
}