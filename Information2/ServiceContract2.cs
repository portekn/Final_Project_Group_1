using Final_Project_Group_1.Models; 
using System.Collections.Generic;  
using System.Linq;  

    namespace Final_Project_Group_1.Information2
    {  
        public class ServiceContract2: IServiceContract2 
        {   
            public LocationContext _locationDbContext;  
            public ServiceContract2 (LocationContext locationDbContext)  
            {
                _locationDbContext = locationDbContext;
            }  

            //Methods below reference variables from IServiceContract 1
            public Location AddLocation(Location location)  
            {
                _locationDbContext.Locations.Add(location);
                _locationDbContext.SaveChanges();  
                return location;  
            }  
            public List<Location> GetLocations()  
            {  
                return _locationDbContext.Locations.ToList();  
            }  
      
            public void UpdateLocation(Location location)  
            {
                _locationDbContext.Locations.Update(location);
                _locationDbContext.SaveChanges();  
            }  
      
            public void DeleteLocation(int Id)  
            {  
                var variable2 = _locationDbContext.Locations.FirstOrDefault(x => x.Id == Id);
                if (variable2 != null)  
                {
                    _locationDbContext.Remove(variable2);
                    _locationDbContext.SaveChanges();  
                }  
            }  
      
            public Location GetLocation(int Id)  
            {  
                return _locationDbContext.Locations.FirstOrDefault(x => x.Id == Id);  
            }  
        }  
 }  