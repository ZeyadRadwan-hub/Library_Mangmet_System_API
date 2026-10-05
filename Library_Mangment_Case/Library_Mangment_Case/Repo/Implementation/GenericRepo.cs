using Library_Mangment_Case.Database_Context;
using Library_Mangment_Case.Repo.Cntract;

namespace Library_Mangment_Case.Repo.Implementation
{
    public class GenericRepo<T> : IGenericRepo<T> where T : class
    {
        private readonly App_Database_Context _db;
        public GenericRepo(App_Database_Context db)
        {
            _db = db;
        }
        public void AddObject(T obj)
        {
            _db.Set<T>().Add(obj);
        }

        public void DeleteObject(T id)
        {
            _db.Set<T>().Remove(id);
        }

        public void UpdateObject(T obj)
        {
            _db.Set<T>().Update(obj);
        }

    }
}
