using Microsoft.AspNetCore.Mvc;
using DI_Demo.Models.Interfaces;
namespace DI_Demo.Controllers
{
    public class AccountsController : Controller
    {


        IAccounts _accObj;
     
        public AccountsController(IAccounts accObj)
        {
            _accObj = accObj;
            
        }

        public IActionResult ShowAllAccounts()
        {
            ViewBag.accDetails = _accObj.GetAllAccounts();
            return View();
        }








    }
}
