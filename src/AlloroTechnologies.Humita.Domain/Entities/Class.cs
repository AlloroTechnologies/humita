namespace AlloroTechnologies.Humita.Domain.Entities;

public class Class : IValidatable
{
    public List<Interface> ImplementedInterfaces { get; set; } = new List<Interface>();
    public Class BaseClass { get; set; } = new Class();
    public List<Property> Properties { get; set; } = new List<Property>();
    public List<Operation> Operations { get; set; } = new List<Operation>();
    public AccessModifier AccessModifier { get; set; } = AccessModifier.Public;
    public Modifier Modifier { get; set; } = Modifier.None;
    public bool IsValid => throw new NotImplementedException();
}