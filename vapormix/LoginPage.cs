using System;
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
    public partial class LoginPage : Form
    {

        public LoginPage()
        {
            InitializeComponent();
        }

        private void btn_Register_Click(object sender, EventArgs e)
        {
            Registration objFormMain = new Registration();
            this.Hide();
            objFormMain.Show();
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            if (txt_Username.Text.Trim() == "admin" && txt_Password.Text.Trim() == "12345")
            {
                AdminPage objFormMain = new AdminPage();
                this.Hide();
                objFormMain.Show();
            }
            else
            {
                SqlConnection sqlcon = new SqlConnection(@"Data Source=DESKTOP-FAOH50K\SQLEXPRESS;Initial Catalog=vapeshop;Integrated Security=True");
                string query = "Select Id from Accounts Where Username = '" + txt_Username.Text.Trim() + "' and Password = '" + txt_Password.Text.Trim() + "'";
                SqlDataAdapter sda = new SqlDataAdapter(query, sqlcon);

                DataTable dtbl = new DataTable();
                sda.Fill(dtbl);
                if (dtbl.Rows.Count == 1)
                {
                    String Id = "";

                    foreach (DataRow row in dtbl.Rows)
                    {
                        Id = row["Id"].ToString();
                    }
                    HomePage objFormMain = new HomePage(Id);
                    this.Hide();
                    objFormMain.Show();
                }
                else
                {
                    MessageBox.Show("Invalid Login Details", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txt_Password.Clear();
                    txt_Username.Focus();
                }
            }
        }

        private void LoginPage_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
