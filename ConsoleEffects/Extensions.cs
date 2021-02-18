using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleEffects
{
    internal static class Extensions
    {
        public static bool IsOdd(this int integer)
        {
            return !(integer % 2 == 0);
        }

        public static bool IsEven(this int integer)
        {
            return (integer % 2 == 0);
        }

    }
}
