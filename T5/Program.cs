using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T5
{
    class Program
    {
        static void Main(string[] args)
        {
            opiskelijat[] students = new opiskelijat[5];


            for (int i = 0; i < students.Length; i++)
            {
                students[i] = new opiskelijat();
            }

            // create a new student object
          
            students[0].Nimi = "Pertti";
            students[0].Opiskelijanro = "P1234";
            students[0].Ka = 3.4;
            students[0].Op = 45.0;
            students[0].Aloitusv = 2015;          

            students[1].Nimi = "Miina";
            students[1].Opiskelijanro = "P5555";
            students[1].Ka = 3.6;
            students[1].Op = 85.0;
            students[1].Aloitusv = 2014;
        
            students[2].Nimi = "Tintti";
            students[2].Opiskelijanro = "P4040";
            students[2].Ka = 2.7;
            students[2].Op = 66.0;
            students[2].Aloitusv = 2014;
           
            students[3].Nimi = "Muumi";
            students[3].Opiskelijanro = "P9999";
            students[3].Ka = 4.5;
            students[3].Op = 100.0;
            students[3].Aloitusv = 2013;
           
            students[4].Nimi = "Tauno";
            students[4].Opiskelijanro = "P2020";
            students[4].Ka = 3.1;
            students[4].Op = 55.0;
            students[4].Aloitusv = 2015;
            

            for (int i = 0; i < students.Length; i++)
            {
                students[i].PrintData();
            }

            

            Console.ReadLine();
        }
    }
}
