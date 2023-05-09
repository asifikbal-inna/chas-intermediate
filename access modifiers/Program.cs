using System;

public class MyBaseClass
{
    private int privateField;

    protected int protectedField;

    public int publicField;

    internal int internalField;

    protected internal int protectedInternalField;

    private void PrivateMethod()
    {
        Console.WriteLine("This is a private method.");
    }

    protected void ProtectedMethod()
    {
        Console.WriteLine("This is a protected method.");
    }

    public void PublicMethod()
    {
        Console.WriteLine("This is a public method.");
    }

    internal void InternalMethod()
    {
        Console.WriteLine("This is an internal method.");
    }

    protected internal void ProtectedInternalMethod()
    {
        Console.WriteLine("This is a protected internal method.");
    }
}

public class MyDerivedClass : MyBaseClass
{
    public void AccessBaseClassMembers()
    {
        // Accessing inherited members from the base class
        protectedField = 10;              // Accessing protected field
        ProtectedMethod();                // Accessing protected method
        publicField = 20;                 // Accessing public field
        PublicMethod();                   // Accessing public method
        internalField = 30;               // Accessing internal field
        InternalMethod();                 // Accessing internal method
        protectedInternalField = 40;      // Accessing protected internal field
        ProtectedInternalMethod();        // Accessing protected internal method
    }
}

public class Program
{
    public static void Main()
    {
        MyDerivedClass myObject = new MyDerivedClass();

        // Accessing members from the derived class
        myObject.AccessBaseClassMembers();
    }
}
