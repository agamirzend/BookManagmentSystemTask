using LibraryManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagmentSystemTask;

internal interface IBook
{
    Book GetBookById(int id);
    List<Book> GetAllBooks();
    void CreateBook(Book book);
    void DeleteBook(int id, bool IsSoftDelete);
}
