using System;
using CalamityRuTranslate.Common;
using CalamityRuTranslate.Common.Utilities;
using CalamityRuTranslate.Core.Config;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ModLoader;

namespace CalamityRuTranslate.Mods.PathOfTerraria;

public class PathOfTerrariaSystem : ModSystem
{
    public override bool IsLoadingEnabled(Mod mod)
    {
        return ModInstances.PathOfTerraria != null && TRuConfig.Instance.PathOfTerrariaLocalization && TranslationHelper.IsRussianLanguage;
    }
    
    public override void PostSetupContent()
    {
        if (!Main.dedServ)
        {
            Type type = ModInstances.PathOfTerraria.Code.GetType("PathOfTerraria.Common.UI.Guide.TutorialUIState");
            type.SetMemberValue("BigBack", ModContent.Request<Texture2D>("CalamityRuTranslate/Assets/Sprites/PathOfTerraria/LargeBack"));
        }
    }
}