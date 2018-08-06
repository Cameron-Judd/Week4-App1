using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week4_App1
{
    class Program
    {
        static void Main(string[] args)
        {
            int loopBreaker = 1;

            Console.WriteLine("Hello world!");
            Console.WriteLine("Workshop 4 edit");
            Console.WriteLine("Cameron Judd was here.");

            String breakString = "Break";
            if (Console.ReadLine() == breakString)
            {
                for (int i = 0; i < loopBreaker; i++)
                {
                    loopBreaker++;
                    Console.WriteLine(i);
                }
            }

            Console.ReadLine();
        }
    }
}
