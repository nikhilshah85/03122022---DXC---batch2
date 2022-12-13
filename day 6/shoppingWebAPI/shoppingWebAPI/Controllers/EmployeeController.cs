using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using shoppingWebAPI.Models;
namespace shoppingWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        EmployeeModel eObj = new EmployeeModel();

        [HttpGet]
        [Route("elist")]
        public IActionResult AllEmployees()
        {
            return Ok(eObj.GetAllEmployees());
        }
        [HttpGet]
        [Route("elist/id/{id}")]
        public IActionResult GetEmployeeById(int id)
        {
            try
            {
                return Ok(eObj.GetEmployeeById(id));
            }
            catch (Exception es)
            {

                return NotFound(es.Message);
            }
        }
        [HttpGet]
        [Route("elist/designation/{designation}")]
        public IActionResult GetEmployeeByDesignation(string designation)
        {
            try
            {
                return Ok(eObj.GetEmployeeBydesignation(designation));
            }
            catch (Exception es)
            {

                return NotFound(es.Message);
            }
        }
        [HttpGet]
        [Route("elist/ispermenant/{isPermenant}")]
        public IActionResult GetEmployeeByStatus(bool isPermenant)
        {
            try
            {
                return Ok(eObj.GetEmployeeByStatus(isPermenant));
            }
            catch (Exception es)
            {
                return NotFound(es.Message);
            }
        }
        [HttpGet]
        [Route("elist/totalsalary")]
        public IActionResult GetTotalSalary()
        {
            return Ok(eObj.GetTotalSalaryPaid());
        }

        [HttpPost]
        [Route("elist/add")]
        public IActionResult AddNewEmployee([FromBody]EmployeeModel newEmp)
        {
            try
            {
                return Created("", eObj.AddEmployee(newEmp));
                    
            }
            catch (Exception es)
            {
                return BadRequest(es.Message);
            }
        }
        [HttpDelete]
        [Route("elist/delete/{id}")]
        public IActionResult DeleteEmployee(int id)
        {
            try
            {
                return Accepted(eObj.DeleteEmployee(id));
            }
            catch (Exception es)
            {
                return BadRequest(es.Message);
            }
        }
        [HttpPut]
        [Route("elist/edit")]
        public IActionResult UpdateEmployee([FromBody] EmployeeModel newDetails)
        {
            try
            {
                return Accepted(eObj.updateEmployee(newDetails));
            }
            catch (Exception es)
            {
                return BadRequest(es.Message);
            }
        }
    }
}
