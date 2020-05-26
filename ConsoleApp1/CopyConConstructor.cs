using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace ConsoleApp1
{
    class CopyConConstructor
    {
        //Types of Constrcutor
        //1. Default or Parameter Less Constructor
        //If a Constructor does not take any parameters then it can be called as Default or Parameter Less Constructor.
        //These Constructors can be defined by a programmer explicitly, if not, it will be provided implicitly by default by Compiler.

        //2.Parameterized Constructor
        //If a Constructor is defined with any parameters then it is called as Parameterized Constructor.
        //These Constructors needs to be defined explicitly only, it can never be defined implicitly.

        //3.Copy Constructor
        //If we want to create multiple instances with the same values then we user these Copy Constructors.
        //In a Copy Constructor the Constructor takes the same class as a parameter to it.

        //4.Static Constructor
        //If a Constructor is explicitly declared by using static modifier it is called as Static Constructor.
        //If a class contains any static variables then only implicit Static Constructors will be present or else Static Constructors needs to be defined explicitly.
        //Static Constructors are responsible in initializing static variables and these constructors are never called explicitly.
        //For Ex: Without creating an instance of the class Static Constructors will be executed.
        //        where as non-static constructors wont be executed till the time their Class instance is created.
        //Static Constructors are first to execute under any class (before non-static constructors and before executing Main method)
        //Static Constructors cannot be parameterized, so Constructors overloading is not possible with Static Constructors
        //Access Modifiers are not allowed for Static Constructors

        int x;

        public CopyConConstructor() //Default Constructor or Parameter Less Constructor
        {
            Console.WriteLine("Default Constructor or Parameter Less Constructor");
        }
        public CopyConConstructor(int i) //Parameterized Constructor
        {
            x = i;
        }

        public CopyConConstructor(CopyConConstructor obj) // Copy Constructor
        {
            x = obj.x;
        }

        static CopyConConstructor() // Static Constructor
        {
            Console.WriteLine("Static Constructor Executed"); // This Statement will be executed first.
        }

        public void Display()
        {
            Console.WriteLine("Value of x is:" + x);
        }

        static void Main()
        {
            CopyConConstructor CC2 = new CopyConConstructor(10);
            CC2.Display();
            CopyConConstructor CC3 = new CopyConConstructor(CC2);
            CC3.Display();
            CopyConConstructor CC1 = new CopyConConstructor();
            Console.WriteLine("Main Method Executed");
            /*Output Order
             1.Static Constructor
             2.non-Static Constructors (Parameterized Constructor)
             2.non-Static Constructors (Copy Constructor)
             3.Default Constructor
             4.Main Method
            */
            Console.ReadLine();
        }
    }
}
