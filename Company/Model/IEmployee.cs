using System;
using Company.SalaryController;

namespace Company.Model
{
    public interface IEmployee
    {
        int Id { get;  }
        int? BossId { get; set; }
        string Name { get; set; }
        DateTime BeginWorkDate { get; }
        EmployeeType Type { get; set; }
    }
}