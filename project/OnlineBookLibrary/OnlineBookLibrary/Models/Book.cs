using System.ComponentModel.DataAnnotations;
namespace OnlineBookLibrary.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string Genre { get; set; }
        [Display(Name = "Published Year")]

        public int PublishedYear { get; set; }

        [Display(Name = "Is Available")]

        public bool IsAvailable { get; set; }
    }
}
