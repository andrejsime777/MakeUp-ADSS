using System.ComponentModel.DataAnnotations;

namespace CarRentalFinal.Models
{
    public class Car
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Model { get; set; }
        [Required]
        public string Manufacturer { get; set; }
        public string Photo { get; set; }
        public int Year_of_Manufacture { get; set; }
    }
}
