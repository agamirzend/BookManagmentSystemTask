using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagmentSystemTask
{
    internal class Magazine : LibraryItem
    {
        public string Genre {  get; set; } 
        public Magazine(string title, DateTime publicationYear) : base(title, publicationYear)
        {

        }

        public override void DisplayInfo()
        {
            Console.WriteLine($"Magazine Title: {Title} Year that made:  {PublicationYear} ");
        }
    }
}
