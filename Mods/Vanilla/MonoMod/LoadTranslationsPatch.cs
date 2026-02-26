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
using Terraria;
using Terraria.Localization;
using Terraria.ModLoader;
using Terraria.ModLoader.Core;

namespace CalamityRuTranslate.Mods.Vanilla.MonoMod;

public class LoadTranslationsPatch : OnPatcher
{
	private static HashSet<string> _customKeys = new();
	
    public override bool AutoLoad => TranslationHelper.IsRussianLanguage;

    public override MethodInfo ModifiedMethod => typeof(LocalizationLoader).FindMethod("LoadTranslations", [typeof(TmodFile), typeof(GameCulture)
    ]);
    
    private delegate List<(string key, string value)> LoadTranslationsDelegate(TmodFile tModFile, GameCulture culture);
    
    public override Delegate Delegate => Translation;

    private List<(string key, string value)> Translation(LoadTranslationsDelegate orig, TmodFile tModFile, GameCulture culture)
    {
	    if (tModFile == null || culture != GameCulture.FromCultureName(GameCulture.CultureName.Russian) || tModFile.Name != nameof(CalamityRuTranslate))
	    {
		    List<(string key, string value)> result = orig.Invoke(tModFile, culture);
		    
		    if (tModFile != null && tModFile.Name != nameof(CalamityRuTranslate) && _customKeys.Count > 0)
			    result.RemoveAll(pair => _customKeys.Contains(pair.Item1));
		    
		    return result;
	    }

	    try
	    {
		    List<(string, string)> flattened = new();
		    string sourceFolder = Path.Combine(Main.SavePath, "ModSources", nameof(CalamityRuTranslate));
		    List<TmodFile.FileEntry> hjsonFiles = tModFile.Where(entry => Path.GetExtension(entry.Name) == ".hjson").ToList();
		    foreach (TmodFile.FileEntry translationFile in hjsonFiles)
		    {
			    string normalizedPath = translationFile.Name.Replace('/', '\\');
			    
			    if (!LocalizationLoader.TryGetCultureAndPrefixFromPath(translationFile.Name, out GameCulture fileCulture, out string prefix))
				    continue;
			    
			    if (fileCulture != culture)
				    continue;

			    if (!TRuConfig.Instance.VanillaLocalization && normalizedPath.Contains(@"Vanilla\")) continue;
			    if (!TRuConfig.Instance.CalamityModLocalization && normalizedPath.Contains(@"Calamity\")) continue;
			    if (!TRuConfig.Instance.CalamityModMusicLocalization && normalizedPath.Contains(@"CalamityModMusic\")) continue;
			    if (!TRuConfig.Instance.FargowiltasLocalization && normalizedPath.Contains(@"Fargowiltas\")) continue;
			    if (!TRuConfig.Instance.FargowiltasSoulsLocalization && normalizedPath.Contains(@"FargowiltasSouls\")) continue;
			    if (!TRuConfig.Instance.InfernumModeLocalization && normalizedPath.Contains(@"InfernumMode\")) continue;
			    if (!TRuConfig.Instance.ThoriumModLocalization && normalizedPath.Contains(@"Thorium\")) continue;
			    if (!TRuConfig.Instance.NoxusBossLocalization && normalizedPath.Contains(@"NoxusBoss\")) continue;
			    if (!TRuConfig.Instance.StarsAboveLocalization && normalizedPath.Contains(@"StarsAbove\")) continue;
			    if (!TRuConfig.Instance.RedemptionLocalization && normalizedPath.Contains(@"Redemption\")) continue;
			    if (!TRuConfig.Instance.CatalystLocalization && normalizedPath.Contains(@"Catalyst\")) continue;
			    if (!TRuConfig.Instance.SpiritReforgedLocalization && normalizedPath.Contains(@"SpiritReforged\")) continue;

			    string translationFileContents;
			    using (Stream stream = tModFile.GetStream(translationFile, newFileStream: true))
			    {
				    using (MemoryStream ms = new MemoryStream())
				    {
					    stream.CopyTo(ms);
					    ms.Position = 0;
					    using (StreamReader streamReader = new StreamReader(ms, Encoding.UTF8, true))
					    {
						    translationFileContents = streamReader.ReadToEnd();
					    }
				    }
			    }

			    if (!string.IsNullOrWhiteSpace(sourceFolder))
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
				    _customKeys.Add(path);
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