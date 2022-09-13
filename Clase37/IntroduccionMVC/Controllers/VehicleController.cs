using IntroduccionMVC.Data;
using IntroduccionMVC.Data.Entities;
using IntroduccionMVC.Models;
using Microsoft.AspNetCore.Mvc;
using System.Runtime.CompilerServices;

namespace IntroduccionMVC.Controllers
{
    public class VehicleController : Controller
    {
        private readonly ApplicationDbContext _dbContext;
        
        public VehicleController(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        
        public IActionResult Edit()
        {
            return View();
        }

        public IActionResult New()
        {
            return View();
        }

        //Post
        [HttpPost] 
        public async Task<IActionResult> Create (Vehiculo vehiculo)
        {
            try
            {
                _dbContext.Add(vehiculo);
                await _dbContext.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            catch (Exception ex)
            {
                return RedirectToAction(nameof(Index));
                //throw;
            }
        }

        public IActionResult Index()
        {
            var vehiculos = _dbContext.Vehiculos.ToList();

            //var model = new VehicleListViewModel
            //{
            //    Vehiculos = new List<VehicleListModel>()
            //};

            //foreach(var vehiculo in vehiculos)
            //{
            //    model.Vehiculos.Add(new VehicleListModel
            //    {
            //        Id = vehiculo.Id,
            //        Dominio = vehiculo.Dominio,
            //        AnioFabricacion = vehiculo.AnioFabricacion
            //    });
            //}

            var vehiclesList = vehiculos
                .Select(v => new VehicleListModel
                {
                    Id = v.Id,
                    Dominio = v.Dominio,
                    AnioFabricacion = v.AnioFabricacion
                })
                .ToList();

            ViewData["miTitulo"] = "My Vehicles";
           // ViewData["Vehicles"] = vehiclesList;

            ViewBag.Vehicles = vehiclesList;

            return View("List");
        }
    }
}
