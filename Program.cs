using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, i, j, flag;

            Console.Write(
            "Enter First Number : ");
            a = Convert.ToInt32(
            Console.ReadLine());

            Console.Write(
            "\nEnter Second Number : ");
            b = Convert.ToInt32(
            Console.ReadLine());

            Console.Write("\nPrime numbers between " + a
                        + " and " + b + " are: ");

            if (a == 1)
            {
                Console.Write(a + " ");
                a++;
                if (b >= 2)
                {
                    Console.Write(a + " ");
                    a++;
                }
            }
            if (a == 2)
            {
                Console.Write(a + " ");
            }

            if (a % 2 == 0)
            {
                a++;
            }

            for (i = a; i <= b; i = i + 2)
            {

                flag = 1;

                for (j = 2; j * j <= i; ++j)
                {
                    if (i % j == 0)
                    {
                        flag = 0;
                        break;
                    }
                }

                if (flag == 1)
                {
                    Console.Write(i + " ");
                }
            }
        }
    }
}   

