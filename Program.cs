using System;

namespace Triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter coordinate x of dot A: ");
            double Ax = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter coordinate y of dot A: ");
            double Ay = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter coordinate x of dot B: ");
            double Bx = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter coordinate y of dot B: ");
            double By = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter coordinate x of dot C: ");
            double Cx = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter coordinate y of dot C: ");
            double Cy = double.Parse(Console.ReadLine());

            double AB = Math.Sqrt(Math.Pow((Bx - Ax), 2) + Math.Pow((By - Ay), 2));
            double AC = Math.Sqrt(Math.Pow((Cx - Ax), 2) + Math.Pow((Cy - Ay), 2));
            double BC = Math.Sqrt(Math.Pow((Cx - Bx), 2) + Math.Pow((Cy - By), 2));
            Console.WriteLine("Length of AB is: " + AB);
            Console.WriteLine("Length of BC is: " + BC);
            Console.WriteLine("Length of AC is: " + AC);
            Console.WriteLine();

            if (AB == AC && AB == BC && AC == BC)
                Console.WriteLine("Triangle IS 'Equilateral'");
            else
                Console.WriteLine("Triangle IS NOT 'Equilateral'");
            
            if (AB == AC)
                    Console.WriteLine("Triangle IS Isosceles");
            else if (AB == BC)
                    Console.WriteLine("Triangle IS Isosceles");
            else if (AB == BC)
                    Console.WriteLine("Triangle IS Isosceles");
            else
                    Console.WriteLine("Triangle IS NOT Isosceles");

            double lig = Math.Pow(BC, 2) - (Math.Pow(AB, 2) + Math.Pow(AC, 2));
            if (lig <= 0.01)
                if (-0.01 <= lig)
                Console.WriteLine("Triangle IS 'Light'");
            else
                Console.WriteLine("Triangle IS NOT 'Light'");

            double P = (AB + AC + BC);
            Console.WriteLine();
            Console.WriteLine($"Perimeter: '{P}'");

            Console.WriteLine();
            Console.WriteLine("Parity numbers in range from 0 to triangle perimeter:");
            for (int i = 0; i < P; i++)
            {
                if (i % 2 == 0)
                    Console.WriteLine(i);
            }               
        }
    }
}
