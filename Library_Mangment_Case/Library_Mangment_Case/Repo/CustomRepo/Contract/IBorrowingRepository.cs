using Library_Mangment_Case.Model;

namespace Library_Mangment_Case.Repo.CustomRepo.Contract
{
    public interface IBorrowingRepository
    {
        List<Borrowing> GetAllWithDetails();
    }
}