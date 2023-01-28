﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace C_ArraysCollection
{
    class Program
    {
        static void Main(string[] args)
        {
            var intList = new List<int>() { 1, 4, 2, 7, 5, 9, 12 }; // обобщение
            intList.Add(7);

            int[] intArray = { 1, 2, 3 };
            intList.AddRange(intArray);

            if (intList.Remove(1)) //first occurence
            {
                //do

            }
            else { }
            intList.RemoveAt(0);

            intList.Reverse();

            bool contains = intList.Contains(3);

            int min = intList.Min();
            int max = intList.Max();

            Console.WriteLine($"Min={min}. Max={max}");

            int indexOf = intList.IndexOf(2);
            int lastIndexOf = intList.LastIndexOf(2);

            Console.WriteLine($"IndexOf2={indexOf}. LastIndexOf2={lastIndexOf}");

            for (int i = 0; i < intList.Count; i++)
            {
                Console.Write($"{intList[i]} ");
            }
            Console.WriteLine();

            foreach (int item in intList)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine();
        }
        static void ArrayType()
        {
            int[] a1;
            a1 = new int[10];

            int[] a2 = new int[5];

            int[] a3 = new int[5] { 1, 3, -2, 5, 10 };

            int[] a4 = { 1, 2, 3, 4, 5 };

            Array myArray = new int[5];

            Array myArray2 = Array.CreateInstance(typeof(int), 5);

            myArray2.SetValue(12, 0); // значениеи индекс
            Console.WriteLine(myArray2.GetValue(0));
            Console.WriteLine();

            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9};
            int index = Array.BinarySearch(numbers, 7); // бинарный поиск работает только на упорядоченном массиве
            Console.WriteLine(index);

            int[] copy = new int[10];
            Array.Copy(numbers, copy, numbers.Length); // что копируем, куда копируем, сколько элементов копируем

            int[] anotherCopy = new int[10];
            copy.CopyTo(anotherCopy, 0); // в который мы хотим копировать, индекс начала копирования

            Array.Reverse(copy);
            foreach (var c in copy)
            {
                Console.WriteLine(c);
            }
            Console.WriteLine();

            Array.Sort(copy);
            foreach (var c in copy)
            {
                Console.WriteLine(c);
            }
            Console.WriteLine();

            Array.Clear(copy, 0, copy.Length);
            foreach (var c in copy)
            {
                Console.WriteLine(c);
            }

        }
    }
}
