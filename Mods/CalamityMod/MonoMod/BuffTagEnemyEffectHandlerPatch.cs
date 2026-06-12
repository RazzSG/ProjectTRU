using System;
using System.Reflection;
using CalamityMod.ChatTags;
using CalamityRuTranslate.Common;
using CalamityRuTranslate.Common.Utilities;
using CalamityRuTranslate.Core.Config;
using CalamityRuTranslate.Core.MonoMod;
using Mono.Cecil.Cil;
using MonoMod.Cil;
using ReLogic.Graphics;
using Terraria;

namespace CalamityRuTranslate.Mods.CalamityMod.MonoMod;

public class BuffTagEnemyEffectHandlerUniqueDrawPatch : ILPatcher
{
    public override bool AutoLoad => ModInstances.Calamity != null && TRuConfig.Instance.CalamityModLocalization && TranslationHelper.IsRussianLanguage;
    
    public override MethodInfo ModifiedMethod => typeof(BuffTagEnemyEffectHandler.Snippet).FindMethod(nameof(BuffTagEnemyEffectHandler.Snippet.UniqueDraw));

    public override ILContext.Manipulator PatchMethod { get; } = il =>
    {
        ILCursor cursor = new ILCursor(il);
        
        TranslationHelper.ModifyIL(il, " ", " «");
        TranslationHelper.ModifyIL(il, 26f, 22f, 2);

        if (cursor.TryGotoNext(MoveType.Before, i => i.MatchCall(typeof(string), nameof(string.Concat))))
        {
            cursor.Emit(OpCodes.Ldstr, "»");
            cursor.Remove();
            cursor.Emit(OpCodes.Call, typeof(string).GetMethod(nameof(string.Concat), new [] { typeof(string), typeof(string), typeof(string) }));
        }
    };
}

public class BuffTagEnemyEffectHandlerGetStringLengthPatch : OnPatcher
{
    public override bool AutoLoad => ModInstances.Calamity != null && TRuConfig.Instance.CalamityModLocalization && TranslationHelper.IsRussianLanguage;
    
    public override MethodInfo ModifiedMethod => typeof(BuffTagEnemyEffectHandler.Snippet).FindMethod(nameof(BuffTagEnemyEffectHandler.Snippet.GetStringLength));
    
    public override Delegate Delegate => Translation;

    private float Translation(Func<BuffTagEnemyEffectHandler.Snippet, DynamicSpriteFont, float> orig, BuffTagEnemyEffectHandler.Snippet self, DynamicSpriteFont font)
    {
        return (!self.DrawIcon ? 0f : 22f + font.MeasureString(" «").X) + font.MeasureString(Lang.GetBuffName(self.BuffId)).X + font.MeasureString("»").X * self.Scale;
    }
}