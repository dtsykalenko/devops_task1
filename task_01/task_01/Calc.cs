using System;

namespace task_01
{
    public class Calc : InterfaceCalc
    {
        private double a = 0;
        private double memory = 0;

        public void Put_A(double a)
        {
            this.a = a;
        }
        public void Clear_A()
        {
            a = 0;
        }
        public double Multiplication(double b)
        {
            return a * b;
        }
        public double Division(double b)
        {
            return a / b;
        }
        public double Sum(double b)
        {
            return a + b;
        }
        public double Subtraction(double b) //віднімання
        {
            return a - b;
        }
        public double SqrtX(double b)
        {
            return Math.Pow(a, 1 / b);
        }
        public double DegreeY(double b)
        {
            return Math.Pow(a, b);
        }
        public double Sqrt()
        {
            return Math.Sqrt(a);
        }
        public double Square()
        {
            return Math.Pow(a, 2.0);
        }
        public double Factorial()
        {
            double f = 1;
            for (int i = 1; i <= a; i++)
                f *= (double)i;
            return f;
        }
        //показати вміст регістру мам'яті
        public double MemoryShow()
        {
            return memory;
        }
        //Стерти вміст регістру мам'яті
        public void Memory_Clear()
        {
            memory = 0.0;
        }
        //* / + - до регістру пам'яті
        public void M_Multiplication(double b)
        {
            memory *= b;
        }
        public void M_Division(double b)
        {
            memory /= b;
        }
        public void M_Sum(double b)
        {
            memory += b;
        }
        public void M_Subtraction(double b)
        {
            memory -= b;
        }
    }
}
