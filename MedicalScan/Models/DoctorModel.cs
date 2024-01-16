namespace MedicalScan.Models;

public record DoctorModel
{
    public string Name { get; init; }
    public List<string> Specialties { get; init; }
}
