using Final_Project_Group_1.Models; 
using System.Collections.Generic;  
using System.Linq;  

    namespace Final_Project_Group_1.Information3
    {  
        public class ServiceContract3: IServiceContract3 
        {   
            public DatabaseContext _interestContext; 
            public ServiceContract3 (DatabaseContext context)  
            {
                _interestContext = context;
            }  

        //----------Add Interest----------//
            public Interest AddInterest(Interest interest)  
            {
                _interestContext.Interests.Add(interest);
                _interestContext.SaveChanges();  
                return interest;  
            }

        //----------Get Interests----------//
            public List<Interest> GetInterests()  
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
            public void DeleteInterest(int Id)  
            {  
                var variable2 = _interestContext.Interests.FirstOrDefault(x => x.Id == Id);
                if (variable2 != null)  
                {
                    _interestContext.Remove(variable2);
                    _interestContext.SaveChanges();  
                }  
            }

        //----------Get Interest----------//
            public Interest GetInterest(int Id)  
            {  
                return _interestContext.Interests.FirstOrDefault(x => x.Id == Id);  
            }  
        }  
 }  