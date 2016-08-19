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
            var animalsByName = Zoo.Members
                .Where(p => p.Name == name)
                .ToList();

            return animalsByName;
        }

        public static int CountAnimalsByName(string name)
        {
            int result = Zoo.Members.Count(a => a.Name == name);

            return result;
        }

        public static List<Animal> GetAnimalsOlderThan(int age)
        {
            var animalsByName = Zoo.Members
                .Where(p => p.Age > age).ToList();

            return animalsByName;
        }

        public static List<Animal> SortAnimalsByNameAge()
        {
            var sortedAnimals = Zoo.Members
                                              .OrderBy(a => a.Name)
                                              .ThenByDescending(a => a.Age)
                                              .ToList();

            var count = sortedAnimals.Count;
            foreach (Animal a in sortedAnimals)
            {
                Console.WriteLine(a.Name);
            }

            return sortedAnimals;
        }

        public static Animal GetAnimalById(int id)
        {
            var animal = Zoo.Members.Single(a => a.Id == id);

            return animal;
        }
    }
}