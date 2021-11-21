using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Final_Project_Group_1;


namespace Final_Project_Group_1.controller
{
    [ApiController]
    [Route ("[controller]")]
    public class Controller1 : ControllerBase
    {
        private readonly ILogger<Controller1> _Logger;
        private readonly ServiceContext1 _Context;
        
        public Controller1(ILogger<Controller1> Logger, ServiceContext1 Context)
        {
            _Logger = Logger;
            _Context = Context;
        }

        [HttpGet]

        public IActionResult Get()
        {
            return Ok(_Context.ServiceContext1.ToList());
        }
    }
}