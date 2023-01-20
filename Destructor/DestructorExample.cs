public class Test
{
    // A destructor works opposite to constructor, It destructs the objects of classes. It can be defined only once in a class. Like constructors, it is invoked automatically.


    private int id;
    private string? name;
    private string? address;

    //constructor which should be always public
    public Test(){
        Console.WriteLine("Constructor Called");
    }

    //Destructor which should always start with ~ and never should be public
    ~Test()
    {
        Console.WriteLine("Destructor Called");
    }
}