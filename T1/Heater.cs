using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T1
{
    class Heater
    {
        //properties
        public string Name { get; set; }
        public int Temperature { get; set; }
        public int Humidity { get; set; }
        public bool IsOn { get; set; }
    

        // deafault constructor
       
        // methods
        // print properties to console
        public void PrintData()
        {
            Console.WriteLine("Heater properties:");
            Console.WriteLine("- Name : {0}", Name);
            Console.WriteLine("- Temperature: {0}", Temperature);
            Console.WriteLine("- Humidity: {0}", Humidity);
            Console.WriteLine("- IsOn: {0}", IsOn);
            
        }
        // method returns object properties in a one string
        public override string ToString()
        {
            return "Temperature = " + Temperature + ", Humidity = " + Humidity + ", IsOn = " + IsOn;
        }
    }
}
