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
    public partial class NewStudentEntry : Form
    {
        public NewStudentEntry()
        {
            InitializeComponent();
        }
        public Library l = new Library();
        private void NewStudentEntry_Load(object sender, EventArgs e)
        {

        }

        private void addSt_Click(object sender, EventArgs e)
        {
            {
                //if (l.StdntIssueBook))
                //{
                //    MessageBox.Show("Successfull");
                //}
                //else
                //{
                //    MessageBox.Show("Unsuccessfull");
                //}
            }
        }
    }
}
