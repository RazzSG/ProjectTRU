using System.Reflection;
using CalamityRuTranslate.Common;
using CalamityRuTranslate.Common.Utilities;
using CalamityRuTranslate.Core.Config;
using CalamityRuTranslate.Core.MonoMod;
using Mono.Cecil.Cil;
using MonoMod.Cil;
using NoxusBoss.Content.NPCs.Bosses.NamelessDeity;
using Terraria.ModLoader;

namespace CalamityRuTranslate.Mods.NoxusBoss.MonoMod;

public class NamelessDeityBossPatch : ILPatcher
{
    public override bool AutoLoad => ModInstances.NoxusBoss != null && TRuConfig.Instance.NoxusBossLocalization && TranslationHelper.IsRussianLanguage;

    public override MethodInfo ModifiedMethod => typeof(NamelessDeityBoss).GetCachedMethod(nameof(NamelessDeityBoss.DoBehavior_RodOfHarmonyRant));
    public override ILContext.Manipulator PatchMethod { get; } = il =>
    {
        ILCursor cursor = new ILCursor(il);
        cursor.TryGotoNext(i => i.MatchCall<ModType>("get_Mod"));
        cursor.Index++;
        cursor.EmitPop();
        cursor.Emit(OpCodes.Ldsfld, typeof(CalamityRuTranslate).GetField("Instance"));
    };
}