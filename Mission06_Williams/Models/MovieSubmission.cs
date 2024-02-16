namespace Mission06_Williams.Models
{
    public class MovieSubmission
    {
        public required string Title { get; set; }
        public required int Year { get; set; }
        public required string Director { get; set; }
        public string Rating { get; set; }
        public bool Edited { get; set; }
        public string Notes { get; set; }
    }
}
