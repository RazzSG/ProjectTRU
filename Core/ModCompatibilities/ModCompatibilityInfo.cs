using System;

namespace CalamityRuTranslate.Core.ModCompatibilities;

public record ModCompatibilityInfo(string InternalName, Version ExpectedVersion, bool ShouldCheckVersion);