using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MoyasimonClicker
{
    public partial class PetriDishControl : UserControl
    {
        //...........podaci...........
        private int playerpoints;
        private int pointsaddedperround;

        //...........path...............
        private string path;

        //event handler za bakterije neke vr
        public event EventHandler<Bacteria> bacteriacolony;

        //konstruktor
        public PetriDishControl()
        {
            InitializeComponent();
        }

        //logistika
        private void buyClicked(object sender, EventArgs e)
        {
            //ako u igri ima manje PlayerPoints nego sto je cijena bakterij, vrati
            if (playerpoints < PriceLabel) return;

            //ako nije, kupi bakteriju
            HowManyLabel += 1;
            //ako je kolonija bakterija bila prazna, lupi novu bakteriju u nju
            if (bacteriacolony != null)
                bacteriacolony(sender, new Bacteria { Price = PriceLabel, HowMany = HowManyLabel, Name = base.Name, Points = playerpoints });

        }



        //..............................svojstva......................
        public string NameLabel
        {
            set { nameLabel.Text = "Species name: " + value; }
            get { return nameLabel.Text; }
        }

        public int HowManyLabel
        {
            set { howmanyLabel.Text = "Number of: " + value.ToString(); }
            get { return int.Parse(howmanyLabel.Text.Split(' ')[2]); }
        }

        public int PriceLabel
        {
            set { priceLabel.Text = "Price: " + value.ToString(); }
            get { return int.Parse(priceLabel.Text.Split(' ')[1]); }
        }

        public int PlayerPoints
        {
            set { playerpoints = value; }
        }

        public int PointsAddedPerRound
        {
            set { pointsaddedperround = value; }
            get { return pointsaddedperround; }
        }


        public Bitmap addImage
        {
            set { BacteriaPictureBox.Image = value; }
        }

        public string AddImageFromPath
        {
            set
            { 
                BacteriaPictureBox.Image = Image.FromFile(value);
                path = value;
            }
            get { return path; }
        }

        private void BacteriaPictureBox_Click(object sender, EventArgs e)
        {

        }
    }
}
