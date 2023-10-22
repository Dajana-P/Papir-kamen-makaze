using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Papir__kamen__makaze
{
    public partial class PapirKamenMakaze : Form
    {
        Random rand = new Random();
        public PapirKamenMakaze()
        {
            InitializeComponent();
            lblWinner.Text = "";
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            int rbrL = RandomNumber();
            int rbrR = RandomNumber();
            pBLeft.Image = GetImage(rbrL);
            pBRight.Image = GetImage(rbrR);
            lblWinner.Text = Winner(rbrL, rbrR);
        }

        private Image GetImage(int br)
        {
            Image pic;
            switch (br)
            {
                case 1 : pic = Properties.Resources.p; //papir = 1
                    break;
                case 2 : pic = Properties.Resources.r; //kamen = 2
                    break;
                case 3 : pic = Properties.Resources.s; //makaze = 3
                    break;
                default : pic = Properties.Resources.img;
                    break;
            }
            return pic;
        }
        private int RandomNumber()
        {
            return rand.Next(1, 4);
        }
        
        private String Winner(int brL, int brR)
        {
            if((brL == 1 && brR == 2) || (brL == 2 && brR == 1))
            {
                return "Papir je pobedio";
            }
            else if((brL == 1 && brR == 3) || (brL == 3 && brR == 1))
            {
                return "Makaze su pobedile";
            }
            else if ((brL == 2 && brR == 3) || (brL == 3 && brR == 2))
            {
                return "Kamen je pobedio";
            }
            else
            {
                return "Nereseno";
            }
        }

        private void PapirKamenMakaze_Load(object sender, EventArgs e)
        {

        }
    }
}
