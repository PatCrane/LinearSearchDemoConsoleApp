using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            int theValueWeArSearchingFor = 7;

            int[] arrayOfIntegers = new int[] { 1, 4, 5, 7, 9, 22 };

            Console.WriteLine("Our array contains: ");
            Array.ForEach(arrayOfIntegers, x => Console.Write($"{ x } "));

            Console.Write($"\n\nThe result of a linear search for { theValueWeArSearchingFor } is: ");

            Console.WriteLine(linearSearch(arrayOfIntegers, theValueWeArSearchingFor));

            Console.ReadLine();
        }

        static int linearSearch(int[] arrayOfIntegers, int theValueWeAreSearchingFor)
        {
            //Step 1
            for (int i = 0; i < arrayOfIntegers.Length; i++)
            {
                if (arrayOfIntegers[i] == theValueWeAreSearchingFor)
                {
                    return i;
                }
            }

            //Step 2
            return -1;
        }
    }


}
