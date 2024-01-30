﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp166
{
    class Program
    {
        static void Main(string[] args)
        {
            var buffer = new StringBuilder();

            var string1 = "This {0} costs:{1:C}.\n\n";

            var objectArray = new object[2] { "car", 1234.56 };

            buffer.AppendFormat(string1, objectArray);

            string string2 = "Number:\n{0:d3}.\n\n" + "Number right aligned with spaces:\n{0,4}.\n\n" + "Number left aligned with spaces:\n{0,-4}.";

            buffer.AppendFormat(string2, 5);

            Console.WriteLine(buffer.ToString());

            Console.ReadLine();
        }
    }
}
