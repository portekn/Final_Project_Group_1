using System.ComponentModel.DataAnnotations;

namespace Final_Project_Group_1.Models
{
    public class Member
    {
        [Key]
        public int Id { get; set; }
        public string FullName { get; set; }
        public int BirthDate { get; set; }
        public string Program { get; set; }
        public int YOD { get; set; }

    }
}