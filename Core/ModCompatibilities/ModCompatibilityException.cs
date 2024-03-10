using System;

namespace CalamityRuTranslate.Core.ModCompatibilities;

public class ModCompatibilityException : Exception
{
    public ModCompatibilityException(string modName, Version currentModVersion, Version expectedModVersion)
        : base(GenerateExceptionMessage(modName, currentModVersion, expectedModVersion)) { }
    
    public override string ToString() => Message;

    private static string GenerateExceptionMessage(string modName, Version currentModVersion, Version expectedModVersion)
    {
        if (currentModVersion > expectedModVersion)
        {
            return $"У вас установлен [c/FFF783:{CalamityRuTranslate.Instance.DisplayName}], который не поддерижвает версию [c/FFF783:{modName}] [c/00FF09:{currentModVersion}]. Для корректной работы необходимо дождаться обновления [c/FFF783:{CalamityRuTranslate.Instance.DisplayName}], которое будет поддерживать версию [c/00FF09:{currentModVersion}].\n";
        }

        return $"У вас установлена несовместимая версия [c/FFF783:{modName}]. Ваша текущая версия: [c/FF0000:{currentModVersion}]. Для корректной работы русификатора необходимо зайти в браузер модов и обновить [c/FFF783:{modName}] до версии [c/00FF09:{expectedModVersion}].\n";
    }
}