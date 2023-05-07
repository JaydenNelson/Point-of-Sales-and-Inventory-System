using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FOTOFIRST
{
    public partial class frmForgot : Form
    {
        public frmForgot()
        {
            InitializeComponent();
        }

        private void btnForgotConfirm_Click(object sender, EventArgs e)
        {
            string forgotUsername, forgotPosition;

            forgotUsername = txtForgotUsername.Text;
            forgotPosition = txtForgotPosition.Text;


        }
    }
}
