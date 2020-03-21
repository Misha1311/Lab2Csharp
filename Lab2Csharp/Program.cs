using System;

namespace Lab2Csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 2;

            for (int i = 0; i < n; i++)
            {
                triangle test = new triangle();
                test.Print();
                test.Lenght();
                test.Angle();
                test.Perimetr();
                test.Square();


                Console.WriteLine("----------------------------------");
            }
        }
    }
}
