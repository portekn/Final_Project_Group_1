using Final_Project_Group_1.Models; 
using System.Collections.Generic;  
using System.Linq;  

    namespace Final_Project_Group_1.Information4
    {  
        public class ServiceContract4: IServiceContract4
        {   
            public MovieContext _movieDbcontext; 
            public ServiceContract4 (MovieContext movieDbcontext)  
            {
                _movieDbcontext = movieDbcontext;
            }  

        //----------Add Movie----------//
            public Movie AddMovie(Movie movie)  
            {
                _movieDbcontext.Movies.Add(movie);
                _movieDbcontext.SaveChanges();  
                return movie;  
            }

        //----------Get Movie----------//
            public List<Movie> GetMovies()  
            {  
                return _movieDbcontext.Movies.ToList();  
            }

        //----------Update Movie----------//
            public void UpdateMovie(Movie movie)  
            {
                _movieDbcontext.Movies.Update(movie);
                _movieDbcontext.SaveChanges();  
            }

        //----------Delete Movie----------//
            public void DeleteMovie(int Id)  
            {  
                var variable2 = _movieDbcontext.Movies.FirstOrDefault(x => x.Id == Id);
                if (variable2 != null)  
                {
                    _movieDbcontext.Remove(variable2);
                    _movieDbcontext.SaveChanges();  
                }  
            }

        //----------Get Movie----------//
            public Movie GetMovie(int Id)  
            {  
                return _movieDbcontext.Movies.FirstOrDefault(x => x.Id == Id);  
            }  
        }  
 }
