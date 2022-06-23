using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seminar_2_Task_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] Array = new int[100];
            int i = 0;
            string temp;
            int up = 0;
            int count = 0;

            do
            {
                temp = Console.ReadLine();
                if (temp == "end")
                {
                    break;
                }

                Array[i] = Convert.ToInt32(temp);
                i++;
            }
            while (true);

            for (i = 0; i < Array.Length - 2; i++)
            {
                if (Array[i + 1] > Array[i])
                {
                    up += 1;
                }
                else
                {
                    up = 0;
                }
                
                if (up == 1)
                {
                    count += 1;
                }
            }

            Console.WriteLine(count);
        }
    }
}
