using System.Reflection;
using CalamityRuTranslate.Common;
using CalamityRuTranslate.Common.Utilities;
using CalamityRuTranslate.Core.MonoMod;
using FargowiltasSouls.Content.NPCs.EternityModeNPCs.VanillaEnemies.Jungle;
using MonoMod.Cil;

namespace CalamityRuTranslate.Mods.FargowiltasSouls.MonoMod;

public class GiantTortoisePatch : ILPatcher
{
    public override bool AutoLoad => ModInstances.FargowiltasSouls != null && TranslationHelper.IsRussianLanguage;

    public override MethodInfo ModifiedMethod => typeof(GiantTortoise).GetCachedMethod(nameof(GiantTortoise.SafeOnHitByItem));

    public override ILContext.Manipulator PatchMethod { get; } = il =>
    {
        TranslationHelper.ModifyIL(il, " was impaled by a Giant Tortoise.", " обезглавливается гигантской черепахой.");
    };
}