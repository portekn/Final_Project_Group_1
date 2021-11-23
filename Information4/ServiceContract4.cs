using Final_Project_Group_1.Models; 
using System.Collections.Generic;  
using System.Linq;  

    namespace Final_Project_Group_1.Information4
    {  
        public class ServiceContract4: IServiceContract4
        {   
            public MovieContext _movieContext; 
            public ServiceContract3 (MovieContext moviescontext)  
            {
                _movieContext = moviescontext;
            }  

        //----------Add Movie----------//
            public Movie AddMovie(Movie movie)  
            {
                _movieContext.Movies.Add(movie);
                _movieContext.SaveChanges();  
                return movie;  
            }

        //----------Get Movie----------//
            public List<Movie> GetMovies()  
            {  
                return _moviesContext.Movies.ToList();  
            }

        //----------Update Movie----------//
            public void UpdateMovie(Movie movie)  
            {
                _moviesContext.Movies.Update(Movie);
                _moviesContext.SaveChanges();  
            }

        //----------Delete Movie----------//
            public void DeleteMovie(string movie)  
            {  
                var variable2 = _moviesContext.Movies.FirstOrDefault(x => x.movie == movie);
                if (variable2 != null)  
                {
                    _moviesContext.Remove(variable2);
                    _moviesContext.SaveChanges();  
                }  
            }

        //----------Get Movie----------//
            public Movie GetMovie(string movie)  
            {  
                return _moviesContext.Movies.FirstOrDefault(x => x.movie == movie);  
            }  
        }  
 }
