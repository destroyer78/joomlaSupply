using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace joomShoppingSupply
{
    public partial class Registration : Form
    {
        string login;
        string pass;
        public Registration()
        {
            InitializeComponent();
        }

        private void btReg_Click(object sender, EventArgs e)
        {
            getReg();   
        }
        private void getReg()
        {
            if (tbLogin.TextLength < 5) return;
            if (tbPassword.TextLength < 5) return;
            login = tbLogin.Text;
            pass = tbPassword.Text;
            this.DialogResult = DialogResult.Yes;
            this.Close();
        }
        public string getLogin() { return login; }
        public string getPassword() { return pass; }

        private void tbLogin_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (tbLogin.TextLength < 5) return;
                tbPassword.Focus();
            }
            
        }

        private void tbPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                getReg();
            }
            
        }
    }
}
