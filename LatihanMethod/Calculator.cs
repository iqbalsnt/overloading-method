using System;
using System.Collections.Generic;
using System.Text;

namespace LatihanMethod
{
    public class Calculator
    {
        public int penjumlahan(int a, int b)
        {
            return a + b;
        }

        // overload method
        public int penjumlahan(int a, int b, int c)
        {
            return a + b + c;
        }

        public int pengurangan(int a, int b)
        {
            return a - b;
        }

        // method static
        public static int perkalian(int a, int b )
        {
            return a * b;
        }
    }
}
