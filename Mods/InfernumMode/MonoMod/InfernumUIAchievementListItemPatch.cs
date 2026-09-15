using System.Reflection;
using CalamityRuTranslate.Common;
using CalamityRuTranslate.Common.Utilities;
using CalamityRuTranslate.Core.Config;
using CalamityRuTranslate.Core.MonoMod;
using InfernumMode.Content.Achievements;
using InfernumMode.Content.UI;
using Microsoft.Xna.Framework;
using Mono.Cecil.Cil;
using MonoMod.Cil;

namespace CalamityRuTranslate.Mods.InfernumMode.MonoMod;

public class DrawSelfPatch : ILPatcher
{
    public override bool AutoLoad => ModInstances.Infernum != null && TRuConfig.Instance.InfernumModeLocalization && TranslationHelper.IsRussianLanguage;
    
    public override MethodInfo ModifiedMethod => typeof(InfernumUIAchievementListItem).FindMethod("DrawSelf");

    public override ILContext.Manipulator PatchMethod { get; } = il =>
    {
        ILCursor c = new ILCursor(il);

        if (c.TryGotoNext(MoveType.Before, x => x.MatchLdloc(14), x => x.MatchLdloc(11), x => x.MatchLdcR4(0f)))
        {
            c.Index++;
            c.Remove();
            c.Emit(OpCodes.Ldc_I4, 119);
            c.Emit(OpCodes.Ldc_I4, 119);
            c.Emit(OpCodes.Ldc_I4, 119);
            c.Emit(OpCodes.Newobj, typeof(Color).GetConstructor(new[] { typeof(int), typeof(int), typeof(int) }));
        }
        
        // Увеличиваем длину для переноса текста на новую строку
        TranslationHelper.ModifyIL(il, 20f, -30f);
    };
}

public class AchievementPatch : ILPatcher
{
    public override bool AutoLoad => ModInstances.Infernum != null && TRuConfig.Instance.InfernumModeLocalization && TranslationHelper.IsRussianLanguage;

    public override MethodBase ModifiedMethod => typeof(InfernumUIAchievementListItem).FindConstructor(typeof(Achievement), typeof(bool));

    public override ILContext.Manipulator PatchMethod { get; } = il =>
    {
        TranslationHelper.ModifyIL(il, 66f, 72f);
        TranslationHelper.ModifyIL(il, "InfernumMode/Content/Achievements/Textures/InfernumAchievement_InnerPanelBottom_Large", "CalamityRuTranslate/Assets/Sprites/Infernum/InfernumAchievement_InnerPanelBottom_Large");
    };
}