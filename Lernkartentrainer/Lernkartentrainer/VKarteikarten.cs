﻿using System;
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
    public partial class VKarteikarten : Form
    {
        bool approved;

        public VKarteikarten()
        {
            InitializeComponent();
            buttonNext.Enabled = false;
            buttonProve.Enabled = false;

            if (textBoxVokabelInput.Text != null)
            {
                buttonProve.Enabled = true;
            }
        }

        private void buttonProve_Click(object sender, EventArgs e)
        {
            approved = Prove(textBoxVokabelInput.Text);
            if (approved == true || approved == false)
            {
                buttonNext.Enabled = true;
            }
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private bool Prove(string text)
        {
            string a = "Hallo";
            bool proved;

            if (textBoxVokabelInput.Text == a)
            {
                proved = true;
            }
            else
            {
                proved = false;
            }
            return proved;
        }
    }
}
