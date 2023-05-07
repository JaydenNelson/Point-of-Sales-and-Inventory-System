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
    public partial class Products : Form
    {
        SqlConnection connection = new SqlConnection(@"Data Source=146.230.177.46;Initial Catalog=GroupPmb14;User ID=GroupPmb14;Password=cmsv69");

        public Products()
        {
            InitializeComponent();
        }

        private void Products_FormClosed(object sender, FormClosedEventArgs e)
        {
            Main.formCLosed = true;
        }

        private void Products_Load(object sender, EventArgs e)
        {
            gbSearch.Enabled = false;
        }

        private void cmbType_SelectedIndexChanged(object sender, EventArgs e)
        {
            gbSearch.Enabled = true;
            txtSearch.Clear();
            String qry;
            connection.Open();
            SqlDataAdapter sda;
            DataTable dt;

            switch (cmbType.SelectedIndex)
            {
                case 0:
                    qry = "SELECT serial_no AS 'Serial Number', name AS 'Item Name', quantity AS 'Stock Quantity', unit_price AS 'Unit Price', description AS 'Item Description' FROM Inventory";
                    sda = new SqlDataAdapter(qry, connection);
                    dt = new DataTable();
                    sda.Fill(dt);
                    ProductData.DataSource = dt;
                    ProductData.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                    lstCategory.Items.Clear();
                    lstCategory.Items.Add("Serial Number");
                    lstCategory.Items.Add("Item Name");
                    lstCategory.Items.Add("Stock Quantity");
                    lstCategory.Items.Add("Item Price");
                    lstCategory.Items.Add("Item Description");
                    break;

                case 1:
                    qry = "SELECT service_ID AS 'Service ID', service_price AS 'Service Price', item_vat As 'VAT', description AS 'Service Description' FROM Service";
                    sda = new SqlDataAdapter(qry, connection);
                    dt = new DataTable();
                    sda.Fill(dt);
                    ProductData.DataSource = dt;
                    ProductData.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                    lstCategory.Items.Clear();
                    lstCategory.Items.Add("Service ID");
                    lstCategory.Items.Add("Service Price");
                    lstCategory.Items.Add("Service Description");
                    break;
            }
            connection.Close();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            txtDisplay.Clear();
            try
            {
                connection.Open();
                SqlCommand qry;
                SqlDataReader dr;
                string category = "";
                switch (cmbType.SelectedIndex)
                {
                    case 0:
                        switch (lstCategory.SelectedIndex)
                        {
                            case 0: category = "serial_no"; break;
                            case 1:  category = "name"; break;
                            case 2:  category = "quantity"; break;
                            case 3:  category = "unit_price"; break;
                            case 4: category = "description"; break;
                        }
                        qry = new SqlCommand("SELECT * FROM Inventory WHERE " + category + " LIKE '%" + txtSearch.Text + "%'", connection);
                        dr = qry.ExecuteReader();

                        txtDisplay.Text = "Serial Number \t Item Name \t Stock Quantity \t Item Price \t Item Description \n\n";

                        while (dr.Read()) txtDisplay.AppendText(dr["serial_no"].ToString() + "\t\t" + dr["name"].ToString() + "\t\t" + dr["quantity"].ToString() + "\t\t" + dr["unit_price"].ToString() + "\t\t" + dr["description"].ToString() + "\n");

                        break;

                    case 1:
                        switch (lstCategory.SelectedIndex)
                        {
                            case 0: category = "service_ID"; break;
                            case 1: category = "service_price"; break;
                            case 2: category = "description"; break;
                        }
                        qry = new SqlCommand("SELECT * FROM Service WHERE " + category + " LIKE '%" + txtSearch.Text + "%'", connection);
                        dr = qry.ExecuteReader();
                        txtDisplay.Text = "Service ID \t Service Price \t Service Description \n\n";

                        while (dr.Read()) txtDisplay.AppendText(dr["service_ID"].ToString() + "\t\t" + dr["service_price"].ToString() + "\t\t" + dr["description"].ToString() + "\n");

                        break;
                }
            }//////////////////////////////////////////////////////  Fix catch stmnt //////////////////////////////////////////////////////////////////////////////
            catch
            {
                MessageBox.Show("No Products were found!\nTry using a different Keyword.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connection.Close();
            }
        }

        private void txtSearch_Click(object sender, EventArgs e)
        {
           if (txtDisplay.Text != "") txtSearch.Clear();
        }
    }
}
