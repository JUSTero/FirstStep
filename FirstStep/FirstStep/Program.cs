using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstStep
{
    class Program
    {
        static void Main()
        {
            int prev = 0;

            int i = 10;

            int sum = 0;

            while (sum < 26)
            {
                Random a = new Random ();
                int b = a.Next(1001);

                if (b > prev)
                {
                    int c = b;

                    sum = 0;

                    while (c >= i)
                    {
                        sum = sum + c % i;

                        c = c / i;
                    }

                sum = sum + c;

                    if (sum < 26)
                    {
                        Console.WriteLine(b);

                        prev = b;
                    }
                    else
                    {
                        Console.WriteLine(b);
                        Console.WriteLine("STOP");

                        break;
                    }
                }
            }
        }
    }
}
