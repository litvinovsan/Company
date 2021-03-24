using System.Collections.Generic;
using Company.Model;

namespace Company.DataRepository
{
    public interface IRepository
    {
        bool Add(IEmployee employee);
        bool Remove(IEmployee employee);
        IEmployee Get(int id);
        IList<IEmployee> GetAll();
    }
}