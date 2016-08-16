using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Animals_SET.Animals.Domain
{
    public abstract class Animal
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public char Gender { get; set; }

        public abstract string makeSound();
    }
}