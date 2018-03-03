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
    public partial class DeleteBook : Form
    {
        public DeleteBook()
        {
            InitializeComponent();
        }
        public Library l;

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            try
            {
                l.DeleteBook(deleteBox.Text);
            }
            catch (Exception)
            {
                MessageBox.Show(Library.collection[0].ISBN);
            }

            for (int i = 0; i < Library.collection.Length; i++)
            {
                if (Library.collection[0] != null)
                {
                    Library.collection[0] = null;
                }
            }
        }
    }
}
