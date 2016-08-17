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
    public class CatTests
    {
        [TestMethod()]
        public void CatTestDefaultConstructor()
        {
            //Arrange
            var oneCat = new Cat();
            var expectedNbBreasts = 0;
            var expectedVertebrate = "bones";
            //Act
            var actualNbBreasts = oneCat.NbOfBreasts;
            var actualVertebrate = oneCat.VertebrateType;
            //Assert
            Assert.AreEqual(expectedNbBreasts, actualNbBreasts);
            Assert.AreEqual(expectedVertebrate, actualVertebrate);
        }

        [TestMethod()]
        public void CatTestParametrizedConstructor()
        {
            //Arrange
            var oneCat = new Cat("Rachel", 12, 'F');
            var expectedNbBreasts = Cat.CATBREASTS;
            var expectedVertebrate = "bones";
            //Act
            var actualNbBreasts = oneCat.NbOfBreasts;
            var actualVertebrate = oneCat.VertebrateType;
            //Assert
            Assert.AreEqual(expectedNbBreasts, actualNbBreasts);
            Assert.AreEqual(expectedVertebrate, actualVertebrate);
        }

        [TestMethod()]
        public void FeedOffSpringTest()
        {
            //Arrange
            var oneFemaleCat = new Cat("Rachel", 12, 'F');
            var oneMaleCat = new Cat("Pepe", 3, 'M');
            var expectedFemaleResult = "Breastfeeding...";
            var expectedMaleResult = "Sorry no food";
            //Act
            var actualFemaleResult = oneFemaleCat.FeedOffSpring();
            var actualMaleResult = oneMaleCat.FeedOffSpring();
            //Assert
            Assert.AreEqual(expectedFemaleResult, actualFemaleResult);
            Assert.AreEqual(expectedMaleResult, actualMaleResult);
        }

        [TestMethod()]
        public void CatmakeSoundTest()
        {
            //Arrange
            var oneCat = new Cat();
            var expected = "meaw";
            //Act
            var actual = oneCat.makeSound();
            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}