using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagmentSystemTask
{
    internal abstract class LibraryItem
    {
        public string Title { get; set; }
        public DateTime PublicationYear { get; set; }
        public abstract void DisplayInfo();
        protected LibraryItem(string title, DateTime publicationYear)
        {
            if (string.IsNullOrEmpty(title))
                throw new ArgumentException("Title cannot be null or empty.");

            Title = title;
            PublicationYear = publicationYear;
        }

    }
}
