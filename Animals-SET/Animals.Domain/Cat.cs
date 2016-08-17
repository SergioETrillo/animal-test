using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Animals_SET.Animals.Domain
{
    /// <summary>
    /// defines a Cat object
    /// </summary>
    public class Cat : Animal, IMammal
    {
        private int _nbOfBreasts;
        private string _vertebrateType;
        public const int CATBREASTS = 8;

        public Cat()
        {
            _vertebrateType = "bones";
        }

        public Cat(string name, int age, char gender) : this()
        {
            this.Name = name;
            this.Age = age;
            if (gender.Equals('M') || gender.Equals('F'))
                this.Gender = gender;
        }

        public int NbOfBreasts
        {
            get { return this._nbOfBreasts = Gender.Equals('F') ? CATBREASTS : 0; }
 
        }

        public string VertebrateType
        {
            get { return _vertebrateType; }
        }
            


        public string FeedOffSpring()
        {
            string result = "";
            result = Gender.Equals('F') ? "Breastfeeding..." : "Sorry no food";

            return result;
        }

        public override string makeSound()
        {
            Console.WriteLine("meaw meaw!");
            return "meaw";
        }
    }
}