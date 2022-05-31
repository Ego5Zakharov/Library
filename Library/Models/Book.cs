using System.ComponentModel.DataAnnotations;

namespace Library.Models
{
    public class Book
    {
        public int Id { get; set; }
        [Required]
        public string ?Name { get; set; }
        [Range(0.01, 9999.9)]
        public decimal Price { get; set; }
        public bool IsAutographFree { get; set; }
        public Genre Genre { get; set; }
    }

    public enum Genre
    {
        Melodrama,
        Сomedy,
        Drama
    }
}
