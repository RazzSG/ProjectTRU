using System.Reflection;
using CalamityMod.Tiles.FurniturePlaguedPlate;
using CalamityRuTranslate.Common.Utilities;
using CalamityRuTranslate.Core.ModCompatibility;
using CalamityRuTranslate.Core.MonoMod;
using MonoMod.Cil;

namespace CalamityRuTranslate.Mods.CalamityMod.MonoMod
{
    [ModDependency("CalamityMod")]
    [CultureDependency("ru-RU")]
    public class PlaguedPlateBedPatch : MonoModPatcher<string>
    {
        public override MethodInfo Method => typeof(PlaguedPlateBed).GetCachedMethod(nameof(PlaguedPlateBed.NewRightClick));

        public override string ModderMethod => nameof(Translation);

        public static void Translation(ILContext il)
        {
            TranslationHelper.ILTranslation(il, "Spawn point removed!", "Точка воскрешения удалена!");
            TranslationHelper.ILTranslation(il, "Spawn point set!", "Точка воскрешения задана!");
        }
    }
}