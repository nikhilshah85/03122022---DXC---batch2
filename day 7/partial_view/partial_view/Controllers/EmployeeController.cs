using Microsoft.AspNetCore.Mvc;
using partial_view.Models;
namespace partial_view.Controllers
{
    public class EmployeeController : Controller
    {

        Employee empObj = new Employee(); //use DI instead


        public IActionResult ListEmployee()
        {
            ViewBag.empList = empObj.GetEmpList();
            return View();
        }


        public IActionResult AddEmployee()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddEmployee(Employee newEmp)
        {
           ViewBag.result  = empObj.AddEmployee(newEmp);
            return View();
        }




    }
}
