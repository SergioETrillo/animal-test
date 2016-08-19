using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Animals_SET.Animals.Domain
{
    /// <summary>
    /// Defines an abstract animal
    /// </summary>
    public abstract class Animal
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public int Age { get; set; }
        public char Gender { get; set; }

        public abstract string MakeSound();

        public string GetAnimalType()
        {
            return this.GetType().Name;
        }
    }
}