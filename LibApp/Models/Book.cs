using System.ComponentModel.DataAnnotations;

namespace LibApp.Models
{
    public class Book
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Please enter book's title")]
        public string Title { get; set; }

        [Required(ErrorMessage = "Please enter book's author")]
        public string Author { get; set; }

        public Genre Genre { get; set; }

        [Required(ErrorMessage = "Please enter book's genre")]
        public byte GenreId { get; set; }

        public DateTime DateAdded { get; set; }

        [Required(ErrorMessage = "Please enter book's release date")]
        public DateTime? ReleaseDate { get; set; }

        [Required(ErrorMessage = "Please enter book's stock number")]
        [Range(1, 20, ErrorMessage = "Please enter the number from 1 to 20")]
        public int NumberInStock { get; set; }
    }
}
