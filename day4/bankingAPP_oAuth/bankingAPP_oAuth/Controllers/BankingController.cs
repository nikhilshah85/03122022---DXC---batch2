using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace bankingAPP_oAuth.Controllers
{

    [Authorize]
    public class BankingController : Controller
    {

        [AllowAnonymous]
        public IActionResult BankingHome()
        {
            return View();
        }
        [AllowAnonymous]
        public IActionResult Services()
        {
            return View();
        }

        public IActionResult TransferFunds()
        {
            return View();
        }

        public IActionResult DownloadStatement()
        {
            return View();
        }
    }
}
