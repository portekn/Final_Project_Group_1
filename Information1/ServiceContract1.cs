using Final_Project_Group_1.Models; 
using System.Collections.Generic;  
using System.Linq;  

    namespace Final_Project_Group_1.Information1
    {  
        public class ServiceContract1: IServiceContract1
        {   
            public DatabaseContext _members;  
            public ServiceContract1 (DatabaseContext members)  
            {
                _members = members;
            }

        //Methods below reference variables from IServiceContract2
        //----------Add Member----------//
        public Member AddMember(Member member)  
            {
                _members.Members.Add(member);
                _members.SaveChanges();  
                return member;
            }

        //----------Get Members----------//
            public List<Member> GetMembers()  
            {  
                return _members.Members.ToList();  
            }

        //----------Update Member----------//
        public void UpdateMember(Member member)  
            {
                _members.Members.Update(member);
                _members.SaveChanges();  
            }

        //----------Delete Member----------//
        public void DeleteMember(int Id)  
            {  
                var variable2 = _members.Members.FirstOrDefault(x => x.Id == Id);
                if (variable2 != null)  
                {
                    _members.Remove(variable2);
                    _members.SaveChanges();  
                }  
            }

        //----------Get Member----------//
        public Member GetMember(int Id)  
            {  
                return _members.Members.FirstOrDefault(x => x.Id == Id);  
            }  
        }  
 }  