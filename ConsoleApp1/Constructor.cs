using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Constructor
    {
        //1.Constructor is a method present under a class responsible for initializing the variables of that class.
        //2.The name of the Constructor should be exactly the same name of the class in which it is present.
        //3.Constructors are non-value returning method.
        /*4.Each and every class requires a constructor if we want to create and instance of that class, if we dont create contructor manually
            an implicit constructor gets defined in that class by the compiler*/
        
        //For Ex:
        int i; string s; bool b; // Three Variables are declared in this class 
        /*Now If we dont create a constructor in this class manually then an implicit constructor gets defined in the class by the Compiler and
          it sets default value to all its variables*/
        public Constructor()
        {
            i = 0; // default value for int is 0.
            s= null; // default value for string is null.
            b = false; // default value for bool is false.
        }

        //5.Implicit defined constructors are parameter less and these constructors are also known as default constructors.
        //6.Implicit constructors are public by default.
        //7.We can also define a constructor under the class and it is called as Explicit Constructor.
        //8.Explicit Constructor can be parameter less or parameterized.
        //9.When an instance of the class is created, we are calling an constructor explicitly.
        //For Ex:
            // Test T = new Test();
                //Here Test is the name of the class
                //T is an instance of the class
                //new is the keyword to create an instance
                //Test() is an Explicit call to the Constructor
    }
}
