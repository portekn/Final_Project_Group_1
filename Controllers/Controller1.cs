using Final_Project_Group_1.Information1;
using Final_Project_Group_1.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace FinalProject.Controllers
{
    [ApiController]
    [Route("api/[controller]")]

    public class MemberController : ControllerBase
    {
        private readonly IServiceContract1 _members;

        public MemberController(IServiceContract1 members)
        {
            _members = members;
        }

        [HttpGet]
        [Route("[action]")]
        [Route("api/Member/GetMembers")]
        public IEnumerable<Member> GetMembers()
        {
            return _members.GetMembers();
        }

        [HttpPost]
        [Route("[action]")]
        [Route("api/Member/AddMember")]
        public IActionResult AddMember(Member member)
        {
            _members.AddMember(member);
            return Ok();
        }

        [HttpPost]
        [Route("[action]")]
        [Route("api/Member/UpdateMember")]
        public IActionResult UpdateMember(Member member)
        {
            _members.UpdateMember(member);
            return Ok();
        }

        [HttpDelete]
        [Route("[action]")]
        [Route("api/Member/DeleteMember")]
        public IActionResult DeleteMember(int id)
        {
            var existingMember = _members.GetMember(id);
            if (existingMember != null)
            {
                _members.DeleteMember(existingMember.Id);
                return Ok();
            }
            return NotFound($"Employee not found with ID: { existingMember.Id}");
        }

        [HttpGet]
        [Route("GetMember")]
        public Member GetMember(int id)
        {
            return _members.GetMember(id);
        }
    }
}