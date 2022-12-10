using Microsoft.AspNetCore.Mvc;

namespace consumeWebAPI.Controllers
{
    public class ProductsController : Controller
    {
        public IActionResult ShowProducts()
        {
            return View();
        }
    }
}
