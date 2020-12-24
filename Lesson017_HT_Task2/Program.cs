using System;

namespace Lesson017_HT_Task2
{
    class MainClass
    {
        public delegate int Add(int a, int b);
        public delegate int Sub(int a, int b);
        public delegate int Mul(int a, int b);
        public delegate int Div(int a, int b);

        public static void Main(string[] args)
        {
            Add add = (a,b) => a + b;
            Sub sub = (a, b) => a - b;
            Mul mul = (a, b) => a * b;
            Div div = (a, b) => a / b;
            int resOfAdd = add(2, 4);
            int resOfSub = sub(4, 2);
            int resOfMul = mul(2, 4);
            int resOfDiv = div(6, 2);
            Console.WriteLine($"Add: {resOfAdd}, Sub: {resOfSub}, Mul: {resOfMul}, Div: {resOfDiv}");
        }
    }
}
