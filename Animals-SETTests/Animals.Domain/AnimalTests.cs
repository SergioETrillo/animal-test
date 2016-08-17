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
    public class AnimalTests
    {
        [TestMethod()]
        public void GetAnimalTypeTest()
        {
            //Arrange
            var oneDog = new Dog();
            var oneCat = new Cat();
            var oneBird = new Bird();
            var expectedDog = "Dog";
            var expectedCat = "Cat";
            var expectedBird = "Bird";

            //Act
            var actualDog = oneDog.GetAnimalType();
            var actualCat = oneCat.GetAnimalType();
            var actualBird = oneBird.GetAnimalType();

            //Assert
            Assert.AreEqual(expectedDog,actualDog);
            Assert.AreEqual(expectedCat, actualCat);
            Assert.AreEqual(expectedBird, actualBird);
        }
    }
}