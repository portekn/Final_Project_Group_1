using Final_Project_Group_1.Models; 
using System.Collections.Generic;  
using System.Linq;

namespace Final_Project_Group_1.Information1
{
    public class ServiceContract1 : IServiceContract1
    {
        public BasicContext _basicDbContext;
        public ServiceContract1(BasicContext basicDbContext)
        {
            _basicDbContext = basicDbContext;
        }

        //Methods below reference variables from IServiceContract2
        //----------Add Location----------//
        public Basic AddBasic(Basic basic)
        {
            _basicDbContext.Basics.Add(basic);
            _basicDbContext.SaveChanges();
            return basic;
        }

        //----------Get Locations----------//
        public List<Basic> GetBasics()
        {
            return _basicDbContext.Basics.ToList();
        }

        //----------Update Location----------//
        public void UpdateBasic(Basic basic)
        {
            _basicDbContext.Basics.Update(basic);
            _basicDbContext.SaveChanges();
        }

        //----------Delete Location----------//
        public void DeleteBasic(int Id)
        {
            var variable2 = _basicDbContext.Basics.FirstOrDefault(x => x.Id == Id);
            if (variable2 != null)
            {
                _basicDbContext.Remove(variable2);
                _basicDbContext.SaveChanges();
            }
        }

        //----------Get Location----------//
        public Basic GetBasic(int Id)
        {
            return _basicDbContext.Basics.FirstOrDefault(x => x.Id == Id);
        }
    }

}  