using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab9
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Вас приветствует калькулятор");
                Console.Write("Введите целое число=");
                int a = Convert.ToInt32(Console.ReadLine());
                Console.Write("Введите целое число=");
                int b = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите код операции");
                Console.WriteLine("          1-сложение");
                Console.WriteLine("          2-вычитание");
                Console.WriteLine("          3-произведение");
                Console.WriteLine("          4-частное");
                Console.Write("Ваш ответ:");
                int c = Convert.ToInt32(Console.ReadLine());
                if (c == 1)
                {
                    Console.WriteLine("Ответ:{0:f2}", a + b);
                }

                if (c == 2)
                {
                    Console.WriteLine("Ответ:{0:f2}", a - b);
                }
                if (c == 3)
                {
                    Console.WriteLine("Ответ:{0:f2}", a * b);
                }
                if (c == 4)
                {
                    double e = Convert.ToDouble(a) / Convert.ToDouble(b);
                    Console.WriteLine("Ответ:{0:f2}", e);
                }
                else 
                {
                    Console.WriteLine("Нет операции с указанным номером");
                }
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (FormatException ex)
            {
                Console.Write("Ошибка!");
                Console.Write(ex.Message);
            }
            Console.ReadKey();
        }
    }
}
