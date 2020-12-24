using System;

namespace Lesson017_Task4
{
    public delegate int NumberGenerationDelegate();
    //public delegate int AvgDelegate(NumberGenerationDelegate[] array);
    class MainClass
    {
        public static void Main(string[] args)
        {
            Func<NumberGenerationDelegate[], double> method = (NumberGenerationDelegate[] array) =>
           {
               var sum = 0;
               foreach (var act in array)
               {
                   sum += act();
               }
               return sum / (double)array.Length;
           };
            var arr = new NumberGenerationDelegate[]
           {
                GenerateNumber,
                GenerateNumber,
                GenerateNumber,
                GenerateNumber,
                GenerateNumber
           };
            var arg = method(arr);
            Console.WriteLine($"{arg}");
           
        }

        static int GenerateNumber()
        {
            return new Random().Next(1, 100);
        }
    }
}
