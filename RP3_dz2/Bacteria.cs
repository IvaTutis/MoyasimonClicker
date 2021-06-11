using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoyasimonClicker
{
    public class Bacteria
    {
        private string name;
        private int points;
        private int price;
        private int how_many;

        //.........svojstva...............
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int Points 
        {
            get { return points; }
            set { points = value; }
        }

        public int Price
        {
            get { return price; }
            set { price = value; }
        }

        public int HowMany 
        {
            get { return how_many; }
            set { how_many = value; }
        }
    }
}
