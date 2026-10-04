using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using CalamityRuTranslate.Common.Utilities;
using CalamityRuTranslate.Core.MonoMod;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using ReLogic.Content;
using Terraria;
using Terraria.ModLoader;

namespace CalamityRuTranslate.Mods.Vanilla.MonoMod;

public class DrawPatch : OnPatcher
{
    private static readonly Dictionary<Texture2D, Texture2D> TextureReplacements = new();

    private delegate void DrawDelegate(SpriteBatch self, Texture2D texture, Rectangle destinationRectangle, Color color);

    public static void CacheTextures(Mod sourceMod, string replacementRoot)
    {
        if (Main.dedServ || sourceMod == null || CalamityRuTranslate.Instance == null)
            return;

        IEnumerable<string> sourceAssets = sourceMod.RootContentSource?.EnumerateAssets();
        IEnumerable<string> replacementAssets = CalamityRuTranslate.Instance.RootContentSource?.EnumerateAssets();
        if (sourceAssets == null || replacementAssets == null)
            return;

        replacementRoot = replacementRoot.TrimEnd('/');

        Dictionary<string, List<string>> sourceAssetsByName = sourceAssets
            .Select(GetAssetPath)
            .GroupBy(Path.GetFileName, StringComparer.Ordinal)
            .ToDictionary(group => group.Key, group => group.ToList(), StringComparer.Ordinal);

        foreach (string filePath in replacementAssets)
        {
            string replacementPath = GetAssetPath(filePath);
            string prefix = replacementRoot + "/";
            if (!replacementPath.StartsWith(prefix, StringComparison.Ordinal))
                continue;

            string relativePath = replacementPath[prefix.Length..];
            string sourcePath = ResolveSourcePath(sourceMod, sourceAssetsByName, relativePath);

            if (sourcePath == null)
                continue;

            Texture2D original = sourceMod.Assets.Request<Texture2D>(sourcePath, AssetRequestMode.ImmediateLoad).Value;
            Texture2D replacement = CalamityRuTranslate.Instance.Assets.Request<Texture2D>(replacementPath, AssetRequestMode.ImmediateLoad).Value;
            TextureReplacements[original] = replacement;
        }
    }

    public static void ClearTextureCache()
    {
        TextureReplacements.Clear();
    }

    public override bool AutoLoad => !Main.dedServ && TranslationHelper.IsRussianLanguage;

    public override MethodInfo ModifiedMethod => typeof(SpriteBatch).FindMethod("Draw", [typeof(Texture2D), typeof(Rectangle), typeof(Color)]);

    public override Delegate Delegate => Translate;

    private void Translate(DrawDelegate orig, SpriteBatch self, Texture2D texture, Rectangle destinationRectangle, Color color)
    {
        if (TextureReplacements.TryGetValue(texture, out Texture2D replacement))
            texture = replacement;

        orig.Invoke(self, texture, destinationRectangle, color);
    }


    private static string GetAssetPath(string path)
    {
        return Path.ChangeExtension(path.Replace('\\', '/'), null);
    }

    private static string ResolveSourcePath(Mod sourceMod, Dictionary<string, List<string>> sourceAssetsByName, string relativePath)
    {
        if (sourceMod.HasAsset(relativePath))
            return relativePath;

        string fileName = Path.GetFileName(relativePath);
        if (!sourceAssetsByName.TryGetValue(fileName, out List<string> matches) || matches.Count != 1)
            return null;

        return matches[0];
    }
}