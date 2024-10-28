using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagmentSystemTask
{
    internal sealed class LibraryMember : Person

    {
        public DateTime MemberShipDate {  get; set; }
        public LibraryMember(string name, DateTime memberShipDate) : base(name)
        {
            MemberShipDate = memberShipDate;

        }
    }
}
