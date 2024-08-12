using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4_CSharpProblems
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Point3D p1 = new Point3D(2, 4, 6);
            Point3D p2 = new Point3D(1, 3, 5);

            if (p1 == p2)
                Console.WriteLine("Equal");
            else
                Console.WriteLine("Not equal");
            Fraction f1 = new Fraction(1, 2);
            Fraction f2 = new Fraction(1, 3);

            Fraction f3 = f1 + f2;

            Console.WriteLine($"{f3.getNom()} / {f3.getDen()}");

            Console.WriteLine("===========================================");

            // Here Compiler will implicit double number to Fraction 

            Fraction f4 = 5.3 + f1;

            Console.WriteLine($"{f4.getNom()} / {f4.getDen()}");

            Console.WriteLine("===========================================");



            Fraction f5 = f1 + 5.3;

            Console.WriteLine($"{f5.getNom()} / {f5.getDen()}");

            Console.WriteLine("===========================================");

            // Here Compiler will Explicit Fraction to double number 

            double num = (double)f1;

            Console.WriteLine(num);

            Console.WriteLine("===========================================");


            int x = 2;

            int y = x++;

            Console.WriteLine(y);



        }
    }
}
