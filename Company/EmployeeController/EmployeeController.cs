using System.Collections.Generic;
using System.Linq;
using Company.Controller;
using Company.DataRepository;
using Company.Model;

namespace Company.EmployeeController
{
    public class EmployeeController
    {
        // Синглтон потокобезопасный. 
        private static readonly IRepository Repository = DataRepository.Repository.GetInstance();

        public static Employee Create(EmplAbstract typeEmplAbstract)
        {
            return (Employee)typeEmplAbstract.FactoryMethod();
        }

        /// <summary>
        /// Если БоссId имеет тип Менеджер или Sale, то этот Id и этого персонажа
        /// можно использовать в качестве босса. Переписываем индекс босса для подчиненного.
        /// </summary>
        /// <param name="bossId"></param>
        /// <param name="subId">Подчиненный</param>
        /// <returns></returns>
        public static bool AddSubEmployee(int bossId, int subId)
        {
            if (Repository.Get(bossId).Type == EmployeeType.Employee)
            {
                // Employee Не может иметь подчиненных
                return false;
            }

            Repository.Get(subId).BossId = bossId;
            return true;
        }

        /// <summary>
        /// Get all sub employees for id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public IList<IEmployee> GetSubEmployees(int id)
        {
            var result = DataRepository.Repository.GetInstance().GetAll().Where(empl => empl.BossId == id).Select(x => x).ToList();
            return result;
        }
    }
}
