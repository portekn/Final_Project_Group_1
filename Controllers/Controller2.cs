using Final_Project_Group_1.Models;
using Final_Project_Group_1.Information2;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace FinalProject.Controllers
{
    [ApiController]
    [Route("api/[controller]")]

    public class LocationController : ControllerBase
    {
        private readonly IServiceContract2 _location;

        public LocationController(IServiceContract2 location)
        {
            _location = location;
        }

        [HttpGet]
        [Route("[action]")]
        [Route("api/Location/GetLocations")]
        public IEnumerable<Location> GetLocations()
        {
            return _location.GetLocations();
        }

        [HttpPost]
        [Route("[action]")]
        [Route("api/Location/AddLocation")]
        public IActionResult AddLocation(Location location)
        {
            _location.AddLocation(location);
            return Ok();
        }

        [HttpPost]
        [Route("[action]")]
        [Route("api/Location/UpdateLocation")]
        public IActionResult UpdateLocation(Location location)
        {
            _location.UpdateLocation(location);
            return Ok();
        }

        [HttpDelete]
        [Route("[action]")]
        [Route("api/Location/DeleteLocation")]
        public IActionResult DeleteLocation(int id)
        {
            var existingLocation = _location.GetLocation(id);
            if (existingLocation != null)
            {
                _location.DeleteLocation(existingLocation.Id);
                return Ok();
            }
            return NotFound($"Employee not found with ID: { existingLocation.Id}");
        }

        [HttpGet]
        [Route("GetLocation")]
        public Location GetLocation(int id)
        {
            return _location.GetLocation(id);
        }
    }
}