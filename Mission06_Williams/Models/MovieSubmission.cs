using System.ComponentModel.DataAnnotations;

namespace Mission06_Williams.Models
{
    public class MovieSubmission
    {
        [Key]
        public required int MovieID { get; set; }
        public required string Category { get; set; }
        public required string Title { get; set; }
        public required int Year { get; set; }
        public required string Director { get; set; }
        public required string Rating { get; set; }
        public bool? Edited { get; set; }
        public bool? LentTo { get; set; }

        [StringLength(25)] 
        public string? Notes { get; set; }
    }
}
