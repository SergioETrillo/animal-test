using Microsoft.VisualStudio.TestTools.UnitTesting;
using Animals_SET.Animals.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals_SET.Animals.Domain.Tests
{
    [TestClass()]
    public class QueryAnimalsTests
    {
        [TestMethod()]
        public void GetAnimalsByNameTest()
        {
            //Arrange
            var filtered = QueryAnimals.GetAnimalsByName("Tweety");
            var expectedCount = 1;
            var expectedId = 3;

            //Act
            var actualCount = filtered.Count;
            var actualId = filtered[0].Id;

            //Assert
            Assert.AreEqual(expectedCount, actualCount);
            Assert.AreEqual(expectedId, actualId);
        }

        [TestMethod()]
        public void GetAnimalsOlderThanTest()
        {
            //Arrange
            var filtered = QueryAnimals.GetAnimalsOlderThan(2);

            //Act
            var expectedCount = 2;
            var expectedFirstId = 1;
            var expectedLastId = 2;
            var actualCount = filtered.Count;
            var actualFirstId = filtered[0].Id;
            var actualLastId = filtered[1].Id;

            //Assert
            Assert.AreEqual(expectedCount, actualCount);
            Assert.AreEqual(expectedFirstId, actualFirstId);
            Assert.AreEqual(expectedLastId, actualLastId);
        }
    }
}