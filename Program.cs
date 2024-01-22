using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR_12._2
{
    internal class Program
    {
        // рекурсивная функция, которая вычисляет значения n по заданным формулам
        static double F(int n)
        {
            return (n > 25) ? 2 * Math.Pow(n, 3) + 1 : F(n + 2) + 2 * F(n + 3);
        }

        static void Main(string[] args) // вызов основного метода
        {

            Console.Title = "Практическая работа №12.2";
            while (true)
            {
                Console.WriteLine("Здравствуйте!");
                Console.WriteLine("Нажмите: Y чтобы продолжить\n\t N чтобы прекратить");
                string select_key = Console.ReadLine();
                switch (select_key)
                {
                    case "Y":
                        try
                        {
                            Console.Write("Укажите диапозон значений от: ");
                            int range_from = Convert.ToInt32(Console.ReadLine()); // диапозон значений от
                            Console.Write("\t\t\t  до: ");
                            int range_to = Convert.ToInt32(Console.ReadLine()); // диапозон значений до
                            
                            int count = 0; // значения, делящиеся на 11

                            for (int n = range_from; n <= range_to; n++)
                            {
                                double answer = F(n); // вызов рекурсивной функции
                                if (F(n) % 11 == 0) // нахождение значений, которые делятся на 11 без остатка
                                {
                                    Console.ForegroundColor = ConsoleColor.Green;
                                    count++; // подсчет значений, делящихся на 11
                                }
                                else
                                    Console.ForegroundColor = ConsoleColor.Red;

                                Console.WriteLine(answer);

                            }
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine("Количество натуральных значений = " + count);

                            Console.ReadKey();
                        }

                        catch (IndexOutOfRangeException)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Элемент находится вне границы");
                            Console.ForegroundColor = ConsoleColor.White;
                        }
                        catch (FormatException)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Вы вводите недопустимые значения!");
                            Console.ForegroundColor = ConsoleColor.White;
                        }
                        catch (Exception ex)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Что-то пошло не так. Ошибка: " + ex.Message);
                            Console.ForegroundColor = ConsoleColor.White;
                        }
                        Console.Clear();
                        break;

                    case "N":
                        Console.WriteLine();
                        Environment.Exit(0);
                        break;
                }
            }
        }
    }
}
