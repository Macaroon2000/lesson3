//Крылов Роман


using System;
using System.Collections.Generic;

namespace Lesson_3
{
    class Program
    {
        static int GetInt()
        {
            while (true)
                if (!int.TryParse(Console.ReadLine(), out int x))
                    Console.WriteLine("Ошибка, введенное значение не является числом.");
                else return x;
        }


        static void Main(string[] args)
        {
            //1. а) Дописать структуру Complex, добавив метод вычитания комплексных чисел.
            //Продемонстрировать работу структуры.
            //б) Дописать класс Complex, добавив методы вычитания и произведения чисел. Проверить работу класса.
            //в) Добавить диалог с использованием switch демонстрирующий работу класса.

            Complex complex1;
            complex1.re = 1;
            complex1.im = 1;
            Complex complex2;
            complex2.re = 2;
            complex2.im = 2;

            Complex result = complex1.Plus(complex2);
            Console.WriteLine("Результат сложения: " + result.ToString());

            result = complex1.Minus(complex2);
            Console.WriteLine("Результат вычитания: " + result.ToString());

            result = complex1.Multi(complex2);
            Console.WriteLine("Результат умножения: " + result.ToString());

            Console.WriteLine("");
            Console.Write("Для продолжения нажмите Enter");
            Console.ReadKey();




            //2. а) С клавиатуры вводятся числа, пока не будет введён 0 (каждое число в новой строке).
            //Требуется подсчитать сумму всех нечётных положительных чисел. Сами числа и сумму
            //вывести на экран, используя tryParse.

            Console.WriteLine("Программа подсчета суммы нечетных положительных чисел" + Environment.NewLine + "Введите по одному числу:");

            int i = 0;
            int cumulative = 0;
            List<int> odd_num = new List<int>();

            do
            {
                //int i = Convert.ToInt32(Console.ReadLine());
                bool flag = int.TryParse(Console.ReadLine(), out i);

                if (i % 2 != 0 && i > 0)
                {
                    odd_num.Add(i);
                    cumulative += i;
                }
            } while (i != 0);

            Console.WriteLine("Нечетные положительные числа:");
            foreach (int item in odd_num)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("Сумма: " + cumulative);

            Console.WriteLine("");
            Console.Write("Для завершения нажмите Enter");
            Console.ReadKey();
        }
    }

    struct Complex
    {
        public double im;
        public double re;

        public Complex Plus(Complex x)
        {
            Complex y;
            y.im = im + x.im;
            y.re = re + x.re;
            return y;
        }

        public Complex Minus(Complex x)
        {
            Complex y;
            y.im = im - x.im;
            y.re = re - x.re;
            return y;
        }

        public Complex Multi(Complex x)
        {
            Complex y;
            y.im = im * x.im + re * x.im;
            y.re = re * x.im - im * x.re;
            return y;
        }
        public string ToString()
        {
            return re + "+" + im + "i";
        }
    }
    /// <summary>
    /// Класс для работы с комплексными числами                          (ПРИМЕР ПРЕПОДА НА ИЗУЧЕНИЕ)
    /// </summary>
    class ComplexClass
    {
        // Поля
        private double im;
        double re;

        // Конструктор без параметров.
        public ComplexClass()
        {
            im = 0;
            re = 0;
        }


        public ComplexClass(double _im, double re)
        {

            im = _im;
            this.re = re;
        }

        /// <summary>
        /// Сложение комплексных чисел
        /// </summary>
        /// <param name="x2">Комплексное число</param>
        /// <returns>Результат сложения комплексных чисел</returns>
        public ComplexClass Plus(ComplexClass x2)
        {
            ComplexClass x3 = new ComplexClass();
            x3.im = x2.im + im;
            x3.re = x2.re + re;
            return x3;
        }

        /// <summary>
        /// Вычитание комплексных чисел
        /// </summary>
        /// <param name="x2">Комплексное число</param>
        /// <returns>Результат вычитания комплексных чисел</returns>
        public ComplexClass Minus(ComplexClass x2)
        {
            ComplexClass x3 = new ComplexClass();
            x3.im = im - x2.im;
            x3.re = re - x2.re;
            return x3;
        }

        /// <summary>
        /// Произведение комплексных чисел
        /// </summary>
        /// <param name="x2">Комплексное число</param>
        /// <returns>Результат произведения комплексных чисел</returns>
        public ComplexClass Multi(ComplexClass x2)
        {
            ComplexClass x3 = new ComplexClass();
            x3.im = re * x2.im + im * x2.re;
            x3.re = re * x2.re - im * x2.im;
            return x3;
        }

        // Свойства - это механизм доступа к данным класса.
        public double Im
        {
            get { return im; }
            set
            {
                im = value;
            }
        }

        // Специальный метод, который возвращает строковое представление данных.
        public override string ToString()
        {
            return $"{re} {(im >= 0 ? "+" : "-")} {Math.Abs(im)}i";
        }

    }
}
