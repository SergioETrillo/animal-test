using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Animals_SET.Animals.Domain
{
    public static class GroupOfAnimals
    {

        public static List<Animal> Members()
        {
            var listOfAnimals = new List<Animal>()
            {
                new Dog { Name = "Fluffy", Age = 3, Gender = 'M' },
                new Cat { Name = "Cattie", Age = 4, Gender = 'F'},
                new Bird { Name = "Tweety", Age = 1, Gender = 'M' }
            };

            return listOfAnimals;
        }
    }
}