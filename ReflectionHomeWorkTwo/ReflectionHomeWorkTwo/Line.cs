using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReflectionHomeWorkTwo
{
    public class Line
    {
        public string NameLine { set; get; }

        public int Size { get; set; }

        public ConsoleColor Color { set; get; }

        public void ShowAllStat()
        {
            Console.WriteLine($"{ NameLine} {Size} {Color}");
        }
    }
}
