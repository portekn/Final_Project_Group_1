using Final_Project_Group_1.Information4;
using Final_Project_Group_1.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;

namespace Final_Project_Group_1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Controller4 : ControllerBase
    {
        private readonly ILogger<Controller4> _Logger;

        private readonly IServiceContract4 _movie;
        public Controller4(IServiceContract4 movie)
        {
            _movie = movie;
        }
        [HttpGet]
        [Route("[action]")]
        [Route("api/Model4/GetMovie")]
        public IEnumerable<Movie> GetMovies()
        {
            return _movie.GetMovies();
        }
        [HttpPost]
        [Route("[action]")]
        [Route("api/Model4/AddMovie")]
        public IActionResult AddMovie(Movie movie)
        {
            _movie.AddMovie(movie);
            return Ok();
        }
        [HttpPost]
        [Route("[action]")]
        [Route("api/Model4/UpdateMovie")]
        public IActionResult UpdateMovie(Movie movie)
        {
            _movie.UpdateMovie(movie);
            return Ok();
        }
        [HttpDelete]
        [Route("[action]")]
        [Route("api/Model4/DeleteMovie")]
        public IActionResult DeleteMovie(int Id)
        {
            var variable2 = _movie.GetMovie(Id);
            if (variable2 != null)
            {
                _movie.DeleteMovie(variable2.Id);
                return Ok();
            }
            return NotFound($"Thing Not Found with movie : {variable2.Id}");
        }
        [HttpGet]
        [Route("GetMovie")]
        public Movie GetMovie(int Id)
        {
            return _movie.GetMovie(Id);
        }
    }
}
