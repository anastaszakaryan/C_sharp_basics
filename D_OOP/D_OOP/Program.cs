using System;

namespace D_OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator calc = new Calculator();
            double avg = calc.Average(new int[] { 1, 2, 3, 4});
            Console.WriteLine(avg);

            avg = calc.AverageWithParams( 1, 2, 3, 4 );
            Console.WriteLine(avg);
        }

        static void RomanNumeral()
        {
            Console.WriteLine(RomanNumeral.Parse("XIV"));
            Console.ReadLine();
        }
        static void Calc()
        { 
            Calculator calc = new Calculator();
            double square1 = calc.CalcTriangleSquare(10, 20);
            double square2 = calc.CalcTriangleSquare(25, 20, 30);
            double square3 = calc.CalcTriangleSquare(10, 20, 50);

            Console.WriteLine($"Square1={square1}. Square2={square2}. Square3={square3}.");
        } 
        static void Character()
        {
           Character c = new Character();
            // c.Health = -20;
            c.Hit(120);

            Console.WriteLine(c.Health);
        }
    }
}
