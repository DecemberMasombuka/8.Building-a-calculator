using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8.Building_a_calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter two integers to add");
            int num1 = Convert.ToInt32(Console.ReadLine());
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(num1 + num2);
            
            Console.WriteLine("Enter Two decimasl to add");
            double num3 = Convert.ToDouble(Console.ReadLine());
            double num4 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine(num3 + num4);
            Console.Read();
        }
    }
}
