namespace AlloroTechnologies.Humita.Domain.Entities;

public class Enum : IValidatable
{
    public IDictionary<string, int> Values { get; set; } = new Dictionary<string, int>();
    public AccessModifier AccessModifier { get; set; } = AccessModifier.Public;
    public bool IsValid => throw new NotImplementedException();
}