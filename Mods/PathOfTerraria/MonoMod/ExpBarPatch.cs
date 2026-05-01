using System;
using System.Reflection;
using CalamityRuTranslate.Common;
using CalamityRuTranslate.Common.Utilities;
using CalamityRuTranslate.Core.Config;
using CalamityRuTranslate.Core.MonoMod;
using MonoMod.Cil;
using PathOfTerraria.Common.UI;

namespace CalamityRuTranslate.Mods.PathOfTerraria.MonoMod;

public class ExpBarPatch : ILPatcher
{
    public override bool AutoLoad => ModInstances.PathOfTerraria != null && TRuConfig.Instance.PathOfTerrariaLocalization && TranslationHelper.IsRussianLanguage;

    public override MethodInfo ModifiedMethod => typeof(ExpBar).FindMethod(nameof(ExpBar.Draw));

    public override ILContext.Manipulator PatchMethod { get; } = il =>
    {
        ILCursor c = new ILCursor(il);

        c.TryGotoNext(MoveType.After, i => i.MatchLdstr("Mods.PathOfTerraria.UI.Lives"));
        c.TryGotoNext(MoveType.After, i => i.MatchCall<string>("Concat"));
        c.EmitDelegate<Func<string, string>>(oldText => $"Осталось жизней: {oldText.Trim()}");
    };
}