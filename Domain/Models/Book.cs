namespace Domain.Models;

public class Book
{
    public string Title {get;set;} = null!;
    public string Author {get;set;} = null!;
    public int Year {get;set;}
    public string Genre {get;set;} = null!;
}
