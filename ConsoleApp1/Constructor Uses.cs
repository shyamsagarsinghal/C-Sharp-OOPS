using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Constructor_Uses
    {
        //Uses of Constructor
        //1.Every Class requires a constructor to be present in it, if we want to create an instance of that class
        /*2.Every Class contains an implicit constructor if not defined explicitly and with the help of that implicit Constructor
            instance of the class can be created.*/
        //3.What is the need of defining a constructor explicitly again..?
        //A.Implicit Constructor of a class will initialize variables of a class with the same value even if we create multiple instance of that class.
        /*4.If we define Constructors excplicitly with parameters then we get a chance of initializing the fields or variables of the class with
            a  new value every time we are going to create instance of that class.*/
        /*5.Whenever we define a class first identify whether if the class variables requires some values to execute and if they are required
            then define a constructor explicitly and pass values through that constructor, so that every time the instance of class is created we 
            get a chance of passing new values.*/
        /*Note: Generally every class requires some values for execution and the values that are required for a class to execute are always sent
          to that class by using the constructor only.*/
    }
}
