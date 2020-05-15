using System;
using System.Runtime.InteropServices;

namespace Evennumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] myNumbers = new int[10];

            Console.WriteLine("Enter the 10 integer Numbers");

            for (int i = 0; i < myNumbers.Length; i++)
            {

                myNumbers[i] = Convert.ToInt32(Console.ReadLine());

            }
            Console.WriteLine("List of even Numbers:");

            for (int i = 0; i < myNumbers.Length; i++)
            {
                if (myNumbers[i] % 2 == 0) 
                    Console.WriteLine(myNumbers [i] );

            }
        }              
    }
}

