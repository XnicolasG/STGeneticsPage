using System.ComponentModel.DataAnnotations;

namespace STGeneticsPage.DBModel
{
    public class Animals
    {
        [Key]
        public string AnimalId { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Breed { get; set; }
        [Required]
        public DateTime DateOfBirth { get; set; }
        [Required]
        public string Sex { get; set; }
        [Required]
        public int Price { get; set; }
        [Required]
        public string Status { get; set; }

    }
}
