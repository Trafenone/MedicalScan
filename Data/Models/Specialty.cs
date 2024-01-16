using System.ComponentModel.DataAnnotations;

namespace Data.Models;

public class Specialty
{
    public int Id { get; set; }
    [Required]
    public string Code { get; set; }
    [Required]
    public string Name { get; set; }
    public ICollection<Doctor> Doctors { get; set; }
}