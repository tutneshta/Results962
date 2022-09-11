using System;

namespace Task92
{
    class Program
    {
        public string[] ArrayName = { "Миша", "Сергей", "Андрей", "Ольга", "Виктор" };

        static void Main(string[] args)
        {

            Program program = new Program();

            program.PrepareSort();

        }

        public void PrepareSort()
        {
            Name name = new Name();

            SortName sortName = new SortName();

            name.OnSortrUp += sortName.NameSortUp;

            name.OnSortrDown += sortName.NameSortDown;

            try
            {

                Console.WriteLine("Введите цифру 1 - Сортировка от А до Я, или 2 - Сортировка от Я до А");

                int index = Int32.Parse(Console.ReadLine());

                if (index == 1 || index == 2)
                {
                    name.NameSort(index);
                }
                else
                {
                    throw new IndexException("Исключение: неправильная цифра");
                }

            }
            catch (IndexException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (FormatException e)
            {
                Console.WriteLine(e.Message);
            }

        }

    }
    class IndexException : Exception
    {
        public IndexException(String message) : base(message) { }
    }

}
