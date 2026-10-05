using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Library_Mangment_Case.Model
{
    public class Book
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public string Author { get; set; }
        [Required]
        public string ISBN { get; set; }//unique
        [Required,Range(0.1,(double)decimal.MaxValue)]
        public decimal Price { get; set; }
        public bool IsAvailable { get; set; } = true;
        //Category ↔ Book → One-to-Many
        [ForeignKey(nameof(CategoryId))]
        public int CategoryId { get; set; }
        public Category Category { get; set; }

        //•	Book ↔ Borrowing → One-to-Many
        public ICollection<Borrowing> Borrowings { get; set; } = new List<Borrowing>();

    }
}
