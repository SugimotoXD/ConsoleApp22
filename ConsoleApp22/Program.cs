using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp22
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Double t, y, n, R;
                Console.Write("Enter t");
                t = double.Parse(Console.ReadLine());
                Console.Write("Enter y");
                y = double.Parse(Console.ReadLine());
                Console.Write("Enter n");
                n = double.Parse(Console.ReadLine());

                R = (Math.Sin(2 * t + 1)) + 0.3 / 1 * n * (t + y);

                Console.WriteLine("R=" + R);
            }

            catch (Exception R)

            {

                Console.WriteLine(R.Message);
            }
        }
    }
}
