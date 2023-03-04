using FirstApp;

class Program
{
    static void Main(string[] args)
    {
        Person person = new Person("Egor");
        person.Name = "Egor K";
        Console.WriteLine(person.Name);
    }
}
