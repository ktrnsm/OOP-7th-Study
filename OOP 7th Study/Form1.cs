using OOP_7th_Study.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_7th_Study
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Book b = new Book()
            {

                BookName=textBox1.Text,
                BookType=textBox2.Text,
                BookPage=textBox3.Text,
            };
            Author a = new Author
            {
                AuthorName=textBox4.Text,
                AuthorLastName=textBox5.Text
            };

            b.Author = a;
            a.Books= new List<Book>();
            a.Books.Add(b);
            listBox1.Items.Add(b.ReflectInfo());
        }
    }
}
