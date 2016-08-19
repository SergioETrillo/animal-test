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
    public class ZooTests
    {
        [TestMethod()]
        public void MembersTest()
        {
            //Arrange
            var list = Zoo.Members;

            //Act
            int expectedLength = 3;

            //Assert
            Assert.AreEqual(list.Count, expectedLength);
        }

        [TestMethod()]
        public void serializeListTest()
        {
            //Arrange
            var expected = @"[{""NbOfBreasts"":0,""VertebrateType"":""bones"",""Id"":1,""Name"":""Fluffy"",""Type"":""Dog"",""Age"":3,""Gender"":""M""},{""NbOfBreasts"":8,""VertebrateType"":""bones"",""Id"":2,""Name"":""Cattie"",""Type"":""Cat"",""Age"":4,""Gender"":""F""},{""Id"":3,""Name"":""Tweety"",""Type"":""Bird"",""Age"":1,""Gender"":""M""}]";
            
            //Act
            var actual = Zoo.SerializeList();
            
            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}