using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flowers.Models
{
    internal record Flower
    {
        string _name;
        string _color;
        double _price;

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
        public string Color 
        {
            get
            {
                return _color;
            }
            set
            {
                _color = value;
            } 
        }
        public double Price 
        {
            get
            {
                return _price;
            }
            set
            {
                if (value >= 0) 
                {
                    _price = value; 
                }
                
            } 
        }

        public Flower(string name,string color,double price)
        {
            Name = name;
            Color = color;
            Price = price;
        }
    }
}
