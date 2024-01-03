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

namespace LaysonMidtermsProjet
{
    public partial class MainPage : Form
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            if (username.Text.Trim() == "admin" && password.Text.Trim() == "12345")
            {
                AdminPage objFormMain = new AdminPage();
                this.Hide();
                objFormMain.Show();
            }
            else
            {
                SqlConnection sqlcon = new SqlConnection(@"Data Source=CLAB1-19\SQLEXPRESS;Initial Catalog=CoffeeKo;Integrated Security=True");
                string query = "Select Id from Accounts Where username = '" + username.Text.Trim() + "' and password = '" + password.Text.Trim() + "'";
                SqlDataAdapter sda = new SqlDataAdapter(query, sqlcon);

                DataTable dtbl = new DataTable();
                sda.Fill(dtbl);
                if (dtbl.Rows.Count == 1)
                {
                    String Id="";

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
                    password.Clear();
                    username.Focus();
                }
            }
        }

        private void btn_Register_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RegistrationPage objFormMain = new RegistrationPage();
            this.Hide();
            objFormMain.Show();
        }
    }
}
