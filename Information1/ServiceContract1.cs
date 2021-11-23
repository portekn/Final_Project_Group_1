using Final_Project_Group_1.Models; 
using System.Collections.Generic;  
using System.Linq;  

    namespace Final_Project_Group_1.Information1
    {  
        public class ServiceContract1: IServiceContract1
        {   
            public LocationContext _locationDbContext;  
            public ServiceContract1 (LocationContext locationDbContext)  
            {
                _locationDbContext = locationDbContext;
            }  

        //Methods below reference variables from IServiceContract2
        //----------Add Location----------//
            public Location AddLocation(Location location)  
            {
                _locationDbContext.Locations.Add(location);
                _locationDbContext.SaveChanges();  
                return location;
            }

        //----------Get Locations----------//
            public List<Location> GetLocations()  
            {  
                return _locationDbContext.Locations.ToList();  
            }

        //----------Update Location----------//
            public void UpdateLocation(Location location)  
            {
                _locationDbContext.Locations.Update(location);
                _locationDbContext.SaveChanges();  
            }

        //----------Delete Location----------//
            public void DeleteLocation(int Id)  
            {  
                var variable2 = _locationDbContext.Locations.FirstOrDefault(x => x.Id == Id);
                if (variable2 != null)  
                {
                    _locationDbContext.Remove(variable2);
                    _locationDbContext.SaveChanges();  
                }  
            }

        //----------Get Location----------//
            public Location GetLocation(int Id)  
            {  
                return _locationDbContext.Locations.FirstOrDefault(x => x.Id == Id);  
            }  
        }  
 }  