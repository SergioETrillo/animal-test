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
    public class BirdTests
    {
        [TestMethod()]
        public void BirdTest()
        {
            //Arrange
            var oneBird = new Bird(4, "Piolin", 2, 'M');
            var expectedName = "Piolin";
            var expectedAge = 2;
            var expectedGender = 'M';

            //Act 
            var actualName = oneBird.Name;
            var actualAge = oneBird.Age;
            var actualGender = oneBird.Gender;

            //Assert
            Assert.AreEqual(expectedName, actualName);
            Assert.AreEqual(expectedAge, actualAge);
            Assert.AreEqual(expectedGender, actualGender);
        }

        [TestMethod()]
        public void BirdTestBadGenre()
        {
            //Arrange
            var expected = '\0';   // default value of char
            var oneBird = new Bird(5, "Piolin", 2, 'X');
            //Act 
            var actual = oneBird.Gender;
            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void BirdMakeSoundTest()
        {
            //Arrange
            var oneBird = new Bird();
            var expected = "tweet";

            //Act
            var actual = oneBird.MakeSound();

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }



}