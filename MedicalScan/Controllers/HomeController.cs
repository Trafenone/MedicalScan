using AutoMapper;
using AutoMapper.QueryableExtensions;
using Data;
using Data.Models;
using MedicalScan.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace MedicalScan.Controllers;

public class HomeController : Controller
{
    private readonly ApplicationDbContext _context;
    private readonly IMapper _mapper;

    public HomeController(ApplicationDbContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }

    public async Task<IActionResult> Index(string specialty = null)
    {
        var viewModel = await GetFilteredViewModel(specialty);
        return View(viewModel);
    }

    private async Task<Model> GetFilteredViewModel(string specialty)
    {
        IQueryable<Doctor> doctorsQuery = _context.Doctors.Include(d => d.Specialties);

        if (!string.IsNullOrEmpty(specialty) && specialty != "All")
        {
            doctorsQuery = doctorsQuery.Where(d => d.Specialties.Any(s => s.Code == specialty));
        }

        var doctors = await doctorsQuery
            .ProjectTo<DoctorModel>(_mapper.ConfigurationProvider)
            .ToListAsync();

        var specialties = await _context.Specialties
            .ProjectTo<SpecialtyModel>(_mapper.ConfigurationProvider)
            .ToListAsync();

        return new Model
        {
            Doctors = doctors,
            Specialties = specialties
        };
    }
}