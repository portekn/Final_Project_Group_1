using System.ComponentModel.DataAnnotations;

namespace Final_Project_Group_1.Models
{
    //Danae Brenner
    public class Movie
    {
        [Key]
        public int Id { get; set; }
        public string MovieName { get; set; }
        public int Year { get; set; }
        public string Director { get; set; }
        public int Score { get; set; }
        public string Type { get; set; }
    }
}
