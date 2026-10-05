namespace Library_Mangment_Case.Repo.Cntract
{
    public interface IGenericRepo<T> where T : class
    {
        void AddObject(T obj);
        void UpdateObject(T obj);
        void DeleteObject(T id);
    }
}
