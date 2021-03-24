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
        private IRepository Repository { get; }

        public EmployeeController(IRepository repository)
        {
            Repository = repository ?? throw new ArgumentNullException(nameof(repository));

        }

        /// <summary>
        /// Get all sub employees for id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public IList<IEmployee> GetSubEmployees(int id)
        {
            var result = Repository.GetAll().Where(empl => empl.BossId == id).Select(x => x).ToList();
            return result;
        }

    }
}
