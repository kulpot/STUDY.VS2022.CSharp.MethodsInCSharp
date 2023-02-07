///                     METHOD
/// A method is a code block that contains a series of statements.A program causes the statements to be executed by calling the method and specifying any required method arguments. In C#, every executed instruction is performed in the context of a method. The Main method is the entry point for every C# application and it is called by the common language runtime (CLR) when the program is started.
/// 
///
///                     Syntax
/*                     
     <Access Specifier> <Return Type> <Method Name>(Parameter List)
     {

          Method Body

     }

<Access Specifier> - determines the visibility of a variable or a method from another class.

<Return Type> - A method may return a value. The return type is the data type of the value the method returns. If the method is not returning any values, then the return type is void.

<Method Name> - is a unique identifier and it is case sensitive. It cannot be same as any other identifier declared in the class.

<Parameter List> - Enclosed between parenthesis, the parameters are used to pass and receive data from a method. The parameter list refers to the type, order, and number of the parameters of a method. Parameters are optional; that is, a method may contain no parameters.
 
<Method Body> - This contains the set of instructions needed to complete the required activity.

 */

//              Example
// public int Add(int num1, int num2) {
//     int result = num1 + num2;
//     return result;
//  }
using System;
            ///Methods - Creating Method/Return value
namespace MethodsInCSharp
{
    /*   ------------Creating Method---------------
    class Program
    {
        static void Main(string[] args)
        {
            WriteSomething();
            WriteSomethingSpecific("I am an argument and am called from a method");
            Console.Read();

        }
        // access modifier (static) return type method name (parameter1, parameter2)
        public static void WriteSomething()
        {
            Console.WriteLine("I am called from a method");
            //Console.Read(); //need to remove and place to the main method for the accessibility of WriteSomethingSpecific
        }

        public static void WriteSomethingSpecific(string myText)
        {
            Console.WriteLine(myText);
            Console.Read();
        }
    }*/

//   ---------------Return Value------------
    class Program
    {
        static void Main(string[] args)
        {
            //int result = Add(15, 31);
            //Console.WriteLine(result);
            Console.WriteLine(Add(Add(1, 2), Add(3, 4)));
            Console.WriteLine(Add(15, 31));//method argument-- (Add(15, 31)) --can use method as an argument ///type string argument Console.WriteLine("type string argument")
            Console.WriteLine(Multiply(25,25));
            Console.WriteLine(Devide(25,13));
            Console.Read();
        }

        public static int Add(int num1, int num2)
        {
            return num1 + num2;
        }

        public static int Multiply(int num1, int num2)
        {
            return num1 * num2;
        }

        public static double Devide(double num1, double num2)
        {
            return num1 / num2;
        }
        /* Results
        10
        46
        625
        1.9230769230769231
        */
    }
}

