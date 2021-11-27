using Final_Project_Group_1.Models; 
using System.Collections.Generic;  
using System.Linq;  

    namespace Final_Project_Group_1.Information4
    {  
        public class ServiceContract4: IServiceContract4
        {   
            public DatabaseContext _movies; 
            public ServiceContract4 (DatabaseContext movies)  
            {
                _movies = movies;
            }  

        //----------Add Movie----------//
            public Movie AddMovie(Movie movie)  
            {
                _movies.Movies.Add(movie);
                _movies.SaveChanges();  
                return movie;  
            }

        //----------Get Movie----------//
            public List<Movie> GetMovies()  
            {  
                return _movies.Movies.ToList();  
            }

        //----------Update Movie----------//
            public void UpdateMovie(Movie movie)  
            {
                _movies.Movies.Update(movie);
                _movies.SaveChanges();  
            }

        //----------Delete Movie----------//
            public void DeleteMovie(int Id)  
            {  
                var variable2 = _movies.Movies.FirstOrDefault(x => x.Id == Id);
                if (variable2 != null)  
                {
                    _movies.Remove(variable2);
                    _movies.SaveChanges();  
                }  
            }

        //----------Get Movie----------//
            public Movie GetMovie(int Id)  
            {  
                return _movies.Movies.FirstOrDefault(x => x.Id == Id);  
            }  
        }  
 }
