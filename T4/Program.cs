
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace T4
{
    class Program
    {
        static void Main(string[] args)
        { //create a new vehicle            
            Auto car = new Auto();
            car.Name = "Kaara";
            car.Speed = 80;
            car.Tyres = 4;
            car.PrintData();
            car.ToString();
            Console.WriteLine(car.ToString());
            Console.ReadLine();
        }
    }
}