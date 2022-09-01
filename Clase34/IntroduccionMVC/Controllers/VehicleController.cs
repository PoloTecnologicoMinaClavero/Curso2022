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

            var model = new VehicleListViewModel
            {
                Vehiculos = vehiculos
                    .Select(v => new VehicleListModel
                    {
                        Id = v.Id,
                        Dominio = v.Dominio,
                        AnioFabricacion = v.AnioFabricacion
                    })
                    .ToList()
            };
            
            return View("List", model);
        }
    }
}
