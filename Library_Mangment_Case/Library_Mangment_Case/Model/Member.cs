using System.ComponentModel.DataAnnotations;

namespace Library_Mangment_Case.Model
{
    public class Member
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required,EmailAddress]
        public string Email { get; set; }//unique
        [Required, Phone]
        public string PhoneNumber { get; set; }
        //Member ↔ Borrowing → One-to-Many
        public ICollection<Borrowing> Borrowings { get; set; } = new List<Borrowing>();
    }
}
