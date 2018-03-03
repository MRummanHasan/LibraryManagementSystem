using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace LMS
{
    public partial class LibraryPanel : Form
    {
        public LibraryPanel()
        {
            InitializeComponent();
        }
        public Library l = new Library();
        public Book b;
        NewBookEntry newbook = new NewBookEntry();
        DeleteBook del = new DeleteBook();
        public Student[] bookworm;
        NewStudentEntry newStudent = new NewStudentEntry();
        IssueBook ib = new IssueBook();

        private void Search_Click(object sender, EventArgs e)
        {
            string rm;
            
            rm = l.SearchBook(searchBar.Text);
            int rm2 = Convert.ToInt32(rm);
            if (rm2 == -1)
            {
                MessageBox.Show("Not Found");
            }
            else if (rm != null)
            {
                srchISBNBox.Text = Library.collection[rm2].ISBN;
                srchTitleBoxTxt.Text = Library.collection[rm2].Title;
                srchAuthorBoxTxt.Text = Library.collection[rm2].Author;
           
            }


            try
            {
                ib.Show();
            }
            catch (Exception)
            {
            }
        }

        private void LibraryPanel_Load(object sender, EventArgs e)
        {
           // b = new Book("1", "rumman", "khan");

            Library.collection[0] = new Book("1","12345678901234567", "rumman", "khan");
            Library.collection[1] = new Book("2","222", "waqar", "khan");
            Library.collection[2] = new Book("3","333", "rayyan", "khan");

        }
        private void LibraryPanel_FormClosing(object sender, FormClosingEventArgs e)
        {
        }

        private void addNewBookToolStripMenuItem_Click(object sender, EventArgs e){}
        private void addNewBookToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            try
            {
                newbook.Show();
            }
            catch (Exception)
            {
            }
            
        }

        private void deleteBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            del.Show();
        }

        private void addNewStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            newStudent.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
