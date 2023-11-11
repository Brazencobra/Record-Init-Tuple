using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals.Models
{
    internal class Animal
    {
        string _gender;
        int _birthyear;

        public string Gender 
        {
            get
            {
                return _gender;
            }
            set
            {
                _gender = value;
            }
        }
        public int BirthYear 
        {
            get
            {
                return _birthyear;
            }
            init 
            {
                _birthyear = value;
            }
        }

        public Animal(string gender)
        {
            Gender = gender;
            BirthYear = DateTime.Now.Year;
        }
    }
}
