using Microsoft.AspNetCore.Mvc;
using WebApp.Models;

namespace WebApp.Controllers
{
    public class BrandController : Controller
    {
        BrandRepository _repository;
        public BrandController(BrandRepository repository)
        {
            this._repository = repository;   
        }
        public IActionResult Index()
        {
            List<Brand> list = _repository.GetBrands();  
            return View(list);
        }
    }
}
