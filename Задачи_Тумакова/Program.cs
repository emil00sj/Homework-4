using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задачи_Тумакова
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Упражнение 5.1 Написать метод, возвращающий наибольшее из двух чисел. Входные
            параметры метода – два целых числа. Протестировать метод.*/
            Console.WriteLine("Упражнение 5.1)");
            Console.Write("Введите певрое число: ");
            int num1 = int.Parse(Console.ReadLine());
            Console.Write("Введите второе число: ");
            int num2 = int.Parse(Console.ReadLine());
            Console.WriteLine($"Наибольшее число - {Zadanie1(num1, num2)}");

            /*Упражнение 5.2 Написать метод, который меняет местами значения двух передаваемых
            параметров. Параметры передавать по ссылке. Протестировать метод.*/
            Zadanie2();

            /*Упражнение 5.3 Написать метод вычисления факториала числа, результат вычислений
            передавать в выходном параметре. Если метод отработал успешно, то вернуть значение true;
            если в процессе вычисления возникло переполнение, то вернуть значение false. Для
            отслеживания переполнения значения использовать блок checked.*/
            Zadanie3();

            /*Упражнение 5.4 Написать рекурсивный метод вычисления факториала числа.*/
            Console.WriteLine("\nУпражнение 5.4)");
            Console.Write("Ввеидите натуральное число: ");
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine($"Факториал числа {number} = {Zadanie4(number)}");

            /*Домашнее задание 5.1 Написать метод, который вычисляет НОД двух натуральных чисел
            (алгоритм Евклида). Написать метод с тем же именем, который вычисляет НОД трех
            натуральных чисел.*/
            Zadanie5_1();
            Zadanie5_2();
            Console.ReadKey();
        }
        static int Zadanie1(int x, int y)
        {
            return Math.Max(x, y);
        }
        static void Zadanie2()
        {
            Console.WriteLine("\nУпражнение 5.2)");
            Console.Write("Введите первую строку: ");
            string place1 = Console.ReadLine();
            Console.Write("Введите вторую строку: ");
            string place2 = Console.ReadLine();
            (place1, place2) = (place2, place1);
            Console.WriteLine($"Вывод: {place1} {place2}");
        }
        static void Zadanie3()
        {
            Console.WriteLine("\nУпражнение 5.3)");
            Console.Write("Введите натуральное число: ");
            int number = int.Parse(Console.ReadLine());
            long fact = 1;
            for (int i = 1; i <= number; i++)
            {
                fact *= i;
            }
            Console.WriteLine(fact);
        }
        static int Zadanie4(int x)
        {
            if (x == 0)
            {
                return 1;
            }
            else
            {
                return x * Zadanie4(x - 1);
            }
        }
        static void Zadanie5_1()
        {
            Console.WriteLine("\nДомашнее задание 5.1) для двух чисел");
            Console.Write("Ведите певрое натуральное число: ");
            int digit1 = int.Parse(Console.ReadLine());
            Console.Write("Ведите второе натуральное число: ");
            int digit2 = int.Parse(Console.ReadLine());
            int nod = 0;
            int max = Math.Max(digit1, digit2);
            for (int i = 2; i <= max; i++)
                if ((digit1 % i == 0) && (digit2 % i == 0))
                {
                    nod = i;
                    break;
                }
            Console.WriteLine($"Наименьший общий делитель, не учитывая 1 = {nod}");
        }
        static void Zadanie5_2()
        {
            Console.WriteLine("\nДомашнее задание 5.1) для трёх чисел");
            Console.Write("Ведите певрое натуральное число: ");
            int digit1 = int.Parse(Console.ReadLine());
            Console.Write("Ведите второе натуральное число: ");
            int digit2 = int.Parse(Console.ReadLine());
            Console.Write("Ведите третье натуральное число: ");
            int digit3 = int.Parse(Console.ReadLine());
            int nod = 0;
            int max1 = Math.Max(digit1, digit2);
            int max2 = Math.Max(max1, digit3);
            for (int i = 2; i <= max2; i++)
                if ((digit1 % i == 0) && (digit2 % i == 0) && (digit3 % i == 0))
                {
                    nod = i;
                    break;
                }
            Console.WriteLine($"Наименьший общий делитель, не учитывая 1 = {nod}");
        }
    }
}
