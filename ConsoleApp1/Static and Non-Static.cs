using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Static_and_Non_Static
    {
        /*1.If we a Constructor is explicitly declared by using a static modifier we call that constructor as static Constructor whereas
            rest of other are non-static Constructors.*/
        /*2.Constructors are responsible for initialzing the fields/variables of a class, so static fields are initialized by static Constructors
            and non-static fields are initialized by non-static Constructors.*/
        //3.Static Constructors are implicitly called whereas non-static Constructors must be explicitly called.
        /*4.Static Constructors executes immediately once the execution of a class starts and more over its the first block of code to run
            under a class whereas non-static Constructors executes only after creating the instance of class as well as each and every time
            the instance of class is created.*/
        /*5.In the life cycle of a class static constructor executes only one time whereas non-static constructor executes for zero times
            if no instance are created and n times if n intance are created.*/
        //6.A static member of a class can be directly accessed in static block.
        /*Eg: static int y;
              static void Main()
              {
                  Console.WriteLine(y); // y can be directly accessed as it is a static variable and we are accessing it under static method.
              }*/
        /*7.Non-static Constructors can be parameterized but static Constructor cannot be parameterized because static constructors are 
            implicitly called and moreover its the first block of the code to run under the class.*/
        //8.Non-static Constructors can be overloaded but static Constructor cannot be overloaded.*/
        //9.Every Class contains an impolicit constructor if not defined explicitly and those implicit constructors are defined based on the following criteria.
            //i.Every class except a static class contains an implicit non-static constructor if not defined with an explicit constructor.
            //ii.Static constructors are implicitly defined only if that class contains any static fields or else that constructor will not be present at all.
}
}
