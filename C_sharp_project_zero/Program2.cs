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
            int x = 1;
            int y = 2;

            int z = x + y;
            int k = x - y;
            int a = z + k - y;

            Console.WriteLine(z);
            Console.WriteLine(k);
            Console.WriteLine(a);

            Console.WriteLine();

            int b = z * 2;
            int c = k / 2; // int срезает всё, что после запятой в дроби

            Console.WriteLine(b);
            Console.WriteLine(c);

            Console.WriteLine();

            a = 4 % 2;
            b = 5 % 2;
            // например, проверки на чётность

            Console.WriteLine(a);
            Console.WriteLine(b);

            Console.WriteLine();

            a = 3;
            a = a * a;
            // a = a * a * a;
            Console.WriteLine(a);

            Console.WriteLine();

            a = 2 + 2 * 2;
            Console.WriteLine(a);

            Console.WriteLine();

            a *= 2;
            // a = a * 2;
            Console.WriteLine(a);
            a /= 2;
            // a = a / 2;
            Console.WriteLine(a);
        }

        static void IncrementDecrementDemo()
        {
            int x = 1;
            x = x + 1;

            Console.WriteLine(x);

            x++; // постфикс
            Console.WriteLine(x);

            ++x; // инфикс
            Console.WriteLine(x);

            // инкремент на 1

            x = x - 1;
            x--;
            --x;
            Console.WriteLine(x);
            // декремент на 1

            Console.WriteLine("Learn abiut increments");
            Console.WriteLine($"Last x state is {x}");

            int j = x++; // присвоение приоритетнее постфиксного инкремента
            Console.WriteLine(j);
            Console.WriteLine(x);

            j = ++x; // префиксный инкремент приоритетнее присвоения
            Console.WriteLine(j);
            Console.WriteLine(x);

            x += 2;
            // x = x + 2;
            Console.WriteLine(x);

            j -= 2;
            // j = j - 2;
            Console.WriteLine(j);
        }

        static void Overflow()
        {
            // checked
            // {
            uint x = uint.MaxValue;

            Console.WriteLine(x);

            x = x + 1; // overflow - переполнение,
                       // когда мы превышаем максимальное значение,
                       // которое можт содержать данный тип,
                       // оно становится минимальным

            Console.WriteLine(x);

            x = x - 1;

            Console.WriteLine(x);
            //}
        }

        static void VariablesScope()
        {
            var a = 1;
            {
                var b = 2;
                {
                    var c = 3;

                    Console.WriteLine(a);
                    Console.WriteLine(b);
                    Console.WriteLine(c);
                    // внешние области видимости распространяются на внутренние,
                    // а внутренние на внешние не распросраняются
                }
                Console.WriteLine(a);
                Console.WriteLine(b);
                // Console.WriteLine(c); переменной нет в этой области видимости
            }
        }

        static void Literals()
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
