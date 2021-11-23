using System.ComponentModel.DataAnnotations;

namespace Final_Project_Group_1.Models
{

    public class Movie
    {
        [Key]
        public string movie { get; set; }
        public int Year { get; set; }
        public string Director { get; set; }
        public int Score { get; set; }
        public string Type { get; set; }

    }
}
