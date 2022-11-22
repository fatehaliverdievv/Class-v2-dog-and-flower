using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowerBucketTask.Models
{
    internal record Flower
    {
        private string _name;
        private string _color;
        private float _price;


        public string Name
        {
            get { return _name; }
            set
            {
                value = value.Trim();
                if (value.Length < 70 && value.Length > 3)
                {
                    _name = value;

                }
                else
                {
                    Console.WriteLine("Bele gul adi yoxdu qardasim");
                }

            }
        }
        public string Color
        {
            get { return _color; }
            set
            {
                value = value.Trim();
                if (value.Length <= 10 && value.Length >= 2)
                {
                    _color = value;
                }
                else
                {
                    Console.WriteLine("Bele reng yoxdu qardasim");
                }
            }
        }
        public float Price
        {
            get { return _price; }
            set
            {
                if (value >= 0.09f)
                {
                    _price = value;
                }
                else
                {
                    Console.WriteLine("Bele reng yoxdu qardasim");
                }
            }
        }
        public Flower(string name, string color, float price)
        {
            this._name = name;
            this._color = color;
            this._price = price;
        }
    }
}
