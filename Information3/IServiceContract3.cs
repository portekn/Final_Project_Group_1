using Final_Project_Group_1.Models;
using System.Collections.Generic;

namespace Final_Project_Group_1.Information3
{
    public interface IServiceContract3
    {
        Interest AddInterest(Interest insterest);
        List<Interest> GetInterests();
        void UpdateInterest(Interest interest);
        void DeleteInterest(int Id);
        Interest GetInterest(int Id);
    }
}