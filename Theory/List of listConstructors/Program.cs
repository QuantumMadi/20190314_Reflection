using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace List_of_listConstructors
{
    class Program
    {
        static void Main(string[] args)
        {
            Type tp = typeof(List<>);

            ConstructorInfo[] constructorInfos = tp.GetConstructors();

            foreach(var c in constructorInfos)
            {
                Console.WriteLine(c);
            }
            Console.ReadLine();
        }
    }
}
