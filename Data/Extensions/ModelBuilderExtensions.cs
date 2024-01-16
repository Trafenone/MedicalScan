using Data.Models;
using Microsoft.EntityFrameworkCore;

namespace Data.Extensions;

public static class ModelBuilderExtensions
{
    public static void SeedData(this ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Doctor>().HasData(
            new Doctor { Id = 1, Name = "Dr. Gipsz Jakab" },
            new Doctor { Id = 2, Name = "Dr. Teszt Elek" },
            new Doctor { Id = 3, Name = "Dr. Kedvező Áron" },
            new Doctor { Id = 4, Name = "Dr. Gipsz Elek" },
            new Doctor { Id = 5, Name = "Dr. Doktor Doloróza" }
        );

        modelBuilder.Entity<Specialty>().HasData(
            new Specialty { Id = 1, Code = "GP", Name = "Háziorvos" },
            new Specialty { Id = 2, Code = "INT", Name = "Belgyógyász" },
            new Specialty { Id = 3, Code = "CAR", Name = "Kardiológus" },
            new Specialty { Id = 4, Code = "SEB", Name = "Sebész" },
            new Specialty { Id = 5, Code = "DER", Name = "Bőrgyógyász" }
        );

        modelBuilder.Entity<DoctorSpecialty>().HasData(
            new DoctorSpecialty { DoctorId = 1, SpecialtyId = 1 },
            new DoctorSpecialty { DoctorId = 1, SpecialtyId = 2 },
            new DoctorSpecialty { DoctorId = 2, SpecialtyId = 5 },
            new DoctorSpecialty { DoctorId = 3, SpecialtyId = 2 },
            new DoctorSpecialty { DoctorId = 3, SpecialtyId = 4 },
            new DoctorSpecialty { DoctorId = 4, SpecialtyId = 3 },
            new DoctorSpecialty { DoctorId = 5, SpecialtyId = 2 },
            new DoctorSpecialty { DoctorId = 5, SpecialtyId = 5 }
        );
    }
}