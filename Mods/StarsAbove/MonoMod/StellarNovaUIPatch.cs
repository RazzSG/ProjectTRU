using System;
using System.Reflection;
using CalamityRuTranslate.Common;
using CalamityRuTranslate.Common.Utilities;
using CalamityRuTranslate.Core.Config;
using CalamityRuTranslate.Core.MonoMod;
using Microsoft.Xna.Framework;
using Mono.Cecil.Cil;
using MonoMod.Cil;
using Terraria.GameContent.UI.Elements;
using Terraria.UI;

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
        
        TranslationHelper.ModifyIL(il, 587f, 590f);
        
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

        cursor.Goto(il.Instrs.Count - 1);
        cursor.Emit(OpCodes.Ldarg_0);
        cursor.EmitDelegate<Action<object>>(self =>
        {
            UIElement area = self.GetMemberValue<UIElement>("area");
            UIImageButton prototokia = self.GetMemberValue<UIImageButton>("prototokia");
            UIImageButton laevateinn = self.GetMemberValue<UIImageButton>("laevateinn");
            UIImageButton kiwamiryuken = self.GetMemberValue<UIImageButton>("kiwamiryuken");
            UIImageButton gardenofavalon = self.GetMemberValue<UIImageButton>("gardenofavalon");
            UIImageButton edingenesisquasar = self.GetMemberValue<UIImageButton>("edingenesisquasar");
            UIImageButton unlimitedbladeworks = self.GetMemberValue<UIImageButton>("unlimitedbladeworks");
            UIImageButton guardianslight = self.GetMemberValue<UIImageButton>("guardianslight");
            UIImageButton fireflytypeiv = self.GetMemberValue<UIImageButton>("fireflytypeiv");
            UIImageButton origininfinity = self.GetMemberValue<UIImageButton>("origininfinity");
            area.Height.Set(730f, 0f);
            prototokia.Left.Set(908f, 0f);
            laevateinn.Left.Set(908f, 0f);
            kiwamiryuken.Left.Set(908f, 0f);
            gardenofavalon.Left.Set(908f, 0f);
            edingenesisquasar.Left.Set(908f, 0f);
            unlimitedbladeworks.Left.Set(908f, 0f);
            guardianslight.Left.Set(908f, 0f);
            fireflytypeiv.Left.Set(908f, 0f);
            origininfinity.Left.Set(908f, 0f);
        });
    };
}

public class StellarNovaUIOnPatch : OnPatcher
{
    public override bool AutoLoad => ModInstances.StarsAbove != null && TRuConfig.Instance.StarsAboveLocalization && TranslationHelper.IsRussianLanguage;

    public override MethodInfo ModifiedMethod => ModInstances.StarsAbove.Code.GetType("StarsAbove.UI.StellarNova.StellarNovaUI").FindMethod("Update");
    
    public override Delegate Delegate => Translation;

    private void Translation(Action<object, GameTime> orig, object self, GameTime gameTime)
    {
        orig.Invoke(self, gameTime);
        
        UIText abilityDescription = self.GetMemberValue<UIText>("abilityDescription");
        abilityDescription.Top.Set(375f, 0f);
    }
}