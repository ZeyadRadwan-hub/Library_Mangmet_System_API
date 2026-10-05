using Library_Mangment_Case.Model;

namespace Library_Mangment_Case.Repo.CustomRepo.Contract
{
    public interface ICategoryRepository
    {
        void IsNameUnique(string name);
        void HasBooks(int categoryId);
        List<Category> GetAllWithBookCount();
    }
}