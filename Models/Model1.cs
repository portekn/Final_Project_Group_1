using System.ComponentModel.DataAnnotations;

namespace Final_Project_Group_1.Models
{

    public class Location
    {
        [Key]
        public int Id { get; set; }
        public string FullName { get; set; }
        public System.DateTime BirthDate { get; set; }
        public string program { get; set; }
        public string year { get; set; }

    }
}