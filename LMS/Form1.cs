using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using System.Runtime.Serialization;

namespace LMS
{
    public partial class welcomForm : Form
    {
        public welcomForm()
        {
            InitializeComponent();
        }
        public User[] arr = new User[0];
        public User Librarian = new User("","");
        public LibraryPanel lp = new LibraryPanel();

        private void Login_Click(object sender, EventArgs e)
        {
            if (Librarian.Name == LgnName.Text && Librarian.ID == LgnPassword.Text)
            {
                this.Hide();
                lp.Show();
            }
            else
            {
                MessageBox.Show("Wrong Username or password");
            }
        }
        private void welcomForm_Load(object sender, EventArgs e)
        {
            //arr[0] = Librarian;

            //FileStream fs = new FileStream("file.dat", FileMode.Open);
            //BinaryFormatter frmttr = new BinaryFormatter();
            //arr = (User[])frmttr.Deserialize(fs);
            ////Library.collection[0] = (Book)frmttr.Deserialize(fs);
            //fs.Close();


            //FileStream fs = new FileStream("BOOKS.dat", FileMode.Open);
            //BinaryFormatter frmttr = new BinaryFormatter();
            //Library.collection = (Book[])frmttr.Deserialize(fs);
            //fs.Close();
        }

        private void welcomForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            //FileStream fs = new FileStream("file.dat", FileMode.Create);
            //BinaryFormatter frmttr = new BinaryFormatter();
            //frmttr.Serialize(fs, arr);
            //fs.Close();
            ////frmttr.Serialize(fs, Library.collection[0].Title);

            FileStream fs = new FileStream("BOOKS.dat", FileMode.Create);
            BinaryFormatter frmttr = new BinaryFormatter();
            frmttr.Serialize(fs, Library.collection);
            fs.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
