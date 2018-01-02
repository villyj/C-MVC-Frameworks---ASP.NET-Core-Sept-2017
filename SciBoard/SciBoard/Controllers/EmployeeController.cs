using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using SciBoard.Entities;

namespace SciBoard.Controllers
{

    [Route("company/[controller]/[action]")]
    public class EmployeeController : Controller
    {

        public ViewResult Index()
        {
            var model = new List<Material>
        {
            new Material { Id = 1, Title = "Shreck" },
            new Material { Id = 2, Title = "Despicable Me" },
            new Material { Id = 3, Title = "Megamind" }
        };

            return View(model);
        }

      
          
       

    }
}
