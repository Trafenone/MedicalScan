namespace MedicalScan.Models;

public record Model
{
    public List<DoctorModel> Doctors { get; init; }
    public List<SpecialtyModel> Specialties { get; init; }
}
