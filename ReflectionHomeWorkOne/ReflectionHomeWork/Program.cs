using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;
using System.Threading.Tasks;

namespace ReflectionHomeWork
{
    class Program
    {
        static void Main(string[] args)
        {
                Type TypeConsole = typeof(Console);
                MethodInfo[] methods = TypeConsole.GetMethods();

                int number=0;
                Console.WriteLine("Список класса Console\n");
                foreach (MethodInfo meto in methods)
                {
                Console.WriteLine(number + "." + meto.ReturnType.Name + "    " + meto.Name);                
                number++;
                }                
            }
        }
    }
