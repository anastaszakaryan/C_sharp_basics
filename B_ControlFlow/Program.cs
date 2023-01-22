using System;
using System.Linq;

namespace B_ControlFlow
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array_of_nums = new int[10];
            int newNum;
            int inputCount = 0;
            while (inputCount < 10)
            {
                string input2 = Console.ReadLine();
                newNum = int.Parse(input2);
                if (newNum == 0)
                    break;
                array_of_nums[inputCount] = newNum;
                inputCount++;
            }

            Console.WriteLine();

            int summa = 0;
            int kolichestvo = 0;
            for (int i = 0; i < array_of_nums.Length ; i++)
            {
                if (array_of_nums[i] > 0 && array_of_nums[i] % 3 == 0)
                {
                    summa = summa + array_of_nums[i];
                    kolichestvo = kolichestvo + 1;
                }
            }
            double srednee = (double)summa / kolichestvo;
            Console.WriteLine(srednee);
        }

        static void Homework_Fibonacchi()
        {
            Console.WriteLine("How many Fibonacchi numbers do you wanna see?");
            string input1 = Console.ReadLine();
            int numOfNums = int.Parse(input1);

            int[] answer = new int[numOfNums];
            answer[0] = 1;
            answer[1] = 1;

            Console.WriteLine("Your numbers are:");

            if (numOfNums == 1)
            {
                Console.WriteLine(answer[0]);
            }
            else if (numOfNums == 2)
            {
                Console.WriteLine(answer[0] + " " + answer[1]);
            }
            else
            {
                Console.Write(answer[0] + " " + answer[1]);
                int new_num;
                for (int i = 2; i < numOfNums; i++)
                {
                    new_num = answer[i - 1] + answer[i - 2];
                    answer[i] = new_num;
                    answer.Append(new_num);
                    Console.Write(" " + answer[i]);
                }
            }
        }

        static void Debug()
        {
            Console.WriteLine("Hello, tell me lengths of three sides of a triangle");

            string input1 = Console.ReadLine();
            double ab = GetDouble();
            string input2 = Console.ReadLine();
            double bc = GetDouble();
            string input3 = Console.ReadLine();
            double ac = GetDouble();

            double P = ab + bc + ac / 2; // в этой строке ошибка
            double S = Math.Sqrt(P * (P - ab) * (P - bc) * (P - ac));

            Console.WriteLine("Square of triangle equals {0:f2}", S);
        }
        static double GetDouble()
        {
            return double.Parse(Console.ReadLine());
        }
        static void SwitchCase()
        {

            int month = int.Parse(Console.ReadLine());
            string season = string.Empty;

            switch(month)
            { 
                case 1:
                case 2:
                case 12:
                    season = "Winter";
                    break;
                case 3:
                case 4:
                case 5:
                    season = "Spring";
                    break;
                case 6:
                case 7:
                case 8:
                    season = "Summer";
                    break;
                case 9:
                case 10:
                case 11:
                    season = "Summer";
                    break;
                default:
                    throw new ArgumentException("Unexpected number of month");
            }
            Console.WriteLine(season);

            Console.WriteLine();

            int weddingYears = int.Parse(Console.ReadLine());

            string name = string.Empty;

            switch (weddingYears)
            {
                case 5:
                    name = "Деревянная свадьба";
                    break;
                case 10:
                    name = "Оловянная свадьба";
                    break;
                case 15:
                    name = "Хрустальная свадьба";
                    break;
                case 20:
                    name = "Фарфоровая свадьба";
                    break;
                case 25:
                    name = "Серебрянная свадьба";
                    break;
                case 30:
                    name = "Жемчужная свадьба";
                    break;
                default:
                    name = "Не знаю такого юбилея!";
                    break;
            }
            Console.WriteLine(name);
        }

        static void BreakContinue()
        {
            Console.WriteLine();

            int[] numbers = { 0, 3, 2, 1, 5, 4, 6, 7, 8, 9 };

            foreach (int n in numbers)
            {
                if (n % 2 != 0)
                    continue;
                Console.WriteLine(n);
            }

            Console.WriteLine();

            char[] letters = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j' };

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine($"Number={numbers[i]}");

                for (int j = 0; j < letters.Length; j++)
                {
                    if (numbers[i] == j)
                        break;
                    Console.Write($"{letters[j]} ");
                }
                Console.WriteLine();
            }

            Console.WriteLine();

            int[] numbers2 = { 1, -2, 4, -7, 5, 3, 2, -1, -3, 2, 7, -1, -3, 1, 7 };

            int counter = 0;
            for (int i = 0; i < numbers.Length - 1; i++)
            {
                if (counter == 3)
                    break; // досрочно прерывает цикл

                for (int j = i + 1; j < numbers.Length; j++)
                {
                    int atI = numbers[i];
                    int atJ = numbers[j];

                    if (atI + atJ == 0)
                    {
                        Console.WriteLine($"Pair ({atI};{atJ}), indexes ({i};{j})");
                        counter++;
                        if (counter == 3)
                            break;
                    }
                }
            }
        }

        static void WhileDoWhile()
        {
            int age = 0;
            while (age < 18)
            {
                Console.WriteLine("What is your age?");
                age = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Good!");

            do
            {
                Console.WriteLine("Do\\While");
                Console.WriteLine("What is your age?");
                age = int.Parse(Console.ReadLine());
            }
            while (age < 18);

            int[] numbers = { 1, 2, 3, 4, 5 };
            int i = 0;
            while (i < numbers.Length)
            {
                Console.Write(numbers[i] + " ");
                i++; // инкремент оператора
            }
        }

        static void NestedFor()
        {
            int[] numbers = { 1, -2, 4, -7, 5, 3, 2, -1, -3, 2, 7, -1, -3, 1, 7 };

            for (int i = 0; i < numbers.Length - 1; i++)
            {
                for (int j = i + 1; j < numbers.Length; j++)
                {
                    int atI = numbers[i];
                    int atJ = numbers[j];

                    if (atI + atJ == 0)
                    {
                        Console.WriteLine($"Pair ({atI};{atJ}), indexes ({i};{j})");
                    }
                }
            }

            Console.WriteLine();

            for (int i = 0; i < numbers.Length - 2; i++)
            {
                for (int j = i + 1; j < numbers.Length - 1; j++)
                {
                    for (int k = j + 1; k < numbers.Length; k++)
                    {
                        int atI = numbers[i];
                        int atJ = numbers[j];
                        int atK = numbers[k];

                        if (atI + atJ + atK == 0)
                        {
                            Console.WriteLine($"Triplets ({atI};{atJ};{atK}), indexes ({i};{j};{k})");
                        }
                    }
                }
            }
        }

        static void ForForeach()
        { 
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            for(int i = 0; i < numbers.Length; i++)
            {
                Console.Write(numbers[i] + " ");
            }

            Console.WriteLine();

            for (int i = numbers.Length - 1; i >= 0; i--)
            {
                Console.Write(numbers[i] + " ");
            }

            Console.WriteLine();

            for (int j = 0; j < numbers.Length; j++)
            {
                if (numbers[j] % 2 == 0)
                { 
                    Console.Write(numbers[j] + " "); 
                }
            }

            Console.WriteLine();

            // for без итератора, без доступа к индексу, без возможности итерации в обратном порядке
            foreach(int val in numbers)
            {
                Console.Write(val + " "); ;
            }
        }

        static void HomeworkGetMax()
        {
            Console.WriteLine("Hi, what is your first number?");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("What is your second number?");
            int num2 = int.Parse(Console.ReadLine());

            if (num1 >= num2)
            {
                Console.WriteLine($"Number {num1} is max between your two numbers");
            }
            else
            {
                Console.WriteLine($"Number {num2} is max between your two numbers");
            }
        }

        static void IfElse()
        {
            Console.WriteLine("What is your age?");
            string input_age = Console.ReadLine();
            int age = int.Parse(input_age);

            Console.WriteLine("What is your height in m?");
            string input_height = Console.ReadLine();
            double height = double.Parse(input_height);

            Console.WriteLine("What is your weight in kg?");
            string input_weight = Console.ReadLine();
            double weight = double.Parse(input_weight);

            double BMI = weight / (height * height);
            Console.WriteLine($"Your BMI is {BMI}");

            bool isTooLow = BMI <= 18.5;
            bool isNormal = BMI > 18.5 && BMI < 25;
            bool isAboveNormal = BMI >= 25 && BMI <= 30;
            bool isTooFat = BMI > 30;

            bool isFat = isAboveNormal || isTooFat;

            if (isFat)
            {
                Console.WriteLine("You need to excersice more");
            }
            else
            { 
                Console.WriteLine("You are beautiful"); 
            }

            // if (isFat == false)
            if (!isFat)
            {
                Console.WriteLine("You are definitele not fat");
            }

            if (isTooLow)
            {
                Console.WriteLine("Not enough weight");
            }
            else if (isNormal)
            {
                Console.WriteLine("You are OK");
            }
            else if (isAboveNormal)
            {
                Console.WriteLine("Be careful");
            }
            else
            {
                Console.WriteLine("You need to lose some weight");
            }

            if (isFat || isTooFat)
            {
                Console.WriteLine("Do you need any help or support?");
            }

            // ternary operation
            string description = age > 18 ? "You can drink alcohol" : "You should get a bit older";

            Console.WriteLine(description);

            // the same in if-else construct
            if (age > 18)
            {
                description = "You can drink alcohol";
            }
            else 
            {
                description = "You should get a bit older";
            }
        }
    }
}
