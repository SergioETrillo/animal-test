using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Animals_SET.Animals.Domain
{
    public static class QueryAnimals
    {
        public static List<Animal> GetAnimalsByName(string name)
        {
            var animalsByName = GroupOfAnimals.Members().Where(p => p.Name == name).ToList();

            return animalsByName;
        }

        public static List<Animal> GetAnimalsOlderThan(int age)
        {
            var animalsByName = GroupOfAnimals.Members().Where(p => p.Age > age).ToList();

            return animalsByName;
        }

        public static List<Animal> SortAnimalsByNameThenAge()
        {
            var sortedAnimals = GroupOfAnimals.Members().OrderBy(p => p.Name)
                                                        .ThenBy(p => p.Age).ToList();

            return sortedAnimals;
        }
    }
}