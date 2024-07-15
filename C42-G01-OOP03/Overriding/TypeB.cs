using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C42_G01_OOP03.Overriding
{
    public class TypeB:TypeA
    {
		private int b;

		public int B			
		{
			get { return b; }
			set { b = value; }
		}
        public TypeB(int _A,int _B ):base(_A)
        {
            b = _B;
        }

        public new void MyFunc01()
        {
            Console.WriteLine("I'm Child !");
        }
        public override void MyFunc02() {
            Console.WriteLine($"A : {A}\nB : {b}");
        }
    }
}
