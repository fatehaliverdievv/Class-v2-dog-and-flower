using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalDogTask.Models
{
    internal record Animal
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
                value= value.Trim();
                if(value.ToLower() == "male" || value.ToLower()=="female")
                {
                    value = _gender;
                }
                else
                {
                    Console.WriteLine("Wrong gender name");
                }
                
            }
        }
        public int Birthyear 
        {
            get { return _birthyear;} 
            init
            {
                _birthyear = DateTime.Now.Year;
                _birthyear = value;

            }
        }
        public Animal(string gender)
        {
            Birthyear = DateTime.Now.Year;
            Gender = gender;
        }
    }
}
