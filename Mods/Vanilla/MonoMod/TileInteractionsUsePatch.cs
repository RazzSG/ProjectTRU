using System.Reflection;
using CalamityRuTranslate.Common.Utilities;
using CalamityRuTranslate.Core.MonoMod;
using MonoMod.Cil;
using Terraria;

namespace CalamityRuTranslate.Mods.Vanilla.MonoMod;

public class TileInteractionsUsePatch : ILPatcher
{
    public override bool AutoLoad => TranslationHelper.IsRussianLanguage;

    public override MethodInfo ModifiedMethod => typeof(Player).FindMethod("TileInteractionsUse");

    public override ILContext.Manipulator PatchMethod { get; } = il =>
    {
        // 12-часовой формат в 24-часовой
        TranslationHelper.ModifyIL(il, 12, 24);
        TranslationHelper.ModifyIL(il, 12, 0, 3);
    };
}