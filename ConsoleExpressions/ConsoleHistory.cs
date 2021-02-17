using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleExpressions
{
    public class ConsoleHistory : List<string>
    {
        public void WriteAll()
        {
            foreach (var input in this)
            {
                Console.WriteLine(input);
            }
        }
    }
}
