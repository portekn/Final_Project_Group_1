using Final_Project_Group_1.Models;
using System.Collections.Generic;

namespace Final_Project_Group_1.Information1  
    {  
    //Interface name needs to include �I� at the beginning 
    public interface IServiceContract1
    {
        Basic AddBasic(Basic basic);
        List<Basic> GetBasics();
        void UpdateBasic(Basic basic);
        void DeleteBasic(int Id);
        Basic GetBasic(int Id);
    }
}