using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D_OOP
{
    public class Calculator
    {
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
