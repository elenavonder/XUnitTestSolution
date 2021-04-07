using System;
using Xunit;
using MyLib = XUnitTestLib;

namespace XUnitTestingProject
{
    public class UnitTest1
    {//open test explorer to test methods
        [Theory]
        [InlineData(3, 1, 2)]
        [InlineData(5, 3, 2)]
        [InlineData(0, 7, -7)]
        //the first value should be expected, second value should be actual
        public void TestMathAdd(int exp, int A, int B)
        {
            Assert.Equal(exp, MyLib.Math.Add(A, B));
        }

        [Theory]
        [InlineData(10, 20, 10)]
        [InlineData(100, 101, 1)]
        [InlineData(0, 7, 7)]
        public void TestMathSub (int exp, int A, int B)
        {
            Assert.Equal(exp, MyLib.Math.Subtract(A, B));
        }

        [Theory]
        [InlineData(5, 2)]
        [InlineData(5, 3)]
        [InlineData(8, 0)]
        [InlineData(4, 8)]
        public void TestMathModulo (int A, int B)
        {
            Assert.Equal(A % B, MyLib.Math.Modulo(A, B));
        }

        [Theory]
        [InlineData(0, -8)]
        [InlineData(84, -7)]
        [InlineData(61, -6)]
        [InlineData(1437, 26)]
        [InlineData(1546, 27)]
        [InlineData(0, 28)]
        [InlineData(7, 0)]
        public void TestGregFunction (int exp, int X)
        {
            Assert.Equal(exp, MyLib.Math.GregFunctionMethod(X));
        }
    }
}
