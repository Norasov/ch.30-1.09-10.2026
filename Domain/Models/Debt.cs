namespace Domain.Models;

public class Debt
{
    private double balance;
    private double interestRate;
    public Debt(double initialBalanace,double initialInterestRate)
    {
        balance = initialBalanace;
        interestRate = initialInterestRate;
    }
    public void PrintBalance()
    {
        System.Console.WriteLine(balance);
    }
    public void WaitOneYear()
    {
        balance+= balance * interestRate;
    }
}
