using System.Runtime.CompilerServices;


namespace FirstProject
{
    internal class Program
    {
        private const string FilePath = "people.txt";
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
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
                Console.Write("Избор: ");

                string choice= Console.ReadLine();
                Console.WriteLine();
                
                switch(choice)
                {
                    case "1":
                        Console.Write("Въведете име: ");
                        string name= Console.ReadLine();

                        Console.Write("Въведете възраст: ");
                        int age = int.Parse(Console.ReadLine());

                        Console.Write("Въведете заплата: ");
                        double salary=double.Parse(Console.ReadLine());

                        Person newPerson=new Person(name, age, salary);
                        people.Add(newPerson);

                        SavePeopleToFile(people);
                        Console.WriteLine("Успешно добавен нов запис!");
                        Console.WriteLine();
                        break;
                }
            }
        }
        static List<Person>LoadPeopleFromFile()
        {
            List<Person>people= new List<Person>();
            if(!File.Exists(FilePath))
            {
                return people;
            }
            string[] lines = File.ReadAllLines(FilePath);
            foreach( string line in lines )
            {
                string[] parts = line.Split(';');

                Person person = new Person(
                    parts[0],
                    int.Parse(parts[1]),
                    double.Parse(parts[2]));
                people.Add(person);
            }
            return people;
        }
        static void SavePeopleToFile(List<Person> people)
        {
            List<string>rows=new List<string>();
            foreach (Person p in people)
            {
                rows.Add(p.ToFileRow());
            }
            File.WriteAllLines(FilePath, rows);
        }
    }
}
