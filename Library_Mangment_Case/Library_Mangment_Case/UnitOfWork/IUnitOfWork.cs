using Library_Mangment_Case.Model;
using Library_Mangment_Case.Repo.Cntract;

namespace Library_Mangment_Case.UnitOfWork
{
    public interface IUnitOfWork
    {
        IGenericRepo<Category> Category { get; }
        IGenericRepo<Book> Book { get; }
        IGenericRepo<Member> Member { get; }
        IGenericRepo<Borrowing> Borrowing { get; }
        int Save();
    }
}
