using System.Reflection;
using CalamityRuTranslate.Common;
using CalamityRuTranslate.Common.Utilities;
using CalamityRuTranslate.Core.MonoMod;
using FargowiltasSouls.Content.Projectiles.Masomode;
using MonoMod.Cil;

namespace CalamityRuTranslate.Mods.FargowiltasSouls.MonoMod;

public class FakeHeartPatch : ILPatcher
{
    public override bool AutoLoad => ModInstances.FargowiltasSouls != null && TranslationHelper.IsRussianLanguage;

    public override MethodInfo ModifiedMethod => typeof(FakeHeart).GetCachedMethod(nameof(FakeHeart.CanHitPlayer));

    public override ILContext.Manipulator PatchMethod { get; } = il =>
    {
        TranslationHelper.ModifyIL(il, " was deceived by Fake Heart.", " обманывается ложным сердцем.");
    };
}