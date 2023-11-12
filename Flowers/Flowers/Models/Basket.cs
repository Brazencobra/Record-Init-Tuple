using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flowers.Models
{
    internal class Basket
    {
        private Flower _flower;
        private int _flowerCount;
        private byte _discountPercent;

        public Flower Flower 
        {
            get
            {
                return _flower;
            }
            set
            {
                _flower = value;
            } 
        }
        public int FlowerCount 
        {
            get
            {
                return _flowerCount;
            }
            set
            {
                _flowerCount = value;
            } 
        }
        public byte DiscountPercent 
        {
            get
            {
                return _discountPercent;
            }
            set
            {
                if (value >= 0 && value <= 100) 
                {
                    _discountPercent = value;
                }
                else
                {
                    Console.WriteLine("Gel obyekti kecirim ele bir basa adiva");
                }
                
            }
        }

        public Basket(byte discountpercent)
        {
            DiscountPercent = discountpercent;
            Flower = null;
        }

        public void AddFlower(Flower flower)
        {
            if (Flower == null)
            {
                Flower = flower;
                FlowerCount = 1;
            }
            else if(Flower != null && flower == Flower)
            {
                FlowerCount++;
            }
            else 
            {
                Console.WriteLine($"Buketdeki gulun adi {Flower.Name}-dir. Siz ise {flower.Name} elave etmek istediyiniz ucun emeliyyat bas tutmadi");
            }
        }

        public (double Price,bool hasflower) TotalPrice()
        {
            if (Flower != null)
            {
                return (FlowerCount * Flower.Price - (FlowerCount * Flower.Price * DiscountPercent / 100), true);
            }
            return (0, false);
        }
    }
}
