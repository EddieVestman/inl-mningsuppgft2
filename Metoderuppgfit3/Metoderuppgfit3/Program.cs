using System;

namespace Metoderuppgfit3
{
    class Program
    {
        static void Main()
        {
            int a = 10, b = 20;

            BytPlats(ref a, ref b);

            Console.WriteLine("a = " + a +" "+ "b = " + b);



        }
        public static void BytPlats(ref int a, ref int b)
        {
            
            int temp = a;
            a = b;
            b = temp;
           
        }
          
    }
}
