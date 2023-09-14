using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace ConsoleApp1
{
    class Program
    {
        static int MyDel(int x, int y)
        {
            if (y == 0)
            {
                Exception exc = new Exception();
                exc.HelpLink = "https://www.ithub.bulgakov.app";
                exc.Data.Add("Время возникновения: ", DateTime.Now);
                exc.Data.Add("Причина: ", "Некорректное значение");
        
                throw exc;
            }
            return x / y;
        }

        static void Green()
        {
            Console.ForegroundColor = ConsoleColor.Green;
        }
        
        
        static void Gray()
        {
            Console.ForegroundColor = ConsoleColor.Gray;
        }
        
        static void Red()
        {
            Console.ForegroundColor = ConsoleColor.Red;
        }

        static void Main()
        {
            try
            {
                Console.Write("Введите x: ");
                int x = int.Parse(Console.ReadLine());
                Console.Write("Введите y: ");
                int y = int.Parse(Console.ReadLine());

                int result = MyDel(x, y);
                Console.WriteLine("Результат: " + result);
            }
            catch (Exception ex)
            {
                Red();
                Console.WriteLine("\n Error! \n");
                Green();
                Console.Write("Ошибка: ");
                Gray();
                Console.Write(ex.Message + "\n\n");
                Green();
                Console.Write("Метод: ");
                Gray();
                Console.Write(ex.TargetSite + "\n\n");
                Green();
                Console.Write("Вывод стека");
                Gray();
                Console.Write(ex.StackTrace + "\n\n");
                Green();
                Console.Write("Подробности на сайте: ");
                Gray();
                Console.Write(ex.HelpLink + "\n\n");
                Green();
                if (ex.Data != null)
                {
                    Console.WriteLine("Свведения: \n");
                    Gray();
                    foreach (DictionaryEntry d in ex.Data)
                        Console.WriteLine("-> {0} {1}", d.Key, d.Value);
                    Console.WriteLine("\n\n");
                }
                Gray();
                Main();
            }
            Console.ReadLine();

            }

        }
    }






