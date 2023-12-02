using System.Reflection;
using CalamityRuTranslate.Common;
using CalamityRuTranslate.Common.Utilities;
using CalamityRuTranslate.Core.MonoMod;
using InfernumMode.Core.GlobalInstances.Systems;
using MonoMod.Cil;

namespace CalamityRuTranslate.Mods.InfernumMode.MonoMod;

public class CustomExoMechSelectionSystemDrawWrapperPatch : ILPatcher
{
    public override bool AutoLoad => ModInstances.Infernum != null && ModInstances.Calamity != null && TranslationHelper.IsRussianLanguage;
    
    public override MethodInfo ModifiedMethod => typeof(CustomExoMechSelectionSystem).GetCachedMethod(nameof(CustomExoMechSelectionSystem.DrawWrapper));

    public override ILContext.Manipulator PatchMethod { get; } = il =>
    {
        TranslationHelper.ModifyIL(il, "Pick two. The first mech will be fought alone. Once sufficiently damaged, the second mech will be summoned and the two will fight together.", "Выбери двоих. Первый экзо-мех будет сражаться в одиночку. Когда он получит достаточно урона, то появится второй экзо-мех, и они будут сражаться вместе.");
        TranslationHelper.ModifyIL(il, 50f, 25f);
    };
}