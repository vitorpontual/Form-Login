using FormLogin.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormLogin.View
{
    public partial class SignUp : Form
    {
        public SignUp()
        {
            InitializeComponent();
        }

        private void btSubmit_Click(object sender, EventArgs e)
        {
            Controller request = new Controller();
            string message = request.SignUpUser(txEmail.Text, txPassword.Text, txRePassword.Text);
            if (request.have)
            {
                MessageBox.Show(message, "Sign Up", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(request.message);
            }

        }
    }
}
