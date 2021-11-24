using Final_Project_Group_1.Models;
using System.Collections.Generic;

namespace Final_Project_Group_1.Information4
{
    public interface IServiceContract4
    {
        Movie AddMovie(Movie movie);
        List<Movie> GetMovies();
        void UpdateMovie(Movie movie);
        void DeleteMovie(int Id);
        Movie GetMovie(int Id);
    }
}
