using System;

namespace Metoder_2
{
    class Program
    {
        static void Main()
        {
            Console.Write("Skriv in det första talet ");
            double tal1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Skriv in det andra talet ");
            double tal2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Skriv in det sista talet ");
            double tal3 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine(Medel(tal1, tal2, tal3));



        }

        static double Medel(double t1, double t2, double t3)  {
            return (t1 + t2 + t3) / 3;


        }
    }
}
