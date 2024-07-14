using System;
using System.Collections.Generic;
using System.Reflection;
using CalamityRuTranslate.Common;
using CalamityRuTranslate.Common.Utilities;
using CalamityRuTranslate.Core.Config;
using CalamityRuTranslate.Core.MonoMod;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace CalamityRuTranslate.Mods.Vanilla.MonoMod;

public class DrawPatch : OnPatcher
{
    private const string PATH = "Assets/Sprites/StarsAbove";
    
    private Dictionary<string, string> _textures = new()
    {
        { "UI/StellarNova/prototokiaIcon", $"{PATH}/prototokiaIcon" },
        { "UI/StellarNova/laevateinnIcon", $"{PATH}/laevateinnIcon" },
        { "UI/StellarNova/KiwamiRyukenIcon", $"{PATH}/KiwamiRyukenIcon" },
        { "UI/StellarNova/gardenofavalonIcon", $"{PATH}/gardenofavalonIcon" },
        { "UI/StellarNova/edingenesisquasarIcon", $"{PATH}/edingenesisquasarIcon" },
        { "UI/StellarNova/unlimitedbladeworksIcon", $"{PATH}/unlimitedbladeworksIcon" },
        { "UI/StellarNova/guardianslightIcon", $"{PATH}/guardianslightIcon" },
        { "UI/StellarNova/fireflytypeIVIcon", $"{PATH}/fireflytypeIVIcon" },
        { "UI/CelestialCartography/LocationDescriptionTextBox", $"{PATH}/LocationDescriptionTextBox" },
        { "UI/CelestialCartography/LocationNames/Caelum", $"{PATH}/Caelum" },
        { "UI/CelestialCartography/LocationNames/Celestia", $"{PATH}/Celestia" },
        { "UI/CelestialCartography/LocationNames/Corvus", $"{PATH}/Corvus" },
        { "UI/CelestialCartography/LocationNames/CygnusAsteroidField", $"{PATH}/CygnusAsteroidField" },
        { "UI/CelestialCartography/LocationNames/FaintArchives", $"{PATH}/FaintArchives" },
        { "UI/CelestialCartography/LocationNames/FallenTheranhad", $"{PATH}/FallenTheranhad" },
        { "UI/CelestialCartography/LocationNames/Katabasis", $"{PATH}/Katabasis" },
        { "UI/CelestialCartography/LocationNames/Lyra", $"{PATH}/Lyra" },
        { "UI/CelestialCartography/LocationNames/MiningStationAries", $"{PATH}/MiningStationAries" },
        { "UI/CelestialCartography/LocationNames/Observatory", $"{PATH}/Observatory" },
        { "UI/CelestialCartography/LocationNames/Pyxis", $"{PATH}/Pyxis" },
        { "UI/CelestialCartography/LocationNames/Scorpius", $"{PATH}/Scorpius" },
        { "UI/CelestialCartography/LocationNames/Serpens", $"{PATH}/Serpens" },
        { "UI/CelestialCartography/LocationNames/TheDreamingCity", $"{PATH}/TheDreamingCity" },
        { "UI/CelestialCartography/LocationNames/Tucana", $"{PATH}/Tucana" },
        { "UI/CelestialCartography/LocationNames/UltraPlant", $"{PATH}/UltraPlant" },
        { "UI/StellarNova/NovaTextBox", $"{PATH}/NovaTextBox" },
        { "UI/StellarNova/NovaUI", $"{PATH}/NovaUI" },
        { "UI/StellarNova/affix1", $"{PATH}/affix1" },
        { "UI/StellarNova/affix2", $"{PATH}/affix2" },
        { "UI/StellarNova/affix3", $"{PATH}/affix3" },
    };
    
    private delegate void DrawDelegate(SpriteBatch self, Texture2D texture, Rectangle destinationRectangle, Color color);
    
    public override bool AutoLoad => TranslationHelper.IsRussianLanguage;

    public override MethodInfo ModifiedMethod => typeof(SpriteBatch).GetCachedMethod("Draw", [typeof(Texture2D), typeof(Rectangle), typeof(Color)
    ]);

    public override Delegate Delegate => Translate;

    private void Translate(DrawDelegate orig, SpriteBatch self, Texture2D texture, Rectangle destinationRectangle, Color color)
    {
        if (ModInstances.StarsAbove != null && TRuConfig.Instance.StarsAboveLocalization)
        {
            foreach (KeyValuePair<string, string> path in _textures)
            {
                if (texture == ModInstances.StarsAbove.Assets.Request<Texture2D>(path.Key).Value)
                {
                    texture = CalamityRuTranslate.Instance.Assets.Request<Texture2D>(path.Value).Value;
                }
            }
        }

        orig.Invoke(self, texture, destinationRectangle, color);
    }
}