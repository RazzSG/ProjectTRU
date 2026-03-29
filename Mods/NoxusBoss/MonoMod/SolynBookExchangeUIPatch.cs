using System.Reflection;
using CalamityRuTranslate.Common;
using CalamityRuTranslate.Common.Utilities;
using CalamityRuTranslate.Core.Config;
using CalamityRuTranslate.Core.MonoMod;
using MonoMod.Cil;
using NoxusBoss.Core.Graphics.UI.Books;

namespace CalamityRuTranslate.Mods.NoxusBoss.MonoMod;

public class SolynBookExchangeUIPatch : ILPatcher
{
    public override bool AutoLoad => ModInstances.NoxusBoss != null && TRuConfig.Instance.NoxusBossLocalization && TranslationHelper.IsRussianLanguage;
    
    public override MethodInfo ModifiedMethod => typeof(SolynBookExchangeUI).FindMethod("RenderBookSlots");

    public override ILContext.Manipulator PatchMethod { get; } = il =>
    {
        TranslationHelper.ModifyIL(il , "New!", "Новая");
    };
}