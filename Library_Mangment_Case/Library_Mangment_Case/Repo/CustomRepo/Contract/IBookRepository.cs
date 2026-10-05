using Library_Mangment_Case.Model;

namespace Library_Mangment_Case.Repo.CustomRepo.Contract
{
    public interface IBookRepository
    {
        List<Book> SearchBooks(string Name);
        Book GetMostExpensiveBook();
        void IsISBNUnique(string isbn);
    }
}