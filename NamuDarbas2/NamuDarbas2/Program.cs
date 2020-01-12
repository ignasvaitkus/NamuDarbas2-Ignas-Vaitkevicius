using System;

namespace NamuDarbas2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] magicNumber= new int[5];
             InsertNumbers(magicNumber);
            PrintNumbers(magicNumber);
        }
        
        static void InsertNumbers( int[] skaiciai)
        {
            for(int i=0;i<skaiciai.Length;i++)
            {
               skaiciai[i] = Convert.ToInt32(Console.ReadLine());
            }
        }

        static void PrintNumbers(int [] skaiciai)
        {
            foreach (int item in skaiciai)
            {
                Console.Write(item + ", ");
            }
        }
    }
}
