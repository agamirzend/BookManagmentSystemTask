using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagmentSystemTask
{
    internal class LibraryCatalog
    {

        public LibraryItem this[int id]
        {
            get
            {
                if (!catalog.ContainsKey(id))
                    throw new CustomBookError($"Book with ID {id} is not found in the catalog.");

                return catalog[id];
            }
        }

        public void AddItem(int id, LibraryItem item)
        {
            catalog[id] = item;
        }
    }
}
