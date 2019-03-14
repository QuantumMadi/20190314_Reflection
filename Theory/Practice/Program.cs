using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
          
           Type strType = typeof(string);


            MethodInfo substr = strType.GetMethod("Substring", new Type[] { typeof(int), typeof(int) });

            object result = substr.Invoke("Hello world!", new object[] { 7, 5 });

            Console.WriteLine("{0} returned \"{1}\".", substr, result);

            Console.ReadLine();
        }
    }
}
