using System;
using Terraria.ModLoader;

namespace CalamityRuTranslate.Core.MonoMod;

public class MonoModPatcherSystem : ModSystem
{
    public override void OnModLoad()
    {
        foreach (Type type in CalamityRuTranslate.Instance.Code.GetTypes())
        {
            if (type.IsSubclassOf(typeof(ILPatcher)) && Activator.CreateInstance(type) is ILPatcher {AutoLoad: true} ilPatcher)
            {
                try
                {
                    MonoModHooks.Modify(ilPatcher.ModifiedMethod, ilPatcher.PatchMethod);
                }
                catch (NullReferenceException)
                {
                    throw new Exception($"[IL] Не удалось найти и пропатчить метод '{ilPatcher.ModifiedMethod.Name}'");
                }
            }
        
            if (type.IsSubclassOf(typeof(OnPatcher)) && Activator.CreateInstance(type) is OnPatcher {AutoLoad: true} onPatcher)
            {
                try
                {
                    MonoModHooks.Add(onPatcher.ModifiedMethod, onPatcher.Delegate);
                }
                catch (NullReferenceException)
                {
                    throw new Exception($"[On] Не удалось найти и пропатчить метод '{onPatcher.ModifiedMethod.Name}'");
                }
            }
        }
    }
}