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
    public partial class Management : Form
    {
        public Management()
        {
            InitializeComponent();
        }

        SqlConnection connection = new SqlConnection(@"Data Source=146.230.177.46;Initial Catalog=GroupPmb14;User ID=GroupPmb14;Password=cmsv69");

        void BindData()
        {
            String qry = "SELECT serial_no AS 'Serial Number', name AS 'Item Name', quantity AS 'Stock Quantity', unit_price AS 'Unit Price', description AS 'Item Description' FROM Inventory";
            SqlDataAdapter sda = new SqlDataAdapter(qry, connection);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            InventoryData.DataSource = dt;
            InventoryData.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            qry = "SELECT service_ID AS 'Service ID', service_price AS 'Service Price', item_vat As 'VAT', description AS 'Service Description' FROM Service";
            sda = new SqlDataAdapter(qry, connection);
            dt = new DataTable();
            sda.Fill(dt);
            ServicesData.DataSource = dt;
            ServicesData.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            qry = "SELECT sale_ID AS 'Sale ID', customer_ID AS 'Customer ID', employee_ID AS 'Employee ID', sale_total AS 'Sale Total',date AS 'Date', time AS 'Time',discount_given AS 'Discount Given' FROM Sales";
            sda = new SqlDataAdapter(qry, connection);
            dt = new DataTable();
            sda.Fill(dt);
            SalesData.DataSource = dt;
            SalesData.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;


            qry = "SELECT * FROM SaleItems";
            sda = new SqlDataAdapter(qry, connection);
            dt = new DataTable();
            sda.Fill(dt);
            SaleItemsData.DataSource = dt;

            qry = "SELECT * FROM Employee";
            sda = new SqlDataAdapter(qry, connection);
            dt = new DataTable();
            sda.Fill(dt);
            EmployeeData.DataSource = dt;

        }

        private void Management_Load(object sender, EventArgs e)
        {
            BindData();
            //===================================================================================================
            btnManage.Text = "Add";
        }

        private void MainTab_Click(object sender, EventArgs e)
        {//======================================================== Edit button names appropriately
         //====================================================== Also check if every case is needed

            connection.Open();
            SqlCommand qry;
            SqlDataReader dr;
            qry = new SqlCommand("SELECT name FROM Employee", connection);
            dr = qry.ExecuteReader();
            while (dr.Read()) { lstEmployeeSales.Items.Add(dr["name"]); lstEmployeeSaleItems.Items.Add(dr["name"]); }
            connection.Close();

            switch (MainTab.SelectedIndex)
            {
                case 0:
                    btnManage.Visible = true;
                    switch (InventorySQLTab.SelectedIndex)
                    {
                        case 0:
                            btnManage.Text = "Add";
                            break;

                        case 1:
                            btnManage.Text = "Remove";
                            break;

                        case 2:
                            btnManage.Text = "Edit";
                            break;
                    }
                    break;

                case 1:
                    btnManage.Visible = true;
                    switch (ServicesSQLTab.SelectedIndex)
                    {
                        case 0:
                            btnManage.Text = "Add";
                            break;

                        case 1:
                            btnManage.Text = "Remove";
                            break;

                        case 2:
                            btnManage.Text = "Edit";
                            break;
                    }
                    break;

                case 2:
                    btnManage.Visible = false;
                    break;

                case 3:
                    btnManage.Visible = false;

                    break;

                case 4:
                    btnManage.Visible = true;
                    switch (EmployeeSQLTab.SelectedIndex)
                    {
                        case 0:
                            btnManage.Text = "Add";
                            break;

                        case 1:
                            btnManage.Text = "Remove";
                            break;

                        case 2:
                            btnManage.Text = "Edit";
                            break;
                    }
                    break;

                case 5:
                    btnManage.Visible = false;
                    break;
            }
        }
        private void InventorySQLTab_Click(object sender, EventArgs e)
        {
            switch (InventorySQLTab.SelectedIndex)
            {
                case 0:
                    btnManage.Text = "Add";
                    break;

                case 1:
                    btnManage.Text = "Remove";
                    break;

                case 2:
                    btnManage.Text = "Edit";
                    break;
            }
        }

        private void ServicesSQLTab_Click(object sender, EventArgs e)
        {
            switch (ServicesSQLTab.SelectedIndex)
            {
                case 0:
                    btnManage.Text = "Add";
                    break;

                case 1:
                    btnManage.Text = "Remove";
                    break;

                case 2:
                    btnManage.Text = "Edit";
                    break;
            }
        }
        private void EmployeeSQLTab_Click(object sender, EventArgs e)
        {
            switch (EmployeeSQLTab.SelectedIndex)
            {
                case 0:
                    btnManage.Text = "Add";
                    break;

                case 1:
                    btnManage.Text = "Remove";
                    break;

                case 2:
                    btnManage.Text = "Edit";
                    break;
            }
        }

        private void btnManage_Click(object sender, EventArgs e)
        {////////////////////////////////////////////////////////////////////////////////////
            connection.Open();
            SqlCommand qry;
            SqlDataReader dr;
            switch (MainTab.SelectedIndex)
            {
                case 0://=================================================================Inventory
                    switch (InventorySQLTab.SelectedIndex){
                        case 0:
                            qry = new SqlCommand("INSERT INTO Inventory( name, quantity, unit_price, description) VALUES( '" + txtAddItemName.Text + "' , '" + cntAddQuantity.Text + "','" + txtAddUnitPrice.Text + "','" + txtAddDescription.Text + "' )", connection);
                            dr = qry.ExecuteReader();

                            break;

                        case 1:
                            qry = new SqlCommand("DELETE FROM Inventory WHERE serial_no = '" + txtRemoveSerialNo.Text + "'", connection);
                            dr = qry.ExecuteReader();
                            break;

                        case 2:
                            qry = new SqlCommand("UPDATE Inventory SET name='" + txtEditItemName.Text + "', quantity='" + cntEditQuantity.Text + "',unit_price='" + txtEditUnitPrice.Text + "',description='" + txtEditItemDescription.Text + "', WHERE serial_no='" + txtEditSerialNo.Text + "'", connection);
                            dr = qry.ExecuteReader();
                            break;
                    }
                    break;

                case 1://================================================================Services
                    switch (ServicesSQLTab.SelectedIndex)
                    {
                        case 0: 
                            qry = new SqlCommand("INSERT INTO Service( service_price, item_vat, description ) VALUES ( '"+txtAddServicePrice+"', '"+txtAddServiceVAT+"', '"+txtAddServiceDescription+"' )", connection);
                            dr = qry.ExecuteReader();
                            break;

                        case 1: 
                            qry = new SqlCommand("DELETE Service WHERE service_ID='"+txtRemoveServiceID+"'", connection);
                            dr = qry.ExecuteReader();
                            break;

                        case 2:
                            qry = new SqlCommand("UPDATE Service SET service_price = '"+txtEditServicePrice+"', item_vat = "+txtEditServicePrice+"', description='"+txtEditServiceDescription+"' WHERE service_ID = '5'", connection);
                            dr = qry.ExecuteReader();
                            break;
                    }
                    break;

                /*case 2: //================================================================Sales
                    
                    break;

                case 3: //====================================================================SaleItems
                    break;*/

                case 4://=====================================================================Employee
                    switch (ServicesSQLTab.SelectedIndex)
                    {
                        case 0: //
                            qry = new SqlCommand("INSERT INTO Employee (login_ID, name, phone_no, email, user_type, commiaaion, monthly_salary) VALUES ('"+txtAddEmployeeID.Text+"','"+txtAddEmployeeName.Text+"','"+txtAddEmployeePhoneNo.Text+"','"+txtAddEmployeeEmail.Text+"','"+txtAddEmployeePosition.Text+"','"+txtAddEmployeeSalary.Text+"','"+txtAddEmployeeSalary.Text+"')", connection);
                            dr = qry.ExecuteReader();
                            break;

                        case 1: //
                            qry = new SqlCommand("DELETE FROM Employee WHERE employee_ID =''", connection);
                            dr = qry.ExecuteReader();
                            break;

                        case 2: //
                            qry = new SqlCommand("UPDATE Service SET (service_ID='2', service_price='2', item_vat='2'. description='2') WHERE service_ID='1'", connection);
                            dr = qry.ExecuteReader();
                            break;
                    }
                    break;

                case 5: //===================================================================Reports
                    break;
            }
            connection.Close();
            BindData();
        }

        private void Management_FormClosed(object sender, FormClosedEventArgs e)
        {
            Main.formCLosed = true;
        }

        /////////////////////////////////////////////////////////////////////////// Test these 2 features
        private void lstEmployeeSales_SelectedIndexChanged(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand qry = new SqlCommand("SELECT employee_ID FROM Employee WHERE name = '"+lstEmployeeSales.SelectedItem+"'", connection);
            SqlDataReader dr = qry.ExecuteReader();
            string id = dr["employee_ID"].ToString();
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM Sales where employee_ID = "+id, connection);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            SalesData.DataSource = dt;
            connection.Close();

        }

        private void lstEmployeeSaleItems_SelectedIndexChanged(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand qry = new SqlCommand("SELECT employee_ID FROM Employee WHERE name = '" + lstEmployeeSaleItems.SelectedItem + "'", connection);
            SqlDataReader dr = qry.ExecuteReader();
            string id = dr["employee_ID"].ToString();
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM Sales where employee_ID = " + id, connection);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            SaleItemsData.DataSource = dt;
            connection.Close();
        }

        private void txtRemoveSerialNo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                connection.Open();
                SqlCommand qry = new SqlCommand("SELECT * FROM Inventory WHERE serial_no = "+txtRemoveSerialNo.Text, connection);
                SqlDataReader dr = qry.ExecuteReader();
                while (dr.Read())
                {
                    txtInventoryRemoveDetails.Text = "Serial Number: \t" + dr["serial_no"] + "\n"+ "Item name: \t" + dr["name"] + "\n" + "Stock Quantity: \t" + dr["quantity"] + "\n"+ "Unit Price:" + dr["unit_price"] + "\n"+"Item Description: \t" + dr["description"]+ "\n\n Would you like to proceed to remove this item from the database?";
                }
                connection.Close();
                btnManage.Text = "Yes";
            }
        }
    }
}
