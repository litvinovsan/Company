using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Company.DataRepository;
using Company.Model;

namespace Company.Controller
{
    public class EmployeeController
    {
        public static Employee Create(Creator typeCreator)
        {
            return (Employee)typeCreator.FactoryMethod();
        }
      
        /// <summary>
        /// Get all sub employees for id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public IList<IEmployee> GetSubEmployees(int id)
        {
            var result = Repository.GetInstance().GetAll().Where(empl => empl.BossId == id).Select(x => x).ToList();
            return result;
        }

    }
}
