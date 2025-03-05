using System;
using System.Collections.Generic;
using System.Reflection;
using CalamityRuTranslate.Common;
using CalamityRuTranslate.Common.Utilities;
using CalamityRuTranslate.Core.Config;
using CalamityRuTranslate.Core.MonoMod;
using NoxusBoss.Content.Items;
using NoxusBoss.Content.Items.GenesisComponents;
using NoxusBoss.Core.DialogueSystem;
using Terraria;
using Terraria.DataStructures;
using Terraria.ModLoader;

namespace CalamityRuTranslate.Mods.NoxusBoss.MonoMod;

public class InvokeClickActionPatch : OnPatcher
{
    private delegate void InvokeClickActionDelegate(Dialogue self);

    public override bool AutoLoad => ModInstances.NoxusBoss != null && TRuConfig.Instance.NoxusBossLocalization && TranslationHelper.IsRussianLanguage;

    public override MethodInfo ModifiedMethod => typeof(Dialogue).GetCachedMethod(nameof(Dialogue.InvokeClickAction));

    public override Delegate Delegate => Translation;
    
    private void Translation(InvokeClickActionDelegate orig, Dialogue self)
    {
        FieldInfo seenDialogueField = typeof(DialogueSaveSystem).GetField("seenDialogue", BindingFlags.NonPublic | BindingFlags.Static);
        FieldInfo clickedDialogueField = typeof(DialogueSaveSystem).GetField("clickedDialogue", BindingFlags.NonPublic | BindingFlags.Static);

        List<string> seenDialogue = (List<string>)seenDialogueField.GetValue(null);
        List<string> clickedDialogue = (List<string>)clickedDialogueField.GetValue(null);

        string[] dialoguesToCheck =
        {
            "Mods.NoxusBoss.Solyn.StargazeQuestSawRift.Talk8",
            "Mods.NoxusBoss.Solyn.CeaselessVoidDiscussionAfterEnteringRift.Conversation6"
        };

        int[] itemIDs =
        {
            ModContent.ItemType<StarCharm>(),
            ModContent.ItemType<TheAntiseed>()
        };

        for (int i = 0; i < dialoguesToCheck.Length; i++)
        {
            string dialogueKey = dialoguesToCheck[i];

            if (seenDialogue.Contains(dialogueKey) && !clickedDialogue.Contains(dialogueKey))
            {
                Main.LocalPlayer.QuickSpawnItem(new EntitySource_WorldEvent(), itemIDs[i]);
                clickedDialogue.Add(dialogueKey);
            }
        }
        
        orig.Invoke(self);
    }
}