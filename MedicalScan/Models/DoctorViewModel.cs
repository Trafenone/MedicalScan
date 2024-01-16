namespace MedicalScan.Models;

public record DoctorViewModel
{
    public string Name { get; init; }
    public List<string> Specialties { get; init; }
}
