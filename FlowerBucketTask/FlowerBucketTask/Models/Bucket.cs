using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowerBucketTask.Models
{
    internal class Bucket
    {
        private Flower _flower;
        private uint _flowerCount;
        private float _discountPercent;

        public uint FlowerCount
        {
            get { return _flowerCount; }
            set
            {
                if (value < 20)
                {
                    _flowerCount = value;
                }
                else
                {
                    Console.WriteLine("bu qeder gul ola bilmez");
                }
            }
        }

        public float DiscountPercent
        {
            get { return _discountPercent; }
            set
            {
                if (value >= 0 && value <= 100)
                {
                    _discountPercent = value;
                }
                else
                {
                    Console.WriteLine("Endirim faizi limiti asdiniz!!!");
                }
            }
        }

        public void AddFlower(Flower flower)
        {
            if (this._flower == flower && flower != null)
            {
                FlowerCount++;
                Console.WriteLine("FlowerCount = " + FlowerCount);
            }
            else if(FlowerCount==0)
            {
                _flower = flower;
                FlowerCount = 1;
                Console.WriteLine("FlowerCount = " + FlowerCount);
            }
        }
        public (float Price, bool hasflower) TotalPrice(float discountpercent)
        {
            this._discountPercent = discountpercent;
            if (FlowerCount >= 1)
            {
                return (_flower.Price * FlowerCount * (100 - DiscountPercent) / 100, true);
            }
            else
            {
                return(0, false);
            }

        }
    }
}
