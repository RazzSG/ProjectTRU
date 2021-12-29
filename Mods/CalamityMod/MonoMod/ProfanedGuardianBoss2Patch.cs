using System.Reflection;
using CalamityMod.NPCs.ProfanedGuardians;
using CalamityRuTranslate.Common.Utilities;
using CalamityRuTranslate.Core.ModCompatibility;
using CalamityRuTranslate.Core.MonoMod;
using MonoMod.Cil;

namespace CalamityRuTranslate.Mods.CalamityMod.MonoMod
{
    [ModDependency("CalamityMod")]
    [CultureDependency("ru-RU")]
    public class ProfanedGuardianBoss2Patch : MonoModPatcher<string>
    {
        public override MethodInfo Method => typeof(ProfanedGuardianBoss2).GetCachedMethod(nameof(ProfanedGuardianBoss2.BossLoot));

        public override string ModderMethod => nameof(Translation);

        public static void Translation(ILContext il)
        {
            TranslationHelper.ILTranslation(il, "A Profaned Guardian", "Осквернённый страж");
        }
    }
}