using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalDogTask.Models
{
    internal record Dog:Animal
    {
        string _name;
        string _breed;

        public string Name
        {
            get { return _name; }
            set
            {
                value = value.Trim();
                if (value.Length < 30 && value.Length > 2)
                {
                    _name = value;
                }
                else
                {
                    Console.WriteLine("Wrong Dog Name!");
                }
            }
        }

        public string Breed
        {
            get { return _breed; }
            init
            {
                value = value.Trim();
                if (value.Length < 15 && value.Length > 2)
                {
                    _breed = value;
                }
                else
                {
                    Console.WriteLine("Wrong Dog Breed!");
                }
            }
        }

        public Dog(string name, string breed ,string gender):base(gender)
        {
            Name = name;
            Breed= breed;
            Gender= gender;
        }
    }
}
