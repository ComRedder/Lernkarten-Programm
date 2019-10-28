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
    public partial class VLogin : Form
    {
        public VLogin()
        {
            InitializeComponent();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            Login();
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private bool Login()
        {
            string username = "Schueler";
            string password = "hhbk";
            bool loginProve = false;

            if (textBoxUsername.Text != username || textBoxPassword.Text != password)
            {
                Console.WriteLine("Passwort oder Benutzername ist falsch!");
            }
            else
            {
                loginProve = true;
            }

            return loginProve;
        }
    }
}
