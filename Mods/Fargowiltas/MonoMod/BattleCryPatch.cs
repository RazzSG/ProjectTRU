using System.Reflection;
using CalamityRuTranslate.Common.Utilities;
using CalamityRuTranslate.Core.ModCompatibility;
using CalamityRuTranslate.Core.MonoMod;
using Fargowiltas.Items.Misc;
using MonoMod.Cil;

namespace CalamityRuTranslate.Mods.Fargowiltas.MonoMod
{
    [ModDependency("Fargowiltas")]
    [CultureDependency("ru-RU")]
    public class BattleCryPatch : MonoModPatcher<string>
    {
        public override MethodInfo Method => typeof(BattleCry).GetCachedMethod(nameof(BattleCry.UseItem));

        public override string ModderMethod => nameof(Translation);

        public static void Translation(ILContext il)
        {
            TranslationHelper.ILTranslation(il, "Spawn rates ", "Скорость появления врагов ");
            TranslationHelper.ILTranslation(il, "increased!", "увеличена!");
            TranslationHelper.ILTranslation(il, "decreased!", "снижена!");
        }
    }
}