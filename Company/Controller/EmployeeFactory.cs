using System;
using Company.Model;

namespace Company.Controller
{
    /// <summary>
    /// Basic class for creating a persons
    /// </summary>
    public abstract class EmplAbstract
    {
        private static int _idCounter;
        protected string Name { get; set; }
        protected int? BossId { get; set; }
        protected DateTime DateStart { get; set; }

        protected EmplAbstract(string name, int? bossId, DateTime dateStart)
        {
            Name = name ?? throw new ArgumentNullException(nameof(name));
            BossId = bossId;
            DateStart = dateStart;
        }

        protected static int IdCounter
        {
            get { return ++_idCounter; }
        }
        public abstract IEmployee FactoryMethod();
    }

    // Concrete Employee, overrides a Factory method to create a different types of employees.
    public class CreateSales : EmplAbstract
    {
        public override IEmployee FactoryMethod()
        {
            return new Employee(IdCounter, Name, BossId, DateStart, EmployeeType.Sales);
        }

        public CreateSales(string name, int? bossId, DateTime dateStart) : base(name, bossId, dateStart)
        {
        }
    }
    public class CreateEmpl : EmplAbstract
    {
        public override IEmployee FactoryMethod()
        {
            return new Employee(IdCounter, Name, BossId, DateStart, EmployeeType.Employee);
        }

        public CreateEmpl(string name, int? bossId, DateTime dateStart) : base(name, bossId, dateStart)
        {
        }
    }
    public class CreateManager : EmplAbstract
    {
        public override IEmployee FactoryMethod()
        {
            return new Employee(IdCounter, Name, BossId, DateStart, EmployeeType.Manager);
        }

        public CreateManager(string name, int? bossId, DateTime dateStart) : base(name, bossId, dateStart)
        {
        }
    }
}
