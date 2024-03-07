using System;

namespace CalamityRuTranslate.Core.ModCompatibilities;

public class ModCompatibilityException : Exception
{
    public ModCompatibilityException(string modName, Version currentModVersion, Version expectedModVersion)
        : base($"У вас установлена несовместимая версия [c/FFF783:{modName}]. Ваша текущая версия: [c/FF0000:{currentModVersion}]. Для корректной работы русификатора необходимо зайти в браузер модов и обновить [c/FFF783:{modName}] до версии [c/00FF09:{expectedModVersion}].\n") { }
    
    public override string ToString() => Message;
}