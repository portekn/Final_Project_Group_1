using Final_Project_Group_1.Information4;
using Final_Project_Group_1.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Final_Project_Group_1.Controllers
{
    [ApiController]
    [Route("api/[controller]")]

    public class MovieController : ControllerBase
    {
        private readonly IServiceContract4 _movies;

        public MovieController(IServiceContract4 movies)
        {
            _movies = movies;
        }

        [HttpGet]
        [Route("[action]")]
        [Route("api/Movie/GetMovies")]
        public IEnumerable<Movie> GetMovies()
        {
            return _movies.GetMovies();
        }

        [HttpPost]
        [Route("[action]")]
        [Route("api/Movie/AddMovie")]
        public IActionResult AddMovie(Movie movie)
        {
            _movies.AddMovie(movie);
            return Ok();
        }

        [HttpPost]
        [Route("[action]")]
        [Route("api/Movie/UpdateMovie")]
        public IActionResult UpdateMovie(Movie movie)
        {
            _movies.UpdateMovie(movie);
            return Ok();
        }

        [HttpDelete]
        [Route("[action]")]
        [Route("api/Movie/DeleteMovie")]
        public IActionResult DeleteMovie(int id)
        {
            var existingMovie = _movies.GetMovie(id);
            if (existingMovie != null)
            {
                _movies.DeleteMovie(existingMovie.Id);
                return Ok();
            }
            return NotFound($"Employee not found with ID: { existingMovie.Id}");
        }

        [HttpGet]
        [Route("GetMovie")]
        public Movie GetMovie(int id)
        {
            return _movies.GetMovie(id);
        }
    }
}
