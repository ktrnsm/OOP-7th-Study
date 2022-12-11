using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_7th_Study.Models
{
    public class Author
    {
        public string AuthorName { get; set; }
        public string AuthorLastName { get; set; }

        public List<Book> Books { get; set; }

        public string ReflectInfo()
        {
            return $"{AuthorName}{AuthorLastName}";

        }

    }
}
