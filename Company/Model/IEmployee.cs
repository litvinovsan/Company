using System;

namespace Company.Model
{
    public interface IEmployee
    {
        int Id { get;  }
        int BossId { get; set; }
        string Name { get; set; }
        DateTime BeginDate { get; }
        EmployeeType Type { get; set; }
    }
}