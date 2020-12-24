using System;

namespace Lesson017_HT
{
    public delegate int MyDelegate(int a, int b, int c);
    class MainClass
    {
        public static void Main(string[] args)
        {
            MyDelegate myDelegate = delegate(int a, int b, int c) {

                return (a + b + c) / 3;

                };
            int res = myDelegate(3, 2, 4);
            Console.WriteLine($"{res}");
        }
    }
}
