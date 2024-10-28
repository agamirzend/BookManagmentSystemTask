using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagmentSystemTask
{
    internal class Book : LibraryItem
    {
        public Book(string title, DateTime publicationYear,int aisle,int shelf, Book Genre) : base(title, publicationYear)
        {
        }

        public override void DisplayInfo()
        {
            Console.WriteLine($"Book Title: {Title} Year that made:  {PublicationYear}  ");
        }
    }
}
