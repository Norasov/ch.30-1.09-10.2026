namespace Domain.Models;

public class Product
{
    private string name;
    private double price;
    private int quantity;

    public Product(string name, double price, int quantity)
    {
        this.name = name;
        this.price = price;
        this.quantity = quantity;
    }

    public void PrintProduct()
    {
        Console.WriteLine($"{name}: price {price}: {quantity} pcs");
    }
}
