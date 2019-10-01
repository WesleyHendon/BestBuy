using System;
namespace BestBuy
{
    public class MyMath
    {
        public static double SumTwoNumbers(double num1, double num2)
        {
            return num1 + num2;
        }

        public static double MapValue(double value, double oldMin, double oldMax, double newMin, double newMax)
        {
            return ((value - oldMin) * ((newMax - newMin) / (oldMax - oldMin))) + newMin;
        }
    }
}
