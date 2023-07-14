using System.ComponentModel.DataAnnotations;

namespace STGeneticsPage.DBModel
{
    public class Animals
    {
        [Key]
        public string AnimalId { get; set; }
        public string? Name { get; set; }
        public string? Breed { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string? Sex { get; set; }
        public int Price { get; set; }
        public string? Status { get; set; }

    }
}
