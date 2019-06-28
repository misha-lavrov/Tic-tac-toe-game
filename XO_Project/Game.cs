using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XO_Project
{
    class Game 
    {
        public GameField gameField;
        public WinTest winTest;
        public int goingIndex;

        public Game(Panel gamePanel, EventHandler e)
        {
            goingIndex = 1;
            gameField = new GameField(gamePanel, e);
            winTest = new WinTest();
        }

        public void NextGoing()
        {
            if (goingIndex == 1)
                goingIndex = 2;
            else
                goingIndex = 1;
        }

        public bool GameOver(Label l)
        {
            if (winTest.isWinner(gameField.LogicField, 1))
            {
                l.Text = "ХРЕСТИКИ перемогли";
                return true;
            }

            if (winTest.isWinner(gameField.LogicField, 2))
            {
                l.Text = "НУЛИКИ перемогли";
                return true;
            }

            bool canGo = false;
            foreach (int f in gameField.LogicField)
            {
                if (f == 0)
                {
                    canGo = true;
                    break;
                }
            }

            if (!canGo)
            {
                l.Text = "Нічия";
                return true;
            }

            return false;
        }
    }
}
