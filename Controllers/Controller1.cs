using Final_Project_Group_1.Information1;
using Final_Project_Group_1.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;

namespace Final_Project_Group_1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Controller1 : ControllerBase
    {
        private readonly ILogger<Controller1> _Logger;

        private readonly IServiceContract1 _basic;
        public Controller1(IServiceContract1 basic)
        {
            _basic = basic;
        }
        [HttpGet]
        [Route("[action]")]
        [Route("api/Model1/GetBasic")]
        public IEnumerable<Basic> GetBasics()
        {
            return _basic.GetBasics();
        }
        [HttpPost]
        [Route("[action]")]
        [Route("api/Model1/AddBasic")]
        public IActionResult AddBasic(Basic basic)
        {
            _basic.AddBasic(basic);
            return Ok();
        }
        [HttpPost]
        [Route("[action]")]
        [Route("api/Model1/UpdateBasic")]
        public IActionResult UpdateBasic(Basic basic)
        {
            _basic.UpdateBasic(basic);
            return Ok();
        }
        [HttpDelete]
        [Route("[action]")]
        [Route("api/Model1/DeleteBasic")]
        public IActionResult DeleteBasic(int Id)
        {
            var variable2 = _basic.GetBasic(Id);
            if (variable2 != null)
            {
                _basic.DeleteBasic(variable2.Id);
                return Ok();
            }
            return NotFound($"Thing Not Found with ID : {variable2.Id}");
        }
        [HttpGet]
        [Route("GetBasic")]
        public Basic GetBasic(int Id)
        {
            return _basic.GetBasic(Id);
        }
    }
}