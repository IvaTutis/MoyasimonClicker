using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoyasimonClicker
{
    class Player
    {
        private int playerpoints;

        //konstruktor
        public Player()
        {
            playerpoints = 0;
        }

        //.......................logistika...........

        public void incrementPoints(int b)
        {
            playerpoints+=b;
        }

        public void decrementPoints(int b) 
        {
            playerpoints -= b;
        }

        public void reset()
        {
            playerpoints = 0;
        }

        //.........................svojstva...............
        public int PlayerPoints 
        {
            get { return playerpoints; }
            set { playerpoints = value; }
        }
    }
}
