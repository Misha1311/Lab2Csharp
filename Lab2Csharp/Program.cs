using System;

namespace Lab2Csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 2;
            double avgsqure = 0;
            double min=0;
            triangle[] test = new triangle[n];
           

            for (int i = 0; i < n; i++)
            {
                test[i] = new triangle();
                test[i].Print();
                test[i].Lenght();
                test[i].IsExists();
                test[i].Angle();
                test[i].Perimetr();
                test[i].Square();

                min = test[0].perimetr;
                avgsqure += test[i].square;
                Console.WriteLine("----------------------------------");
            }
            avgsqure /= n;
            Console.WriteLine($"Average Square = {avgsqure}");

            for (int i = 0; i < n; i++)
            {
                if (test[i].perimetr < min)
                {
                    min = test[i].perimetr;
                }

            }
            Console.WriteLine($"Minimum of perimetr = {min}");

        }
    }
}
