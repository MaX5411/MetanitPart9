namespace PatternMatchingProperties;

class Program
{
    static void Main(string[] args)
    {
        Person tom = new Person { Language = "English", Status = "user", Name = "Tom" };
        Person pierre = new Person { Language = "French", Status = "user", Name = "Pierre" };
        Person tomas = new Person { Language = "German", Status = "Admin", Name = "Tomas" };
        Person pablo = new Person { Language = "Spanish", Status = "user", Name = "Pablo" };

        SayHello(tom); 
        Console.WriteLine(GetMessage(tomas));
        Console.WriteLine(GetMessage(pierre));
        Console.WriteLine(GetMessage(pablo));

        Console.ReadKey();
    }

    static string GetMessage(Person? person)
    {
        return person switch
        {
            { Language: "English" } => "Hello",
            { Language: "French" } => "Bonjour",
            { Language: "German", Status: "Admin" } => "Hallo, admin!",
            null => "NULL",
            { } => "undefined"
        };
    }

    static void SayHello(Person? person)
    {
        if (person is Person { Language: "English" })
        {
            Console.WriteLine("Hello!");
        }
        else
        {
            Console.WriteLine("Fuck, off");
        }
    }
}

public class Person
{
    public string Name { get; set; } = "";
    public string Status { get; set; } = "";
    public string Language { get; set; } = "";
}