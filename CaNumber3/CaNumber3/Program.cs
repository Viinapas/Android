using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CaNumber3
{
    class Program
    {
        static void Main(string[] args)
        {

            // Input 3 number; Program output number lowest to highest. basics

   
            
            Console.WriteLine("Program input numbers from order lowest ti high.");

            //Console.WriteLine("Please select first number");

            //num1 = int.Parse(Console.ReadLine());

            //Console.WriteLine("Please select second number");

            //num2 = int.Parse(Console.ReadLine());

            //Console.WriteLine("Please select third number");

            //num3 = int.Parse(Console.ReadLine());

            float large, small;
            int[] a = new int[100000];
            Console.WriteLine("Please enter first how many number you want choise the array");
            int max = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter the compare numbers. ");
            for (int i = 0; i < max; i++)
            {
                string s1 = Console.ReadLine();
                a[i] = int.Parse(s1);
            }
            Console.Write("");
            large = a[0];
            small = a[0];
            for (int i = 1; i < max; i++)
            {
                if (a[i] > large)
                    large = a[i];
                else if (a[i] < small)
                    small = a[i];
            }
            Console.WriteLine("Largest number in the array is {0}", large);
            Console.WriteLine("Smallest number in the array is {0}", small);
            Console.ReadLine();


     

                
    
    
       





        }
    }
}
