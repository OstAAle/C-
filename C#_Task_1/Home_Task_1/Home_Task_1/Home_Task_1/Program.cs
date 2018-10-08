using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home_Task_1
{
    class Program
    {

        static double Length(double x1, double y1, double x2, double y2)
        {

            double r2 = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
            return r2;

        }

        static void Pause()
        {

            Console.ReadKey();

        }

        static void Main(string[] args)
        {

            Console.Title = ("Остапенко Алексей");
            Console.SetWindowSize(30, 10);
            Console.SetBufferSize(30, 10);
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.BackgroundColor = ConsoleColor.Cyan;

            //Home_Task_1

            Console.Write("Добрый день, введиет свое имя, ");
            string name = Console.ReadLine();
            Console.Write("фамилию, ");
            string surname = Console.ReadLine();
            Console.Write("возраст, ");
            string age = Console.ReadLine();
            Console.Write("рост, ");
            string height = Console.ReadLine();
            Console.Write("вес. ");
            string weight = Console.ReadLine();
            Console.WriteLine("Ваше имя - " + name + " " + "фамилия - " + surname + " " + "возраст - " + age + " " + "рост - " + height + " " + "вес - "  + weight + " " + ".");
            Console.WriteLine("{0} {1} {2} {3} {4}",name, surname, age, height, weight);
            Console.WriteLine($"{name} {surname} {age} {height} {weight}");
            Pause();

            //Home_Task_2

            Console.WriteLine("Введите вес");
            double m = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите рост");
            double h = Convert.ToDouble(Console.ReadLine());
            double imt = m / (h * h);
            Console.WriteLine("Ваш ИМТ = " + imt);
            Pause();

            //Home_Task_3

            Console.WriteLine("Введите координату x1");
            double x1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите координату y1");
            double y1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите координату x2");
            double x2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите координату y2");
            double y2 = Convert.ToDouble(Console.ReadLine());
            double r = Math.Sqrt(Math.Pow(x2 - x1,2) + Math.Pow(y2 - y1,2));
            //double r = Length(x1,y1,x2,y2); method usage
            Console.WriteLine($"Координата x1 - {x1:F2}, координата y1 - {y1:F2}, координата x2 - {x2:F2}, координата y2 - {y2:F2}. Расстояние между координатами = {r:F2}.");
            Pause();

            //Home_Task_4

            Console.WriteLine("Введите первую переменную");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите вторую переменную");
            double b = Convert.ToDouble(Console.ReadLine());
            double c = a;
            a = b;
            b = c;
            // a=a+b; b=a-b; a=a-b; 2 variables
            Console.WriteLine($"{a} , {b}");
            Pause();

        }
    }
}
