﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class Calculator
    {
        public int Sum(int a, int b)
        {
            return a + b;
        }
        public int Substraction(int a, int b)
        {
            return a - b;
        }
        public int Multiply(int a, int b)
        {
            rreturn a * b;
        }

        public int Divide(int a, int b)
        {
            return b != 0 ? a / b : throw new ArgumentException();
        }
    }
}
