using System;

namespace CalamityRuTranslate.Core.ModCompatibilities;

public class ModCompatibilityException : Exception
{
    public ModCompatibilityException(string modName, Version currentModVersion, Version expectedModVersion)
        : base($"Обнаружена несовместимая версия с модом '{modName}'. Ваша текущая версия: [c/FF0000:{currentModVersion}]. Ожидаемая версия: [c/00FF09:{expectedModVersion}]. Для корректной работы русификатора необходимо установить ожидаемую версию.\n") { }
}