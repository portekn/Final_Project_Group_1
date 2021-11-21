using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Final_Project_Group_1.controller
{
    [Route ("api/[controller]")]
    [ApiController]
    public class Controller1 : ControllerBase
    {
        private readonly ILogger<Controller1> _Logger;
    }
}