using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LMS
{
    public partial class NewBookEntry : Form
    {
        public NewBookEntry()
        {
            InitializeComponent();
        }
        public Book kitab = new Book();
        public Library l = new Library();
        private void AddBook_Click(object sender, EventArgs e)
        {

            if (kitab.checkIfEmpty(AccNoBox.Text, ISBNBox.Text, TitleBox.Text, AuthorBox.Text))
            {
                kitab = new Book(AccNoBox.Text, ISBNBox.Text, TitleBox.Text, AuthorBox.Text);
            }
            else
            {
                MessageBox.Show("Fill kar bey");
            }
            
            //try
            //{
            //    l.AddBook(kitab);
            //}s
            //catch (Exception)
            //{
            //}

            for (int i = 0; i < Library.collection.Length; i++)
            {
                if (Library.collection[i] != null)
                {
                    Library.collection[i] = kitab;
                }
            }
            MessageBox.Show( "Book is available " + Convert.ToString(kitab.Available));
            //MessageBox.Show(Library.collection[0].Title + " " + Library.collection[0].ISBN + " " + Library.collection[0].Author);
        }

        private void NewBookEntry_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void AuthorBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void TitleBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void ISBNBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
