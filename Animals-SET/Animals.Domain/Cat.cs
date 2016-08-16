using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Animals_SET.Animals.Domain
{
    public class Cat : Animal, IMammal
    {
        private int nbOfBreasts;

        public int NbOfBreasts
        {
            get { return nbOfBreasts; }
            set { nbOfBreasts = 8; }
        }

        private string vertebrate;

        public string Vertebrate
        {
            get { return vertebrate; }
            set { vertebrate = "bones"; }
        }


        public string FeedOffSpring()
        {
            string result = "";
            result = Gender.Equals("F") ? "Breastfeeding..." : "Sorry no food";
            Console.WriteLine(result);

            return result;
        }

        public override string makeSound()
        {
            Console.WriteLine("meaw meaw!");
            return "meaw";
        }
    }
}