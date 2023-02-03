using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    public class SortList
    {
        public delegate void SortListDelegate(List<string> list);
        public event SortListDelegate SortListEvent;

        public static List<string> FillList()
        {
            Console.WriteLine("Вам нужно ввести 5 фамилий для сортировки");
            List<string> surnames = new List<string>();

            string temp = null;

            for (int i = 0; i < 5; i++)
            {
                Console.Write($"Введите {i + 1}-ю фамилию: ");
                temp = Console.ReadLine();
                surnames.Add(temp);
            }

            return surnames;
        }

        public void Sort(List<string> list)
        {
            SortListActivator(list);
        }

        protected void SortListActivator(List<string> list) => SortListEvent(list);
    }
}
