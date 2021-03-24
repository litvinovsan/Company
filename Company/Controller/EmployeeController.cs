using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Company.DataRepository;

namespace Company.Controller
{
    public class EmployeeController
    {
        public IRepository Repository { get; }

        public EmployeeController(IRepository repository)
        {
            Repository = repository ?? throw new ArgumentNullException(nameof(repository));
        }

       

    }
}
