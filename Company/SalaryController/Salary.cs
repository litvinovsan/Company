using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Company.DataRepository;

namespace Company.SalaryController
{
    public class Salary
    {
        // Синглтон потокобезопасный. 
        private static readonly IRepository Repository = DataRepository.Repository.GetInstance();

        public static int Get(int id, DateTime date)
        {
            var employee = Repository.Get(id);



            throw new NotImplementedException(typeof(ManagerSalary).FullName);

            return 0;
        }

        public static int GetAllSalaries()
        {
            var employees = Repository.GetAll();
            throw new NotImplementedException(typeof(ManagerSalary).FullName);

            return 0;
        }
    }
}
