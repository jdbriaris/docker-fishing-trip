using Microsoft.AspNetCore.Mvc;
using docker_fishing_trip.Models;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace docker_fishing_trip.Controllers
{
    public class PieController : Controller
    {
        private readonly IPieRepository _pieRepository; 
        private readonly ICategoryRepository _categoryRepository;

        public PieController(IPieRepository pieRepository, ICategoryRepository categoryRepository)
        {
            _pieRepository = pieRepository;
            _categoryRepository = categoryRepository;
        }

        public ViewResult List()
        {
            return View(_pieRepository.Pies);
        }
    }
}
