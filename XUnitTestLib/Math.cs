using System;

namespace XUnitTestLib
{
    public class Math
    {
        //add method
        public static int Add(int A, int B)
        {
            return A + B;
        }
        public static int Multiply(int A, int B)
        {
            return A * B;
        }
        public static int Subtract(int A, int B)
        {
            return A - B;
        }
        public static int Divide (int A, int B)
        {
            return A / B;
        }
        public static int Modulo(int A, int B)
        {
            return A - (A / B * B);
        }
        public static int Cube(int A)
        {
            return A * A * A;
        }
        public static int Squared(int A)
        {
            return A * A;
        }
        public static int GregFunctionMethod(int X)
        {
            return (2 *(X * X) + 3 * (X) + 7);
        }
    }
}
