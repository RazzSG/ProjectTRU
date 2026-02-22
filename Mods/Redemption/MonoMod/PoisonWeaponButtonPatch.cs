using System.Reflection;
using CalamityRuTranslate.Common;
using CalamityRuTranslate.Common.Utilities;
using CalamityRuTranslate.Core.Config;
using CalamityRuTranslate.Core.MonoMod;
using MonoMod.Cil;
using Redemption.NPCs.Friendly.TownNPCs;

namespace CalamityRuTranslate.Mods.Redemption.MonoMod;

public class PoisonWeaponButtonPatch : ILPatcher
{
    public override bool AutoLoad => ModInstances.Redemption != null && TRuConfig.Instance.RedemptionLocalization && TranslationHelper.IsRussianLanguage;
        
    public override MethodInfo ModifiedMethod => typeof(PoisonWeaponButton).FindMethod(nameof(PoisonWeaponButton.ModifyPosition));

    public override ILContext.Manipulator PatchMethod { get; } = il =>
    {
        TranslationHelper.ModifyIL(il, 56f, 46f);
    };
}