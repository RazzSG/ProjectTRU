using System;
using System.Reflection;
using MonoMod.Cil;
using MonoMod.RuntimeDetour;
using MonoMod.RuntimeDetour.HookGen;

namespace CalamityRuTranslate.Core.MonoMod
{
    public abstract class MonoModPatcher<T> where T : class
    {
        public abstract MethodInfo Method { get; }

        public abstract T ModderMethod { get; }

        public virtual void Apply()
        {
            switch (ModderMethod)
            {
                case string method:
                    Delegate @delegate = Delegate.CreateDelegate(typeof(ILContext.Manipulator), GetType(), method);
                    HookEndpointManager.Modify(Method, @delegate);
                    CalamityRuTranslate.Modifiers.Add((Method, @delegate));
                    break;

                case MethodInfo method:
                    Hook hook = new Hook(Method, method);
                    hook.Apply();
                    CalamityRuTranslate.Hooks.Add(hook);
                    break;
            }
        }
    }
}