class Employee
{
    private int? EmployeId { get; set; }
    private string? FirstName { get; set; }
    private string? LastName { get; set; }
    private string? Email { get; set; }
    private string? Phone { get; set; }

    public Employee(int id, string firstName, string lastName, string email, string phone)
    {
        this.EmployeId = id;
        this.FirstName = firstName;
        this.LastName = lastName;
        this.Email = email;
        this.Phone = phone;
    }

    public Employee()
    {
    }

    static void Main(string[] args)
    {
        Employee employee = new Employee(1, "Bikas", "Shah", "test@gmail.com", "981430191");
        BankServce b;
        b = new BankServiceImpl();
        b.Deposit(2500);
        b.WithDraw(500);
    }
}