using System;
using Company.DataRepository;
using Company.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Company.DataRepository.Tests
{
    [TestClass()]
    public class RepositoryTests
    {
        [TestMethod()]
        public void GetAllTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void GetTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void GetTest1()
        {
            Assert.Fail();
        }
    }
}

namespace CompanyTests.DataRepository
{
    [TestClass()]
    public class RepositoryTests
    {
        /// <summary>
        /// Instance Not Null and the same
        /// </summary>
        [TestMethod()]
        public void GetInstanceTest()
        {
            // Action 
            var actual = Repository.GetInstance();
            var actual2 = Repository.GetInstance();
            // Assert
            Assert.IsNotNull(actual);
            Assert.AreSame(actual, actual2);
        }

        [TestMethod()]
        public void AddTest()
        {
            // Arrange
            var repository = Repository.GetInstance();
            // Action 
            var actual = repository.Add(new Employee(1,"dummy", 2, DateTime.Now, EmployeeType.Sales));
            // Assert
            Assert.IsTrue(actual);
        }

        [TestMethod()]
        public void RemoveTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void GetTest()
        {
            Assert.Fail();
        }
    }
}