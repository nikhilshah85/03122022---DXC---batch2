using Microsoft.AspNetCore.Mvc;
using DI_Demo.Models;
namespace DI_Demo.Controllers
{
    public class EmployeeController : Controller
    {

        //This is Developer creating object, which is not good 
       // Employee empObj = new Employee(); //this is wrong

        Employee _empObj;


        public EmployeeController(Employee empObjREF)
        {
            this._empObj = empObjREF;
        }

        public IActionResult ShowALlEmployee()
        {
            ViewBag.eList = _empObj.GetALlEmployees();
            return View();
        }

        public IActionResult SearchEmployee()
        {
            ViewBag.hasData = false;
            return View();
        }
        [HttpPost]
        public IActionResult SearchEmployee(int empNo)
        {
            ViewBag.hasData = true;
            ViewBag.empDetails = _empObj.GetEmpById(empNo);
            return View();
        }

        public IActionResult SearchEmployeeByDesignation()
        {
            ViewBag.hasData = true;
            return View();
        }
        [HttpPost]
        public IActionResult SearchEmployeeByDesignation(string empDesignation)
        {
            ViewBag.hasData = true;
            ViewBag.empDetails = _empObj.GetEmpByDesigantion(empDesignation);
            return View();
        }

    }
}
