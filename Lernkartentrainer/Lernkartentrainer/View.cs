using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lernkartentrainer
{
    public partial class View : Form
    {
        public View()
        {
            InitializeComponent();
            pnlSideAuswahl.Height = buttonUebersicht.Height;
            pnlUebersicht.Visible = true;
        }

        private void buttonUebersicht_Click(object sender, EventArgs e)
        {
            pnlSideAuswahl.Height = buttonUebersicht.Height;
            pnlUebersicht.Visible = true;
            pnlFach1.Visible = false;
            pnlFach2.Visible = false;
            pnlFach3.Visible = false;
            pnlFach4.Visible = false;
            pnlFach5.Visible = false;
        }

        private void buttonFach1_Click(object sender, EventArgs e)
        {
            pnlSideAuswahl.Height = buttonFach2.Height;
            pnlUebersicht.Visible = false;
            pnlFach1.Visible = true;
            pnlFach2.Visible = false;
            pnlFach3.Visible = false;
            pnlFach4.Visible = false;
            pnlFach5.Visible = false;
        }

        private void buttonFach2_Click(object sender, EventArgs e)
        {
            pnlSideAuswahl.Height = buttonFach2.Height;
            pnlUebersicht.Visible = false;
            pnlFach1.Visible = false;
            pnlFach2.Visible = true;
            pnlFach3.Visible = false;
            pnlFach4.Visible = false;
            pnlFach5.Visible = false;
        }

        private void buttonFach3_Click(object sender, EventArgs e)
        {
            pnlSideAuswahl.Height = buttonFach3.Height;
            pnlUebersicht.Visible = false;
            pnlFach1.Visible = false;
            pnlFach2.Visible = false;
            pnlFach3.Visible = true;
            pnlFach4.Visible = false;
            pnlFach5.Visible = false;
        }

        private void buttonFach4_Click(object sender, EventArgs e)
        {
            pnlSideAuswahl.Height = buttonFach4.Height;
            pnlUebersicht.Visible = false;
            pnlFach1.Visible = false;
            pnlFach2.Visible = false;
            pnlFach3.Visible = false;
            pnlFach4.Visible = true;
            pnlFach5.Visible = false;
        }

        private void buttonFach5_Click(object sender, EventArgs e)
        {
            pnlSideAuswahl.Height = buttonFach5.Height;
            pnlUebersicht.Visible = false;
            pnlFach1.Visible = false;
            pnlFach2.Visible = false;
            pnlFach3.Visible = false;
            pnlFach4.Visible = false;
            pnlFach5.Visible = true;
        }

        private void buttonF5Start_Click(object sender, EventArgs e)
        {

        }

        private void buttonF4Start_Click(object sender, EventArgs e)
        {

        }

        private void buttonF3Start_Click(object sender, EventArgs e)
        {

        }

        private void buttonF2Start_Click(object sender, EventArgs e)
        {

        }

        private void buttonF1Start_Click(object sender, EventArgs e)
        {

        }
    }
}
