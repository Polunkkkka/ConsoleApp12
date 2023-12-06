using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ConsoleApp11;
internal class Program
{
    static void Main(string[] args)
    {
        Console.Write("Введите целое число для проверки на простоту: "); // Ввод числа
        string input = Console.ReadLine();

        if (!int.TryParse(input, out int number)) // Проверка, является ли введенная строка целым числом
        {
            Console.WriteLine("Некорректные данные. Введите целое число!");
            Console.ReadLine();
            return;
        }

        bool isPrime = true;
        for (int i = 2; i < number; i++) // Цикл проверки
        {
            if (number % i == 0)
            {
                isPrime = false;
                break;
            }
        }

        if (isPrime && number > 1) // Вывод результата проверки
        {
            Console.WriteLine($"{number} - простое число.");
        }
        else
        {
            Console.WriteLine($"{number} - не является простым числом.");
        }
        Console.ReadLine();
    }
}