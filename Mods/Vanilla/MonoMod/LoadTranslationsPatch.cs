using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using CalamityRuTranslate.Common.Utilities;
using CalamityRuTranslate.Core.Config;
using CalamityRuTranslate.Core.MonoMod;
using Hjson;
using Newtonsoft.Json.Linq;
using Terraria.Localization;
using Terraria.ModLoader;
using Terraria.ModLoader.Core;

namespace CalamityRuTranslate.Mods.Vanilla.MonoMod;

[EarlyPatcher]
public class LoadTranslationsPatch : OnPatcher
{
    private sealed class TranslationPass
    {
        internal readonly List<(string key, string value)> Translations;
        internal readonly HashSet<string> Keys;

        internal TranslationPass(List<(string key, string value)> translations)
        {
            Translations = translations;
            Keys = translations.Select(pair => pair.key).ToHashSet(StringComparer.Ordinal);
        }
    }
    
    [ThreadStatic]
    private static TranslationPass _activePass;
    
    public override bool AutoLoad => TranslationHelper.IsRussianLanguage;

    public override MethodInfo ModifiedMethod => typeof(LocalizationLoader).FindMethod("LoadTranslations", [typeof(TmodFile), typeof(GameCulture)
    ]);
    
    private delegate List<(string key, string value)> LoadTranslationsDelegate(TmodFile tModFile, GameCulture culture);
    
    public override Delegate Delegate => Translation;

    private List<(string key, string value)> Translation(LoadTranslationsDelegate orig, TmodFile tModFile, GameCulture culture)
    {
        if (culture != GameCulture.FromCultureName(GameCulture.CultureName.Russian))
            return orig.Invoke(tModFile, culture);

        if (tModFile == null)
            return orig.Invoke(tModFile, culture);

        if (tModFile.Name == CalamityRuTranslate.Instance.Name)
            return _activePass?.Translations ?? ReadTranslations(tModFile, culture);

        List<(string key, string value)> translations = orig.Invoke(tModFile, culture);
        return _activePass == null
            ? translations
            : translations.Where(pair => !_activePass.Keys.Contains(pair.key)).ToList();
    }

    internal static void LoadModTranslations(Action<GameCulture> orig, GameCulture culture)
    {
        if (culture != GameCulture.FromCultureName(GameCulture.CultureName.Russian))
        {
            orig(culture);
            return;
        }

        TranslationPass previousPass = _activePass;
        try
        {

            TmodFile modFile = (TmodFile)typeof(Mod).FindProperty("File").GetValue(CalamityRuTranslate.Instance);
            _activePass = new TranslationPass(ReadTranslations(modFile, culture));
            orig(culture);
        }
        finally
        {
            _activePass = previousPass;
        }
    }

    private static List<(string key, string value)> ReadTranslations(TmodFile tModFile, GameCulture culture)
    {
        Type type = typeof(Mod).Assembly.GetType("Terraria.ModLoader.Core.BuildProperties");
        MethodInfo readModFile = type.FindMethod("ReadModFile");
        object properties = readModFile.Invoke(null, [tModFile]);
        string modSourceField = properties.GetMemberValue<string>("modSource"); 
        string sourceFolder = Directory.Exists(modSourceField) ? modSourceField : "";
        try
        {
            List<(string, string)> flattened = new();
            foreach (TmodFile.FileEntry translationFile in tModFile.Where(entry => Path.GetExtension(entry.Name) == ".hjson"))
            {
                string modpath = Path.Combine(tModFile.Name, translationFile.Name).Replace('/', '\\');
                
                if (!LocalizationLoader.TryGetCultureAndPrefixFromPath(translationFile.Name, out GameCulture fileCulture, out string prefix))
                    continue;
                
                if (fileCulture != culture)
                    continue;

                if (!TRuConfig.Instance.VanillaLocalization && modpath.Contains(@"Vanilla\")) continue;
                if (!TRuConfig.Instance.CalamityModLocalization && modpath.Contains(@"Calamity\")) continue;
                if (!TRuConfig.Instance.CalamityModMusicLocalization && modpath.Contains(@"CalamityModMusic\")) continue;
                if (!TRuConfig.Instance.FargowiltasLocalization && modpath.Contains(@"Fargowiltas\")) continue;
                if (!TRuConfig.Instance.FargowiltasSoulsLocalization && modpath.Contains(@"FargowiltasSouls\")) continue;
                if (!TRuConfig.Instance.InfernumModeLocalization && modpath.Contains(@"InfernumMode\")) continue;
                if (!TRuConfig.Instance.ThoriumModLocalization && modpath.Contains(@"Thorium\")) continue;
                if (!TRuConfig.Instance.NoxusBossLocalization && modpath.Contains(@"NoxusBoss\")) continue;
                if (!TRuConfig.Instance.StarsAboveLocalization && modpath.Contains(@"StarsAbove\")) continue;
                if (!TRuConfig.Instance.RedemptionLocalization && modpath.Contains(@"Redemption\")) continue;
                if (!TRuConfig.Instance.CatalystLocalization && modpath.Contains(@"Catalyst\")) continue;
                if (!TRuConfig.Instance.PathOfTerrariaLocalization && modpath.Contains(@"PathOfTerraria\")) continue;
                
                using Stream stream = tModFile.GetStream(translationFile);
                using StreamReader streamReader = new StreamReader(stream, Encoding.UTF8, true);

                string translationFileContents = streamReader.ReadToEnd();

                HashSet<(string Mod, string fileName)> changedFiles = typeof(LocalizationLoader).GetMemberValue<HashSet<(string Mod, string fileName)>>("changedFiles");

                if (!string.IsNullOrWhiteSpace(sourceFolder) && changedFiles.Select(x => Path.Join(x.Mod, x.fileName).Replace('/', '\\')).Contains(modpath))
                {
                    string path = Path.Combine(sourceFolder, translationFile.Name);
                    
                    if (File.Exists(path))
                    {
                        try
                        {
                            translationFileContents = File.ReadAllText(path);
                        }
                        catch (Exception)
                        {
                            // ignored
                        }
                    }
                }

                string jsonString;
                try
                {
                    jsonString = HjsonValue.Parse(translationFileContents).ToString();
                }
                catch (Exception e)
                {
                    string additionalContext = "";
                    if(e is ArgumentException && Regex.Match(e.Message, "At line (\\d+),") is { Success: true } match && int.TryParse(match.Groups[1].Value, out int line)) {
                        string[] lines = translationFileContents.Replace("\r", "").Replace("\t", "    ").Split('\n');
                        int start = Math.Max(0, line - 4);
                        int end = Math.Min(lines.Length, line + 3);
                        StringBuilder linesOutput = new StringBuilder();
                        for (int i = start; i < end; i++) {
                            if (line - 1 == i)
                                linesOutput.Append($"\n{i + 1}[c/ff0000:>" + lines[i] + "]");
                            else
                                linesOutput.Append($"\n{i + 1}:" + lines[i]);
                        }
                        additionalContext = "\nContext:" + linesOutput;
                    }
                    throw new Exception($"The localization file \"{translationFile.Name}\" is malformed and failed to load:{additionalContext} ", e);
                }

                JObject jsonObject = JObject.Parse(jsonString);

                foreach (JToken t in jsonObject.SelectTokens("$..*"))
                {
                    if (t.HasValues)
                        continue;

                    if (t is JObject obj && obj.Count == 0)
                        continue;

                    string path = "";
                    JToken current = t;

                    for (JToken parent = t.Parent; parent != null; parent = parent.Parent)
                    {
                        path = parent switch
                        {
                            JProperty property => property.Name + (path == string.Empty ? string.Empty : "." + path),
                            JArray array => array.IndexOf(current) + (path == string.Empty ? string.Empty : "." + path),
                            _ => path
                        };
                        current = parent;
                    }

                    path = path.Replace(".$parentVal", "");
                    if (!string.IsNullOrWhiteSpace(prefix))
                        path = prefix + "." + path;

                    flattened.Add((path, t.ToString()));
                }
            }

            return flattened;
        }
        catch (Exception e)
        {
            e.Data["mod"] = tModFile.Name;
            throw;
        }
    }
}

[EarlyPatcher]
public class LoadModTranslationsPatch : OnPatcher
{
    public override bool AutoLoad => TranslationHelper.IsRussianLanguage;

    public override MethodInfo ModifiedMethod => typeof(LocalizationLoader).FindMethod(nameof(LocalizationLoader.LoadModTranslations), [typeof(GameCulture)]);

    public override Delegate Delegate => LoadTranslationsPatch.LoadModTranslations;
}
