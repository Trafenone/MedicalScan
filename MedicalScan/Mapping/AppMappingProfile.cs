using AutoMapper;
using Data.Models;
using MedicalScan.Models;

namespace MedicalScan.Mapping;

public class AppMappingProfile : Profile
{
    public AppMappingProfile()
    {
        CreateMap<Doctor, DoctorModel>()
            .ForMember(dest => dest.Specialties, opt =>
                opt.MapFrom(src => src.Specialties.Select(s => s.Name)));
        CreateMap<Specialty, SpecialtyModel>();
    }
}