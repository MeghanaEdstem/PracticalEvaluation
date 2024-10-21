namespace PracticalEvaluation;

class BankAccount
{    
    private  double balance =  1000;

    public void GetBalance()
    {
        Console.WriteLine(balance);
    }
    
    public void  Deposit( double amount)
    {
        try
        {
            if(amount <= 0)
            {
                throw new ArgumentException("amount should be greater than zero");
            }
            else
            {
                balance += amount;
            }
        }
        catch(ArgumentException)
        {
            Console.WriteLine("Can not deposite the amount : " + amount);
        }      
    }

    public void Withdraw( double amount)
    {
        try
        {
            if(amount < 0)
            {
                throw new ArgumentException("The amonut should be greater than zero");
            }
            if(amount < balance)
            {
                throw new ArgumentException("Enter an amonut less than your balance");
            }
            else
            {
                balance -= amount;
            }
        }
        catch(ArgumentException)
        {
            Console.WriteLine("Can not withdraw the amount : " + amount);
        }
    }
}

class BankInformation
{
    public static void Main(string[] args)
    {
        BankAccount bankAccount = new BankAccount();
        bankAccount.Deposit(1000);
        bankAccount.Withdraw(500);
        bankAccount.GetBalance();
        var accountNumber = "ABCD0098765";
        var accountHolder = "Test Holder";
        Console.WriteLine("Account Number : " + accountNumber);
        Console.WriteLine("Account Holder Name : " + accountHolder);
        // Console.WriteLine("Account Balance : " + balance);

    }
}