using System.Reflection;
using CalamityMod.NPCs.Perforator;
using CalamityRuTranslate.Common;
using CalamityRuTranslate.Common.Utilities;
using CalamityRuTranslate.Core.MonoMod;
using MonoMod.Cil;
using Terraria.ModLoader;

namespace CalamityRuTranslate.Mods.CalamityMod.MonoMod;

[JITWhenModsEnabled("CalamityMod")]
public class PerforatorHeadSmallPatch : Patch<ILContext.Manipulator>
{
    public override bool AutoLoad => ModsCall.TryGetCalamity && TranslationHelper.IsRussianLanguage;
        
    public override MethodInfo ModifiedMethod => typeof(PerforatorHeadSmall).GetCachedMethod(nameof(PerforatorHeadSmall.BossLoot));

    public override ILContext.Manipulator PatchMethod { get; } = il =>
    {
        TranslationHelper.ModifyIL(il, "The Small Perforator", "Перфоратор");
    };
}