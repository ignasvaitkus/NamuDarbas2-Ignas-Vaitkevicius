using System;


namespace NamuDarbas2
{
    class Program
    {
        static void Main(string[] args)
        {
            
             Start:

            int y = 2;
            int[] magicNumber = new int[6];
                InsertNumbers(magicNumber);
                PrintNumbers(magicNumber);
                Console.WriteLine();
                if (!CheckNumbers(magicNumber))
                { Console.WriteLine("Klaida, yra pasikartojantys skaiciai, bandykite is naujo"); goto Start; }
                else Console.WriteLine("Visi skaiciai skirtingi, tesiama toliau..");
                Middle:

                int[] magicNumber2 = new int[6];
                magicNumber2 = (int[])magicNumber.Clone();

                if (MakeNewInt(y, magicNumber2) > 999999)
                {
                    Console.WriteLine("Magiskas skaicius per didelis, bandykite is naujo!");
                    goto Start;
                }
                else
                {
                    int skaicius = MakeNewInt(y, magicNumber2);
                    MakeNewArray(skaicius, magicNumber2);
                }
                Console.Write("Jusu magiskas skaicius: ");
                PrintNumbers(magicNumber2);
                Console.WriteLine(" " + y);
                y++;
                if(y<=6) goto Middle;
            
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

        static int MakeNewInt(int y,int[] skaicius)
        {

            int sum = 0;
            int x = 100000;
            for (int i = 0; i < skaicius.Length; i++)
            {
                sum = sum + skaicius[i] * x;
                x /= 10;
            }
            sum *= y;
            return sum;
            
        }
        static void MakeNewArray(int sum, int[] skaicius)
        {
            for (int i = skaicius.Length - 1; i >= 0; i--)
            {
                int skc = sum % 10;
                skaicius[i] = skc;
                sum /= 10;

            }
        
        }
    }
}
