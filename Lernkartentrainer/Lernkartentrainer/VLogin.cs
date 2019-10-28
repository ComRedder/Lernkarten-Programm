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
    public partial class VLogin : Form , IView
    {
        private int loginProve = 2;
        public VLogin()
        {
            InitializeComponent();
            textBoxPassword.PasswordChar = '*';
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            loginProve = Login();
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private int Login()
        {
            string username = "Schueler";
            string password = "hhbk";

            if (textBoxUsername.Text != username || textBoxPassword.Text != password)
            {
                MessageBox.Show("Passwort oder Benutzername ist falsch!");
            }
            else
            {
                MessageBox.Show("Login erfolgt!");
                loginProve = 1;
                this.Close();
            }

            return loginProve;
        }

        int IView.LoginBool
        {
            get { return loginProve; }
            set { loginProve = value; }
        }

        public VLogin(int loginbool)
        {
            (this as IView).LoginBool = loginbool;
        }
    }
}
