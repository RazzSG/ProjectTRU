using System.Reflection;
using CalamityRuTranslate.Common;
using CalamityRuTranslate.Common.Utilities;
using CalamityRuTranslate.Core.MonoMod;
using InfernumMode.Content.Items.Accessories;
using MonoMod.Cil;

namespace CalamityRuTranslate.Mods.InfernumMode.MonoMod;

public class SakuraBloomPatch : ILPatcher
{
    public override bool AutoLoad => ModInstances.Infernum != null && ModInstances.Calamity != null && TranslationHelper.IsRussianLanguage;
    
    public override MethodInfo ModifiedMethod => typeof(SakuraBloom).GetCachedMethod(nameof(SakuraBloom.PreDrawTooltipLine));

    public override ILContext.Manipulator PatchMethod { get; } = il =>
    {
        TranslationHelper.ModifyIL(il, "A symbol of how beautiful love is when in bloom, and how easily it can wither away", "Символ того, как прекрасна любовь, когда она расцветает, и того, как легко она может увянуть");
        TranslationHelper.ModifyIL(il, "A symbol of how beautiful ", "Символ того, как прекрасна ");
        TranslationHelper.ModifyIL(il, "love", "любовь");
        TranslationHelper.ModifyIL(il, " is when it’s in bloom, and yet how easily it can wither away", ", когда она расцветает, и того, как легко она может увянуть");
        TranslationHelper.ModifyIL(il, "Temporary", "Заглушка");
        TranslationHelper.ModifyIL(il, "Maybe with this, we can hold onto the ", "Может быть, с её помощью мы сможем сохранить в памяти те прекрасные ");
        TranslationHelper.ModifyIL(il, "memories", "воспоминания");
    };
}