namespace AlloroTechnologies.Humita.Domain.Entities;

public class Operation : IValidatable
{
    public string Name { get; set; } = default!;
    public List<OperationParameter> Parameters { get; set; } = new List<OperationParameter>();
    public string ReturnType { get; set; } = default!;
    public AccessModifier AccessModifier { get; set; } = AccessModifier.Public;
    public Modifier Modifier { get; set; } = Modifier.None;
    public bool IsValid => throw new NotImplementedException();
}