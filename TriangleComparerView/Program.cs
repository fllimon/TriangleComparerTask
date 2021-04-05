using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using TriangleComparerLib;

namespace TriangleComparerView
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                ConsoleControler controller = new ConsoleControler();
                controller.AddNewTriangle(args[0], args[1], args[2], args[3]);
                controller.AddNewTriangle(args[4], args[5], args[6], args[7]);
                controller.AddNewTriangle(args[8], args[9], args[10], args[11]);

                for (int i = 0; i < controller.CountItems; i++)
                {
                    Console.WriteLine(controller[i]);
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadKey();
        }
    }
}
