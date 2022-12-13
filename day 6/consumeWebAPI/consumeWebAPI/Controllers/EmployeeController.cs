using Microsoft.AspNetCore.Mvc;

namespace consumeWebAPI.Controllers
{
    public class EmployeeController : Controller
    {
        public IActionResult ShowEmployee()
        {
            return View();
        }
    }
}
