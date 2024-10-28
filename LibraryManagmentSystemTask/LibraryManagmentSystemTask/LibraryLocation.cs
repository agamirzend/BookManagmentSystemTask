using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagmentSystemTask
{
    internal struct  LibraryLocation
    {
        enum BookGenre
        {
            Fiction,
            NonFiction,
            Scinence,
            Art
        }
        public LibraryLocation(int aisle,int shelf)
        {
            Aisle = aisle;
            Shelf = shelf;
        }
        public int Aisle {  get; set; }
        public int Shelf { get; set; }
        public string Genre{ get; set; }
    }
}
