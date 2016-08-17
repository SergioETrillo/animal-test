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
    public class DogTests
    {
        [TestMethod()]
        public void DogTestDefaultConstructor()
        {
            //Arrange
            var oneDog = new Dog();
            var expectedNbBreasts = 0;
            var expectedVertebrate = "bones";
            //Act
            var actualNbBreasts = oneDog.NbOfBreasts;
            var actualVertebrate = oneDog.VertebrateType;
            //Assert
            Assert.AreEqual(expectedNbBreasts, actualNbBreasts);
            Assert.AreEqual(expectedVertebrate, actualVertebrate);
        }

        [TestMethod()]
        public void DogTestParametrizedConstructor()
        {
            //Arrange
            var oneDog = new Dog("Rachel", 12, 'F');
            var expectedNbBreasts = Dog.DOGBREASTS;
            var expectedVertebrate = "bones";
            //Act
            var actualNbBreasts = oneDog.NbOfBreasts;
            var actualVertebrate = oneDog.VertebrateType;
            //Assert
            Assert.AreEqual(expectedNbBreasts, actualNbBreasts);
            Assert.AreEqual(expectedVertebrate, actualVertebrate);
        }

        [TestMethod()]
        public void FeedOffSpringTest()
        {
            //Arrange
            var oneFemaleDog = new Dog("Rachel", 12, 'F');
            var oneMaleDog = new Dog("Pepe", 3, 'M');
            var expectedFemaleResult = "Breastfeeding...";
            var expectedMaleResult = "Sorry no food";
            //Act
            var actualFemaleResult = oneFemaleDog.FeedOffSpring();
            var actualMaleResult = oneMaleDog.FeedOffSpring();
            //Assert
            Assert.AreEqual(expectedFemaleResult, actualFemaleResult);
            Assert.AreEqual(expectedMaleResult, actualMaleResult);
        }

        [TestMethod()]
        public void DogmakeSoundTest()
        {
            //Arrange
            var oneDog = new Dog();
            var expected = "woof";
            //Act
            var actual = oneDog.makeSound();
            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}