using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24SOECE13009_Dhiraj_BM
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //without mention datda type
            //var a=10;
            Console.WriteLine("Enter num 1:");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter num 1:");
            int b = Convert.ToInt32(Console.ReadLine());
            int sum;
            sum = a + b;
            Console.WriteLine($"sum is {a},{b}:"+sum);

            //Console.Read();


        }
    }
}
