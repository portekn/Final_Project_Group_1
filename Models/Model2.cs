using System.ComponentModel.DataAnnotations;

namespace Final_Project_Group_1.Models
{

    public class Location
    {
        [Key]
        public int Id { get; set; }
        public string State { get; set; }
        public string City { get; set; }
        public int ZipCode { get; set; }
        public string StreetName { get; set; }

    }
}