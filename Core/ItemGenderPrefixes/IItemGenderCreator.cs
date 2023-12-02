namespace CalamityRuTranslate.Core.ItemGenderPrefixes;

public interface IItemGenderCreator
{
    public string ModName { get; }
    
    IItemGender Create();
}