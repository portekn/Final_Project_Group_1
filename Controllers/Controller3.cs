using Final_Project_Group_1.Information3;
using Final_Project_Group_1.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;

namespace Final_Project_Group_1.Controllers
{
    [Route("api/[Controllers]")]
    [ApiController]
    public class Controller3 : ControllerBase
    {
        private readonly ILogger<Controller3> _Logger;

        private readonly IServiceContract3 _interest;
        public Controller3(IServiceContract3 interest)
        {
            _interest = interest;
        }
        [HttpGet]
        [Route("[action]")]
        [Route("api/Model3/GetInterests")]
        public IEnumerable<Interest> GetInterests()
        {
            return _interest.GetInterests();
        }
        [HttpPost]
        [Route("[action]")]
        [Route("api/Model3/AddInterest")]
        public IActionResult AddInterest(Interest interest)
        {
            _interest.AddInterest(interest);
            return Ok();
        }
        [HttpPost]
        [Route("[action]")]
        [Route("api/Model3/UpdateInterest")]
        public IActionResult UpdateInterest(Interest interest)
        {
            _interest.UpdateInterest(interest);
            return Ok();
        }
        [HttpDelete]
        [Route("[action]")]
        [Route("api/Model3/DeleteInterest")]
        public IActionResult DeleteInterest(int Id)
        {
            var variable2 = _interest.GetInterest(Id);
            if (variable2 != null)
            {
                _interest.DeleteInterest(variable2.Id);
                return Ok();
            }
            return NotFound($"Thing Not Found with ID : {variable2.Id}");
        }
        [HttpGet]
        [Route("GetInterest")]
        public Interest GetInterest(int Id)
        {
            return _interest.GetInterest(Id);
        }
    }
}