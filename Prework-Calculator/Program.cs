using System;

namespace Prework_Calculator
{
    class Program
    {
        static void Main(string[] args)
        { 
            Add();
            Subtract();
            Multiply();
            Divide(); 
        }

        static void Add()
        {   //define variables
            int numX;
            int numY;

            //get number inputs from user 
            Console.WriteLine("Enter a number: ");
            numX = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter a number: ");
            numY = Convert.ToInt32(Console.ReadLine());
            int numZ = numX + numY;

            //output sum of chosen numbers
            Console.WriteLine($"Sum is {numZ}");
        }

        static void Subtract()

        {   //define variables
            int numX;
            int numY;

            //get number inputs from user 
            Console.WriteLine("Enter a number: ");
            numX = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter a number: ");
            numY = Convert.ToInt32(Console.ReadLine());
            int numZ = numX - numY;

            //output difference of chosen numbers
            Console.WriteLine($"Difference is {numZ}");
        }


        static void Multiply()

        {   //define variables
            int numX;
            int numY;

            //get number inputs from user 
            Console.WriteLine("Enter a number: ");
            numX = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter a number: ");
            numY = Convert.ToInt32(Console.ReadLine());
            int numZ = numX * numY;

            //output product of chosen numbers
            Console.WriteLine($"Product is {numZ}");
        }

        static void Divide()
        {
            //define variables
            int numX;
            int numY;

            //get number inputs from user 
            Console.WriteLine("Enter a number: ");
            numX = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter a number: ");
            numY = Convert.ToInt32(Console.ReadLine());
            int numZ = numX / numY;

            //output quotient of chosen numbers
            Console.WriteLine($"Quotient is {numZ}");
        }
    }
}
