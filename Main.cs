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
    public partial class Main : Form
    {
        public static Boolean LoggedIn = false;
        public static Boolean formCLosed = false;
        public static String LoggedInAs;
        public int tab;
        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            lOGOUTToolStripMenuItem.Enabled = false;
        }

        public void loadForm(object Form)
        {
            if (this.pnlMain.Controls.Count > 0)
                this.pnlMain.Controls.RemoveAt(0);
            Form f = Form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.pnlMain.Controls.Add(f);
            this.pnlMain.Tag = f;
            f.Show();
        }
         public void LOGIN()
        {
            MainMenu.Enabled = false;
            loginTimer.Start();
            Login l = new Login();
            l.ShowDialog();
        }

        private void loginTimer_Tick(object sender, EventArgs e)
        {
            if (LoggedIn)
            {
                loginTimer.Stop();
                switch (tab)
                {
                    case 1:
                        loadForm(new Sales());
                        txtLoggedInAs.Visible = true;
                        txtLoggedInAs.Text += LoggedInAs;
                        break;

                    case 2:
                        loadForm(new Management());
                        break;
                }
                MainMenu.Enabled = true;
                lOGOUTToolStripMenuItem.Enabled = true;
            }
            else if (LoggedIn && formCLosed)
            {
                MainMenu.Enabled = true;
                lOGOUTToolStripMenuItem.Enabled = true;
                formCLosed = false;
            }
            else if (!LoggedIn && formCLosed)
            {
                MainMenu.Enabled = true;
                managementToolStripMenuItem.Enabled = true;
                lOGOUTToolStripMenuItem.Enabled = false;
                formCLosed = false;
            }
        }

        private void makeSaleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tab = 1;
            if (LoggedIn)
            {
                loadForm(new Sales());
                
            }
                
            else
            {
                MainMenu.Enabled = false;
                managementToolStripMenuItem.Enabled = false;
                LOGIN();
            }
                
        }

        private void inventoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lOGOUTToolStripMenuItem.Enabled = false;
            loadForm(new Products());
        }

        private void servicesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lOGOUTToolStripMenuItem.Enabled = false;
            loadForm(new Products());
        }

        private void managementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tab = 2;
            if (LoggedIn)
                loadForm(new Management());
            else
            {
                MainMenu.Enabled = false;
                LOGIN();
            }
        }

        private void eXITToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lOGOUTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoggedIn = false;
            txtLoggedInAs.Text = "Logged in as: ";
            txtLoggedInAs.Visible = false;
            if (this.pnlMain.Controls.Count > 0)
                this.pnlMain.Controls.RemoveAt(0);
            lOGOUTToolStripMenuItem.Enabled = false;
            managementToolStripMenuItem.Enabled = true; ;
        }
    }
}
