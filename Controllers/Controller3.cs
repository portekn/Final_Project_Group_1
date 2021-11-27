using Final_Project_Group_1.Information3;
using Final_Project_Group_1.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Final_Project_Group_1.Controllers
{
    [ApiController]
    [Route("api/[controller]")]

    public class InterestController : ControllerBase
    {
        private readonly IServiceContract3 _interest;

        public InterestController(IServiceContract3 interest)
        {
            _interest = interest;
        }

        [HttpGet]
        [Route("[action]")]
        [Route("api/Interest/GetInterests")]
        public IEnumerable<Interest> GetInterests()
        {
            return _interest.GetInterests();
        }

        [HttpPost]
        [Route("[action]")]
        [Route("api/Interest/AddInterest")]
        public IActionResult AddInterest(Interest interest)
        {
            _interest.AddInterest(interest);
            return Ok();
        }

        [HttpPost]
        [Route("[action]")]
        [Route("api/Interest/UpdateInterest")]
        public IActionResult UpdateInterest(Interest interest)
        {
            _interest.UpdateInterest(interest);
            return Ok();
        }

        [HttpDelete]
        [Route("[action]")]
        [Route("api/Interest/DeleteInterest")]
        public IActionResult DeleteInterest(int id)
        {
            var existingInterest = _interest.GetInterest(id);
            if (existingInterest != null)
            {
                _interest.DeleteInterest(existingInterest.Id);
                return Ok();
            }
            return NotFound($"Employee not found with ID: { existingInterest.Id}");
        }

        [HttpGet]
        [Route("GetInterest")]
        public Interest GetInterest(int id)
        {
            return _interest.GetInterest(id);
        }
    }
}