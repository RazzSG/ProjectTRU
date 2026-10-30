using System.Collections.Generic;
using System.Linq;
using CalamityRuTranslate.Common.Utilities;
using Terraria.GameContent.UI.Elements;
using Terraria.GameContent.UI.States;
using Terraria.ModLoader;
using Terraria.UI;

namespace CalamityRuTranslate.Mods.Vanilla.MonoMod;

public class UIWorldCreationPatch : ILoadable
{
    public bool IsLoadingEnabled(Mod mod)
    {
        return TranslationHelper.IsRussianLanguage;
    }

    public void Load(Mod mod)
    {
        On_UIWorldCreation.AddDescriptionPanel += UIWorldCreationOnAddDescriptionPanel;
        On_UIWorldCreation.BuildPage += UIWorldCreationOnBuildPage;
    }

    public void Unload()
    {
        On_UIWorldCreation.AddDescriptionPanel -= UIWorldCreationOnAddDescriptionPanel;
        On_UIWorldCreation.BuildPage -= UIWorldCreationOnBuildPage;
    }

    private static void UIWorldCreationOnBuildPage(On_UIWorldCreation.orig_BuildPage orig, UIWorldCreation self)
    {
        orig.Invoke(self);

        UIElement root = self.Children.FirstOrDefault();
        if (root == null || root.Width.Pixels != 500f)
            return;
        
        const float extraWidth = 120f;
        root.Width = StyleDimension.FromPixels(620f);
        
        foreach (UIElement element in Descendants(self))
        {
            string typeName = element.GetType().FullName;

            if (typeName == "FargoSeeds.UI.WorldGenMenu.UIWorldGenTab")
            {
                element.Left.Set(element.Left.Pixels + extraWidth / 2f, element.Left.Percent);
            }
            else if (typeName is "FargoSeeds.UI.WorldGenMenu.UIWorldGenToggle" or "FargoSeeds.UI.WorldGenMenu.UIWorldGenSlider")
            {
                element.Width.Set(element.Width.Pixels + extraWidth / 2f, element.Width.Percent);
            }
        }

        self.Recalculate();
    }

    private static IEnumerable<UIElement> Descendants(UIElement parent)
    {
        foreach (UIElement child in parent.Children)
        {
            yield return child;

            foreach (UIElement descendant in Descendants(child))
                yield return descendant;
        }
    }

    private static void UIWorldCreationOnAddDescriptionPanel(On_UIWorldCreation.orig_AddDescriptionPanel orig, UIWorldCreation self, UIElement container, float accumulatedHeight, string tagGroup)
    {
        HashSet<UIElement> existingChildren = [.. container.Children];

        orig.Invoke(self, container, accumulatedHeight, tagGroup);

        foreach (UIElement panel in container.Children)
        {
            if (existingChildren.Contains(panel) || panel is not UISlicedImage)
                continue;

            foreach (UIElement child in panel.Children)
            {
                if (child is not UIText description)
                    continue;

                description.PaddingTop = 0f;
                description.IsWrapped = true;
            }
        }
    }
}