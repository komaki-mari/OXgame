using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OXgame
{
    class Player
    {
        public int PlayerO;
        public int PlayerX;

        public Player(int O, int X)
        {
            this.PlayerO = O;
            this.PlayerX = X;
        }

        public void GameWin(int O, int X)
        {
            this.PlayerO = PlayerO + O;
            this.PlayerX = PlayerX + X;
        }
    }

   
}
