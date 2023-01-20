namespace AlloroTechnologies.Humita.Domain.Entities;

public interface IFile
{
    string Name { get; set; }
    FileType Type { get; }
}