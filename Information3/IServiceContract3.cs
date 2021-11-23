using Final_Project_Group_1.Models;
using System.Collections.Generic;

namespace Final_Project_Group_1.Information2
{
    public interface IServiceContract3
    {
        Interest AddInterest(Interest insterest);
        List<Interest> GetInterests();
        void UpdateInterest(Interest interest);
        void DeleteInterest(string interest);
        Interest GetInterest(string interest);
    }
}