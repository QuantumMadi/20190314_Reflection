using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace ConsoleMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            Type console = typeof(Console);
            MethodInfo[] methodInfos = console.GetMethods();

            foreach(var methodInfo in methodInfos)
            {
                Console.WriteLine(methodInfo);
            }
            Console.ReadLine();
        }
    }
}
