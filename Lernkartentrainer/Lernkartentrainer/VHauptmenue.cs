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
    public partial class VHauptmenue : Form
    {
        double anzahl;
        double anzahlGesamt;
        double a;
        double b;
        bool pruefWert;

        public VHauptmenue()
        {
            InitializeComponent();
            pnlSideAuswahl.Height = buttonUebersicht.Height;
            pnlSideAuswahl.Top = buttonUebersicht.Top;
            pnlUebersicht.Visible = true;
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            VLogin openForm = new VLogin();
            openForm.Show();
        }

        private void buttonEditor_Click(object sender, EventArgs e)
        {
            VEditorVSC openForm = new VEditorVSC();
            openForm.Show();
        }

        private void buttonEditorXML_Click(object sender, EventArgs e)
        {
            VEditorXML openForm = new VEditorXML();
            openForm.Show();
        }

        private void buttonUebersicht_Click(object sender, EventArgs e)
        {
            pnlSideAuswahl.Height = buttonUebersicht.Height;
            pnlSideAuswahl.Top = buttonUebersicht.Top;
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
            pnlSideAuswahl.Top = buttonFach1.Top;
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
            pnlSideAuswahl.Top= buttonFach2.Top;
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
            pnlSideAuswahl.Top = buttonFach3.Top;
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
            pnlSideAuswahl.Top = buttonFach4.Top;
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
            pnlSideAuswahl.Top = buttonFach5.Top;
            pnlUebersicht.Visible = false;
            pnlFach1.Visible = false;
            pnlFach2.Visible = false;
            pnlFach3.Visible = false;
            pnlFach4.Visible = false;
            pnlFach5.Visible = true;
        }

        private void buttonF5Start_Click(object sender, EventArgs e)
        {
            anzahl = 20;
            anzahlGesamt = 30;
            pruefWert = AnzahlGeprueft(anzahl, anzahlGesamt);
            if (pruefWert == true)
            {
                buttonF5Start.Enabled = true;
            }
            else
            {
                buttonF5Start.Enabled = false;
            }
            VKarteikarten openForm = new VKarteikarten();
            openForm.Show();
        }

        private void buttonF4Start_Click(object sender, EventArgs e)
        {
            anzahl = 20;
            anzahlGesamt = 30;
            pruefWert = AnzahlGeprueft(anzahl, anzahlGesamt);
            if (pruefWert == true)
            {
                buttonF4Start.Enabled = true;
            }
            else
            {
                buttonF4Start.Enabled = false;
            }

            VKarteikarten openForm = new VKarteikarten();
            openForm.Show();
        }

        private void buttonF3Start_Click(object sender, EventArgs e)
        {
            anzahl = 20;
            anzahlGesamt = 30;
            pruefWert = AnzahlGeprueft(anzahl, anzahlGesamt);
            if (pruefWert == true)
            {
                buttonF3Start.Enabled = true;
            }
            else
            {
                buttonF3Start.Enabled = false;
            }

            VKarteikarten openForm = new VKarteikarten();
            openForm.Show();
        }

        private void buttonF2Start_Click(object sender, EventArgs e)
        {
            anzahl = 20;
            anzahlGesamt = 30;
            pruefWert = AnzahlGeprueft(anzahl, anzahlGesamt);
            if (pruefWert == true)
            {
                buttonF2Start.Enabled = true;
            }
            else
            {
                buttonF2Start.Enabled = false;
            }

            VKarteikarten openForm = new VKarteikarten();
            openForm.Show();
        }

        private void buttonF1Start_Click(object sender, EventArgs e)
        {
            VKarteikarten openForm = new VKarteikarten();
            openForm.Show();
        }

        private static bool AnzahlGeprueft(double anzahl, double anzahlGesamt)
        {
            bool pruefErgebniss = false;

            double zwischenproof = (100 * anzahl) / anzahlGesamt;
            if (zwischenproof >= 60)
            {
                pruefErgebniss = true;
            }
            return pruefErgebniss;
        }
    }
}
