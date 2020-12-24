using System;

namespace Lesson017_HT_Task3
{
    class MainClass
    {
        public delegate int MyDelegate(MyDelegate[] arr);

        public static int Random(object[] arr)
        {
            int[] arr2 = new int[3];
            arr2[0] = (int)3;
            arr2[1] = (int)4;
            arr2[2] = (int)5;
            return arr2[1];
        }
        public static int Mid(object[] arr)
        {
            int a = (int)arr[0];
            int b = (int)arr[1];
            int c = (int)arr[2];
            return (a + b + c) / 3;
        }

        public static void Main(string[] args)
        {
            MyDelegate[] delegates = new MyDelegate[2];
            Object[] arr = new Object[3];
            //Вказує на метод Random
            delegates[0] = MainClass.Random;
            delegates[1] = MainClass.Mid;

            MyDelegate myDelegate = delegate (MyDelegate[] arr)
            {
                return delegates[0];
            };
        }
    }
}

