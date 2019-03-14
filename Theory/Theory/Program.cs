using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace Theory
{
    class Program
    {
        static void Main(string[] args)
        {
            Assembly assembly = Assembly.LoadFile(@"C:\Users\АбдигалиевМ.CORP.000\source\repos\20190314_Reflection\ClassLibrary2\ClassLibrary2\bin\Debug\ClassLibrary2.dll");
            foreach(var type in assembly.GetTypes())
            {
                foreach(var memberInfo in type.GetMembers())
                {
                    Console.WriteLine($"{memberInfo.MemberType} {memberInfo.Name}");
                    if (memberInfo is ConstructorInfo)
                    {
                        var Constructor = memberInfo as ConstructorInfo;
                        Console.WriteLine($"{Constructor.GetParameters()[0]}");
                    }
                      
                    if(memberInfo is MethodInfo && memberInfo.Name == "SendMessage")
                    {
                        object smsService = Activator.CreateInstance(type,"Message");
                        (memberInfo as MethodInfo).Invoke(smsService, new object[] { "SMS", " to Somebody" });
                    }                                       
                    //if (memberInfo.GetType() == typeof(ConstructorInfo))    //isEqual
                    //{

                    //}
                }
            }
        }
    }
}
