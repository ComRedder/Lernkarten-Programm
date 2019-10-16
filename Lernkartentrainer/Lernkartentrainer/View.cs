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
            panelSide.Height = buttonUebersicht.Height;
        }

        private void buttonUebersicht_Click(object sender, EventArgs e)
        {
            panelSide.Height = buttonUebersicht.Height;
        }

        private void buttonFach1_Click(object sender, EventArgs e)
        {
            panelSide.Height = buttonFach1.Height;
        }

        private void buttonFach2_Click(object sender, EventArgs e)
        {
            panelSide.Height = buttonFach2.Height;
        }

        private void buttonFach3_Click(object sender, EventArgs e)
        {
            panelSide.Height = buttonFach3.Height;
        }

        private void buttonFach4_Click(object sender, EventArgs e)
        {
            panelSide.Height = buttonFach4.Height;
        }

        private void buttonFach5_Click(object sender, EventArgs e)
        {
            panelSide.Height = buttonFach5.Height;
        }
    }
}
