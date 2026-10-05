using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Library_Mangment_Case.Model
{
    public class Borrowing
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public DateTime BorrowedDate { get; set; } = DateTime.Now;
        public DateTime? ReturnedDate { get; set; }

        //Member ↔ Borrowing → One-to-Many
        [ForeignKey(nameof(MemberId))]
        public int MemberId { get; set; }
        public Member Member { get; set; }
        //•	Book ↔ Borrowing → One-to-Many
        [ForeignKey(nameof(BookId))]
        public int BookId { get; set; }
        public Book Book { get; set; }
    }
}
