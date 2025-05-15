using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section_5___OOP
{
    class Cooks
    {
        private string _name;
        private string _position;

        public string ChefName
        {
            get { return _name; }

            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    Console.WriteLine("Please enter a cook's name");
                    _name = "Unknown";
                }
                else
                {
                    _name = value;
                }
            }
        }
        public string ChefPosition
        {
            get { return _position; }

            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    Console.WriteLine("Please enter a cook's position");
                    _position = "Unknown";
                }
                else
                {
                    _position = value;
                }
            }
        }

        public string[] ChefExperiences { get; set; }


        public Cooks(string name, string position, string[] experiences)
        {
            ChefName = name;
            ChefPosition = position;
            ChefExperiences = experiences;
            Console.WriteLine($"A Cook named {ChefName} with a position {ChefPosition} has been created");
        }
    }
}
