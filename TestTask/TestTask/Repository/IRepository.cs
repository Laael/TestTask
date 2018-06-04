using System.Collections.Generic;

namespace TestTask
{
    public interface IRepository<T>
    {
        void Create(T version);
        void Update(T version);
        void Delete(int id);
        T Get(int id);
        List<T> GetItems();
    }
}
