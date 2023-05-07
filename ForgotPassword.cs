using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace FOTOFIRST
{
    public partial class ForgotPassword : Form
    {
        public ForgotPassword()
        {
            InitializeComponent();
        }
        SqlConnection connection = new SqlConnection(@"Data Source=146.230.177.46;Initial Catalog=GroupPmb14;User ID=GroupPmb14;Password=cmsv69");

        public static class Global
        {
            public static int count = 0;
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            string username, position;
            //int count;
           
            username = txtUsername.Text;
            position = txtPosition.Text;
            //Global.count = 0;
               
            if(username == "" || position == "" || username == " " || position == " ")
            {
                MessageBox.Show("Details are missing. Please fill in all details.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //count= count + 1;
                //txtUsername.Clear();
                txtPosition.Clear();
                txtUsername.Focus();
            }
            else
            {
                try
                {
                    connection.Open();
                    String qry = "SELECT * FROM LoginDetails WHERE username='" + username + "' AND user_type='" + position + "'";
                    SqlDataAdapter sda = new SqlDataAdapter(qry, connection);
                    DataTable dtable = new DataTable();
                    sda.Fill(dtable);

                    if (dtable.Rows.Count > 0)
                    {
                        Sales formNew = new Sales();
                        formNew.Show();
                        this.Hide();

                    }
                    else
                    {
                        MessageBox.Show("Details not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        Global.count = Global.count + 1;
                        txtUsername.Clear();
                        txtPosition.Clear();
                        txtUsername.Focus();
                    }

                    if(Global.count >= 3)
                    {
                        MessageBox.Show("You have been locked out.\nNumber of tries have been exceeded.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        this.Hide();
                    }
                }
                catch
                {
                    MessageBox.Show("Error");
                } //catch end
                finally
                {
                    connection.Close();
                } // finally end
                
            }// if else end
            
        }
    }
}
