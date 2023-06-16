namespace consturctor
class Person
{
    public string Name { get; set; }
    public int Age { get; set; }

    // Default constructor
    public Person()
    {
        Name = "Unknown";
        Age = 0;
    }

    // Parameterized constructor
    public Person(string name, int age)
    {
        Name = name;
        Age = age;
    }

    // Copy constructor
    public Person(Person otherPerson)
    {
        Name = otherPerson.Name;
        Age = otherPerson.Age;
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Using the default constructor
        Person person1 = new Person();
        Console.WriteLine("Person 1: Name = " + person1.Name + ", Age = " + person1.Age);

        // Using the parameterized constructor
        Person person2 = new Person("Alice", 25);
        Console.WriteLine("Person 2: Name = " + person2.Name + ", Age = " + person2.Age);

        // Using the copy constructor
        Person person3 = new Person(person2);
        Console.WriteLine("Person 3: Name = " + person3.Name + ", Age = " + person3.Age);
    }
}
