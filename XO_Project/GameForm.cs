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
    public partial class GameForm : Form
    {
        private Game g;

        public GameForm()
        {
            InitializeComponent();
            g = new Game(GamePnl, this.Picture_Click);
            
        }

        void Picture_Click(object sender, EventArgs e)
        {
            PictureBox ClickImage = sender as PictureBox;
            string[] ParseName = ClickImage.Name.Split('_');
            int i = Convert.ToInt32(ParseName[1]);
            g.gameField.ImagesField[i].Image = Image.FromFile(g.gameField.ImgNames[g.goingIndex]);
            g.gameField.ImagesField[i].Enabled = false;
            g.gameField.LogicField[i] = g.goingIndex;
            g.NextGoing();

            if(g.GameOver(WinnerLbl))
            {
                ToMenuBtn.Visible = true;
                RestartBtn.Visible = true;
                WinnerLbl.Visible = true;
                g.gameField.Lock();
            }
        }

        private void RestartBtn_Click(object sender, EventArgs e)
        {
            g.gameField.Reset();
            g.goingIndex = 1;
            ToMenuBtn.Visible = false;
            RestartBtn.Visible = false;
            WinnerLbl.Visible = false;
        }

        private void ToMenuBtn_Click(object sender, EventArgs e)
        {
            Program.menu.Show();
            this.Close();
        }

        private void GameForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Program.menu.Show();
        }
    }
}
