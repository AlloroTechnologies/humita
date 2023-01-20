namespace AlloroTechnologies.Humita.Domain.Entities;

public class OperationParameter : IValidatable
{
    public string Name { get; set; } = default!;
    public string Type { get; set; } = default!;
    public bool IsValid => throw new NotImplementedException();
}