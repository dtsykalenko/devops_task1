using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_01
{
    internal interface InterfaceCalc
    {
        void Put_A(double a); //зберегти а
        void Clear_A();
        double Multiplication(double b);
        double Division(double b);
        double Sum(double b);
        double Subtraction(double b); //віднімання
        double SqrtX(double b);
        double DegreeY(double b);
        double Sqrt();
        double Square();
        double Factorial();
        double MemoryShow(); //показати вміст регістру пам'яті
        void Memory_Clear(); //Стерти вміст регістру пам'яті
                             //* / + - до регістру пам'яті
        void M_Multiplication(double b);
        void M_Division(double b);
        void M_Sum(double b);
        void M_Subtraction(double b); //віднімання
    }
}
