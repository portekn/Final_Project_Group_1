using Final_Project_Group_1.Information2;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;

namespace Final_Project_Group_1.controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class Controller2 : ControllerBase
    {
        private readonly ILogger<Controller1> _Logger;

        private readonly IServiceContract2 _variableService;
        public Controller2(IServiceContract2 variableService)
        {
            _variableService = variableService;
        }
        [HttpGet]
        [Route("[action]")]
        [Route("api/ModelFile/GetVariables")]
        public IEnumerable<Variable> GetVariables()
        {
            return _variableService.GetVariables();
        }
        [HttpPost]
        [Route("[action]")]
        [Route("api/ModelFile/AddVariable")]
        public IActionResult AddVariable(Variable variable)
        {
            _variableService.AddVariable(variable);
            return Ok();
        }
        [HttpPost]
        [Route("[action]")]
        [Route("api/ModelFile/UpdateVariable")]
        public IActionResult UpdateVariable(Variable variable)
        {
            _variableService.UpdateVariable(variable);
            return Ok();
        }
        [HttpDelete]
        [Route("[action]")]
        [Route("api/ModelFile/DeleteVariable")]
        public IActionResult DeleteVariable(VariableType variable1)
        {
            var variable2 = _variableService.GetVariable(variable1);
            if (variable2 != null)
            {
                _variableService.DeleteVariable(variable2.variable1);
                return Ok();
            }
            return NotFound($"Thing Not Found with ID : {variable2.variable1}");
        }
        [HttpGet]
        [Route("GetVariable")]
        public Employee GetVariable(VariableType variable1)
        {
            return _variableService.GetVariable(variable1);
        }
    }
}