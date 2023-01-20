
public class BankServiceImpl : BankServce
{


    void BankServce.WithDraw(long Amount)
    {
        Console.WriteLine("With draw Amount" + Amount);
    }

    void BankServce.Deposit(long Amount)
    {
        Console.WriteLine("Deposit Amount" + Amount);
    }

    // static void Main(string[] args){
    //     Employee employee = new Employee();
    // }
}

