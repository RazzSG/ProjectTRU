using System;
using System.Reflection;
using CalamityRuTranslate.Common;
using CalamityRuTranslate.Common.Utilities;
using CalamityRuTranslate.Core.Config;
using CalamityRuTranslate.Core.MonoMod;
using Microsoft.Xna.Framework;
using Terraria.UI.Chat;

namespace CalamityRuTranslate.Mods.PathOfTerraria.MonoMod;

public class ParsePatch : OnPatcher
{
    public override bool AutoLoad => ModInstances.PathOfTerraria != null && TRuConfig.Instance.PathOfTerrariaLocalization && TranslationHelper.IsRussianLanguage;

    public override MethodInfo ModifiedMethod => ModInstances.PathOfTerraria.Code.GetType("PathOfTerraria.Common.NPCs.Dialogue.MechanicsTagHandler").FindMethod("Parse");

    public override Delegate Delegate => Translation;

    private TextSnippet Translation(Func<object, string, Color, string?, TextSnippet> orig, object self, string text,
        Color baseColor, string? options)
    {
        string mechanic = text;
        string? customText = null;

        if (text.Contains("::"))
        {
            string[] parts = text.Split(["::"], StringSplitOptions.None);
            mechanic = parts[0];
            customText = parts[1];
        }

        TextSnippet snippet = orig.Invoke(self, mechanic, baseColor, options);

        if (customText != null && snippet != null)
        {
            snippet.Text = customText;
        }

        return snippet;
    }
}

public class TagPatch : OnPatcher
{
    public override bool AutoLoad => ModInstances.PathOfTerraria != null && TRuConfig.Instance.PathOfTerrariaLocalization && TranslationHelper.IsRussianLanguage;

    public override MethodInfo ModifiedMethod => ModInstances.PathOfTerraria.Code.GetType("PathOfTerraria.Common.NPCs.Dialogue.MechanicsTagHandler+MechanicsTextSnippet").FindMethod("get_Tag");

    public override Delegate Delegate => Translation;

    private string Translation(Func<TextSnippet, string> orig, TextSnippet self)
    {
        if (!string.IsNullOrEmpty(self.Text))
        {
            return self.Text;
        }
        
        return orig.Invoke(self);
    }
}