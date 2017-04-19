using System;
using System.Collections.Generic;
using System.Linq;

namespace Extend
{
    public static class Int32s
    {
        public static int Pow(this int number, int exponent) => (int)Math.Pow(number, exponent);

        public static int Sqr(this int number) => number * number;

        public static double Sqrt(this int number) => Math.Sqrt(number);
    }
}