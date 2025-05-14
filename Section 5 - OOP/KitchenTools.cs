using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section_5___OOP
{
    class KitchenTools
    {
        //FIelds
        private string _name;
        private string _brand;
        private int _modelNumber;

        //Properties
        public string Name {

            get { return _name; }

            set { if (string.IsNullOrEmpty(value)) {
                    //If the value is null or empty, set the name to "Unknown"
                    Console.WriteLine("Name Cannot be Null or Empty");
                    _name = "Unknown";

                } else { 
                    _name = value; } }
        }

        public string Brand
        {

            get { return _brand; }

            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    //If the value is null or empty, set the name to "Unknown"
                    Console.WriteLine("Name Cannot be Null or Empty");
                    _brand = "Unknown";

                }
                else
                {
                    _brand = value;
                }
            }
        }

        public int ModelNumber
        {
            get { return _modelNumber; }
            set
            {
                if (value < 0)
                {
                    //If the value is less than 0, set the name to "Unknown"
                    Console.WriteLine("Model Number Cannot be Negative");
                    _modelNumber = 0;
                }
                else
                {
                    _modelNumber = value;
                }
            }
        }
        //Constructors
        public KitchenTools(string toolName, string brand, int modelNumber)
        {
            Name = toolName;
            Brand = brand;
            ModelNumber = modelNumber;
            Console.WriteLine("KitchenTools has been created!");
        }
    }
}
