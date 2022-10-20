using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using task_01;

namespace task_1_Test
{
    [TestClass]
    public class Calc_Test
    {
        [TestMethod]
        public void Multiplication_30and10_returned300()
        {
            //arrange
            double a = 30;
            double b = 10;
            double expected = 300;
            //act
            Calc calc = new Calc();
            calc.Put_A(a);
            double actual = calc.Multiplication(b);
            //assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Multiplication_negative10and10_negative100returned()
        {
            //arrange
            double a = -10;
            double b = 10;
            double expected = -100;
            //act
            Calc calc = new Calc();
            calc.Put_A(a);
            double actual = calc.Multiplication(b);
            //assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Division_by_zero()
        {
            //arrange
            double a = 65;
            double b = 0;
            double expected = double.PositiveInfinity;
            //act
            Calc calc = new Calc();
            calc.Put_A(a);
            double actual = calc.Division(b);
            //assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Sum_MaxValue_and_MaxValue()
        {
            //arrange
            double a = double.MaxValue;
            double b = double.MaxValue;
            double expected = double.PositiveInfinity;
            //act
            Calc calc = new Calc();
            calc.Put_A(a);
            double actual = calc.Sum(b);
            //assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Sqrt_Negative100()
        {
            //arrange
            double a = -100;
            double expected = double.NaN;
            //act
            Calc calc = new Calc();
            calc.Put_A(a);
            double actual = calc.Sqrt();
            //assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void DegreeY_Y_Equals_Negative2()
        {
            //arrange
            double a = 10;
            double b = -2;
            double expected = 0.01;
            //act
            Calc calc = new Calc();
            calc.Put_A(a);
            double actual = calc.DegreeY(b);
            //assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Factorial_9()
        {
            //arrange
            double a = 9;
            double expected = 362880;
            //act
            Calc calc = new Calc();
            calc.Put_A(a);
            double actual = calc.Factorial();
            //assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Factorial_362880()
        {
            //arrange
            double a = 362880;
            double expected = double.PositiveInfinity;
            //act
            Calc calc = new Calc();
            calc.Put_A(a);
            double actual = calc.Factorial();
            //assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void M_Sum_negative99999999_negative99999999()
        {
            //arrange
            double memory = -99999999;
            double memory2 = -99999999;
            double expected = -199999998;
            //act
            Calc calc = new Calc();
            calc.M_Sum(memory);
            calc.M_Sum(memory2);
            double actual = calc.MemoryShow();
            //assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void M_Sum_MaxValue()
        {
            //arrange
            double memory = 99999999;
            double memory2 = double.MaxValue;
            double expected = double.MaxValue;
            //act
            Calc calc = new Calc();
            calc.M_Sum(memory);
            calc.M_Sum(memory2);
            double actual = calc.MemoryShow();
            //assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void M_Division_by_Zero()
        {
            //arrange
            double memory = 1;
            double memory2 = 0;
            double expected = double.PositiveInfinity;
            //act
            Calc calc = new Calc();
            calc.M_Sum(memory);
            calc.M_Division(memory2);
            double actual = calc.MemoryShow();
            //assert
            Assert.AreEqual(expected, actual);
        }
    }
}
