namespace PatternMatching;

class Program
{
    static void Main(string[] args)
    {
        Employee tom = new Manager();
        tom.Work();
        UseEmployee(tom);

        Employee? bob = new Employee();
        Employee? john = null;

        NullCheck(bob);
        NullCheck(john);

        UseSwitch(tom);
        UseSwitch(bob);
        UseSwitch(john);


        Console.ReadKey();

    }

    static void UseSwitch(Employee? emp)
    {
        switch (emp)
        {
            case Manager manager when !manager.IsOnVacation:
                manager.Work();
                break;
            case null:
                Console.WriteLine("obj is null");
                break;
            default:
                Console.WriteLine("Object is not Manager");
                break;
        }
    }
    static void NullCheck(Employee? emp)
    {
        if (emp is not null)
        {
            emp.Work();
        }
        else
        {
            Console.WriteLine("Not working");
        }
    }

    static void UseEmployee(Employee emp)
    {
        if (emp is Manager manager && manager.IsOnVacation == false)
        {
            manager.Work();
        }
        else
        {
            Console.WriteLine("Not working");
        }
    }
}

public class Employee
{
    public virtual void Work() => Console.WriteLine("Emploeey working");

}

public class Manager : Employee
{
    public override void Work() => Console.WriteLine("Manager working");
    public bool IsOnVacation { get; set; }
}  