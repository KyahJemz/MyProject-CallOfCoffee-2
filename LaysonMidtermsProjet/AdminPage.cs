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
    public partial class AdminPage : Form
    {
        DateTime date1;
        DateTime date2;
        String acc_index;
        String item_index;
        public AdminPage()
        {
            InitializeComponent();
        }

        private void btn_Search1_Click(object sender, EventArgs e)
        {
            dgv_Orders.DataSource = null;
            dgv_Orders.Rows.Clear();

            int x = 0;
            String query = "Select ";

            if (cb_Id.Checked)
            {
                query = query + "Orders.Id"; 
                x++;
            }
            if (cb_CustomerName.Checked)
            {
                if (x >= 1) {
                    query = query + ",";
                }
                query = query + "Accounts.Firstname";
                x++;
            }
            if (cb_ItemQuantity.Checked)
            {
                if (x >= 1) {
                    query = query + ",";
                }
                query = query + "Orders.TotalQuantity";
                x++;
            }
            if (cb_TotalPrice.Checked)
            {
                if (x >= 1) {
                    query = query + ",";
                }
                query = query + "Orders.TotalPrice";
                x++;
            }
            if (cb_Timestamp.Checked)
            {
                if (x >= 1) {
                    query = query + ",";
                }
                query = query + "Orders.Timestamp";
                x++;
            }

            query = query + " from Orders inner join Accounts on Accounts.Id = Orders.Customer_Id";

            if (rb_All.Checked)
            {
                if (txt_Search.Text != "")
                {
                    query = query + " where Accounts.Firstname like @SearchTerm";
                }
            }
            else
            {
                date1 = dtp_Date1.Value;
                date2 = dtp_Date2.Value;
                query = query + " where Orders.Timestamp between @Date1 and @Date2";
                if (txt_Search.Text != "")
                {
                    query = query + " and Accounts.Firstname like @SearchTerm";
                }
            }

            SqlConnection sqlcon = new SqlConnection(@"Data Source=CLAB1-19\SQLEXPRESS;Initial Catalog=CoffeeKo;Integrated Security=True");
            sqlcon.Open();
            Console.WriteLine(query);
            SqlCommand cmd = new SqlCommand(query, sqlcon);

            if (txt_Search.Text != "")
            {
                cmd.Parameters.AddWithValue("@SearchTerm", "%" + txt_Search.Text.ToString() + "%");
            }
            if (rb_Custom.Checked)
            {
                Console.WriteLine(date1);
                Console.WriteLine(date2);
                cmd.Parameters.AddWithValue("@Date1", dtp_Date1.Value);
                cmd.Parameters.AddWithValue("@Date2", dtp_Date2.Value);
            }

            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dtbl = new DataTable();
            sda.Fill(dtbl);
            dgv_Orders.DataSource = dtbl;
        }

        private void btn_Logout_Click(object sender, EventArgs e)
        {
            MainPage objFormMain = new MainPage();
            this.Hide();
            objFormMain.Show();
        }


        private void btn_Orders_Click(object sender, EventArgs e)
        {
            pnl_Orders.Visible = true;
            pnl_Accounts.Visible = false;
            pnl_Items.Visible = false;
        }

        private void refreshAccounts()
        {
            dgv_Accounts.DataSource = "";
            SqlConnection sqlcon = new SqlConnection(@"Data Source=CLAB1-19\SQLEXPRESS;Initial Catalog=CoffeeKo;Integrated Security=True");
            sqlcon.Open();
            SqlCommand cmd = new SqlCommand("select * from Accounts order by Id", sqlcon);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dtbl = new DataTable();
            sda.Fill(dtbl);

            if (dtbl.Rows.Count >= 1)
            {
                dgv_Accounts.DataSource = dtbl;
            }
        }

        private void btn_Accounts_Click(object sender, EventArgs e)
        {
            pnl_Orders.Visible = false;
            pnl_Accounts.Visible = true;
            pnl_Items.Visible = false;
            refreshAccounts();
        }

        private void dgv_Accounts_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            acc_index = dgv_Accounts.Rows[e.RowIndex].Cells[0].Value.ToString();
            txt_Firstname.Text = dgv_Accounts.Rows[e.RowIndex].Cells[1].Value.ToString();
            txt_Lastname.Text = dgv_Accounts.Rows[e.RowIndex].Cells[2].Value.ToString();
            txt_Age.Text = dgv_Accounts.Rows[e.RowIndex].Cells[3].Value.ToString();
            txt_Gender.Text = dgv_Accounts.Rows[e.RowIndex].Cells[4].Value.ToString();
            txt_Email.Text = dgv_Accounts.Rows[e.RowIndex].Cells[5].Value.ToString();
            txt_Password.Text = dgv_Accounts.Rows[e.RowIndex].Cells[7].Value.ToString();
        }

        private void btn_AccDelete_Click(object sender, EventArgs e)
        {
            if (acc_index != "")
            {
                SqlConnection sqlcon = new SqlConnection(@"Data Source=CLAB1-19\SQLEXPRESS;Initial Catalog=CoffeeKo;Integrated Security=True");
                sqlcon.Open();
                String query = "Delete from Accounts where Id = '" + acc_index + "'";
                SqlCommand cmd = new SqlCommand(query, sqlcon);
                acc_index = "";
                cmd.ExecuteNonQuery();
                sqlcon.Close();
                refreshAccounts();
                MessageBox.Show("Record Removed");
            }
        }

        private void btn_AccSave_Click(object sender, EventArgs e)
        {
            if (acc_index != "") {
                SqlConnection sqlcon = new SqlConnection(@"Data Source=CLAB1-19\SQLEXPRESS;Initial Catalog=CoffeeKo;Integrated Security=True");
                sqlcon.Open();
                SqlCommand cmd = new SqlCommand("Update Accounts set Firstname=@Firstname, Lastname=@Lastname, Age=@Age, Gender=@Gender, Email=@Email, Password=@Password Where ID='" + acc_index + "'", sqlcon);

                cmd.Parameters.AddWithValue("@Firstname", txt_Firstname.Text);
                cmd.Parameters.AddWithValue("@Lastname", txt_Lastname.Text);
                cmd.Parameters.AddWithValue("@Age", txt_Age.Text);
                cmd.Parameters.AddWithValue("@Gender", txt_Gender.Text);
                cmd.Parameters.AddWithValue("@Email", txt_Email.Text);
                cmd.Parameters.AddWithValue("@Password", txt_Password.Text);

                txt_Firstname.Text = "";
                txt_Lastname.Text = "";
                txt_Age.Text = "";
                txt_Gender.Text = "";
                txt_Email.Text = "";
                txt_Password.Text = "";
                cmd.ExecuteNonQuery();
                sqlcon.Close();

                refreshAccounts();
                MessageBox.Show("Changes Saved");
            }
        }

        private void btn_Items_Click(object sender, EventArgs e)
        {
            pnl_Items.Visible = true;
            pnl_Accounts.Visible = false;
            pnl_Orders.Visible = false;
            refreshItems();

        }

        private void refreshItems()
        {
            dgv_Items.DataSource = "";
            SqlConnection sqlcon = new SqlConnection(@"Data Source=CLAB1-19\SQLEXPRESS;Initial Catalog=CoffeeKo;Integrated Security=True");
            sqlcon.Open();
            SqlCommand cmd = new SqlCommand("select * from Items order by Id", sqlcon);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dtbl = new DataTable();
            sda.Fill(dtbl);

            if (dtbl.Rows.Count >= 1)
            {
                dgv_Items.DataSource = dtbl;
            }
        }

        private void btn_ItemsDelete_Click(object sender, EventArgs e)
        {
            if (item_index != "")
            {
                SqlConnection sqlcon = new SqlConnection(@"Data Source=CLAB1-19\SQLEXPRESS;Initial Catalog=CoffeeKo;Integrated Security=True");
                sqlcon.Open();
                String query = "Delete from Items where Id = '" + item_index + "'";
                SqlCommand cmd = new SqlCommand(query, sqlcon);
                txt_ItemName.Text = "";
                txt_ItemPrice.Text = "";
                txt_ItemImage.Text = "";
                item_index = "";
                cmd.ExecuteNonQuery();
                sqlcon.Close();
                refreshItems();
                MessageBox.Show("Record Removed");
            }
        }

        private void btn_ItemsSave_Click(object sender, EventArgs e)
        {
            if (cb_NewItem.Checked)
            {
                SqlConnection sqlcon = new SqlConnection(@"Data Source=CLAB1-19\SQLEXPRESS;Initial Catalog=CoffeeKo;Integrated Security=True");
                sqlcon.Open();
                SqlCommand cmd = new SqlCommand("Insert into Items (ItemName, ItemPrice, ItemImage) Values (@ItemName, @ItemPrice, @ItemImage)", sqlcon);

                cmd.Parameters.AddWithValue("@ItemName", txt_ItemName.Text);
                cmd.Parameters.AddWithValue("@ItemPrice", txt_ItemPrice.Text);
                cmd.Parameters.AddWithValue("@ItemImage", txt_ItemImage.Text);

                cmd.ExecuteNonQuery();
                sqlcon.Close();

                txt_ItemName.Text = "";
                txt_ItemPrice.Text = "";
                txt_ItemImage.Text = "";

                refreshItems();
                MessageBox.Show("Item Added");
                acc_index = "";
            } 
            else if (acc_index != "")
            {
                SqlConnection sqlcon = new SqlConnection(@"Data Source=CLAB1-19\SQLEXPRESS;Initial Catalog=CoffeeKo;Integrated Security=True");
                sqlcon.Open();
                SqlCommand cmd = new SqlCommand("Update Items set ItemName=@ItemName, ItemPrice=@ItemPrice, ItemImage=@ItemImage Where ID='" + item_index + "'", sqlcon);

                cmd.Parameters.AddWithValue("@ItemName", txt_ItemName.Text);
                cmd.Parameters.AddWithValue("@ItemPrice", txt_ItemPrice.Text);
                cmd.Parameters.AddWithValue("@ItemImage", txt_ItemImage.Text);

                txt_ItemName.Text = "";
                txt_ItemPrice.Text = "";
                txt_ItemImage.Text = "";

                cmd.ExecuteNonQuery();
                sqlcon.Close();

                refreshItems();
                MessageBox.Show("Changes Saved");
            }
        }

        private void dgv_Items_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            item_index = dgv_Items.Rows[e.RowIndex].Cells[0].Value.ToString();
            txt_ItemName.Text = dgv_Items.Rows[e.RowIndex].Cells[1].Value.ToString();
            txt_ItemPrice.Text = dgv_Items.Rows[e.RowIndex].Cells[2].Value.ToString();
            txt_ItemImage.Text = dgv_Items.Rows[e.RowIndex].Cells[3].Value.ToString();
        }
    }
}
