namespace MedicalScan.Models;

public record Model
{
    public List<DoctorViewModel> Doctors { get; set; }
    public List<SpecialtyViewModel> Specialties { get; set; }
}
