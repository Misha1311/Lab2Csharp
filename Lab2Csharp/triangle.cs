using System;
using System.Collections.Generic;
using System.Text;

namespace Lab2Csharp
{
    public struct point2D
    {
        public int x;
        public int y;
    }

    class triangle
    {
        int n = 3;
        point2D[] points;
        double[] lenght;
        double angle1 = 0;
        double angle2 = 0;
        double angle3 = 0;
        public double perimetr = 0;
        public double square = 0;
        Random rand = new Random();
        public triangle()
        {

            points = new point2D[3];
            for (int i = 0; i < points.Length; i++)
            {
                points[i].x = rand.Next(0, 10);
                points[i].y = rand.Next(0, 10);
            }
        }

        public void IsExists()
        {
            for (int i = 0; i < n; i++)
            {
                if (lenght[i] + lenght[(i + 1) % n] <= lenght[(i + 2) % n])
                {
                    Console.WriteLine("\t\tThe triangle does not exist");
                    break;
                }
            }
        }

            public void Print()
        {
            for (int i = 0; i < points.Length; i++)
            {
                Console.WriteLine($"X = {points[i].x} B  = {points[i].y}");
            }
        }

        public void Lenght()
        {
            lenght = new double[n];

            for (int i = 0; i < n; i++)
            {
                lenght[i] = Math.Sqrt(Math.Pow(points[(i + 1) % n].x - points[i].x, 2) + Math.Pow(points[(i + 1) % n].y - points[i].y, 2));
                Console.WriteLine($"Lenght {i + 1} : {lenght[i]}");
            }

        }
        public void Angle()
        {
            angle1 = Math.Cos((Math.Pow(lenght[0], 2) + Math.Pow(lenght[2], 2) - Math.Pow(lenght[1], 2)) / (2 * lenght[0] * lenght[2]));
            angle2 = Math.Cos((Math.Pow(lenght[0], 2) + Math.Pow(lenght[1], 2) - Math.Pow(lenght[2], 2)) / (2 * lenght[0] * lenght[1]));
            angle3 = Math.Cos((Math.Pow(lenght[1], 2) + Math.Pow(lenght[2], 2) - Math.Pow(lenght[0], 2)) / (2 * lenght[2] * lenght[1]));

            Console.WriteLine($"Angle 1 = {angle1 * 180 / Math.PI}");
            Console.WriteLine($"Angle 2 = {angle2 * 180 / Math.PI}");
            Console.WriteLine($"Angle 3 = {angle3 * 180 / Math.PI}");
        }

        public void Perimetr()
        {
            perimetr = lenght[0] + lenght[1] + lenght[2];

            Console.WriteLine("Perimetr = " + perimetr);
        }

        public void Square()
        {
            square = 0.5 * lenght[0] * lenght[1] * Math.Sin(angle1);
            Console.WriteLine($"Square = {square}");

        }
    }
}
