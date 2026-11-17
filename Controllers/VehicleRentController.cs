using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DriveRentSales.Models.Entities;
using DriveRentSales.Repository;
using DriveRentSales.Services;
namespace DriveRentSales.Controllers
{
    public class VehicleRentController: Controller
    {
        private readonly IRepository <VehicleRent> _vehicleRentRepo;
        private readonly CarServices _accessService;
        public VehicleRentController(IRepository<VehicleRent> vehicleRentRepo, CarServices accessService) 
        {
            _vehicleRentRepo = vehicleRentRepo;
            _accessService = accessService; 
        }
        public async Task<IActionResult> Index()
    {
        var workouts = await _vehicleRentRepo.GetAllAsync();
        if (!workouts.Any())
        {
            await _vehicleRentRepo.AddAsync(new VehicleRent
            {
                RegistrationNumber="PB0635OE",
                Model="GLA",
                Brand="Mercedes Benz",
                Year=2019,
                Fuels="Diesel",
                Gearbox="Authomatic",
                DayRentPrice=200,
                Status="Free"

            });

            await _vehicleRentRepo.AddAsync(new VehicleRent

            {
                RegistrationNumber = "C1584BA",
                Model = "X6",
                Brand = "BMW",
                Year = 2017,
                Fuels = "Petrol",
                Gearbox = "Authomatic",
                DayRentPrice = 100,
                Status = "Free"
            });

            await _vehicleRentRepo.AddAsync(new VehicleRent

            {
                RegistrationNumber = "B0635OE",
                Model = "GLA",
                Brand = "Mercedes Benz",
                Year = 2019,
                Fuels = "Diesel",
                Gearbox = "Authomatic",
                DayRentPrice = 200,
                Status = "Free"
            });

            workouts = await _vehicleRentRepo.GetAllAsync();
        }
        return View(workouts);
    }
}
}
    

