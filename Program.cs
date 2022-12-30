using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace project_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num, start, end, i, x;


            Console.Write("Enter starting number : ");
            start = int.Parse(Console.ReadLine());
            Console.Write("Enter ending number : ");
            end = int.Parse(Console.ReadLine());
            Console.Write("The prime numbers between " + start + " and " + end + " are : \n ");

            for (num = start; num <= end; num++)
            {
                x = 0;

                for (i = 2; i <= num / 2; i++)
                {
                    if (num % i == 0)
                    {
                        x++;
                        break;
                    }
                }

                if (x == 0 && num > 1)
                    Console.WriteLine(" \n {0} ", num);
            }

        }
    }
}

