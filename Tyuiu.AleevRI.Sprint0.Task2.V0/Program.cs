using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.AleevRI.Sprint0.Task2.V0.Lib;

namespace Tyuiu.AleevRI.Sprint0.Task2.V0
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DataService.GetMessage("Руслан"));
            Console.ReadKey();
        }
    }
}
