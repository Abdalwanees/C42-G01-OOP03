using C42_G01_OOP03.Binding;
using C42_G01_OOP03.Interface;
using C42_G01_OOP03.Overriding;

namespace C42_G01_OOP03
{
    internal class Program
    {
        #region Method Overloading
        public static int Sum(int Num1, int num2)
        {
            return Num1 + num2;
        }
        public static int Sum(int Num1, int Num2, int Num3)
        {
            return Num1 + Num2 + Num3;
        }
        #endregion

        #region processEmployee
        public static void ProcessEmployee(Employee employee) /*employee = new FullTimeEmployee*/
        {
            if (employee is not null)
            {
                employee.GetStatus();
                employee.GetInfo();
            }
        }
        #endregion


        static void Main(string[] args)
        {
            //OOP Defination
            // 1- Encapsulation 
            // 2- Inhertance
            // 3- Polymorphism
            // 4- Abstraction
            //---------------------
            // Polymorphism --(OverLoading(Use Many Method with same name (عدد - نوع البرامتر - ترتيب ) ) &&  Overriding (New & Override))
            // Poly --> Many   || Morphism --> Forms

            #region Calling method Overloading
            //Console.WriteLine(Sum(5, 10));
            //Console.WriteLine(Sum(5, 10, 15)); 
            #endregion

            #region Method Overriding
            //Override (Not Use in Struct)
            //TypeA typeA=new TypeA(5);
            ////typeA.A = 50;
            //typeA.MyFunc01();
            //typeA.MyFunc02();
            //Console.WriteLine("--------TypeB-----------");
            //TypeB typeB=new TypeB(6,10);
            ////typeB.A = 60;
            ////typeB.B = 70;
            //typeB.MyFunc01();
            //typeB.MyFunc02(); 
            #endregion

            #region Binding
            ////Binding --> Reference from parent to Object from child
            //TypeA RefBase = new TypeB(5, 10);
            //RefBase.A = 1; //Valid
            ////RefBase.B=2;--> // XXXXX -->Not Valid
            //RefBase.MyFunc01(); //I'm Base  --> Static Binding
            //RefBase.MyFunc02(); //Print Valuse Of 'A' and 'B' on multible line -->Dynamic Binding
            //-----------------------------------------------------
            //Static Binding
            //Compiler will bind call based on refernce not object
            //Compilation time (early binding)
            //-----------------------------------------------------
            //Static Binding
            //Compiler will bind call based on refernce not object
            //Compilation time (early binding)
            //-----------------------------------------------------
            //Dynamic Binding
            //Compiler will  call last Function Overrided based on object not reference
            //Compilation time (late binding)
            #endregion

            #region Casting --> Unsafe casting

            ////Casting -->take reference from child to object from parent
            //TypeA typeA = new TypeB(5, 11);
            //typeA = new TypeA(10);
            //TypeB typeB = (TypeB)typeA;//Un Save Casting

            #endregion

            #region Emplyee Call (Binding behavior)
            //FullTimeEmployee fullTimeEmployee = new FullTimeEmployee()
            //{
            //    Id = 1,
            //    Name = "Ali",
            //    Age = 25,
            //    Salary = 9_000
            //};
            //ProcessEmployee(fullTimeEmployee);

            //Console.WriteLine("---------------------------------");

            //PartTimeEmployee partTimeEmployee = new PartTimeEmployee()
            //{
            //    Id = 1,
            //    Name = "ahmed",
            //    Age = 28,
            //    HourRate = 120
            //};
            //ProcessEmployee(partTimeEmployee);
            #endregion

            #region interface
            //A code contract is a type of agreement between the programmer who wrote the code
            //and the programmer who implements or uses it.

            IMyFile myFile;
            //declare for reference of type 'IMyType' , refering to null
            //this referennce 'IMyType' can refer to an object from class or dtruct implementing the iterface
            //clr will allocate 4 bytes at stack for the refernce


            // myFile = new IMyFile(); //--> invalide

            MyFile myFile1 = new MyFile();
            myFile1.Salary = 10_000;
            myFile1.MyFun();
            //myFile1.print(); xxxx

            //The only way to access the default implementation of a method is to refer to
            //the interface that contains the default implementation method, while pointing
            //to an object from a class or struct that implements the interface

            IMyFile referenceFormatInterface = new MyFile();
            referenceFormatInterface.Salary = 10_000;
            referenceFormatInterface.MyFun();
            referenceFormatInterface.print();
            #endregion
        }
    }
}
