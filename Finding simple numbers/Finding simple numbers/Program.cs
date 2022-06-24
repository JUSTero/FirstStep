using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Finding_simple_numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите нижний предел");
            string mintemp = Console.ReadLine();
            int min = Convert.ToInt32(mintemp);
            Console.WriteLine("Введите верхний предел");
            string maxtemp = Console.ReadLine();
            int max = Convert.ToInt32(maxtemp);

            int count = 0;
            int i;
            Random c = new Random();

            while (count < 5)

            {
                int count_div = 0;
                int a = c.Next(min, max + 1);

                if (a % 2 == 0 || a % 3 == 0 || a % 5 == 0)

                {
                    continue;
                }

                if (a * a % 10 != 1)

                {
                    for (i = 7; i <= Math.Sqrt(a); i += 2)
                    {
                        if (a % i == 0)
                        {
                            count_div += 1;
                        }

                        if (count_div > 0)
                        {
                            break;
                        }
                    }
                    if (count_div == 0)
                    {
                        int b = a;
                        int sum = 0;
                        while (b >= 10)
                        {
                            sum = sum + b % 10;
                            b = b / 10;
                        }

                        sum = sum + b;
                        
                        if (10 < sum & sum < 20)
                        {
                            Console.WriteLine(a);
                            count++;
                        }
                    }
                }
            }
        }
    }
}