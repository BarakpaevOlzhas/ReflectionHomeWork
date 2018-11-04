using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ReflectionHomeWorkTwo
{
    class Program
    {
        static void Main(string[] args)
        {
            Line line = new Line
            {
                Size = 20,
                Color = ConsoleColor.Blue,
                NameLine = "Wsd"
            };

            Type type = typeof(Line);

            PropertyInfo[] properities = type.GetProperties();            

            foreach (PropertyInfo properiti in properities)
            {
                if (properiti.GetIndexParameters().Length == 0)
                {
                    Console.Write(properiti.Name + ": ");                    
                    Console.Write(properiti.GetValue(line) + "\n");
                }
            }


        }
    }
}
