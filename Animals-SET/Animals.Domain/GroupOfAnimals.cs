using Newtonsoft.Json;
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
                new Dog { Id = 1, Name = "Fluffy", Age = 3, Gender = 'M' },
                new Cat { Id = 2, Name = "Cattie", Age = 4, Gender = 'F'},
                new Bird {Id = 3, Name = "Tweety", Age = 1, Gender = 'M' }
            };

            return listOfAnimals;
        }

        // for test purposes
        public static List<Animal> OneAnimal()
        {
            var onlyAnimal = new List<Animal>()
            {
                new Dog { Id = 1, Name = "Fluffy", Age = 3, Gender = 'M' }
            };

            return onlyAnimal;
        }

        public static string SerializeList()
        {
            return JsonConvert.SerializeObject(Members());
        }
    }
}