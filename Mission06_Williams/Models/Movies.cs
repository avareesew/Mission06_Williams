using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Mission06_Williams.Models
{
    //creating the movie submission class, based 
    //the database off this model
    public class Movies
    {
        [Key]
        public required int MovieId { get; set; }

        [ForeignKey("CategoryId")]
        public int? CategoryId { get; set; }
        public Category? Category { get; set; }
        public required string Title { get; set; }

        [Range(1888, int.MaxValue, ErrorMessage = "Please enter a valid year.")]
        public required int Year { get; set; }
        public string? Director { get; set; }
        public string? Rating { get; set; }
        public required bool Edited { get; set; }
        public bool? LentTo { get; set; }

        public required bool CopiedToPlex { get; set; }

        [StringLength(25)] 
        public string? Notes { get; set; }
    }
}
