using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C42_G01_OOP03.Overriding
{
    public class TypeA
    {
		private int a;
		public int A
		{
			get { return a; }
			set { a = value; }
		}
        public TypeA(int _A)
        {
           a = _A;
        }
        public void MyFunc01()
        {
            Console.WriteLine("I'm Base !");
        }
        public virtual void MyFunc02() {
            Console.WriteLine($"A : {a}");
        }

    }
}
