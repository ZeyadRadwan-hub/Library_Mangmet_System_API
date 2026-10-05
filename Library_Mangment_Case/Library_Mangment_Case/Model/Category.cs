using System.ComponentModel.DataAnnotations;

namespace Library_Mangment_Case.Model
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }//unique
        [MaxLength(200)]
        public string Description { get; set; }
        //Category ↔ Book → One-to-Many
        public ICollection<Book> Books { get; set; }= new List<Book>();
    }
}
