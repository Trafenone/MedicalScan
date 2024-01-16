using System.ComponentModel.DataAnnotations;

namespace Data.Models;

public class Doctor
{
    public int Id { get; set; }
    [Required]
    public string Name { get; set; }
    public ICollection<Specialty> Specialties { get; set; }
}