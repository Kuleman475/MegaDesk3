using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MegaDesk3.Models
{
    public class Quote
    {
        public int ID { get; set; }

        [RegularExpression(@"^[A-Z]+[a-zA-Z\s]*$")]
        [Required]
        public string FirstName { get; set; } = string.Empty;
        [RegularExpression(@"^[A-Z]+[a-zA-Z\s]*$")]
        [Required]
        public string LastName { get; set; } = string.Empty;
        public int Width { get; set; }
        public int Depth { get; set; }
        public int Drawers { get; set; }
        [Required]
        public int Materials { get; set; }
        [Required]

        [Display(Name = "Order Date")]
        [DataType(DataType.Date)]
        public DateTime OrderDate { get; set; }
        public int RushOrderShipping { get; set; }
    }
}
