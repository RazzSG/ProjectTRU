using System;
using System.Reflection;
using CalamityRuTranslate.Common;
using CalamityRuTranslate.Common.Utilities;
using CalamityRuTranslate.Core.Config;
using CalamityRuTranslate.Core.MonoMod;
using Mono.Cecil.Cil;
using MonoMod.Cil;
using Terraria.Localization;

namespace CalamityRuTranslate.Mods.PathOfTerraria.MonoMod;

public class TutorialUIStatePatch : ILPatcher
{
    public override bool AutoLoad => ModInstances.PathOfTerraria != null && TRuConfig.Instance.PathOfTerrariaLocalization && TranslationHelper.IsRussianLanguage;

    public override MethodInfo ModifiedMethod => ModInstances.PathOfTerraria.Code.GetType("PathOfTerraria.Common.UI.Guide.TutorialUIState").FindMethod("DrawBacked");

    public override ILContext.Manipulator PatchMethod { get; } = il =>
    {
        ILCursor c = new ILCursor(il);
        string capturedFullText = string.Empty;
        
        c.Emit(OpCodes.Ldarg_3);
        c.EmitDelegate<Action<string>>(text =>
        {
            capturedFullText = text;
        });
        
        TranslationHelper.ModifyIL(il, 24f, 18f); // расстояние между строками
        
        if (c.TryGotoNext(MoveType.Before, i => i.MatchLdcR4(40f)))
        {
            c.Remove();
            c.EmitDelegate(() =>
            {
                if (capturedFullText == Language.GetText("Mods.PathOfTerraria.UI.Guide.7").Value)
                {
                    return 90f; 
                }
                
                return 50f;
            });
        }
    };
}