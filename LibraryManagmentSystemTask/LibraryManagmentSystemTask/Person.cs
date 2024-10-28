using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagmentSystemTask
{
    internal abstract class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        protected Person(string name)
        {
            if (string.IsNullOrEmpty(name))
                throw new ArgumentException("Name null veya bosh ola bilmez.");

            Name = name;
        }
    }
}
