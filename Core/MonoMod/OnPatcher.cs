using System;
using System.Reflection;

namespace CalamityRuTranslate.Core.MonoMod;

public abstract class OnPatcher
{
    public virtual bool AutoLoad => false;
    public abstract MethodBase ModifiedMethod { get; }
    public abstract Delegate Delegate { get; }
}