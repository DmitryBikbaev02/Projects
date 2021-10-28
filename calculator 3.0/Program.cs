using System;

namespace calculator_3._0
{
    class Program
    {

        static double Ost(double d, double e)
        {
            double res;
            res = d - (d / e);

            return res;


        }
        static int Sum(int a, int b)
        {
            int res = a + b;
            return res;
        }

        static int Subtraction(int a, int b)
        {
            int res = a - b;
            return res;
        }

        static int Mult(int a, int b)
        {
            int res = a * b;
            return res;
        }
        static int Div(int a, int b)
        {
            if (b == 0)
            {
                Console.WriteLine("Ошибка: нельзя делить на 0");
            }

            int res = a / b;
            return res;
        }

        static long Fact(long a)
        {

            {
                if (a == 1)
                {
                    return 1;
                }
                if (a < 1)
                {
                    Console.WriteLine("Ошибка: факториал существует только от натурального числа");
                    return a;
                }

                else
                {
                    long res = a * Fact(a - 1);
                    return res;
                }

            }
        }

       


    static void Main(string[] args)
        {

            int a, b, res;
            double d, e;
            string act;
            Console.WriteLine("Выберите действие: +, -, :, *, !, остаток (остаток от деления)");
            act = Console.ReadLine();
            if (act == "+")
            {
                Console.WriteLine("Введите первое число");

                a = int.Parse(Console.ReadLine());
                Console.WriteLine("Введите второе число");
                b = int.Parse(Console.ReadLine());

                res = Sum(a, b);
                Console.WriteLine(res);

            }
            if (act == "-")
            {
                Console.WriteLine("Введите первое число");

                a = int.Parse(Console.ReadLine());
                Console.WriteLine("Введите второе число");
                b = int.Parse(Console.ReadLine());

                res = Subtraction(a, b);
                Console.WriteLine(res);
            }
            if (act == "*")
            {
                Console.WriteLine("Введите первое число");

                a = int.Parse(Console.ReadLine());
                Console.WriteLine("Введите второе число");
                b = int.Parse(Console.ReadLine());

                res = Mult(a, b);
                Console.WriteLine(res);
            }
            if (act == ":")
            {
                Console.WriteLine("Введите первое число");

                a = int.Parse(Console.ReadLine());
                Console.WriteLine("Введите второе число");
                b = int.Parse(Console.ReadLine());

                res = Div(a, b);
                Console.WriteLine(res);
            }
            if (act == "!")
            {
                Console.WriteLine("Введите число");

                a = int.Parse(Console.ReadLine());
                Console.WriteLine(Fact(a));



                Console.ReadLine();
            }
                 if (act == "остаток")

                {

                Console.WriteLine("Введите первое число");

                d = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите второе число");
                e = Convert.ToInt32(Console.ReadLine());

                res = Ost(d, e);
                
                Console.WriteLine(res);

            }


        }

    }
}

