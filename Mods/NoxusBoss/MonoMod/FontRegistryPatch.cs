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

public class DraedonTextPatch : ILPatcher
{
    public override bool AutoLoad => ModInstances.NoxusBoss != null && TRuConfig.Instance.NoxusBossLocalization && TranslationHelper.IsRussianLanguage;

    public override MethodInfo ModifiedMethod => typeof(FontRegistry).GetCachedMethod("get_DraedonText");

    public override ILContext.Manipulator PatchMethod { get; } = il =>
    {
        ILCursor cursor = new ILCursor(il);
        cursor.TryGotoNext(MoveType.After, i => i.MatchCall<ModType>("get_Mod"));
        cursor.EmitPop();
        cursor.Emit(OpCodes.Ldsfld, typeof(CalamityRuTranslate).GetField("Instance"));
        TranslationHelper.ModifyIL(il, "Assets/Fonts/DraedonText", "Assets/Fonts/Item_Stack");
    };
}

public class NamelessDeityTextPatch : ILPatcher
{
    public override bool AutoLoad => ModInstances.NoxusBoss != null && TRuConfig.Instance.NoxusBossLocalization && TranslationHelper.IsRussianLanguage;

    public override MethodInfo ModifiedMethod => typeof(FontRegistry).GetCachedMethod("get_NamelessDeityText");

    public override ILContext.Manipulator PatchMethod { get; } = il =>
    {
        ILCursor cursor = new ILCursor(il);
        cursor.TryGotoNext(MoveType.After, i => i.MatchCall<ModType>("get_Mod"));
        cursor.EmitPop();
        cursor.Emit(OpCodes.Ldsfld, typeof(CalamityRuTranslate).GetField("Instance"));
        TranslationHelper.ModifyIL(il, "Assets/Fonts/NamelessDeityTextRussian", "Assets/Fonts/FairyMuffinRoundPop");
    };
}

public class SolynTextPatch : ILPatcher
{
    public override bool AutoLoad => ModInstances.NoxusBoss != null && TRuConfig.Instance.NoxusBossLocalization && TranslationHelper.IsRussianLanguage;

    public override MethodInfo ModifiedMethod => typeof(FontRegistry).GetCachedMethod("get_SolynText");

    public override ILContext.Manipulator PatchMethod { get; } = il =>
    {
        ILCursor cursor = new ILCursor(il);
        cursor.TryGotoNext(MoveType.After, i => i.MatchCall<ModType>("get_Mod"));
        cursor.EmitPop();
        cursor.Emit(OpCodes.Ldsfld, typeof(CalamityRuTranslate).GetField("Instance"));
        TranslationHelper.ModifyIL(il, "Assets/Fonts/NamelessDeityTextRussian", "Assets/Fonts/Death_Text");
    };
}

public class SolynTextItalicsPatch : ILPatcher
{
    public override bool AutoLoad => ModInstances.NoxusBoss != null && TRuConfig.Instance.NoxusBossLocalization && TranslationHelper.IsRussianLanguage;

    public override MethodInfo ModifiedMethod => typeof(FontRegistry).GetCachedMethod("get_SolynTextItalics");

    public override ILContext.Manipulator PatchMethod { get; } = il =>
    {
        ILCursor cursor = new ILCursor(il);
        cursor.TryGotoNext(MoveType.After, i => i.MatchCall<ModType>("get_Mod"));
        cursor.EmitPop();
        cursor.Emit(OpCodes.Ldsfld, typeof(CalamityRuTranslate).GetField("Instance"));
        TranslationHelper.ModifyIL(il, "Assets/Fonts/SolynTextItalicsRussian", "Assets/Fonts/SolynTextItalics");
    };
}

public class SolynFightDialoguePatch : ILPatcher
{
    public override bool AutoLoad => ModInstances.NoxusBoss != null && TRuConfig.Instance.NoxusBossLocalization && TranslationHelper.IsRussianLanguage;

    public override MethodInfo ModifiedMethod => typeof(FontRegistry).GetCachedMethod("get_SolynFightDialogue");

    public override ILContext.Manipulator PatchMethod { get; } = il =>
    {
        ILCursor cursor = new ILCursor(il);
        cursor.TryGotoNext(MoveType.After, i => i.MatchCall<ModType>("get_Mod"));
        cursor.EmitPop();
        cursor.Emit(OpCodes.Ldsfld, typeof(CalamityRuTranslate).GetField("Instance"));
        TranslationHelper.ModifyIL(il, "Assets/Fonts/SolynFightDialogue", "Assets/Fonts/SolynFightDialogue");
    };
}

public class AvatarPoemTextPatch : ILPatcher
{
    public override bool AutoLoad => ModInstances.NoxusBoss != null && TRuConfig.Instance.NoxusBossLocalization && TranslationHelper.IsRussianLanguage;

    public override MethodInfo ModifiedMethod => typeof(FontRegistry).GetCachedMethod("get_AvatarPoemText");

    public override ILContext.Manipulator PatchMethod { get; } = il =>
    {
        ILCursor cursor = new ILCursor(il);
        cursor.TryGotoNext(MoveType.After, i => i.MatchCall<ModType>("get_Mod"));
        cursor.EmitPop();
        cursor.Emit(OpCodes.Ldsfld, typeof(CalamityRuTranslate).GetField("Instance"));
        TranslationHelper.ModifyIL(il, "Assets/Fonts/AvatarPoemTextRussian", "Assets/Fonts/AvatarPoemText");
    };
}