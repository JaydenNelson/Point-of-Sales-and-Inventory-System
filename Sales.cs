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
    public partial class Sales : Form
    {
        SqlConnection connection = new SqlConnection(@"Data Source=146.230.177.46;Initial Catalog=GroupPmb14;User ID=GroupPmb14;Password=cmsv69");

        string customerName, customerID, saleID, date, time, serialNo, serviceID, P_S, P_SName, qty;
        float TOTAL = 0, totalVAT = 0, discount, grandTOTAL, unitPrice, cost, vat, subtotal;
        int count = 1;
        Boolean tempSale = false;
        public static String EmployeeID;

        public Sales()
        {
            InitializeComponent();
        }

        private void txtCustomer_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                customerName = txtCustomer.Text;
                connection.Open();
                SqlCommand qry = new SqlCommand("SELECT * FROM Customer2 WHERE name = '" + customerName + "'", connection);
                SqlDataReader dr = qry.ExecuteReader();
                dr.Read();
                if (dr.HasRows)
                {
                    customerID = dr["customer_ID"].ToString();
                    connection.Close();
                }
                else
                {
                    ////////////////////CALL CUSTOMER FORM
                }
            }
        }

        private void rbtnProduct_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnProduct.Checked)
            {
                rbtnService.Checked = false;
                P_S = "Product";
            }
                
        }

        private void rbtnService_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnService.Checked)
            {
                rbtnProduct.Checked = false;
                P_S = "Service";
            }
            //gbProducts.Text = "Search and select a Service:";
        }

        private void txtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            lstItems.Items.Clear();
            connection.Open();
            SqlCommand qry;
            SqlDataReader dr;
            if (txtSearch.Text!="")
                if (rbtnProduct.Checked)
                {
                    qry = new SqlCommand("SELECT * FROM Inventory2 WHERE name LIKE '%"+txtSearch.Text+"%'", connection);
                    dr = qry.ExecuteReader();
                    while (dr.Read())
                        lstItems.Items.Add(dr["name"]);

                }
                else if (rbtnService.Checked)
                {
                    qry = new SqlCommand("SELECT * FROM Services WHERE service_name LIKE '%" + txtSearch.Text + "%'", connection);
                    dr = qry.ExecuteReader();
                    while (dr.Read())
                        lstItems.Items.Add(dr["service_name"]);
                }
            connection.Close();
        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand qry;
            SqlDataReader dr;
            if (tempSale == false)
            {
                qry = new SqlCommand("INSERT INTO Sales(employee_id, customer_id, sale_total, vat_total, date, time, discount, grand_total) VALUES('" + EmployeeID + "', '" + customerID + "', '0', '0', '1111/11/11', '11:11', '0', '0')", connection);
                dr = qry.ExecuteReader();
                tempSale = true;
                dr.Close();
                qry = new SqlCommand("SELECT TOP(1) sale_id FROM Sales ORDER BY sale_id DESC", connection);
                dr = qry.ExecuteReader();
                dr.Read();
                saleID = dr["sale_id"].ToString();
                dr.Close();
            }

            P_SName = lstItems.SelectedItem.ToString();
            qty = cntQty.Text;

            switch (P_S)
            {
                case "Product":
                    qry = new SqlCommand("SELECT serial_no, unit_price, vat FROM Inventory2 WHERE name = '" + P_SName + "'", connection);
                    dr = qry.ExecuteReader();
                    dr.Read();
                    serialNo = dr["serial_no"].ToString();
                    unitPrice = float.Parse(dr["unit_price"].ToString());
                    vat = float.Parse(dr["vat"].ToString());
                    dr.Close();

                    cost = unitPrice * int.Parse(qty);
                    subtotal = unitPrice + vat;

                    count++;
                    ListViewItem items = new ListViewItem(count.ToString());
                    items.SubItems.Add(P_S);
                    items.SubItems.Add(P_SName);
                    items.SubItems.Add("x  " + qty);
                    items.SubItems.Add("@  " + unitPrice.ToString());
                    items.SubItems.Add("+  " + vat.ToString());
                    items.SubItems.Add(subtotal.ToString());
                    lstSaleItems.Items.Add(items);

                    qry = new SqlCommand("INSERT INTO SaleItems(sale_id, serial_no, product_or_service, product_or_service_name, " +
                        "unit_price, quantity, cost, vat, subtotal) VALUES('"+saleID+"', '"+serialNo+"', '"+P_S+"', '"+P_SName+"', " +
                        "'"+unitPrice+"', '"+qty+"', '"+cost+"', '"+ vat + "', '"+subtotal+"')", connection);
                    dr = qry.ExecuteReader();


                    break;

                case "Service":

                    break;

            }
            date = DateTime.Now.ToShortDateString();
            time = DateTime.Now.ToShortTimeString();
            TOTAL += subtotal;
            totalVAT += vat;
            lblTotal.Text = "TOTAL: R " + TOTAL.ToString();

            connection.Close();
           
        }


        private void btnRemove_Click(object sender, EventArgs e)
        {

        }
    }
}
