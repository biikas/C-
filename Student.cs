class Student{

    private string? Name {get;set;}
    private string? Address{get;set;}

    Student(string name,string address){
        this.Address=address;
        this.Name=name;
    }

    
    // static void Main(string[] args){
    //     Student s = new Student("Bikash Shah","Biratnagr");
    //     Console.WriteLine(s);
    // }
}