using System.Reflection;
using CalamityRuTranslate.Common;
using CalamityRuTranslate.Common.Utilities;
using CalamityRuTranslate.Core.Config;
using CalamityRuTranslate.Core.MonoMod;
using MonoMod.Cil;

namespace CalamityRuTranslate.Mods.PathOfTerraria.MonoMod;

public class CollectCountPatch : ILPatcher
{
    public override bool AutoLoad => ModInstances.PathOfTerraria != null && TRuConfig.Instance.PathOfTerrariaLocalization && TranslationHelper.IsRussianLanguage;

    public override MethodInfo ModifiedMethod => ModInstances.PathOfTerraria.Code.GetType("PathOfTerraria.Common.Systems.Questing.QuestStepTypes.CollectCount").FindMethod("DisplayString");

    public override ILContext.Manipulator PatchMethod { get; } = il =>
    {
        TranslationHelper.ModifyIL(il, "Collect ", "Собрать ");
    };
}