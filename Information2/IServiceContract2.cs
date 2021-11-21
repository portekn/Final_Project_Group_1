using Final_Project_Group_1.Models;
using System.Collections.Generic;

namespace Final_Project_Group_1.Information2
{
    //Interface name needs to include “I” at the beginning 
    public interface IServiceContract2
    {
        Location AddLocation(Location location);
        List<Location> GetLocations();
        void UpdateLocation(Location location);
        void DeleteLocation(int Id);
        Location GetLocation(int Id);
    }
}