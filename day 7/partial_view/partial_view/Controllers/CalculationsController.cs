using Microsoft.AspNetCore.Mvc;

namespace partial_view.Controllers
{
    public class CalculationsController : Controller
    {
        public IActionResult Greetings()
        {
            return View();
        }

        public IActionResult test()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Greetings(string guestName)
        {
            ViewBag.greetMessage = "Hello and welcome to my App " + guestName;
            return View();
        }

        [HttpPost]
        public IActionResult GreetingsPartTwo(string firstName, string lastName)
        {
            ViewBag.greetMessage = "Hello and welcome to my App " + firstName;
            if (lastName.Length > 0)
            {
                ViewBag.fullNameGreet = "Hello " + firstName + " " + lastName + " Wonderful to have to you here";
            }
            ViewBag.fullNameGreet = "";
            return View("Greetings");
        }


        public IActionResult CalculateNumbers()
        {
            ViewBag.hasErr = "No";
            return View();
        }
        [HttpPost]
        public IActionResult CalculateNumbers(int firstNumber, int secondNumber)
        {
            if (firstNumber == 0 || secondNumber == 0)
            {
                ViewBag.hasErr = "Yes";
                ViewBag.errMessage = "Please Enter Numbers greater than Zero Only";
            }
            else if (firstNumber < 0 || secondNumber < 0)
            {
                ViewBag.hasErr = "Yes";
                ViewBag.errMessage = "Please Enter Only Positive Numbers";
            }
            else
            {
                ViewBag.hasErr = "No";
                ViewBag.addition = "Addition is " + (firstNumber + secondNumber);
                ViewBag.subtraction = "Subtraction is " + (firstNumber - secondNumber);
                ViewBag.division = "Division is " + (firstNumber / secondNumber);
                ViewBag.multiplication = "Multiplication is " + (firstNumber * secondNumber);
            }
            return View();
        }



    }
}
