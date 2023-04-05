public class Person {
    // fields
    private string _name;
    private int _age;

    // properties
    public string Name {
        get { return _name; }
        set { _name = value; }
    }

    public int Age {
        get { return _age; }
        set { _age = value; }
    }

    public int Address { get; set;} // Instead of modifying a field, it modifies itself

    // methods
    public void SayHello() {
        Console.WriteLine("Hello, my name is " + _name + " and I am " + _age + " years old.");
    }
}
