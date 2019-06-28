using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XO_Project
{
    class GameField
    {
        public PictureBox[] ImagesField;
        public int[] LogicField = { 0, 0, 0,
                                    0, 0, 0,
                                    0, 0, 0
                                   };
        public string[] ImgNames = { "space.png",
                                     "cross.jpg",
                                     "zero.png"
                                    };

        public GameField(Panel gamePanel, EventHandler e)
        {
            InitializeGameField(gamePanel, e);
        }

        public void InitializeGameField(Panel gamePanel, EventHandler e)
        {
            ImagesField = new PictureBox[9];
            int PicHeigth = 100;
            int PicWidth = 100;
            String PicName = "Pic_";
            int i = 0;
            for(int x = 0; x < 3; x++)
            {
                for(int y = 0; y < 3; y++)
                {
                    ImagesField[i] = new PictureBox()
                    {
                        Name = PicName + i,
                        Height = PicHeigth,
                        Width = PicWidth,
                        Image = Image.FromFile(ImgNames[0]),
                        SizeMode = PictureBoxSizeMode.StretchImage,
                        Location = new Point(x * PicWidth, y * PicHeigth)
                    };
                    ImagesField[i].Click += e;
                    gamePanel.Controls.Add(ImagesField[i]);
                    i++;
                }
            }
        }
        
        public void Reset()
        {
            LogicField = new int[] { 0, 0, 0, 0, 0, 0, 0, 0, 0 };
            foreach (PictureBox p in ImagesField)
            {
                p.Image = Image.FromFile(ImgNames[0]);
                p.Enabled = true;
            }
        }

        public void Lock()
        {
            foreach (PictureBox p in ImagesField)
                p.Enabled = false;
        }
    }
}
