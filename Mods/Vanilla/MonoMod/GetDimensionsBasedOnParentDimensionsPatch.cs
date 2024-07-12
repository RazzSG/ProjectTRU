using System;
using System.Reflection;
using CalamityRuTranslate.Common;
using CalamityRuTranslate.Common.Utilities;
using CalamityRuTranslate.Core.Config;
using CalamityRuTranslate.Core.MonoMod;
using CalamityRuTranslate.Mods.StarsAbove;
using Terraria.UI;

namespace CalamityRuTranslate.Mods.Vanilla.MonoMod;

public class GetDimensionsBasedOnParentDimensionsPatch : OnPatcher
{
    private delegate CalculatedStyle GetDimensionsBasedOnParentDimensionsDelegate(UIElement self, CalculatedStyle parentDimensions);
    
    public override bool AutoLoad => TranslationHelper.IsRussianLanguage;

    public override MethodInfo ModifiedMethod => typeof(UIElement).GetCachedMethod("GetDimensionsBasedOnParentDimensions");

    public override Delegate Delegate => Translation;

    private CalculatedStyle Translation(GetDimensionsBasedOnParentDimensionsDelegate orig, UIElement self, CalculatedStyle parentDimensions)
    {
        if (ModInstances.StarsAbove != null && TRuConfig.Instance.StarsAboveLocalization)
        {
            if (StarsAboveSystem.CelestialCartographyActive)
            {
                self.Top.Pixels = self.Top.Pixels switch
                {
                    524f => 564f,
                    546f => 586f,
                    568f => 608f,
                    _ => self.Top.Pixels
                };
            }

            if (StarsAboveSystem.NovaUIActive)
            {
                if (self.Width.Pixels == 1000 && self.Height.Pixels == 700)
                    self.Height.Pixels = 730;
                
                if (self.Left.Pixels == 864)
                    self.Left.Pixels = 908;

                if (self.Top.Pixels == 587)
                    self.Top.Pixels = 590;
            }
        }

        return orig.Invoke(self, parentDimensions);
    }
}