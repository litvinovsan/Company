using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company.Model
{
    public class Employee : IEmployee
    {
        public int Id { get; }
        public int BossId { get; set; }
        public string Name { get; set; }
        public DateTime BeginDate { get; }
        public EmployeeType Type { get; set; }

        public Employee(int id, string name, int bossId, DateTime dateStart, EmployeeType type)
        {
            Id = id;
            Name = name;
            BossId = bossId;
            BeginDate = dateStart;
            Type = type;
        }
    }

    public enum EmployeeType
    {
        Employee,
        Manager,
        Sales
    }
}
