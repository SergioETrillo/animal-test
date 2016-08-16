using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Animals_SET.Animals.Domain
{
    public class Bird : Animal
    {
        public override string makeSound()
        {
            Console.WriteLine("tweet tweet!");
            return "tweet";
        }
    }
}