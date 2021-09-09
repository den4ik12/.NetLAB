using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    class Hello
    {
        static void Main(string[] args)
        {
            if (args.Length != 0)
                Console.Write($"Hello, { args[0]}");
            else
                Console.Write("Аргументов нет(");
        }
    }
}
