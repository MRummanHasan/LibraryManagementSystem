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
    public partial class IssueBook : Form
    {
        public IssueBook()
        {
            InitializeComponent();
        }

        public Library l = new Library();
        private void button1_Click(object sender, EventArgs e)
        {
            if (l.StdntIssueBook(issueStIDbox.Text, issueStNameBox.Text))
            {
                MessageBox.Show("Successfull");
            }
            else
            {
                MessageBox.Show("Unsuccessfull");
            }
        }
    }
}
