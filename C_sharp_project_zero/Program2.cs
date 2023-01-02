using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_sharp_project_zero
{
    class Program2
    {
        static void Main(string[] args)
        {
            // Variables(); 
            // вызов функции Variables

            int x = 0b11; // 3
            int y = 0b1001; // 9
            int k = 0b10001001;
            int m = 0b1000_1001;
            // литерал можно передавать в переменные в бинарном виде

            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(k);
            Console.WriteLine(m);

            Console.WriteLine();

            x = 0x1;
            y = 0xFF0D;
            k = 0x1FAB30EF;
            m = 0x1FAB_30EF;
            // шестнадцатиричные литералы

            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(k);
            Console.WriteLine(m);

            Console.WriteLine();

            Console.WriteLine(4.5e2);
            Console.WriteLine(3.1E-1);

            Console.WriteLine();

            Console.WriteLine('\x78');
            Console.WriteLine('\x5A');

            Console.WriteLine('\u0420');
            Console.WriteLine('\u0421');
        }

        static void Variables()
        {
            int x = -1;

            int y;
            y = 2;

            // Int32 x1 = -1;
            // экивалентно int x = -1;

            // uint  = -1;
            // некорректное значение для типа

            // float f = 1.1;
            // double конвертировать во float по умолчанию нельзя
            // float занимает 4 байт, double 8
            float f = 1.1f;

            //по умолчанию дробные значения имеют тип double
            double d = 2.3;

            int x2 = 0;
            int x3 = new int(); // оператор new нужен для создания экземпляров типов
                                // инстанциировть тип

            var a = 1; // int - компилятор самостоятельно выводит тип данных по умолчанию
            // литерал - значение, которое напрямую было записано в редакторе кода

            var b = 1.2; // double - по умолчанию, но злоупотреблять var не стоит

            // Dictionary<int, string> dict = new Dictionary<int, string>();
            var dict = new Dictionary<int, string>();
            // var делает более читаемым код, когда название тип длинное
            // когда в правой части и так указан тип

            // var v;
            // нельзя объявить, но не декларировать переменную

            decimal money = 3.0m; // объявление перемнной типа decimal
                                  // больше наков после запятой, чем у double

            char character = 'A';
            string name = "John";

            bool canDrive = false;
            bool canDraw = true;

            object obj = 1;
            object obj2 = "obj2";
            // так можно делать, но не значит, что нужно

            Console.WriteLine(1);
            Console.WriteLine(a);
            Console.WriteLine(name);
        }
    }
}
