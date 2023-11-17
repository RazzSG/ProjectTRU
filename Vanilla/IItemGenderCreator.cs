namespace CalamityRuTranslate.Vanilla;

public interface IItemGenderCreator
{
    public string ModName { get; }
    
    IItemGender Create();
}