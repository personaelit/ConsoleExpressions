using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleExpressions
{
    internal class ConsoleHistory : List<string>
    {
        internal void WriteAll()
        {
            foreach (var input in this)
            {
                Console.WriteLine(input);
            }
        }
    }
}
