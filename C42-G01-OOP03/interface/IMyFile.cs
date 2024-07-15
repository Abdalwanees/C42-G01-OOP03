using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C42_G01_OOP03.Interface
{
    //Devloper 01
    internal interface IMyFile
    {
        //Defualt access modifier inside the interface is "public"
        // private access modifier inside the interface is not allowed for signatuers


        //what you can write inside the interface
        ////1.Signature for property

        int Salary { get; set; }

        ////2.Signature for method
        void MyFun();

        ////3.defualt implemented method -> C#8.0 feature (.net core 3.1 (2019))
        void print()
        {
            Console.WriteLine("hello defualt implmented method from interface[C# 8.0 featuer]");
        }
    }
}