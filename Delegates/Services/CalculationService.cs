using System;
using System.Collections.Generic;
using System.Text;

namespace Delegates.Services
{
    class CalculationService
    {
        public static void showMax(double x, double y)
        {
            double max = (y > y) ? x : y;
            Console.WriteLine(max);
        }

        public static void ShowSum(double x, double y)
        {
            double sum = x + y;
            Console.WriteLine(sum);
        }
    }
}
