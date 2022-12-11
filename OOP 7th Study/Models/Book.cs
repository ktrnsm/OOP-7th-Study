using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_7th_Study.Models
{
    public class Book
    {
        public string BookName { get; set; }
        public string BookType { get; set; }
        public string BookPage { get; set; }
        public Author Author { get; set; }


        public string ReflectInfo()
        {
            return $"{BookName}{BookType}{BookPage}{Author.AuthorName}{Author.AuthorLastName}";
        }

    }

    
}
