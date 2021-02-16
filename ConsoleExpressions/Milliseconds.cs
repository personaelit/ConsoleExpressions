using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleExpressions
{
    internal class Milliseconds
    {
        internal int Value { get; private set; }

        public Milliseconds(int value)
        {
            Value = value;
        }
    }
}
