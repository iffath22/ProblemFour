using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemFour
{

    class Program
    {
        
        static void Main(string[] args)
        {
            int totaleven = 0, totalodd = 0;
            Console.Write("Enter The Range You Want to Sum of Even and Odd Numbers: ");

            Console.WriteLine("-------------------------------------------------------------");
            Console.Write("Even Numbers:");
            Console.WriteLine("\t Odd Numbers:");
            for (int num = 0; num <= 100; num++)
            {
                if (num % 2 == 0)
                {
                    Console.Write(" {0}", num);
                    totaleven = totaleven + num;
                }
                else
                {
                    Console.WriteLine(" \t\t\t {0}", num);
                    totalodd = totalodd + num;
                }
            }
            Console.WriteLine(" \n Sum of All Even Numbers are : {0} \n Sum of All Odd Numbers are : {1}", totaleven, totalodd);
            Console.Read();
        }
    }
}
