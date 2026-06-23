using System.Reflection;
using CalamityRuTranslate.Common;
using CalamityRuTranslate.Common.Utilities;
using CalamityRuTranslate.Core.Config;
using CalamityRuTranslate.Core.MonoMod;
using MonoMod.Cil;
using ThoriumMod.NPCs;

namespace CalamityRuTranslate.Mods.ThoriumMod.MonoMod;

public class CookPatch : ILPatcher
{
    public override bool AutoLoad => ModInstances.Thorium != null && TRuConfig.Instance.ThoriumModLocalization && TranslationHelper.IsRussianLanguage;
    
    public override MethodInfo ModifiedMethod => typeof(Cook).FindMethod(nameof(Cook.OnKill));

    public override ILContext.Manipulator PatchMethod { get; } = il =>
    {
        TranslationHelper.ModifyIL(il, "Alfredo", "Альфредо");
        TranslationHelper.ModifyIL(il, "Linguini", "Лингуини");
    };
}