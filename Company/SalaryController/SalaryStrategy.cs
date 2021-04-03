using System;
using System.Collections.Generic;

namespace Company.SalaryController
{
    // Реализуется GOF паттерн Strategy.

    // Контекст использует этот интерфейс для вызова алгоритма, определённого
    // Конкретными Стратегиями.
    public interface IGetSalary
    {
        int Get(DateTime date);
    }

    #region Конкретные реализации Стратегий по зарплате
    // Конкретные Стратегии реализуют алгоритм вычисления зарплаты, следуя базовому интерфейсу
    // Стратегии. Этот интерфейс делает их взаимозаменяемыми в Контексте.
    class ManagerSalary : IGetSalary
    {
        public int Get(DateTime date)
        {
            throw new NotImplementedException(typeof(ManagerSalary).FullName);
            // FIXME 
            return 0;
        }
    }

    class SalesSalary : IGetSalary
    {
        public int Get(DateTime date)
        {
            throw new NotImplementedException(typeof(SalesSalary).FullName);

            // FIXME
            return 0;
        }
    }

    class EmployeeSalary : IGetSalary
    {
        public int Get(DateTime date)
        {
            throw new NotImplementedException(typeof(EmployeeSalary).FullName);

            // FIXME
            return 0;
        }
    }
    #endregion

    // Контекст определяет интерфейс, представляющий интерес для клиентов.
    class SalaryContext
    {
        // Контекст хранит ссылку на один из объектов Стратегии. Контекст не
        // знает конкретного класса стратегии. Он должен работать со всеми
        // стратегиями через интерфейс Стратегии.
        private IGetSalary _getSalary;

        public SalaryContext()
        { }

        // Обычно Контекст принимает стратегию через конструктор, а также
        // предоставляет сеттер для её изменения во время выполнения.
        public SalaryContext(IGetSalary getSalary)
        {
            this._getSalary = getSalary;
        }

        /// <summary>
        /// Контекст позволяет заменить объект Стратегии во время выполнения.
        /// </summary>
        /// <param name="getSalary"></param>
        public void SetStrategy(IGetSalary getSalary)
        {
            this._getSalary = getSalary;
        }

        /// <summary>
        /// Вместо того, чтобы самостоятельно реализовывать множественные версии алгоритма,
        /// Контекст делегирует работу объекту Стратегии.
        /// </summary>
        /// <returns></returns>
        public int GetSalary(int Id)
        {
            var result = _getSalary.Get(DateTime date);
            return result;
        }
    }
}
