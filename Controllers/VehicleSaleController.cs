using DriveRentSales.Models.Entities;
using DriveRentSales.Repository;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DriveRentSales.Models.Entities;
using DriveRentSales.Repository;
using DriveRentSales.Services;
namespace DriveRentSales.Controllers
{
    public class VehicleSaleController: Controller
    {
       
            private readonly IRepository<VehicleSale> _vehicleSaleRepo;
            private readonly CarServices _accessService;
            public VehicleSaleController(IRepository<VehicleSale> vehicleSaleRepo, CarServices accessService)
            {
                _vehicleSaleRepo = vehicleSaleRepo;
                _accessService = accessService;
            }
            public async Task<IActionResult> Index()
            {
                var workouts = await _vehicleSaleRepo.GetAllAsync();
                if (!workouts.Any())
                {
                    await _vehicleSaleRepo.AddAsync(new VehicleSale
                    {
                        Model = "TUCSON",
                        Brand = "Hyundai",
                        Year = 2023,
                        Fuels = "Diesel",
                        Gearbox = "Authomatic",
                        Price = 20000,
                        Status = true
                    });

                    await _vehicleSaleRepo.AddAsync(new VehicleSale

                    {
                        Model = "Yaris",
                        Brand = "Toyota",
                        Year = 2015,
                        Fuels = "Petrol",
                        Gearbox = "Authomatic",
                        Price = 7500,
                        Status = true
                    });

                    await _vehicleSaleRepo.AddAsync(new VehicleSale

                    {
                        Model = "3",
                        Brand = "Mazda",
                        Year = 2009,
                        Fuels = "Gas",
                        Gearbox = "Manual transmission",
                        Price = 3000,
                        Status = true
                    });

                    workouts = await _vehicleSaleRepo.GetAllAsync();
                }
                return View(workouts);
            }
        }
    }

