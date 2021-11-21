using Final_Project_Group_1.Information2;
using Final_Project_Group_1.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;

namespace Final_Project_Group_1.controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class Controller2 : ControllerBase
    {
        private readonly ILogger<Controller2> _Logger;

        private readonly IServiceContract2 _location;
        public Controller2(IServiceContract2 location)
        {
            _location = location;
        }
        [HttpGet]
        [Route("[action]")]
        [Route("api/Model2/GetLocation")]
        public IEnumerable<Location> GetLocations()
        {
            return _location.GetLocations();
        }
        [HttpPost]
        [Route("[action]")]
        [Route("api/Model2/AddLocation")]
        public IActionResult AddLocation(Location location)
        {
            _location.AddLocation(location);
            return Ok();
        }
        [HttpPost]
        [Route("[action]")]
        [Route("api/Model2/UpdateLocation")]
        public IActionResult UpdateLocation(Location location)
        {
            _location.UpdateLocation(location);
            return Ok();
        }
        [HttpDelete]
        [Route("[action]")]
        [Route("api/Model2/DeleteLocation")]
        public IActionResult DeleteLocation(int Id)
        {
            var variable2 = _location.GetLocation(Id);
            if (variable2 != null)
            {
                _location.DeleteLocation(variable2.Id);
                return Ok();
            }
            return NotFound($"Thing Not Found with ID : {variable2.Id}");
        }
        [HttpGet]
        [Route("GetLocation")]
        public Location GetLocation(int Id)
        {
            return _location.GetLocation(Id);
        }
    }
}