using Domain.Models;

namespace infrastructure.Repositories;

public class Library
{
    private List<Book> books =[];
    public void AddBook(Book book)
    {
        books.Add(book);
    }
    public void RemoveBook(string title)
    {
        for(int i = 0;i < books.Count; i++)
        {
            if(books[i].Title == title)
            {
                books.RemoveAt(i);
            }
        }
    }
    public List<Book> SearchBookByAuthor(string author)
    {
        return books.FindAll(x=>x.Author == author);
    }
    public List<Book> SearchBookByYear(int year)
    {
        return books.FindAll(x=>x.Year > year);
    }
    public List<Book> SearchBookByGenre(string genre)
    {
        return books.FindAll(x=>x.Genre == genre);
    }
    public int GetBoolCount()
    {
        return books.Count;
    }
}
