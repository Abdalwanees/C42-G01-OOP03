using C42_G01_OOP03.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C42_G01_OOP03.Interface
{
    //Devloper 02
    internal class MyFile : IMyFile /* -->implement */
    {
        private int salary;

        public int Salary { get; set; }

        public void MyFun()
        {
            Console.WriteLine("Hello World!");
        }
    }
}