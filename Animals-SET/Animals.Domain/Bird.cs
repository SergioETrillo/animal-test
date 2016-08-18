using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Animals_SET.Animals.Domain
{
    /// <summary>
    /// defines a Bird object
    /// </summary>
    public class Bird : Animal
    {
        public Bird()
        {
            Type = GetAnimalType();
            // to allow create list using default instantiation of class Bird
        }

        public Bird(int id, string name, int age, char gender) : this()
        {
            this.Id = id;
            this.Name = name;
            this.Age = age;
            if (gender.Equals('M') || gender.Equals('F'))
                this.Gender = gender;
        }

        public override string makeSound()
        {
            Console.WriteLine("tweet tweet!");
            return "tweet";
        }
    }
}