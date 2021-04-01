using System;
using System.Collections.Generic;
using System.Linq;
using Company.Model;

namespace Company.DataRepository
{
    public class Repository : IRepository
    {
        private IList<IEmployee> Employees { get; }

        private static Repository _repository;
        private static object _locker=new object();
        private Repository()
        {
            Employees = new List<IEmployee>();
        }

        public static Repository GetInstance() // Singleton
        {
            if (_repository != null)
                return _repository;
            else
            {
                lock (_locker)
                {
                    return _repository = new Repository(); 
                }
            }
        }

        /// <summary>
        /// Add Employees to data Repository
        /// </summary>
        /// <param name="employee"></param>
        /// <returns></returns>
        public bool Add(IEmployee employee)
        {
            if (employee == null) throw new ArgumentNullException(nameof(employee));

            if (Employees.Contains(employee)) return false;

            Employees.Add(employee);

            return true;
        }
        /// <summary>
        /// Remove from repository
        /// </summary>
        /// <param name="employee"></param>
        /// <returns></returns>
        public bool Remove(IEmployee employee)
        {
            if (employee == null) throw new ArgumentNullException(nameof(employee));

            if (!Employees.Contains(employee)) return false;
            Employees.Remove(employee);
            return true;
        }
        /// <summary>
        /// Get by Employees Id
        /// </summary>
        /// <param name="id"></param>
        /// <returns>Null if not found or collection is empty</returns>
        public IEmployee Get(int id)
        {
            if (id <= 0) throw new ArgumentOutOfRangeException(nameof(id));

            var result = Employees.FirstOrDefault(eId => eId.Id == id);
            return result;
        }

        public IList<IEmployee> GetAll()
        {
            return Employees;
        }
    }
}
