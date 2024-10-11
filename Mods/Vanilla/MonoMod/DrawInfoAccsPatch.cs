using System.Reflection;
using CalamityRuTranslate.Common.Utilities;
using CalamityRuTranslate.Core.MonoMod;
using Mono.Cecil.Cil;
using MonoMod.Cil;
using Terraria;

namespace CalamityRuTranslate.Mods.Vanilla.MonoMod;

public class DrawInfoAccsPatch : ILPatcher
{
    public override bool AutoLoad => TranslationHelper.IsRussianLanguage;

    public override MethodInfo ModifiedMethod => typeof(Main).GetCachedMethod("DrawInfoAccs");

    public override ILContext.Manipulator PatchMethod { get; } = il =>
    {
        // 12-часовой формат в 24-часовой
        TranslationHelper.ModifyIL(il, 12, 24);
        TranslationHelper.ModifyIL(il, 12, 0, 3);
        // мили в километры
        ILCursor cursor = new ILCursor(il);
        if (cursor.TryGotoNext(MoveType.After, i => i.MatchLdstr("GameUI.Speed")))
        {
            cursor.Emit(OpCodes.Ldloc, 50);
            cursor.Emit(OpCodes.Ldc_R4, 1.60934f);
            cursor.Emit(OpCodes.Mul);
            cursor.Emit(OpCodes.Stloc, 50);
        }
    };
}