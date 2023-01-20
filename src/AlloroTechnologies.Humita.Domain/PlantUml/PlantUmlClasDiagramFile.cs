using AlloroTechnologies.Humita.Domain.Entities;

namespace AlloroTechnologies.Humita.Domain.PlantUml;

public class PlantUmlClassDiagramFile : IFile, IValidatable
{
    public string Name { get; set; } = default!;
    public FileType Type => FileType.DomainClassesDiagram;
    public bool IsValid => throw new NotImplementedException();
    public List<Entities.Enum> Enums { get; private set; } = default!;
    public List<Struct> Structs { get; private set; } = default!;
    public List<Interface> Interfaces { get; private set; } = default!;
    public List<Class> Classes { get; private set; } = default!;

    public void ParseEnums()
    {
        
    }
    public void ParseStructs()
    {
        
    }
    public void ParseInterfaces()
    {
        
    }
    public void ParseClasses()
    {
        
    }
    public void ParseAll()
    {

    }
}