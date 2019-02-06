using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                MethodA();
            }
            public static void MethodA()
            {
                while (Peanut())
                {
                    Console.WriteLine("Help ! i am stuck in a infinite loop!");
                }

            }
            public static bool 
                Peanut()
            {
                return true;
            }
        }
    }
}
