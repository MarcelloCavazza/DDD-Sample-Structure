using Microsoft.AspNetCore.Mvc;

namespace DDD.API.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
