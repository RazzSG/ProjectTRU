﻿using System.Reflection;
using MonoMod.Cil;

namespace CalamityRuTranslate.Core.MonoMod;

public abstract class ILPatcher
{
    public virtual bool AutoLoad => false;
    public abstract MethodBase ModifiedMethod { get; }
    public abstract ILContext.Manipulator PatchMethod { get; }
}