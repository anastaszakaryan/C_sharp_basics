using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace C_sharp_course
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int x = -1;

            int y;
            y = 2;

            // Int32 x1 = -1;
            // ����������� int x = -1;

            // uint  = -1;
            // ������������ �������� ��� ����

            // float f = 1.1;
            // double �������������� �� float �� ��������� ������
            // float �������� 4 ����, double 8
            float f = 1.1f;

            //�� ��������� ������� �������� ����� ��� double
            double d = 2.3;

            int x2 = 0;
            int x3 = new int(); // �������� new ����� ��� �������� ����������� �����
                                // �������������� ���

            var a = 1; // int - ���������� �������������� ������� ��� ������ �� ���������
            // ������� - ��������, ������� �������� ���� �������� � ��������� ����

            var b = 1.2; // double - �� ���������, �� �������������� var �� �����

            // Dictionary<int, string> dict = new Dictionary<int, string>();
            var dict = new Dictionary<int, string>();
            // var ������ ����� �������� ���, ����� �������� ��� �������
            // ����� � ������ ����� � ��� ������ ���

            // var v;
            // ������ ��������, �� �� ������������� ����������

            decimal money = 3.0m; // ���������� ��������� ���� decimal
                // ������ ����� ����� �������, ��� � double

            char character = 'A';
            string name = "John";

            bool canDrive = false;
            bool canDraw = true;

            object obj = 1;
            object obj2 = "obj2";
            // ��� ����� ������, �� �� ������, ��� �����

            Console.WriteLine(1);
            Console.WriteLine(a);
            Console.WriteLine(name);

        }
    }
}
