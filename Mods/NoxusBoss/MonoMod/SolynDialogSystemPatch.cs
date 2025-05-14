using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using CalamityRuTranslate.Common;
using CalamityRuTranslate.Common.Utilities;
using CalamityRuTranslate.Core.Config;
using CalamityRuTranslate.Core.MonoMod;
using Microsoft.Xna.Framework;
using NoxusBoss.Core.Graphics.UI.SolynDialogue;
using ReLogic.Utilities;
using Terraria.Audio;

namespace CalamityRuTranslate.Mods.NoxusBoss.MonoMod;

public class SolynDialogSystemPatch : OnPatcher
{
    private SlotId _currentVoiceSlot = SlotId.Invalid;
    private string _lastTextKey;
    private const string LocalizationPrefix = "Mods.NoxusBoss.Solyn";
    
    private readonly Dictionary<string, SoundStyle> _dialogueVoiceMap = new(InitializeVoiceMap());
    
    public override bool AutoLoad => ModInstances.NoxusBoss != null && TRuConfig.Instance.NoxusBossLocalization && TranslationHelper.IsRussianLanguage && TRuConfig.Instance.SolynVoices;
    
    public override MethodInfo ModifiedMethod => typeof(SolynDialogSystem).FindMethod(nameof(SolynDialogSystem.UpdateUI));

    public override Delegate Delegate => (Action<SolynDialogSystem, GameTime> orig, SolynDialogSystem self, GameTime gameTime) =>
    {
        orig.Invoke(self, gameTime);
        
        if (!SolynDialogSystem.Visible)
        {
            StopCurrentSound();
            _lastTextKey = null;
            return;
        }
        
        string currentTextKey = self.DialogUI.CurrentDialogueNode?.TextKey;
        
        if (currentTextKey != _lastTextKey)
        {
            StopCurrentSound();
            _lastTextKey = currentTextKey;

            if (currentTextKey != null && _dialogueVoiceMap.TryGetValue(currentTextKey, out SoundStyle voiceStyle))
                _currentVoiceSlot = SoundEngine.PlaySound(voiceStyle);
            else
                _currentVoiceSlot = SlotId.Invalid;
        }
    };
    
    private static Dictionary<string, SoundStyle> InitializeVoiceMap()
    {
        Dictionary<string, SoundStyle> voiceMap = new();
        Type[] nestedSoundTypes = typeof(NoxusBossSounds).GetNestedTypes(BindingFlags.Public | BindingFlags.Instance);

        foreach (Type nestedType in nestedSoundTypes)
        {
            FieldInfo[] soundFields = nestedType.GetFields(BindingFlags.Public | BindingFlags.Static).Where(f => f.FieldType == typeof(SoundStyle)).ToArray();

            foreach (FieldInfo field in soundFields)
            {
                string textKey = $"{LocalizationPrefix}.{nestedType.Name}.{field.Name}";

                if (field.GetValue(null) is SoundStyle originalStyle)
                {
                    voiceMap[textKey] = originalStyle with
                    {
                        MaxInstances = 1,
                        SoundLimitBehavior = SoundLimitBehavior.ReplaceOldest,
                    };
                }
            }
        }
        
        return voiceMap;
    }
    
    private void StopCurrentSound()
    {
        if (_currentVoiceSlot.IsValid && SoundEngine.TryGetActiveSound(_currentVoiceSlot, out ActiveSound currentSound))
            currentSound.Stop();
        _currentVoiceSlot = SlotId.Invalid;
    }
}

