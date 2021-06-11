using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace MoyasimonClicker
{

    public partial class Form1 : Form
    {
        //bodovi
        Player p;

        //usercontrol
        PetriDishControl GreenFungiControl;
        PetriDishControl OryzaeControl;
        PetriDishControl CladosporiumControl;

        //flags
        bool oryzae;
        bool cladosporium;
        bool greenfungi;

        //music player
        System.Media.SoundPlayer soundplayer = new System.Media.SoundPlayer(Properties.Resources.Music);

        public Form1()
        {
            InitializeComponent();

            //da nam se pri restartu nove igre ne pokrece ponovno ga stavljam tu
            soundplayer.PlayLooping();
        }

        //funkcija koja (re)inicijalizira igru
        private void Form1_Load(object sender, EventArgs e)
        {
            //forma
            FormBorderStyle = FormBorderStyle.None;
            WindowState = FormWindowState.Maximized;
            splitContainer1.SplitterDistance = this.Width/3;
            splitContainer2.SplitterDistance = this.Width/3;
            clickButton.Width = this.Width / 6;

            //inicijaliziram igraca
            p = new Player();

            //inicijaliziram kontrole
            GreenFungiControl = new PetriDishControl();
            OryzaeControl = new PetriDishControl();
            CladosporiumControl = new PetriDishControl();

            //inicijaliziram zastavice
            oryzae = false;
            greenfungi = false;
            cladosporium = false;


            //imena
            GreenFungiControl.NameLabel = "Green Fungi";
            OryzaeControl.NameLabel = "Oryzae";
            CladosporiumControl.NameLabel = "Claudosporium";

            //HowManyLabel PlayerPoints dodaju
            GreenFungiControl.PointsAddedPerRound = 5;
            OryzaeControl.PointsAddedPerRound = 10;
            CladosporiumControl.PointsAddedPerRound = 15;

            //inicijaliziram HowManyLabel one registriraju da ima ukupno PlayerPoints u igri
            GreenFungiControl.PlayerPoints = 0;
            CladosporiumControl.PlayerPoints = 0;
            OryzaeControl.PlayerPoints = 0;

            //updateam cijene
            GreenFungiControl.PriceLabel = 5;
            OryzaeControl.PriceLabel = 10;
            CladosporiumControl.PriceLabel = 20;

            //updateam HowManyLabel ih ima 
            GreenFungiControl.HowManyLabel = 0;
            OryzaeControl.HowManyLabel = 0;
            CladosporiumControl.HowManyLabel = 0;


            //updateam event handlere
            GreenFungiControl.bacteriacolony += (_sender, _e) =>
            {

                p.PlayerPoints -= GreenFungiControl.PriceLabel;
                GreenFungiControl.HowManyLabel = _e.HowMany;
                GreenFungiControl.PriceLabel += 5;

                GreenFungiControl.PlayerPoints = p.PlayerPoints;
                writeText(_e);
            };

            CladosporiumControl.bacteriacolony += (_sender, _e) =>
            {

                p.PlayerPoints -= CladosporiumControl.PriceLabel;
                CladosporiumControl.HowManyLabel = _e.HowMany;
                CladosporiumControl.PriceLabel += 5;

                CladosporiumControl.PlayerPoints = p.PlayerPoints;
                writeText(_e);
            };

            OryzaeControl.bacteriacolony += (_sender, _e) =>
            {
                //oduzimam broj PlayerPoints
                p.PlayerPoints -= CladosporiumControl.PriceLabel;

                //pisem u labele
                OryzaeControl.HowManyLabel = _e.HowMany;
                OryzaeControl.PriceLabel += 5;

                CladosporiumControl.PlayerPoints = p.PlayerPoints;
                writeText(_e);
            };


            //.......................grafika...................
            //dodajem slike
            GreenFungiControl.addImage = Properties.Resources.green_fungi;
            OryzaeControl.addImage = Properties.Resources.orizae;
            CladosporiumControl.addImage = Properties.Resources.cladosporium;

            //stil kontrola za docking
            GreenFungiControl.Dock = DockStyle.Top;
            OryzaeControl.Dock = DockStyle.Top;
            CladosporiumControl.Dock = DockStyle.Top;

            writeText("New game. Objective: Collect Bacteria!");

        }

        //funkcija koja obradjuje stisak gumba na toolstripu
        private void NewGameClicked(object sender, EventArgs e)
        {
            splitContainer2.Panel1.Controls.Clear();
            textBox1.Text = "";

            Form1_Load(sender, e);
        }

        //-----------------------------------BODOVI KROZ VRIJEME-------------
        //funkcija koja obradjuje stisak clicker gumba
        private void ClickMeClicked(object sender, EventArgs e)
        {
            IncrementPointsBy(1);
        }

        //glavni timer igre
        private void timer1_Tick(object sender, EventArgs e)
        {
            //dodaj bodove od farmanja
            int added_points = GreenFungiControl.HowManyLabel * GreenFungiControl.PointsAddedPerRound
                                + OryzaeControl.HowManyLabel * OryzaeControl.PointsAddedPerRound
                                + CladosporiumControl.HowManyLabel * CladosporiumControl.PointsAddedPerRound;

            //updateaj bodove
            IncrementPointsBy(added_points);
        }

        //funkcija koja updatea bodove u kontrolama i labelu
        private void IncrementPointsBy(int b)
        {
            p.incrementPoints(b);

            //prosljedujem ukupan broj PlayerPoints kontrolama
            GreenFungiControl.PlayerPoints = p.PlayerPoints;
            OryzaeControl.PlayerPoints = p.PlayerPoints;
            CladosporiumControl.PlayerPoints = p.PlayerPoints;

            //pisem u label isti broj PlayerPoints
            pointsLabel.Text = "Bacteria number: " + p.PlayerPoints.ToString();
        }

        //funkcija koja updatea bodove u kontrolama i labelu
        private void DecrementPointsBy(int b)
        {
            p.decrementPoints(b);

            //prosljedujem ukupan broj PlayerPoints kontrolama
            GreenFungiControl.PlayerPoints = p.PlayerPoints;
            OryzaeControl.PlayerPoints = p.PlayerPoints;
            CladosporiumControl.PlayerPoints = p.PlayerPoints;

            //pisem u label isti broj PlayerPoints
            pointsLabel.Text = "Bacteria number: " + p.PlayerPoints.ToString();
        }

        //------------------------------KREIRANJE NOVE IGRE---------------

        private void writeText(Bacteria e)
        {
            DateTime dt = DateTime.Now;
            textBox1.Text += dt.ToString("hh:mm") + " " + "  New number " + e.Name + ": " + e.HowMany + Environment.NewLine;
        }

        private void writeText(string s)
        {
            DateTime dt = DateTime.Now;
            textBox1.Text += dt.ToString("hh-mm") +"  "+ s + Environment.NewLine;
        }

        private void pointsLabelChanged(object sender, EventArgs e)
        {

            //dodaj oryzae ako vec nisu
            if (!oryzae && OryzaeControl.PriceLabel <= p.PlayerPoints)
            {
                oryzae = true;
                splitContainer2.Panel2.Controls.Add(OryzaeControl);
            }
           
            if (!cladosporium && CladosporiumControl.PriceLabel <= p.PlayerPoints)
            {
                cladosporium = true;
                splitContainer2.Panel2.Controls.Add(CladosporiumControl);
            }

            if (!greenfungi && GreenFungiControl.PriceLabel <= p.PlayerPoints)
            {
                greenfungi = true;
                splitContainer2.Panel2.Controls.Add(GreenFungiControl);
            }
        }

    }

}

