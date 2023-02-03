

namespace Task2
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<string> list1 = SortList.FillList();
            SortList mySort = new SortList();

            while (true)
            {
                try
                {
                    Console.Write("\n1 - от А до Я\n2 - от Я до А\nВыберите как хотите отсортировать список: ");
                    int choose = CheckSortChoose();

                    switch (choose)
                    {
                        case 1: mySort.SortListEvent += SortAtoZ; break;
                        case 2: mySort.SortListEvent += SortZtoA; break;
                    }

                    Console.WriteLine();
                    mySort.Sort(list1);

                    foreach (var item in list1)
                    {
                        Console.WriteLine(item);
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine();
                    Console.WriteLine("Введен неправильный формат!");
                }
            }
        }

        static void SortAtoZ(List<string> list)
        {
            list.Sort();
        }
        static void SortZtoA(List<string> list)
        {
            list.Sort();
            list.Reverse();
        }

        static int CheckSortChoose()
        {
            int choose = Convert.ToInt32(Console.ReadLine());

            if (choose != 1 && choose != 2) throw new FormatException();

            return choose;
        }
    }
}