using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XO_Project
{
    public partial class AboutForm : Form
    {
        public AboutForm()
        {
            InitializeComponent();
        }

        private void ToMenuBtn_Click(object sender, EventArgs e)
        {
            Program.menu.Show();
            this.Close();
        }

        private void AboutForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Program.menu.Show();
        }
    }
}
