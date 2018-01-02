using System;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using SciBoard.Services;
using SciBoard.ViewModels;

namespace SciBoard.Controllers
{
    //[Route("[controller]/[action]")]
    public class HomeController : Controller
    {
        private IMaterialData _material;
        public HomeController(IMaterialData material)
        {
            _material = material;
        }
      

        public ViewResult Index()

        {
            var model = _material.GetAll().Select(video => new VideoViewModel
            {
                Id = video.Id,
                Title = video.Title,
                Genre = Enum.GetName(typeof(Genres),video.GenreId)
            });
            return View(model);
        }

       
     
        public IActionResult Details(int id)
        {
            var model = _material.Get(id);
            if (model == null) return RedirectToAction("Index");
            return View(new VideoViewModel {
                Id = model.Id,
                Title = model.Title,
                Genre = Enum.GetName(typeof(Genres), model.GenreId)
            });

          

        }

       

       
    }
}
