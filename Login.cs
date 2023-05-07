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
    
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        SqlConnection connection = new SqlConnection(@"Data Source=146.230.177.46;Initial Catalog=GroupPmb14;User ID=GroupPmb14;Password=cmsv69");

        void LOGIN()
        {
            //try
            {
                /*String qry = "SELECT * FROM LoginDetails WHERE Username = '" + txtUsername.Text + "' AND Password = '" + txtPassword.Text + "' ";
                SqlDataAdapter sda = new SqlDataAdapter(qry, connection);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                
                 connection.Open();
                SqlCommand qry;
                SqlDataReader dr;
                 */

                connection.Open();
                SqlCommand qry = new SqlCommand("SELECT * FROM LoginDetails2, Employee2 WHERE LoginDetails2.username = '" 
                    + txtUsername.Text+ "' AND LoginDetails2.password = '" + txtPassword.Text+"' " +
                    "AND Employee2.login_ID=LoginDetails2.login_ID", connection);
                SqlDataReader dr = qry.ExecuteReader();
                dr.Read();

                if (dr.HasRows)
                {
                    Main.LoggedIn = true;
                    Main.LoggedInAs = dr["name"].ToString();
                    Sales.EmployeeID = dr["employee_ID"].ToString();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Invalid Username or Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtUsername.Clear();
                    txtPassword.Clear();
                    txtUsername.Focus();
                }

                /*if (dt.Rows.Count > 0)
                {
                    Main.LoggedIn = true;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Invalid Username or Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtUsername.Clear();
                    txtPassword.Clear();
                    txtUsername.Focus();
                }*/
            }
           // catch
            {
             //   MessageBox.Show("Error");
            }
           // finally
            {
                connection.Close();
            }
        }

        internal static void ActiveForm()
        {
            throw new NotImplementedException();
        }

        private void txtUsername_KeyDown(object sender, KeyEventArgs e)
        {
            if (txtUsername.Text !="" && e.KeyCode == Keys.Enter) txtPassword.Focus();
        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                LOGIN();
            }
            
            //------------------------------------------------------------------------------------
            /*if (txtUsername.Text != "" && txtPassword.Text != "" && e.KeyCode == Keys.Enter)
            {
                if (txtUsername.Text == "1" && txtPassword.Text == "1")
                {
                    Main.LoggedIn = true;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("wrong!");
                    txtUsername.Clear();
                    txtPassword.Clear();
                    txtUsername.Focus();
                }
            }*/
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtUsername.Clear();
            txtPassword.Clear();
            txtUsername.Focus();
        }

        private void Login_FormClosed(object sender, FormClosedEventArgs e)
        {
            Main.formCLosed = true;
        }

        private void lblLogIn_Click(object sender, EventArgs e)
        {
            LOGIN();
        }


        private void lnkForgotPassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ForgotPassword form = new ForgotPassword();
            form.Show();
            //this.Hide();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
