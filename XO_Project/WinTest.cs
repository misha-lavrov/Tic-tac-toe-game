using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XO_Project
{
    class WinTest
    {
        public int[,] WinCombinations =
        {
            {1, 1, 1,
             0, 0, 0,
             0, 0, 0},

            {0, 0, 0,
             1, 1, 1,
             0, 0, 0},

            {0, 0, 0,
             0, 0, 0,
             1, 1, 1},

            {1, 0, 0,
             1, 0, 0,
             1, 0, 0},

            {0, 1, 0,
             0, 1, 0,
             0, 1, 0},

            {0, 0, 1,
             0, 0, 1,
             0, 0, 1},

            {1, 0, 0,
             0, 1, 0,
             0, 0, 1},

            {0, 0, 1,
             0, 1, 0,
             1, 0, 0}
        };

        public WinTest()
        {

        }

        public bool isWinner(int[] LogicField, int Player)
        {
            int isWin = 0;
            for(int i = 0; i <= WinCombinations.GetUpperBound(0); i++)
            {
                isWin = 0;
                for (int j = 0; j < LogicField.Length; j++)
                {
                    if(WinCombinations[i,j] == 1 &&
                        LogicField[j] == Player)
                    {
                        isWin++;
                    }
                    if (isWin == 3)
                        return true;
                }
            }
            return false;
        }
    }
}
