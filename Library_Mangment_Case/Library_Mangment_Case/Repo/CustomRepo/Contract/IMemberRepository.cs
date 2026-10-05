using Library_Mangment_Case.Model;

namespace Library_Mangment_Case.Repo.CustomRepo.Contract
{
    public interface IMemberRepository
    {
        void IsEmailUnique(string email);
        List<Member> GetTopReaders(int count = 5);
        int GetMemberStatistics(int memberId);
    }
}