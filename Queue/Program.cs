
class Program
{
    public static void Change1(Person person)
    {
        person.Name = "Lionel";
        person.SecondName = "Messi";
    }

    public static void Change2(Person person)
    {
        person = new Person("Lionel", "Messi");
    }

    public static void Change3(Person person)
    {
        person = null;
    }

    public static void PrintPerson(Person person)
    {
        Console.WriteLine(person.Name + " " + person.SecondName);
    }

    static void Main()
    {
        Person person = new Person("Cristiano", "Ronaldo");

        PrintPerson(person);

        Change1(person);

        PrintPerson(person);

        Change2(person);

        PrintPerson(person);

        Change3(person);

        PrintPerson(person);

        Console.ReadKey();
    }
}

