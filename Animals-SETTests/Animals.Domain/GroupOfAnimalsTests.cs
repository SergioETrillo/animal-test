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
    public class GroupOfAnimalsTests
    {
        [TestMethod()]
        public void MembersTest()
        {
            //Arrange
            var list = GroupOfAnimals.Members();
            //Act
            int expectedLength = 3;
            //Assert
            Assert.AreEqual(list.Count, expectedLength);
        }

        [TestMethod()]
        public void serializeListTest()
        {
            //Arrange
            var list = GroupOfAnimals.OneAnimal();
            //Act
            var expected = @"[{""NbOfBreasts"":0,""VertebrateType"":""bones"",""Id"":1,""Name"":""Fluffy"",""Age"":3,""Gender"":""M""},{""NbOfBreasts"":8,""VertebrateType"":""bones"",""Id"":2,""Name"":""Cattie"",""Age"":4,""Gender"":""F""},{""Id"":3,""Name"":""Tweety"",""Age"":1,""Gender"":""M""}]";            
            var actual = GroupOfAnimals.SerializeList();
            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}