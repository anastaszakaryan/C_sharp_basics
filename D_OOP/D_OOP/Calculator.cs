using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D_OOP
{
    public class Calculator
    {
        public bool TryDivide(double divisible, double divisor, out double result)
        {
            result = 0;
            if (divisor == 0)
            {
                return false;
            }
            result = divisible / divisor;
            return true;
        }

        public double Average(int[] numbers)
        {
            int sum = 0;
            foreach (int n in numbers)
            {
                sum += n;
            }
            return (double)sum / numbers.Length;
        }

        // аргумент params должен быть последним в списке аругментов
        public double AverageWithParams(params int[] numbers)
        {
            int sum = 0;
            foreach (int n in numbers)
            {
                sum += n;
            }
            return (double)sum / numbers.Length;
        }

        public double CalcTriangleSquare(double ab, double bc, double ac)
        {
            double P = (ab + bc + ac) / 2;
            return Math.Sqrt(P * (P - ab) * (P - bc) * (P - ac));

        }

        public double CalcTriangleSquare(double b, double h)
        {
            return 0.5 * b * h;
        }

        public double CalcTriangleSquare(double ab, double ac, int alpha)
        {
            double rads = alpha * Math.PI / 180;
            return 0.5 * ab * ac * Math.Sin(rads);
        }

        // такая перегрузка в C# запрещена
        /*
        public float CalcTriangleSquare(double b, double h)
        {
            return (float)0.5 * b * h;
        }
        */
    }
}
