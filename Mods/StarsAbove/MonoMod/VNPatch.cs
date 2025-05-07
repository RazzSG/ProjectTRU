using System.Reflection;
using CalamityRuTranslate.Common;
using CalamityRuTranslate.Common.Utilities;
using CalamityRuTranslate.Core.Config;
using CalamityRuTranslate.Core.MonoMod;
using Mono.Cecil.Cil;
using MonoMod.Cil;
using Terraria.GameContent.UI.Elements;

namespace CalamityRuTranslate.Mods.StarsAbove.MonoMod;

public class VNPatch : ILPatcher
{
    public override bool AutoLoad => ModInstances.StarsAbove != null && TRuConfig.Instance.StarsAboveLocalization && TranslationHelper.IsRussianLanguage;

    public override MethodInfo ModifiedMethod => ModInstances.StarsAbove.Code.GetType("StarsAbove.UI.VN.VN").FindMethod("Update");
    
    public override ILContext.Manipulator PatchMethod { get; } = il =>
    {
        ILCursor cursor = new ILCursor(il);
        cursor.TryGotoNext(MoveType.After, i => i.MatchLdfld("StarsAbove.StarsAbovePlayer", "animatedDialogue"));
        cursor.RemoveRange(3); // dup, brtrue, pop
        cursor.Emit(OpCodes.Ldc_R4, 1.05f);
        cursor.Emit(OpCodes.Ldc_I4_0);
        cursor.Emit(OpCodes.Callvirt, typeof(UIText).GetMethod("SetText", new[] { typeof(string), typeof(float), typeof(bool) }));
        cursor.RemoveRange(2); // ldstr, callvirt
    };
}