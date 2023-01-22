using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp25
{
    internal class Book
    {
        internal string Name;
        internal string AuthorName;
        internal int PublishedDate;
        internal int PageCount;



        public override string ToString()
        {
            return $"{Name} {AuthorName} {PublishedDate} {PageCount}";
        }
    }

    internal class Book2
    {
        internal string Name;
        internal string AuthorName;
        internal int PublishedDate;
        internal int PageCount;
    }
}
