using System.Runtime.CompilerServices;

namespace FirstProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Person> people = LoadPeopleFromFile();
            bool running = true;

            while( running )
            {
                Console.WriteLine("---Избери операция---");
                Console.WriteLine("1.CREATE (Добавяне на човек)");
                Console.WriteLine("2.READ (Показване на всички)");
                Console.WriteLine("3.UPDATE (Промяна на заплатата)");
                Console.WriteLine("4.DELETE (Изтриване по име) ");
                Console.WriteLine("5.Изход");
                Console.WriteLine("Избор: ");

                string choice= Console.ReadLine();
                Console.WriteLine();
                
            }
        }
    }
}
