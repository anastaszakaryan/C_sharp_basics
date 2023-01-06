using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace C_sharp_project_zero
{
    class Program2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, what is your last name?");
            string FirstName = Console.ReadLine();
            Console.WriteLine("What is your first name?");
            string LastName = Console.ReadLine();
            Console.WriteLine("What is your age?");
            string input_age = Console.ReadLine();
            int age = int.Parse(input_age);
            Console.WriteLine("What is your height?");
            string input_height = Console.ReadLine();
            double height = double.Parse(input_height);
            Console.WriteLine("What is your weight?");
            string input_weight = Console.ReadLine();
            double weight = double.Parse(input_weight);

            double BMI = weight / (height * height);

            Console.WriteLine();

            Console.WriteLine("Your profile:\n" +
                $"Full Name: {LastName} {FirstName}\n" +
                $"Age: {age}\n" +
                $"Weight: {weight}\n" +
                $"Height: {height}\n" +
                "Body Mass Index: {0:f2}",BMI);
        }

        static void Homework02()
        {
            Console.WriteLine("Hello, tell me lengths of three sides of a triangle");

            string input1 = Console.ReadLine();
            double ab = double.Parse(input1);
            string input2 = Console.ReadLine();
            double bc = double.Parse(input2);
            string input3 = Console.ReadLine();
            double ac = double.Parse(input3);

            double P = (ab + bc + ac) / 2;
            double S = Math.Sqrt(P * (P - ab) * (P - bc) * (P - ac));

            Console.WriteLine("Square of triangle equals {0:f2}", S);
        }

        static void Homework01()
        {
            // Solution 1
            Console.WriteLine("Hi, what is your name?");
            string name = Console.ReadLine();
            Console.WriteLine($"Hello, {name}.");

            // Solution 2
            Console.WriteLine("Tell me two numbers, please");
            string input1 = Console.ReadLine();
            int num1 = int.Parse(input1);
            string input2 = Console.ReadLine();
            int num2 = int.Parse(input2);
            Console.WriteLine($"Your numbers are {num1} and {num2}");

            int temp = num1;
            num1 = num2;
            num2 = temp;
            Console.WriteLine($"Your numbers vice versa are {num1} and {num2}");

            // Solution3
            Console.WriteLine("Tell me positive integer number, please");
            string input3 = Console.ReadLine();
            int str_len = input3.Length;
            Console.WriteLine($"Your number has {str_len} digit");
        }

        static void DateTimeIntro()
        {
            // NB!
            // всю арифметику на датах нужно проводить с помощью специальных методов DateTime
            // помните про часовые пояса

            DateTime now = DateTime.Now;
            Console.WriteLine(now.ToString());

            Console.WriteLine($"It's {now.Date}, {now.Hour}: {now.Minute}");

            DateTime dt = new DateTime(2016, 2, 28); // по умолчанию полночь
            Console.WriteLine(dt);

            // DateTime не изменяет экземпляр, а создаёт новый
            DateTime newDt = dt.AddDays(1); // високосный год
            Console.WriteLine(newDt);

            newDt = newDt.AddDays(1); // переход на следующий месяц
            Console.WriteLine(newDt);

            TimeSpan ts = now - dt; // длительность между экземплярами
            // ts = now.Subtract(dt);
            Console.WriteLine(ts.Days);
        }

        static void IntroToArrays()
        {
            int[] a1; // объявление массива
            a1 = new int[10]; // ~ 40 байт под массив, 10 чисел с индексами от 0 до 9

            int[] a2 = new int[5];

            int[] a3 = new int[5] { 1, 3, - 2, 5, 10 };

            int[] a4 = { 1, 2, 3, 4, 5 };

            Console.WriteLine(a4[0]);

            int number = a4[4];
            Console.WriteLine(number);

            a4[4] = 6;
            Console.WriteLine(a4[4]);

            Console.WriteLine(a4.Length); // длина массива
            Console.WriteLine(a4[a4.Length - 1]); // обращение к последнему элементу массива

            // со string можно работать как с массивом
            // модифицировать строку НЕЛЬЗЯ
            // impossible
            // s1[0] = 'z';
            string s1 = "abcdefgh";
            char first = s1[0];
            char last = s1[s1.Length - 1];

            Console.WriteLine($"First: {first}, last: {last}");
        }

        static void MathDemo() 
        {
            // math - статический класс,
            // у него есть много статических методов,
            // с их помощью можно производить математические вычисления

            Console.WriteLine(Math.Pow(2, 3));
            Console.WriteLine(Math.Sqrt(9));
            Console.WriteLine(Math.Sqrt(8));

            Console.WriteLine(Math.Round(1.7));
            Console.WriteLine(Math.Round(1.4));
            Console.WriteLine();

            Console.WriteLine(Math.Round(2.5)); // по умолчанию ToEven
            Console.WriteLine();

            Console.WriteLine(Math.Round(2.5, MidpointRounding.AwayFromZero)); // число округляется к ближайшему числу, удаленному от нуля
            Console.WriteLine(Math.Round(2.5, MidpointRounding.ToEven)); // число округляется к ближайшему четному числу
        }

        static void Comments()
        {
            // a single-line comment

            /*
             * Multi-line comment
             * We can write here
             * 
             */

            // descrive hows and whys! not whats!

            int a = 1;

            // increment a by 1 - bad comment, this code os self-evident

            // we need to tweak the index to match the expected outcome
            a++;
        }

        static void CastingAndParsing()
        {
            byte b = 3; // 8 бит 0000 0011
            int i = b; // 4 байта, 32 бита 0000 0000 0000 0000 0000 0000 0000 0011
            long l = i; // 0000 0000 0000 0000 0000 0000 0000 0000 0000 0000 0000 0000 0000 0000 0000 0011
            Console.WriteLine(l);

            float f = i;
            Console.WriteLine(f);

            // b = i; 
            // нельзя впихнуть невпихиваемое

            b = (byte)i; // явное приведение
            Console.WriteLine(b);

            // i = f;
            i = (int)f;
            Console.WriteLine(i);

            f = 3.1f;
            i = (int)f; // потеря точности
            Console.WriteLine(i);

            // строку привести к int нельзя
            string str = "1";
            // i = (int)str;
            i = int.Parse(str);
            Console.WriteLine($"Parsed i = {i}");

            int x = 5;
            int result = x / 2;
            Console.WriteLine(result);

            double result2 = (double)x / 2; // приведение типов более приоритетная операция, чем деление

        }

        static void ConsoleBasics()
        {
            // Console.WriteLine("Hi, please tell me your name");
            // string name = Console.ReadLine();
            // string sentence = $"Your name is {name}";
            // Console.WriteLine(sentence);

            Console.WriteLine("Hi, please tell me your age");
            string input = Console.ReadLine();
            int age = int.Parse(input);

            string sentence = $"Your age is {age}";
            Console.WriteLine(sentence);

            Console.Clear();
            Console.BackgroundColor = ConsoleColor.Cyan;
            Console.ForegroundColor = ConsoleColor.DarkMagenta;

            Console.Write("New Style ");
            Console.Write("New Style\n");
            ;        }

        static void ComparingStrings() 
        {
            // string str1 = "abcde";
            // string str2 = "abcde";

            // bool areEqual = str1 == str2;
            // Console.WriteLine(areEqual);

            // areEqual = string.Equals(str1, str2, StringComparison.Ordinal);
            // Console.WriteLine(areEqual);

            string s1 = "Strasse";
            string s2 = "Straße";
            bool areEqual = string.Equals(s1, s2, StringComparison.Ordinal);
            Console.WriteLine(areEqual);
            areEqual = string.Equals(s1, s2, StringComparison.InvariantCulture);
            Console.WriteLine(areEqual);
            areEqual = string.Equals(s1, s2, StringComparison.CurrentCulture);
            Console.WriteLine(areEqual);

        } 

        static void StringFormat() 
        {
            string name = "Anastasiia";
            int age = 28;
            string str1 = string.Format("Me name is {0} and I'm {1}", name, age);
            // string str2 = "My name is " + name + " and I'm " + age;
            // string str2 = $"My name is " + name + " and I'm " + age;
            string str2 = $"My name is {name} and I'm {age}";

            string str3 = "My name is \n John"; // \r\n или \n
            string str4 = "I'm \t 30";

            str3 = $"My name is {Environment.NewLine}John";

            string str5 = "I'm John and I'm a \"good\" programmer";
            // экранирование кавычек

            Console.WriteLine(str1);
            Console.WriteLine(str3);

            Console.WriteLine(str5);

            // string str6 = "C:\\tmp\\test_file.txt"; 
            string str6 = @"C:\tmp\test_file.txt";
            // экранирование слэша
            Console.WriteLine(str6);

            int answer = 42;
            string result = string.Format("{0:d}", answer);
            string result2 = string.Format("{0:d4}", answer);

            Console.WriteLine(result);
            Console.WriteLine(result2);

            double answer2 = 42.3;
            result = string.Format("{0:f}", answer2);
            result2 = string.Format("{0:f4}", answer2); // к числу добавятся ноли

            Console.WriteLine(result);
            Console.WriteLine(result2);

            double answer3 = 42.08;
            string result3 = string.Format("{0:f1}",answer3); // число округлится
            Console.WriteLine(result3);

            Console.OutputEncoding = Encoding.UTF8;

            double money = 12.8;
            result = string.Format("{0:C}", money);
            result2 = string.Format("{0:C3}", money);

            result = $"{money:C2}";

            Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");
            
            Console.WriteLine(result);
            Console.WriteLine(money.ToString("C2"));
            Console.WriteLine(result2);
        }

        static void StringBuilderDemo() 
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("My ");
            sb.Append("name ");
            sb.Append("is ");
            sb.Append("Jim");
            sb.AppendLine("!");
            sb.AppendLine("Hello!");

            string str = sb.ToString();
            Console.WriteLine(str);
        }

        static void StringModification() 
        {
            string nameConcat = string.Concat("My ", "name ", "is ", "Anastasiia");
            Console.WriteLine(nameConcat);

            nameConcat = "My " + "name " + "is " + "John";
            Console.WriteLine(nameConcat);

            nameConcat = string.Join(" ", "My", "name", "is", "Dmitrii");
            Console.WriteLine(nameConcat);

            // nameConcat =
            nameConcat = nameConcat.Insert(0, "By the way, ");
            Console.WriteLine(nameConcat);
            // методы инстанции не изменяют саму инстанцию

            nameConcat = nameConcat.Remove(0, 1);
            // индекс, с которого удаляем, и сколько удаляем
            Console.WriteLine(nameConcat);

            string replaced = nameConcat.Replace('i', 'x');
            Console.WriteLine(replaced);

            string data = "12;28;34;25;64";
            string[] splitData = data.Split(';');
            string first = splitData[0];
            Console.WriteLine(first);

            char[] chars = nameConcat.ToCharArray();
            Console.WriteLine(chars[0]);
            Console.WriteLine(nameConcat[0]);

            string lower = nameConcat.ToLower();
            Console.WriteLine(lower);

            string upper = nameConcat.ToUpper();
            Console.WriteLine(upper);

            string john = " My name is John ";
            Console.WriteLine(john.Trim());
        }

        static void MaiStringEmptiness() 
        {
            string str = string.Empty; // same as ""

            string empty = "";
            string whiteSpaced = " ";
            string notEmpty = " b";
            string nullString = null;

            Console.WriteLine("IsNullOrEmpty");
            bool isNullOrEmpty = string.IsNullOrEmpty(nullString);
            Console.WriteLine(isNullOrEmpty);

            isNullOrEmpty = string.IsNullOrEmpty(whiteSpaced);
            Console.WriteLine(isNullOrEmpty);

            isNullOrEmpty = string.IsNullOrEmpty(notEmpty);
            Console.WriteLine(isNullOrEmpty);

            isNullOrEmpty = string.IsNullOrEmpty(empty);
            Console.WriteLine(isNullOrEmpty);

            Console.WriteLine();
            Console.WriteLine("IsNullOrWhiteSpace");

            bool IsNullOrWhiteSpace = string.IsNullOrWhiteSpace(nullString);
            Console.WriteLine(IsNullOrWhiteSpace);

            IsNullOrWhiteSpace = string.IsNullOrWhiteSpace(whiteSpaced);
            Console.WriteLine(IsNullOrWhiteSpace);

            IsNullOrWhiteSpace = string.IsNullOrWhiteSpace(notEmpty);
            Console.WriteLine(IsNullOrWhiteSpace);

            IsNullOrWhiteSpace = string.IsNullOrWhiteSpace(empty);
            Console.WriteLine(IsNullOrWhiteSpace);
        }

        static void QueryingStrings() 
        {
            string name = "abracadabra";
            bool containsA = name.Contains('a');
            bool containsE = name.Contains('e');

            Console.WriteLine(containsA);
            Console.WriteLine(containsE);

            bool endsWithAbra = name.EndsWith("abra");
            Console.WriteLine(endsWithAbra);

            bool startsWithAbra = name.StartsWith("abra");
            Console.WriteLine(startsWithAbra);

            int indexOfA = name.IndexOf('a', 1); 
            // 1 индекс, с которого начинать поиск
            Console.WriteLine(indexOfA);

            int lastIndexOfR = name.LastIndexOf('r');
            Console.WriteLine(lastIndexOfR);

            Console.WriteLine(name.Length);

            string substrFrom5 = name.Substring(5);
            string subsFromTo = name.Substring(0, 3);

            Console.WriteLine(subsFromTo);
            Console.WriteLine(subsFromTo);


        }

        static void StaticAndInstanceMembers() 
        {
            // string name = "abracadabra";
            string name = new string("abracadabra"); // конструктор
            // экземпляр строки, abracadabra - литерал
            // класс определяет методы, которые могут быть использованы
            // методы класса - не статические, а экземплярные
            bool containsA = name.Contains('a');
            bool containsE = name.Contains('e');

            Console.WriteLine(containsA);
            Console.WriteLine(containsE);

            // статический тип не имеет состояния,
            // мы не можем его создать
            // вызываем статический метод без создания экземпляра

            string abc = string.Concat("a", "b", "c");
            // метод concat статический
            // метод вызывается на самом типе string
            // метод возвращает экземпляр типа string

            Console.WriteLine(int.MinValue);
            // MinValue также статический метод, вызывается на типе

            int x = 1;
            string xStr = x.ToString();
            Console.WriteLine(xStr);
            Console.WriteLine(x);
        }

        static void ComparisonOperators() 
        {
            int x = 1;
            int y = 2;

            bool areEqual = x == y;
            Console.WriteLine(areEqual);

            bool result = x > y;
            Console.WriteLine(result);

            result = x >= y;
            Console.WriteLine(result);

            result = x < y;
            Console.WriteLine(result);

            result = x <= y;
            Console.WriteLine(result);

            result = x != y;
            Console.WriteLine(result);
        }

        static void MathOperations() 
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

            a = (2 + 2) * 2;
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
