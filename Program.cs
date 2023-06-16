namespace modifier
// Public access modifier
public class PublicClass
{
    public void PublicMethod()
    {
        Console.WriteLine("Public method can be accessed from anywhere.");
    }
}

// Private access modifier
class PrivateClass
{
    private void PrivateMethod()
    {
        Console.WriteLine("Private method can only be accessed within the class.");
    }

    public void AccessPrivateMethod()
    {
        PrivateMethod(); // Private method can be accessed within the class
    }
}

// Protected access modifier
class BaseClass
{
    protected void ProtectedMethod()
    {
        Console.WriteLine("Protected method can be accessed within the class and derived classes.");
    }
}

class DerivedClass : BaseClass
{
    public void AccessProtectedMethod()
    {
        ProtectedMethod(); // Protected method can be accessed within the derived class
    }
}

// Internal access modifier
internal class InternalClass
{
    internal void InternalMethod()
    {
        Console.WriteLine("Internal method can be accessed within the same assembly.");
    }
}

// Protected internal access modifier
class ProtectedInternalClass
{
    protected internal void ProtectedInternalMethod()
    {
        Console.WriteLine("Protected internal method can be accessed within the same assembly and derived classes.");
    }
}

class Program
{
    static void Main(string[] args)
    {
        PublicClass publicObj = new PublicClass();
        publicObj.PublicMethod(); // Public method can be accessed from anywhere

        Console.WriteLine();

        PrivateClass privateObj = new PrivateClass();
        privateObj.AccessPrivateMethod(); // Accessing private method within the class

        Console.WriteLine();

        DerivedClass derivedObj = new DerivedClass();
        derivedObj.AccessProtectedMethod(); // Accessing protected method within the derived class

        Console.WriteLine();

        InternalClass internalObj = new InternalClass();
        internalObj.InternalMethod(); // Internal method can be accessed within the same assembly

        Console.WriteLine();

        ProtectedInternalClass protectedInternalObj = new ProtectedInternalClass();
        protectedInternalObj.ProtectedInternalMethod(); // Protected internal method can be accessed within the same assembly and derived classes
    }
}
