using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace MyClassforReflection
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car("Nissan", "Sedan", 300, true);
            GetPropertyValues(car);
            Console.ReadLine();
        }
       
        private static void GetPropertyValues(object obj)
        {
            Type getType = obj.GetType();
            Console.WriteLine($"Type is {getType.Name} ");
            PropertyInfo[] properties = getType.GetProperties();
            Console.WriteLine($"Properties = {properties.Length}");

            foreach(var property in properties)
            {           
                    Console.WriteLine($"{property.Name} : {property.PropertyType.Name} : {property.GetValue(obj)} ");           
            }
        }
    }
}
