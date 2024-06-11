using System.Reflection;
using CalamityRuTranslate.Common;
using CalamityRuTranslate.Common.Utilities;
using CalamityRuTranslate.Core.Config;
using CalamityRuTranslate.Core.MonoMod;
using Mono.Cecil.Cil;
using MonoMod.Cil;
using NoxusBoss.Assets.Fonts;
using Terraria.ModLoader;

namespace CalamityRuTranslate.Mods.NoxusBoss.MonoMod;

public class FontRegistryPatch : ILPatcher
{
    public override bool AutoLoad => ModInstances.NoxusBoss != null && TRuConfig.Instance.NoxusBossLocalization && TranslationHelper.IsRussianLanguage;

    public override MethodInfo ModifiedMethod => typeof(FontRegistry).GetCachedMethod("get_NamelessDeityText");

    public override ILContext.Manipulator PatchMethod { get; } = il =>
    {
        ILCursor cursor = new(il);
        cursor.TryGotoNext(i => i.MatchCall<ModType>("get_Mod"));
        cursor.Index++;
        cursor.EmitPop();
        cursor.Emit(OpCodes.Ldsfld, typeof(CalamityRuTranslate).GetField("Instance"));
        TranslationHelper.ModifyIL(il, "Assets/Fonts/NamelessDeityText", "Assets/Fonts/FairyMuffinRoundPop");
    };
}