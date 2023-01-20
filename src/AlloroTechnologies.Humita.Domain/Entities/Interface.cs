namespace AlloroTechnologies.Humita.Domain.Entities;

public class Interface : IValidatable
{
    public List<Interface> ExtendedInterfaces { get; set; } = new List<Interface>();
    public List<Property> Properties { get; set; } = new List<Property>();
    public List<Operation> Operations { get; set; } = new List<Operation>();
    public AccessModifier AccessModifier { get; set; } = AccessModifier.Public;
    public bool IsValid => throw new NotImplementedException();
}