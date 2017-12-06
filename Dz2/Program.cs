using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dz2
{
    class Program
    {
        static void Main(string[] args)
        {
            Task1();
            Task2();
            Task3();
            Task4();
            Task5();
            Task6();
            Task7();
            Task8();
            Task9();
            Task10();
            
        }

        private static void Task10()
        {
            Console.WriteLine("a)");
            int initialValue = 20;
            int finalValue = 35;
           for (int i= initialValue; i<= finalValue; i++)
            {
                Console.WriteLine(i + "\n");
            }
            Console.WriteLine("b)");
            Console.WriteLine("Введите значение b>10:");

           int b = int.Parse(Console.ReadLine());
            int value = 10;
            for (int i = value; i <= b; i++)
            {
                Console.WriteLine(i + "^2=" + i*i + "\n");
            }
            Console.WriteLine("c)");
            Console.WriteLine("Введите значение a<50:");
            int a = int.Parse(Console.ReadLine());
            int lastValue = 50;

            for (int i = a; i <= lastValue; i++)
            {
                Console.WriteLine(i + "^3=" + Math.Pow(i,3) + "\n");
            }

            Console.WriteLine("d)");
            Console.WriteLine("Введите значение a и b (b > a):");
            int aa = int.Parse(Console.ReadLine());
            int bb = int.Parse(Console.ReadLine());

            for (int i = aa; i <= bb; i++)
            {
                Console.WriteLine(i + "\n");
            }
            
        }

        private static void Task9()
        {
            Console.WriteLine("Введите сопротивление и напряжение 1-го участка цепи:");
            int v1 = int.Parse(Console.ReadLine());
            int m1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите объем и массу 2-го элемента:");
            int v2 = int.Parse(Console.ReadLine());
            int m2 = int.Parse(Console.ReadLine());
            int p1 = m1 / v1;
            int p2 = m2 / v2;
            if (p1 > p2) Console.WriteLine("Плотность 1-го материала больше.");
            else Console.WriteLine("Плотность 2-го материала больше.");

        }

        private static void Task8()
        {
            Console.WriteLine("Введите объем и массу 1-го элемента:");
            int v1 = int.Parse(Console.ReadLine());
            int m1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите объем и массу 2-го элемента:");
            int v2 = int.Parse(Console.ReadLine());
            int m2 = int.Parse(Console.ReadLine());
            int p1 = m1 / v1;
            int p2 = m2 / v2;
            if (p1 > p2) Console.WriteLine("Плотность 1-го материала больше.");
            else Console.WriteLine("Плотность 2-го материала больше.");

        }

        private static void Task7()
        {
            Console.WriteLine("Введите радиус круга:");
             int r = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите длину стороны квадрата:");
             int a = int.Parse(Console.ReadLine());
            var sCircle = Math.PI * Math.Pow(r, r);
            Console.WriteLine("Площадь круга равна: " + sCircle);
            var sSquare = a * a;
            Console.WriteLine("Площадь квадрата равна: " + sSquare);
            if(sCircle>sSquare) Console.WriteLine("Площадь круга больше.");
            else Console.WriteLine("Площадь квадрата больше.");
        }

        private static void Task6()
        {
            bool a = true;
            bool b = false;
            bool c = false;


        }

        private static void Task5()
        {
            Console.WriteLine("Введите расстояние в сантиметрах");
            int sm = int.Parse(Console.ReadLine());
            const int metr1 = 100;
            int metr = sm / metr1;
            Console.WriteLine("Полное кол-во метров: " + metr);

        }
  
        private static void Task4()
        {
            Console.WriteLine("Введите двухзначное число:");
            int number = int.Parse(Console.ReadLine());
            int tenth = 10;
            int a = number / tenth;
            Console.WriteLine(a + " - Число десятков");
            int b = number % tenth;
            Console.WriteLine(b + " - Число единиц");
            int sum = a + b;
            Console.WriteLine(sum + " - Cумма его цифр");
            int proiz = a * b;
            Console.WriteLine(proiz + " - Произведение его цифр");

        }

        private static void Task3()
        {
            int someDay = 234;
            int oneWeek = 7;
            int week = someDay / oneWeek;
            Console.WriteLine(week + " полных недель прошло за 234 дня.");

        }

        private static void Task2()
        {
            int a = 5, b = 10, c = 21;
            Console.WriteLine(a + "\n" + b + "\n" + c);
        }

        private static void Task1()
        {
            Console.WriteLine("Введите любые три числа:");
            int number1 = int.Parse(Console.ReadLine());
            int number2 = int.Parse(Console.ReadLine());
            int number3 = int.Parse(Console.ReadLine());
            Console.WriteLine(number1 + "  " + number2 + "  " + number3);
        }
    }
}
