using System.Reflection;
using CalamityMod.Tiles.FurniturePlaguedPlate;
using CalamityRuTranslate.Common;
using CalamityRuTranslate.Common.Utilities;
using CalamityRuTranslate.Core.MonoMod;
using MonoMod.Cil;

namespace CalamityRuTranslate.Mods.CalamityMod.MonoMod;

public class PlaguedPlateBedPatch : ILPatcher
{
    public override bool AutoLoad => ModInstances.Calamity != null && TranslationHelper.IsRussianLanguage;
        
    public override MethodInfo ModifiedMethod => typeof(PlaguedPlateBed).GetCachedMethod(nameof(PlaguedPlateBed.RightClick));

    public override ILContext.Manipulator PatchMethod { get; } = il =>
    {
        TranslationHelper.ModifyIL(il, "Spawn point removed!", "Точка воскрешения удалена!");
        TranslationHelper.ModifyIL(il, "Spawn point set!", "Точка воскрешения задана!");
    };
}