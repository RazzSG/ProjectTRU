using System.Reflection;
using CalamityRuTranslate.Common;
using CalamityRuTranslate.Common.Utilities;
using CalamityRuTranslate.Core.Config;
using CalamityRuTranslate.Core.MonoMod;
using Mono.Cecil.Cil;
using MonoMod.Cil;
using Terraria.GameContent.UI.Elements;

namespace CalamityRuTranslate.Mods.StarsAbove.MonoMod;

public class StellarNovaUIPatch : ILPatcher
{
    public override bool AutoLoad => ModInstances.StarsAbove != null && TRuConfig.Instance.StarsAboveLocalization && TranslationHelper.IsRussianLanguage;

    public override MethodInfo ModifiedMethod => ModInstances.StarsAbove.Code.GetType("StarsAbove.UI.StellarNova.StellarNovaUI").FindMethod("Update");
    
    public override ILContext.Manipulator PatchMethod { get; } = il =>
    {
        ILCursor cursor = new ILCursor(il);
        cursor.TryGotoNext(MoveType.After, i => i.MatchLdfld("StarsAbove.StarsAbovePlayer", "baseStats"));
        cursor.RemoveRange(3); // dup, brtrue, pop
        cursor.Emit(OpCodes.Ldc_R4, 0.625f);
        cursor.Emit(OpCodes.Ldc_I4_0);
        cursor.Emit(OpCodes.Callvirt, typeof(UIText).GetMethod("SetText", new[] { typeof(string), typeof(float), typeof(bool) }));
        cursor.RemoveRange(2); // ldstr, callvirt

        cursor.TryGotoNext(MoveType.After, i => i.MatchLdfld("StarsAbove.StarsAbovePlayer", "modStats"));
        cursor.RemoveRange(3); // dup, brtrue, pop
        cursor.Emit(OpCodes.Ldc_R4, 0.625f);
        cursor.Emit(OpCodes.Ldc_I4_0);
        cursor.Emit(OpCodes.Callvirt, typeof(UIText).GetMethod("SetText", new[] { typeof(string), typeof(float), typeof(bool) }));
        cursor.RemoveRange(2); // ldstr, callvirt
        
        // cursor.TryGotoNext(MoveType.After, i => i.MatchLdcR4(452f));
        // cursor.TryGotoNext(MoveType.After, i => i.MatchLdcR4(0f));
        // cursor.TryGotoNext(MoveType.After, i => i.MatchCall(typeof(StyleDimension).GetMethod("Set")));
        // cursor.TryGotoNext(MoveType.After, i => i.MatchLdarg0());
        // cursor.TryGotoNext(MoveType.After, i => i.MatchLdfld("StarsAbove.StarsAbovePlayer", "setBonusInfo"));
        // cursor.GotoPrev(i => i.MatchLdloc(1));
        // cursor.RemoveRange(7);
        // cursor.Emit(OpCodes.Ldsfld, typeof(FontAssets).GetField("MouseText"));
        // cursor.Emit(OpCodes.Callvirt, typeof(Asset<DynamicSpriteFont>).GetMethod("get_Value"));
        // cursor.Emit(OpCodes.Ldloc_1);
        // cursor.Emit(OpCodes.Ldfld, typeof(StarsAbovePlayer).GetField("setBonusInfo"));
        // cursor.Emit(OpCodes.Ldc_R4, 680f);
        // cursor.Emit(OpCodes.Callvirt, typeof(DynamicSpriteFont).GetMethod("CreateWrappedText", new []{ typeof(string), typeof(float) }));
        // cursor.Emit(OpCodes.Callvirt, typeof(UIText).GetMethod("SetText", new[] { typeof(string) }));
    };
}