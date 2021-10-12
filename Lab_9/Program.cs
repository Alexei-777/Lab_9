using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Смоделируйте работу простого калькулятора. Программа должна запрашивать 2 числа, а затем – код операции (например, 1 – сложение, 2 – вычитание, 3 – произведение, 4 – частное).
//После этого на консоль выводится ответ. Используйте обработку исключений для защиты от ввода некорректных данных.

namespace Lab_9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Вас приветствует калькулятор!"); // Говорящий калькулятор :)))
            int s = 0;
            try
            {
                Console.Write("Введите целое число X=");
                int X = Convert.ToInt32(Console.ReadLine());
                Console.Write("Введите целое число Y=");
                int Y = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите код операции:");
                Console.WriteLine("     1 - Сложение");
                Console.WriteLine("     2 - Вычитание");
                Console.WriteLine("     3 - Умножение");
                Console.WriteLine("     4 - Деление");
                Console.Write("Введите:");
                int g = Convert.ToInt32(Console.ReadLine());
                for (int i = 0; i < 1000; i++)
                {
                    if ((g > 0) && (g < 5))
                    {
                        i = 1001;
                    }
                    else
                    {
                        Console.WriteLine("Вы ввели не правельное значение операции");
                        Console.Write("Введите снова:");
                        g = Convert.ToInt32(Console.ReadLine());
                    }
                }
                if (g == 1) { s = X + Y; }
                if (g == 2) { s = X - Y; }
                if (g == 3) { s = X * Y; }
                if (g == 4) { s = X / Y; }
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("На ноль делить нельзя, даже если ооочень захотеть!");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.WriteLine($"Реультат ={s}");
            Console.ReadKey();


        }
    }
}
