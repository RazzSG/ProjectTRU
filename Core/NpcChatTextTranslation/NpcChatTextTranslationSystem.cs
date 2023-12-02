using System;
using System.Collections.Generic;
using System.Linq;
using CalamityRuTranslate.Common.Utilities;
using Terraria.ModLoader;
using Terraria.UI;

namespace CalamityRuTranslate.Core.NpcChatTextTranslation;

public class NpcChatTextTranslationSystem : ModSystem
{
    private readonly List<INpcChatText> _npcChatTexts = new();
    
    public override bool IsLoadingEnabled(Mod mod)
    {
        return TranslationHelper.IsRussianLanguage;
    }

    public override void OnModLoad()
    {
        IEnumerable<Type> types = CalamityRuTranslate.Instance.Code.GetTypes()
            .Where(t => !t.IsAbstract && t.GetInterfaces().Contains(typeof(INpcChatText)) && t.GetInterfaces().Contains(typeof(ILoadable)));
        
        foreach (Type type in types)
        {
            object instance = Activator.CreateInstance(type);
            if (instance is ILoadable loadable && loadable.IsLoadingEnabled(CalamityRuTranslate.Instance))
            {
                if (instance is INpcChatText npcChatTextInstance)
                {
                    _npcChatTexts.Add(npcChatTextInstance);
                }
            }
        }
    }

    public override void ModifyInterfaceLayers(List<GameInterfaceLayer> layers)
    {
        foreach (INpcChatText npcChatText in _npcChatTexts)
        {
            npcChatText.NpcChatTextTranslation();
        }
    }
}