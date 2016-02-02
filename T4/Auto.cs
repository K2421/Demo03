using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace T4
{
    class Auto
    { //properties 
        public string Name { get; set; }
        public int Speed { get; set; }
        public int Tyres { get; set; }
        //methods  //Tulostaa ominaisuudet 
        public void PrintData()
        {
            Console.WriteLine("Vehicle properties :");
            Console.WriteLine("Name : {0}", Name);
            Console.WriteLine("Speed : {0}", Speed);
            Console.WriteLine("Tyres : {0}", Tyres);
        }  // palauttaa kaikki ominaisuudet yhtenä merkkijonona 
        public override string ToString()
        {
            return "Name : " + Name + ", Speed : " + Speed + ", Tyres : " + Tyres;
        }
    }
}