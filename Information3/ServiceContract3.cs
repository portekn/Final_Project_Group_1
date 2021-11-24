using Final_Project_Group_1.Models; 
using System.Collections.Generic;
using System.Linq;

namespace Final_Project_Group_1.Information3
    {  
        public class ServiceContract3: IServiceContract3
        {   
            public InterestContext _interestDbContext; 
            public ServiceContract3 (InterestContext interestDbContext)  
            {
            _interestDbContext = interestDbContext;
            }  

        //----------Add Interest----------//
            public Interest AddInterest(Interest interest)  
            {
            _interestDbContext.Interests.Add(interest);
            _interestDbContext.SaveChanges();  
                return interest;  
            }

        //----------Get Interests----------//
            public List<Interest> GetInterests()  
            {  
                return _interestDbContext.Interests.ToList();  
            }

        //----------Update Interest----------//
            public void UpdateInterest(Interest interest)  
            {
            _interestDbContext.Interests.Update(interest);
            _interestDbContext.SaveChanges();  
            }

        //----------Delete Interest----------//
            public void DeleteInterest(int Id)  
            {  
                var variable2 = _interestDbContext.Interests.FirstOrDefault(x => x.Id == Id);
                if (variable2 != null)  
                {
                _interestDbContext.Remove(variable2);
                _interestDbContext.SaveChanges();  
                }  
            }

        //----------Get Interest----------//
            public Interest GetInterest(int Id)  
            {  
                return _interestDbContext.Interests.FirstOrDefault(x => x.Id == Id);  
            }  
        }  
 }  