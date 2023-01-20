namespace AlloroTechnologies.Humita.Domain.Entities;

public class Property : IValidatable
{
    public string Name { get; set; } = default!;
    public string Type { get; set; } = default!;
    public AccessModifier AccessModifier { get; set; } = AccessModifier.Public;
    public Modifier Modifier { get; set; } = Modifier.None;
    public bool IsValid => throw new NotImplementedException();
}