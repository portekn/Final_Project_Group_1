using System.ComponentModel.DataAnnotations;

namespace Final_Project_Group_1.Models
{

    public class Interest
    {
        [Key]
        public int Id { get; set; }
        public string InterestName { get; set; }
        public int Years { get; set; }
        public bool Expensive { get; set; }
        public int TimeConsumption { get; set; }

    }
}