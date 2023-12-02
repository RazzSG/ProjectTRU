using System.Collections.Generic;

namespace CalamityRuTranslate.Core.ItemGenderPrefixes;

public interface IItemGender
{
    List<int> Feminine { get; }
    List<int> Neuter { get; }
    List<int> Plural { get; }
}