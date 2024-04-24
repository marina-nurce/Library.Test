using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Test
{
    public class Books
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public int PublicationYear { get; set; }
        public string Genre { get; set; }

        //konstruktor me parameter
        public Books(string title, string author, int publicationyear, string genre)
        {
            Title = title;
            Author = author;
            PublicationYear = publicationyear;
            Genre = genre;
        }

        public Books()
        {
        }
    }
}
