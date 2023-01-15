class Student{

    private string? _name {get;set;}
    private string? _address{get;set;}

    Student(string name,string address){
        this._address=address;
        this._name=name;
    }

    
    static void Main(string[] args){
        Student s = new Student("Bikash Shah","Biratnagr");
        Console.WriteLine(s);
    }
}