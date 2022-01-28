using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CarRentalFinal.Models
{
    public class Client
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        [Range(18, 70, ErrorMessage = "Must be between 18 and 70!")]
        public string Age { get; set; }
        [Required]
        public string Passport_Number { get; set; }

        //Foreign key
        [Display(Name = "Cars")]
        public int CarID { get; set; }
        [ForeignKey("CarID")]
        public virtual Car Car { get; set; }
    }
}
