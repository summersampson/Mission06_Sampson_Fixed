using System.ComponentModel.DataAnnotations;

namespace Mission06_LastName.Models
{
    // this is where the movie info goes when the form is submitted
    public class Movie
    {
        [Key] // Primary Key
        public int MovieId { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        public string Category { get; set; }

        [Required]
        public int Year { get; set; }

        [Required]
        public string Director { get; set; }

        [Required]
        public string Rating { get; set; } // G, PG, PG-13, R

        public bool? Edited { get; set; } // Nullable for optional input

        public string? LentTo { get; set; } // Nullable because it's optional

        [MaxLength(25)] // Limits to 25 characters
        public string? Notes { get; set; }
    }
}
