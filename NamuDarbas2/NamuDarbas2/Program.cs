using System;

namespace NamuDarbas2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] magicNumber= new int[6];
             InsertNumbers(magicNumber);
            PrintNumbers(magicNumber);
            Console.WriteLine();
            if (!CheckNumbers(magicNumber))
            { Console.WriteLine("Klaida, yra pasikartojantys skaiciai"); return; }
            else Console.WriteLine("Visi skaiciai skirtingi");

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
            foreach (int number in skaiciai)
            {
                Console.Write(number);
            }
        }

        static bool CheckNumbers(int [] skaiciai)
        {
            bool check=true;
            for(int i=0;i<skaiciai.Length;i++)
            {
                int skc1 = skaiciai[i];
                for(int j=0;j<skaiciai.Length;j++)
                {
                    int skc2 = -1;
                    if(i!=j) skc2 = skaiciai[j];
                    if(skc1==skc2)
                    {
                        check = false;
                        break;
                    }
                }

            }
            return check;
        }
    }
}
