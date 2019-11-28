﻿using System;
using Delegates.Services;

namespace Delegates
{

    delegate void BinaryNumericOperation(double n1, double n2);

    class Program
    {
        static void Main(string[] args)
        {
            double a = 10;
            double b = 12;

            BinaryNumericOperation op = CalculationService.ShowSum;
            op += CalculationService.showMax;

            op(a, b); // or op.Invoke(a,b)

        }
    }
}
