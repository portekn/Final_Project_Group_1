using System.ComponentModel.DataAnnotations;

namespace Final_Project_Group_1.Models
{

    public class Interest
    {
        [Key]
        public string Category { get; set; }
        public string interest { get; set; }
        public int InterestYears { get; set; }
        public bool Expensive { get; set; }
        public int TimeConsumption { get; set; }

    }
}