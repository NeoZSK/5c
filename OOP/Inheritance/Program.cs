// Human -> Student, Employee

Employee e = new Employee("Trevor", 57);
e.Eat("das Gurken");
e.Work("ZSK");


Student s = new Student("Phill", 19);
s.Eat("das Gurken");
s.Learn("math");


// abstract, virtual
abstract class IHuman
{
    // 'virtual' must have body
    // 'abstract' cannot have body
    public abstract void Eat(string food);
    public abstract void Sleep(int time);
}


abstract class Human(string name, int age) : IHuman
{
    public int Age = age;
    public string Name = name;

    public override void Eat(string food)
    {
        Console.WriteLine($"{Name} eats {food}");
    }

    public override void Sleep(int time)
    {
        Console.WriteLine($"{Name} sleeps {time} hours");
    }
}


class Student(string name, int age) : Human(name, age)
{
    public void Learn(string subject)
    {
        Console.WriteLine($"{Name} learns {subject}");
    }

    public override void Eat(string food)
    {
        Console.WriteLine($"{Name} eats nothing because they are poor. {food} is too expensive.");
    }
}

class Employee(string name, int age) : Human(name, age)
{
    public void Work(string workPlace)
    {
        Console.WriteLine($"{Name} works at {workPlace}");
    }
}

