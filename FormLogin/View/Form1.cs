using FormLogin.Model;
using FormLogin.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormLogin
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btSignUp_Click(object sender, EventArgs e)
        {
            SignUp sign = new SignUp();
            sign.Show();
        }

        private void btClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btLogin_Click(object sender, EventArgs e)
        {
            Controller controller = new Controller();
            controller.Access(txLogin.Text, txPassword.Text);
            if (controller.message.Equals(""))
            {
                if (controller.have)
                {
                    MessageBox.Show("Sucess", "Connect", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Logado welcome = new Logado();
                    welcome.Show();
                }
                else
                {
                    MessageBox.Show("Login or Password Incorrect", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
                MessageBox.Show(controller.message);
            }
        }
    }
}
