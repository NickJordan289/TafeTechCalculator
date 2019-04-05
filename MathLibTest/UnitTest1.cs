using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using AlgebraicLib;
using ArithmeticLib;
using TrigonometricLib;

namespace MathLibTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestAddition()
        {
            double val;
            double expected;
            
            // Small numbers
            val = Arithmetic.Add(1, 1);
            expected = 2;
            Assert.AreEqual(expected, val);

            // Big numbers
            val = Arithmetic.Add(51091036, 168609436);
            expected = 219700472;
            Assert.AreEqual(expected, val);

            // Negative Numbers
            val = Arithmetic.Add(-45, 17);
            expected = -28;
            Assert.AreEqual(expected, val);

            // decimal point numbers
            val = Arithmetic.Add(1.24861, 0.15008295);
            expected = 1.39869295;
            Assert.AreEqual(expected, val);
        }

        [TestMethod]
        public void TestSubtraction()
        {
            double val = Arithmetic.Subtraction(1,1);
            double expected = 0;
            Assert.AreEqual(expected, val);

            val = Arithmetic.Subtraction(-1, -1);
            expected = 0;
            Assert.AreEqual(expected, val);

            val = Arithmetic.Subtraction(1, 0);
            expected = 1;
            Assert.AreEqual(expected, val);
        }

        [TestMethod]
        public void TestDivision()
        {
            double val;
            double expected;

            val = Arithmetic.Division(1, 1);
            expected = 1;
            Assert.AreEqual(expected, val);

            val = Arithmetic.Division(0, 10);
            expected = 0;
            Assert.AreEqual(expected, val);

            val = Arithmetic.Division(10, 3);
            expected = 3.33333333333;
            Assert.AreEqual(expected, val, 0.00000001);

            val = Arithmetic.Division(10, -2);
            expected = -5;
            Assert.AreEqual(expected, val);

            Assert.ThrowsException<Exception>(() => Arithmetic.Division(1, 0)); // 1/0 = invalid
        }

        [TestMethod]
        public void TestMultiplication()
        {
            double val;
            double expected;

            val = Arithmetic.Multiplication(1, 1);
            expected = 1;
            Assert.AreEqual(expected, val);

            val = Arithmetic.Multiplication(10, 2);
            expected = 20;
            Assert.AreEqual(expected, val);

            val = Arithmetic.Multiplication(5, 0);
            expected = 0;
            Assert.AreEqual(expected, val);
        }

        [TestMethod]
        public void TestTan()
        {
            double val;
            double expected;

            val = Trigonometric.Tan(70,false); // 70 deg
            expected = 2.74747741946;
            Assert.AreEqual(expected, val, 0.00000001);

            val = Trigonometric.Tan(0,false); // 0 deg
            expected = 0;
            Assert.AreEqual(expected, val);

            val = Trigonometric.Tan(Math.PI/4.0,true); // pi/4 radians
            expected = 1;
            Assert.AreEqual(expected, val, 0.00000001);

            Assert.ThrowsException<Exception>(() => Trigonometric.Tan(450.0, false)); // 450 deg = 90 deg == invalid
            Assert.ThrowsException<Exception>(() => Trigonometric.Tan(90.0, false)); // 90 deg == invalid
        }

        [TestMethod]
        public void TestSine()
        {
            double val;
            double expected;

            val = Trigonometric.Sine(70, false); // 70 deg
            expected = 0.93969262078;
            Assert.AreEqual(expected, val, 0.00000001);

            val = Trigonometric.Sine(0, false); // 0 deg
            expected = 0;
            Assert.AreEqual(expected, val);

            val = Trigonometric.Sine(Math.PI / 2.0, true); // pi/2 radians
            expected = 1;
            Assert.AreEqual(expected, val, 0.00000001);
        }

        [TestMethod]
        public void TestCosine()
        {
            double val;
            double expected;

            val = Trigonometric.Cosine(70, false); // 70 deg
            expected = 0.34202014332;
            Assert.AreEqual(expected, val, 0.00000001);

            val = Trigonometric.Cosine(0, false); // 0 deg
            expected = 1;
            Assert.AreEqual(expected, val);

            val = Trigonometric.Cosine(Math.PI / 2.0, true); // pi/2 radians
            expected = 0;
            Assert.AreEqual(expected, val, 0.00000001);

            val = Trigonometric.Cosine(Math.PI, true); // pi radians
            expected = -1;
            Assert.AreEqual(expected, val, 0.00000001);
        }

        [TestMethod]
        public void TestSquareRoot()
        {
            double val;
            double expected;

            val = Algebraic.SquareRoot(25);
            expected = 5;
            Assert.AreEqual(expected, val, 0.00000001);

            val = Algebraic.SquareRoot(0);
            expected = 0;
            Assert.AreEqual(expected, val);

            val = Algebraic.SquareRoot(2);
            expected = 1.41421356237;
            Assert.AreEqual(expected, val, 0.00000001);

            Assert.ThrowsException<Exception>(() => Algebraic.SquareRoot(-1)); // Imaginary number
        }

        [TestMethod]
        public void TestCubeRoot()
        {
            double val;
            double expected;

            val = Algebraic.CubeRoot(27);
            expected = 3;
            Assert.AreEqual(expected, val, 0.00000001);

            val = Algebraic.CubeRoot(0);
            expected = 0;
            Assert.AreEqual(expected, val, 0.00000001);

            val = Algebraic.CubeRoot(2.0);
            expected = 1.25992104989;
            Assert.AreEqual(expected, val, 0.00000001);

            Assert.ThrowsException<Exception>(() => Algebraic.CubeRoot(-1)); // Imaginary number
        }

        [TestMethod]
        public void TestInverse()
        {
            double val;
            double expected;

            val = Algebraic.Inverse(1);
            expected = 1;
            Assert.AreEqual(expected, val, 0.00000001);

            val = Algebraic.Inverse(5);
            expected = 0.2;
            Assert.AreEqual(expected, val, 0.00000001);

            Assert.ThrowsException<Exception>(() => Algebraic.Inverse(0)); // invalid

            val = Algebraic.Inverse(-1);
            expected = -1;
            Assert.AreEqual(expected, val);
        }
    }
}
