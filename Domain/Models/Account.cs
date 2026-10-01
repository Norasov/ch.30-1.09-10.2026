namespace Domain.Models;

public class Account
{
    public string Name {get;set;} = null!;
    public double Balance {get;set;}
    public void Deposit(double amount)
    {
        if(amount > 0)
        {
            Balance+=amount;
        }
    }
    public void Withdraw(double amount)
    {
        if (amount > 0)
        {
            Balance -= amount;
        }
    }

    public override string ToString()
    {
        return $"{Name} balance: {Balance}";
    }

}
