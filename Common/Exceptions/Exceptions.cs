﻿using System;

namespace CalamityRuTranslate.Common.Exceptions
{
    public class TranslationException : Exception
    {
        public TranslationException(string invalidKey) : base($"Ключ {invalidKey} не найден!\n")
        {
        }
    }

    public class ModVersionException : Exception
    {
        public ModVersionException(string modName, string modVersion, Version currectModVersion) : base($"Было обнаружено, что вы используете {currectModVersion} версию мода {modName}, которую не поддерживает русификатор. Русификатор работает только с версией {modVersion}. Если ваша версия {modName} ниже версии {modVersion} - вам необходимо обновить {modName} до последней версии. Если ваша версия {modName} выше версии {modVersion} - вам необходимо ждать обновление русификатора с поддержкой нового обновления {modName}. О сроках выхода нового обновления вы можете узнать на нашем дискорд сервере.\n")
        {
        }
    }
}