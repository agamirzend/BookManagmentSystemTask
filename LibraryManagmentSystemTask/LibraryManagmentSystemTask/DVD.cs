using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagmentSystemTask
{
    internal class DVD : LibraryItem
    {
        public DVD(string title, DateTime publicationYear) : base(title, publicationYear)
        {

        }

        public override void DisplayInfo()
        {
            Console.WriteLine($"Dvd Title: {Title} Year that made:  {PublicationYear} ");
        }
    }
}
