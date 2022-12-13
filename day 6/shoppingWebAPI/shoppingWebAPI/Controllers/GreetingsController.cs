using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Reflection.Metadata.Ecma335;

namespace shoppingWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GreetingsController : ControllerBase
    {

        [HttpGet]
        [Route("greetuser")]
        public IActionResult Greet()
        {   //collect data from model
            //pass data to Model
            return Ok("Hello and Welcome to WebAPI ");
        }

        [HttpGet]
        [Route("greetuser/{name}/{lastname}")]
        public IActionResult Greet(string name, string lastname)
        {
            return Ok("Hello " + name + " " + lastname);
        }

        List<string> techNames = new List<string>()
            {
                ".Net Core","Angular","React","Javascript","PowerBI","Azure"
            };
        [HttpGet]
        [Route("technology")]
        public IActionResult GetTechnologyNames()
        {
           
            return Ok(techNames);
               
        }

        [HttpGet]
        [Route("technology/{position}")]
        public IActionResult GetTechByPosition(int position)
        {
            try
            {
                var tech = techNames[position];
                return Ok(tech);
            }
            catch(ArgumentOutOfRangeException es)
            {
                return NotFound("No technology at this Position");
            }
        }



    }
}
