using System;

namespace B_ControlFlow
{
    class Program
    {
        static void Main(string[] args)
        {
            
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
