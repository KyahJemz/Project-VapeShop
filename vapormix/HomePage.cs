using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace vapormix
{
    public partial class HomePage : Form
    {
        String Id;
        ArrayList itemIds = new ArrayList();
        ArrayList itemNames = new ArrayList();
        ArrayList itemPrices = new ArrayList();

        public HomePage()
        {
            InitializeComponent();
        }
        public HomePage(String Id)
        {
            InitializeComponent();
            this.Id = Id;
        }

        private void btn_CheckOut_Click(object sender, EventArgs e)
        {
            if (cb_item1.Checked) 
            { 
                itemIds.Add("2");
                itemNames.Add("Creamy Strawbery Candy");
                itemPrices.Add("250"); 
            }
            if (cb_item2.Checked)
            {
                itemIds.Add("3");
                itemNames.Add("Watermelon Blast");
                itemPrices.Add("250");
            }
            if (cb_item3.Checked)
            {
                itemIds.Add("4");
                itemNames.Add("Sweet Tobacco");
                itemPrices.Add("250");
            }
            if (cb_item4.Checked)
            {
                itemIds.Add("5");
                itemNames.Add("Pineapple Blast");
                itemPrices.Add("250");
            }
            if (cb_item5.Checked)
            {
                itemIds.Add("6");
                itemNames.Add("Sweet Toasted Bread");
                itemPrices.Add("250");
            }
            if (cb_item6.Checked)
            {
                itemIds.Add("7");
                itemNames.Add("Mango Splash");
                itemPrices.Add("250");
            }
            if (cb_item7.Checked)
            {
                itemIds.Add("8");
                itemNames.Add("Y. G. R. T.");
                itemPrices.Add("250");
            }
            if (cb_item8.Checked)
            {
                itemIds.Add("9");
                itemNames.Add("Black Lychee");
                itemPrices.Add("250");
            }
            if (cb_item9.Checked)
            {
                itemIds.Add("10");
                itemNames.Add("Milky Nuts");
                itemPrices.Add("250");
            }
            if (cb_item10.Checked)
            {
                itemIds.Add("11");
                itemNames.Add("Blueberry Blast");
                itemPrices.Add("250");
            }
            if (cb_item11.Checked)
            {
                itemIds.Add("12");
                itemNames.Add("Vape - Brown");
                itemPrices.Add("750");
            }
            if (cb_item12.Checked)
            {
                itemIds.Add("13");
                itemNames.Add("Vape - White");
                itemPrices.Add("750");
            }
            if (cb_item13.Checked)
            {
                itemIds.Add("14");
                itemNames.Add("Vape - Colored");
                itemPrices.Add("750");
            }
            if (cb_item14.Checked)
            {
                itemIds.Add("15");
                itemNames.Add("Vape - Red");
                itemPrices.Add("750");
            }
            if (cb_item15.Checked)
            {
                itemIds.Add("16");
                itemNames.Add("Vape - Bluew");
                itemPrices.Add("750");
            }
            if (cb_item16.Checked)
            {
                itemIds.Add("17");
                itemNames.Add("Vape - Black");
                itemPrices.Add("750");
            }


            if (itemIds.Count >= 1)
            {
                CheckOut objFormMain = new CheckOut(Id, itemIds, itemNames, itemPrices);
                this.Hide();
                objFormMain.Show();
            }
            else
            {
                MessageBox.Show("Invalid Orders", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_Logout_Click(object sender, EventArgs e)
        {
            LoginPage objFormMain = new LoginPage();
            this.Hide();
            objFormMain.Show();
        }

        private void btn_ShopNow_Click(object sender, EventArgs e)
        {
            pnl_MyOrders.Visible = false;
            pnl_ShopNow.Visible = true;
            btn_CheckOut.Visible = true;
        }

        private void btn_MyOrders_Click(object sender, EventArgs e)
        {
            pnl_MyOrders.Visible = true;
            pnl_ShopNow.Visible = false;
            btn_CheckOut.Visible = false;
            ordersListView.Items.Clear();
            itemsListView.Items.Clear();

            SqlConnection sqlcon = new SqlConnection(@"Data Source=DESKTOP-FAOH50K\SQLEXPRESS;Initial Catalog=vapeshop;Integrated Security=True");
            string query = "Select * from Transactions Where Account_Id = '"+Id+"'";
            SqlDataAdapter sda = new SqlDataAdapter(query, sqlcon);

            DataTable dtbl = new DataTable();
            sda.Fill(dtbl);
            if (dtbl.Rows.Count >= 1)
            {
                foreach (DataRow row in dtbl.Rows)
                {
                    ListViewItem lvi = new ListViewItem(new[] { row["Id"].ToString(), row["Firstname"].ToString(), row["Lastname"].ToString(), row["TotalPrice"].ToString(), row["TotalQuantity"].ToString() });
                    ordersListView.Items.Add(lvi);
                }
            }
        }


        private void ordersListView_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (ordersListView.SelectedItems.Count > 0)
            {
                itemsListView.Items.Clear();
                ListViewItem selectedItem = ordersListView.SelectedItems[0];
                string firstCellValue = selectedItem.SubItems[0].Text;
                Console.WriteLine(firstCellValue);

                SqlConnection sqlcon = new SqlConnection(@"Data Source=DESKTOP-FAOH50K\SQLEXPRESS;Initial Catalog=vapeshop;Integrated Security=True");
                string query = "Select * from Carts join Items on Carts.Item_Id = Items.Id where Carts.Transaction_Id ='" + firstCellValue + "'";
                SqlDataAdapter sda = new SqlDataAdapter(query, sqlcon);

                DataTable dtbl = new DataTable();
                sda.Fill(dtbl);
                Console.WriteLine(dtbl.Rows.Count);
                if (dtbl.Rows.Count >= 1)
                {
                    foreach (DataRow row in dtbl.Rows)
                    {
                        Console.WriteLine(row["ItemName"]);
                        ListViewItem lvi = new ListViewItem(new[] { row["ItemName"].ToString() });
                        itemsListView.Items.Add(lvi);
                    }
                }
            }
        }
    }
}
