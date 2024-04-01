using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
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
    public override bool AutoLoad => TranslationHelper.IsRussianLanguage;

    public override MethodInfo ModifiedMethod => typeof(LocalizationLoader).GetCachedMethod("LoadTranslations");
    
    private delegate List<(string key, string value)> LoadTranslationsDelegate(Mod mod, GameCulture culture);
    
    public override Delegate Delegate => Translation;

    private List<(string key, string value)> Translation(LoadTranslationsDelegate orig, Mod mod, GameCulture culture)
    {
	    if (culture != GameCulture.FromCultureName(GameCulture.CultureName.Russian) || mod.Name != nameof(CalamityRuTranslate))
		    return orig.Invoke(mod, culture);

	    TmodFile file = mod.GetType().GetCachedProperty("File").GetValue(mod) as TmodFile;
	    Dictionary<string, bool> translationsToSkip = new()
	    {
		    {"Mods.CalamityMod", TRuConfig.Instance.CalamityModLocalization},
		    {"Mods.Fargowiltas", TRuConfig.Instance.FargowiltasLocalization},
		    {"Mods.FargowiltasSouls", TRuConfig.Instance.FargowiltasSoulsLocalization},
		    {"Mods.InfernumMode", TRuConfig.Instance.InfernumModeLocalization},
		    {"Mods.ThoriumMod", TRuConfig.Instance.ThoriumModLocalization},
	    };

	    if (file == null)
		    return new();

	    try
	    {
		    List<(string, string)> flattened = new();

		    foreach (TmodFile.FileEntry translationFile in file.Where(entry => Path.GetExtension(entry.Name) == ".hjson"))
		    {
			    string modpath = Path.Combine(mod.Name, translationFile.Name).Replace('/', '\\');
			    
			    if (!LocalizationLoader.TryGetCultureAndPrefixFromPath(translationFile.Name, out GameCulture fileCulture, out string prefix))
				    continue;
			    
			    if (fileCulture != culture)
				    continue;

			    if (fileCulture == GameCulture.FromCultureName(GameCulture.CultureName.Russian) &&
			        translationsToSkip.TryGetValue(prefix, out bool skip) && !skip)
				    continue;

			    if (fileCulture == GameCulture.FromCultureName(GameCulture.CultureName.Russian) &&
			        !TRuConfig.Instance.VanillaLocalization && modpath == @"CalamityRuTranslate\Localization\Vanilla\ru-RU.hjson")
				    continue;

			    using Stream stream = file.GetStream(translationFile);
			    using StreamReader streamReader = new StreamReader(stream, Encoding.UTF8, true);

			    string translationFileContents = streamReader.ReadToEnd();

			    HashSet<(string Mod, string fileName)> changedFiles = typeof(LocalizationLoader).GetCachedField("changedFiles").GetValue(null) as HashSet<(string Mod, string fileName)>;

			    if (changedFiles.Select(x => Path.Join(x.Mod, x.fileName)).Contains(modpath))
			    {
				    string modSourcePath = typeof(Main).Assembly.GetTypes().First(t => t.Name == "ModCompile").GetCachedField("ModSourcePath").GetValue(null) as string;
				    string path = Path.Combine(modSourcePath, modpath);
				    
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
				    throw new Exception($"The localization file \"{translationFile.Name}\" is malformed and failed to load: ", e);
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
		    e.Data["mod"] = mod.Name;
		    throw;
	    }
    }
}