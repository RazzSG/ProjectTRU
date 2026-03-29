using System;
using System.Reflection;
using CalamityRuTranslate.Common;
using CalamityRuTranslate.Common.Utilities;
using CalamityRuTranslate.Core.Config;
using CalamityRuTranslate.Core.MonoMod;
using InfernumMode.Content.Credits;
using Microsoft.Xna.Framework;

namespace CalamityRuTranslate.Mods.InfernumMode.MonoMod;

public class CreditAnimationObjectPatch : OnPatcher
{
    public override bool AutoLoad => ModInstances.Infernum != null && TRuConfig.Instance.InfernumModeLocalization && TranslationHelper.IsRussianLanguage;

    public override MethodBase ModifiedMethod => typeof(CreditAnimationObject).GetConstructor([typeof(Vector2), typeof(string), typeof(string), typeof(Color), typeof(bool)]);

    public override Delegate Delegate => Translation;

    private void Translation(Action<CreditAnimationObject, Vector2, string, string, Color, bool> orig, CreditAnimationObject self, Vector2 velocity, string header, string names, Color headerColor, bool swapSides)
    {
        if (names.Contains("Dimension Translate Group"))
            names = names.Replace("Dimension Translate Group\nIndeperevod Team", "Dimension Translate Group\nProject tRU");

        orig(self, velocity, header, names, headerColor, swapSides);

    }
}
 