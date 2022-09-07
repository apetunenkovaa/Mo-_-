using System;

namespace Моб_р
{
    class Program
    {
        

        static void Main(string[] args)
        {
            Console.WriteLine("Задача1:");
            task1();
            task2();
            task3();
            task4();
            task5();
            task6();
            task7();
            task8();
        }

        static void task1()
        {
            double z;
            Console.WriteLine("Введите первое число:");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите второе число:");
            double y = Convert.ToDouble(Console.ReadLine());
            z = Math.Pow(x, y);
            Console.WriteLine($"Результат:{z}");
        }

        static void task2()
        {
           
        }

        static void task3()
        {
            Console.WriteLine("Введите число:");
            double x = Convert.ToDouble(Console.ReadLine());
            double x1 = x % 2;
            double x2 = x % 3;
            if (x1 == x2)
            {
                Console.WriteLine("Остаток от деления на 3 и на 2 совпадает");
            }
            else Console.WriteLine("Остаток от деления на 3 и на 2 НЕ совпадает");
        }

       
        static void task4()
        {
            Console.WriteLine("Введите n-значное число (n от 1 и до 10):");
            string n = Convert.ToString(Console.ReadLine());


            




        }
        static void task5()
        {
            double z;
            Console.WriteLine("Введите первое число:");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите второе число:");
            double y = Convert.ToDouble(Console.ReadLine());
            z = (1+ Math.Sin(Math.Sqrt(x+1)))/(Math.Cos(12*y-4));
            Console.WriteLine($"Результат:{z}");
        }
        static void task6()
        {
            Console.WriteLine("Введите количество чисел в последовательности:");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] a = new int[n];
            a[0] = 0;
            a[1] = 1;
            for (int i = 2; i < n; i++)
            {
                a[i] = a[i-1]+ a[i - 2];
            }
            for (int i = 0; i < n; i++)
            {
                if (a[i] % 2 == 0)
                {
                    Console.WriteLine($"{i+1}-ое число четное число последовательности Фибоначи равно - {a[i]}");
                }
            }
        }
        static void task7()
        {
            Console.WriteLine("Введите число n:");
            int n = Convert.ToInt32(Console.ReadLine());

            if (n>0)
            { 
                
                double x1 = 1;
                double x2 = 2;
                double sum = x1/x2;
                for (int i = 0; i < n; i++)
                {
                    sum = sum + (x1++ / x2++);
                }
                Console.WriteLine($"Сумма чисел последовательности равна - {sum}");
            }
            else Console.WriteLine("Последовательность невозможна :((");
        }
        static void task8()
        {
            Console.WriteLine("Введите время первого спортсмена:");
            double t1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите время второго спортсмена:");
            double t2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите время третьего спортсмена:");
            double t3 = Convert.ToDouble(Console.ReadLine());
            if ((t1 > t2) && (t1 > t3))
            {
                Console.WriteLine($"Первый спорсмен показал лучшее время{t1}");
            }
            else if ((t2 > t1) && (t2 > t3))
            {
                {
                    Console.WriteLine($"Второй спорсмен показал лучшее время{t2}");
                }
            }
            else if ((t3 > t1) && (t3 > t2))
            {
                {
                    Console.WriteLine($"Третий спорсмен показал лучшее время{t3}");
                }
            }
            else Console.WriteLine("Вы что-то ввели не так :(((");
            
        }


    }
    
}

