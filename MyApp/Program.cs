using Domain.Models;
using infrastructure.Repositories;

/* 1
Library library = new Library();

Book book1 = new Book
{
    Title = "The Hobbit",
    Author = "J.R.R. Tolkien",
    Year = 1937,
    Genre = "Fantasy"
};

Book book2 = new Book
{
    Title = "Harry Potter",
    Author = "J.K. Rowling",
    Year = 1997,
    Genre = "Fantasy"
};

Book book3 = new Book
{
    Title = "1984",
    Author = "George Orwell",
    Year = 1949,
    Genre = "Dystopia"
};

Book book4 = new Book
{
    Title = "The Alchemist",
    Author = "Paulo Coelho",
    Year = 1988,
    Genre = "Novel"
};

library.AddBook(book1);
library.AddBook(book2);
library.AddBook(book3);
library.AddBook(book4);
library.RemoveBook("The Alchemist");

foreach (var item in library.SearchBookByAuthor("George Orwell"))
{
    System.Console.WriteLine(item.Title + " " + item.Author + " " + item.Year);
}

foreach (var item in library.SearchBookByYear(1997))
{
    System.Console.WriteLine(item.Title + " " + item.Author + " " + item.Year);
}

foreach (var item in library.SearchBookByGenre("Fantasy"))
{
    System.Console.WriteLine(item.Title + " " + item.Author + " " + item.Year);
}
System.Console.WriteLine(library.GetBoolCount());
*/

/* 2
Debt mortgage = new Debt(100000, 0.01);
mortgage.PrintBalance(); // Output: 100000

mortgage.WaitOneYear();
mortgage.PrintBalance(); // Output: 101000

mortgage.WaitOneYear();
mortgage.PrintBalance(); // Output: 102010
*/

/*
List<InformationAboutBook> books = [];
InformationAboutBook book1 = new InformationAboutBook
{
    Author = "Muhammad",
    CountOfPapers = 200,
    Title = "Legend1",
    YearOfPublication = 2026
};

InformationAboutBook book2 = new InformationAboutBook
{
    Author = "Muhammad",
    CountOfPapers = 300,
    Title = "Legend2",
    YearOfPublication = 2026
};

InformationAboutBook book3 = new InformationAboutBook
{
    Author = "Muhammad3",
    CountOfPapers = 400,
    Title = "Legend3",
    YearOfPublication = 2026
};

books.Add(book1);
books.Add(book2);
books.Add(book3);
string? enterUser = Console.ReadLine()!;
switch (enterUser)
{
    case "Title":
        System.Console.WriteLine("Названия книг:");
        foreach (var item in books)
        {
            System.Console.WriteLine($"{item.Title}");
        }
        break;
    case "Author":
        System.Console.WriteLine("Имена авторов:");
        foreach (var item in books)
        {
            System.Console.WriteLine($"{item.Author}");
        }
        break;
    case "Everything":
        System.Console.WriteLine("Список книг:");
        foreach (var item in books)
        {
            System.Console.WriteLine($"{item.Title} {item.Author} {item.YearOfPublication} {item.CountOfPapers}");
        }
        break;
}
*/

// task 1
Account account = new();
account.Balance = 100;
account.Deposit(20);
System.Console.WriteLine(account.Balance);

// task 2
Account heikkisAccount = new();

heikkisAccount.Name = "Heikki's account";
heikkisAccount.Balance = 1000;

Account personalAccount = new();

personalAccount.Name = "Personal account";
personalAccount.Balance = 0;

heikkisAccount.Withdraw(100);
personalAccount.Deposit(100);

Console.WriteLine(heikkisAccount);
Console.WriteLine(personalAccount);

// 4
Product product = new Product("Banana", 1.1, 13);
product.PrintProduct();

// 5
Counter counter = new Counter(5);

counter.PrintValue();

counter.Decrement();
counter.PrintValue();

counter.Decrement();
counter.PrintValue();

counter.Reset();
counter.PrintValue();