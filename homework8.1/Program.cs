using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework8._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            List<int> list = new List<int>();
            
            FillList(list);                       // заполнение листа
            Console.WriteLine("Список из 100 рандомных чисел\n");
            PrintList(list);                      // вывод листа на экран
            ClearList(list);                      // отчистка от ненужных чисел
            Console.WriteLine("\nСписок без чисел в интервале между 25 и 50\n");
            PrintList(list);                      // вывод листа на экран

        }

       #region Методы

        /// <summary>
        /// заполнение листа
        /// </summary>
        /// <param name="list"></param>
        static void FillList(List<int>list)
        {
            Random random = new Random();
            for (int i = 0; i < 100; i++)
            {
                list.Add(random.Next(0, 100));
            }
        }

        /// <summary>
        /// вывод листа на экран
        /// </summary>
        /// <param name="list"></param>
        static void PrintList(List<int> list)
        {
            int q = 0;
            foreach (var number in list)
            {
                Console.Write($"{number} ");
                q++;
                if (q == 10)
                {
                    Console.WriteLine();
                    q = 0;
                }
            }
            Console.ReadKey();
        }

        /// <summary>
        /// отчистка от ненужных чисел
        /// </summary>
        /// <param name="list"></param>
        static void ClearList(List<int> list)
        {
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] > 25 && list[i] < 50)
                {
                    list.RemoveAt(i);
                }
            }
            Console.WriteLine();
        }

        #endregion

    }
}
