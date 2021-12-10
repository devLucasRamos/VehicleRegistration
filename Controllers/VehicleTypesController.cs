using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using VehicleRegistration.Models;

namespace VehicleRegistration.Controllers
{
    public class VehicleTypesController : Controller
    {
        public IActionResult Index()
        {
            List<VehicleTypes> list = new List<VehicleTypes>();
            list.Add(new VehicleTypes { Id = 1, Name = "Carro" });
            list.Add(new VehicleTypes { Id = 2, Name = "Moto" });
            list.Add(new VehicleTypes { Id = 3, Name = "Carro e Moto" });

            return View();
        }
    }
}
