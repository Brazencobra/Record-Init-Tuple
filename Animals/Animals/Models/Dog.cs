using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals.Models
{
    internal class Dog : Animal
    {
        string _name;
        string _breed;

        public string Name 
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }
        public string Breed 
        {
            get
            {
                return _breed;
            }
            init
            {
                _breed = value;
            } 
        }

        public Dog(string gender,string name,string breed):base(gender)
        {
            Name = name;
            Breed = breed;
        }
    }
}
