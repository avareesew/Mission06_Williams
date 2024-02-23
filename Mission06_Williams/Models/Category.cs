using System.ComponentModel.DataAnnotations;

namespace Mission06_Williams.Models
{
    public class Category
    {
        [Key]
        public required int CategoryId {  get; set; }
        public required  string CategoryName {  get; set; }
    }
}
