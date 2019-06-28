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
    public partial class MenuForm : Form
    {
        public MenuForm()
        {
            InitializeComponent();
        }

        private void StartBtn_Click(object sender, EventArgs e)
        {
            Program.game = new GameForm();
            Program.game.StartPosition = FormStartPosition.CenterScreen;
            Program.game.Show();
            this.Hide();
        }
        
        private void AboutBtn_Click(object sender, EventArgs e)
        {
            Program.info = new InfoForm();
            Program.info.StartPosition = FormStartPosition.CenterScreen;
            Program.info.Show();
            this.Hide();
        }

        private void InfoBtn_Click(object sender, EventArgs e)
        {
            Program.about = new AboutForm();
            Program.about.StartPosition = FormStartPosition.CenterScreen;
            Program.about.Show();
            this.Hide();
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}
