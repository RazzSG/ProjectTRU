using System;
using System.Collections.Generic;
using Terraria.ModLoader;
using Terraria.ModLoader.Core;

namespace CalamityRuTranslate.Core.MonoMod;

public class MonoModPatcherSystem : ModSystem
{
    private readonly HashSet<Type> _attemptedPatchers = new();

    public override void OnModLoad()
    {
        InstallPatchers(early: true);
    }

    public override void ResizeArrays()
    {
        InstallPatchers(early: false);
    }

    public override void Unload()
    {
        _attemptedPatchers.Clear();
    }

    private void InstallPatchers(bool early)
    {
        foreach (Type type in AssemblyManager.GetLoadableTypes(Mod.Code))
        {
            if (type.IsAbstract || type.ContainsGenericParameters ||
                (!type.IsSubclassOf(typeof(ILPatcher)) && !type.IsSubclassOf(typeof(OnPatcher))) ||
                type.IsDefined(typeof(EarlyPatcherAttribute), false) != early ||
                !_attemptedPatchers.Add(type))
                continue;

            try
            {
                object patcher = Activator.CreateInstance(type);

                if (patcher is ILPatcher { AutoLoad: true } ilPatcher)
                    MonoModHooks.Modify(ilPatcher.ModifiedMethod, ilPatcher.PatchMethod);

                if (patcher is OnPatcher { AutoLoad: true } onPatcher)
                    MonoModHooks.Add(onPatcher.ModifiedMethod, onPatcher.Delegate);
            }
            catch (Exception e)
            {
                Mod.Logger.Error($"[Patch Error] {type.FullName}", e);
            }
        }
    }
}