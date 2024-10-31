using LibraryManagementSystem.Enums;
using LibraryManagmentSystemTask;

namespace LibraryManagementSystem.Models;

public class Book : LibraryItem, IBook
{
    private static int _counter;
    public int Id { get; set; }
    public BookGenreEnum Genre { get; set; }
    public LibraryLocation LibraryLocation { get; set; }

    public Book(string title, int? publicationYear) : base(title, publicationYear)
    {
        _counter++;
        Id = _counter;

    }

    public override void DisplayInfo()
    {
        Console.WriteLine("Hello from Book");
    }
   

    public static List<Book> Books;

   
    public Book()
    {
        Books = new List<Book>();
    }
    public void CreateBook(Book book)
    {
        Books.Add(book);
    }

    public Book GetBookById(int id)
    {
        int index = -1;
        for (int i = 0; i < Book.Count; i++)
        {
            if (id == Books[i].Id)
            {
                index = i;
                break;
            }
        }

        if (index != -1)
        {
            return Books[index];
        }
        else
        {
            throw new Exception($"Books list daxilinde gonderilen id-e({id}) uygun deyer tapilmadi, bu sebebden geriye deyer qaytarila bilmedi.");
        }
    }

    public List<Book> GetAllBooks()
    {
        return Books;
    }

    public void CreateLibrarian(Book book)
    {
        Books.Add(book);
    }

    public void DeleteBook(int id, bool IsSoftDelete)
    {
        int index = -1;
        for (int i = 0; i < Books.Count; i++)
        {
            if (id == Books[i].Id)
            {
                index = i;
                break;
            }
        }

        if (index != -1)
        {
            if (IsSoftDelete)
            {
                Books[index].BookStatus = Enums.BookStatusEnum.Removed;
            }
            else
            {

                Books.Remove(Books[index]);
            }
        }
        else
        {
            throw new Exception($"Books list daxilinde gonderilen id-e({id}) uygun deyer tapilmadi, bu sebebden Delete prosesi yekunlasmadi");
        }
    }
}
