using Final_Project_Group_1.Models;
using System.Collections.Generic;

namespace Final_Project_Group_1.Information1  
    {  
    //Interface name needs to include �I� at the beginning 
    public interface IServiceContract1
    {
        Member AddMember(Member member);
        List<Member> GetMembers();
        void UpdateMember(Member member);
        void DeleteMember(int Id);
        Member GetMember(int Id);
    }
}