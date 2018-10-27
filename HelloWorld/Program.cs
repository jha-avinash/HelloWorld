using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    //public is a access modifier
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World");
            // a is a variable and here integer is the data type
            int a = 3;
            int b = 4;
            int c = a + b;
            Console.WriteLine(" The vlaue of c is " + c);
            //we assigning a new value to c here which was 7 intitally
            //we cannot declare a varialble in the scope for more than once
            int d = a * b;
            Console.WriteLine ("The product of a and b is " + d);
            Console.ReadKey();

        }
    }
}
