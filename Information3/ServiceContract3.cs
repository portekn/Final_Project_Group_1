using Final_Project_Group_1.Models; 
using System.Collections.Generic;  
using System.Linq;  

    namespace Final_Project_Group_1.Information2
    {  
        public class ServiceContract3: IServiceContract3 
        {   
            public InterestContext _interestContext; 
            public ServiceContract3 (InterestContext context)  
            {
                _interestContext = context;
            }  

        //----------Add Interest----------//
            public Location AddInterest(Interest interest)  
            {
                _interestContext.Interests.Add(location);
                _interestContext.SaveChanges();  
                return interest;  
            }

        //----------Get Interests----------//
            public List<Location> GetInterests()  
            {  
                return _interestContext.Interests.ToList();  
            }

        //----------Update Interest----------//
            public void UpdateInterest(Interest interest)  
            {
                _interestContext.Interests.Update(interest);
                _interestContext.SaveChanges();  
            }

        //----------Delete Interest----------//
            public void DeleteInterest(string interest)  
            {  
                var variable2 = _interestContext.Interests.FirstOrDefault(x => x.interest == interest);
                if (variable2 != null)  
                {
                    _interestContext.Remove(variable2);
                    _interestContext.SaveChanges();  
                }  
            }

        //----------Get Interest----------//
            public Location GetInterest(string interest)  
            {  
                return _interestContext.Interests.FirstOrDefault(x => x.interest == interest);  
            }  
        }  
 }  