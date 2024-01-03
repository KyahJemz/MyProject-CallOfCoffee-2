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

namespace LaysonMidtermsProjet

{
    public partial class HomePage : Form
    {
        private double totalPrice = 0;
        private int totalItems = 0;
        private String id;
        private ArrayList orderNameArrayList = new ArrayList();
        private ArrayList orderIdArrayList = new ArrayList();
        private ArrayList priceArrayList = new ArrayList();

        String firstname = "";
        String lastname = "";
        String age = "";
        String gender = "";
        String email = "";
        String username = "";
        String password = "";

        public HomePage()
        {
            InitializeComponent();
        }

        public HomePage(String id)
        {
            InitializeComponent();
            this.id = id;
            pnl_Home.Visible = true;
            pnl_EditProfile.Visible = false;
            pnl_Shop.Visible = false;
            pnl_MyOrders.Visible = false;
            clearArrayLists();

        }

        private void btn_ShopNow_Click(object sender, EventArgs e)
        {
            pnl_Home.Visible = false;
            pnl_EditProfile.Visible = false;
            pnl_Shop.Visible = true;
            pnl_MyOrders.Visible = false;
            clearArrayLists();
            loadItemsTable();
        }
        private void btn_EditProfile_Click(object sender, EventArgs e)
        {
            pnl_Home.Visible = false;
            pnl_EditProfile.Visible = true;
            pnl_Shop.Visible = false;
            pnl_MyOrders.Visible = false;
            clearArrayLists();
            getProfile();
        }

        private void btn_MyOrders_Click(object sender, EventArgs e)
        {
            pnl_Home.Visible = false;
            pnl_EditProfile.Visible = false;
            pnl_Shop.Visible = false;
            pnl_MyOrders.Visible = true;
            clearArrayLists();
            loadMyOrders();
        }

        private void btn_Home_Click(object sender, EventArgs e)
        {
            
            pnl_Home.Visible = true;
            pnl_EditProfile.Visible = false;
            pnl_Shop.Visible = false;
            pnl_MyOrders.Visible = false;
            clearArrayLists();
        }
        private void clearArrayLists()
        {
            orderIdArrayList.Clear();
            orderNameArrayList.Clear();
            priceArrayList.Clear();
            lv_OrdersList.Items.Clear();
        }

// SHOP NOW FUNCTIONS ##############

        private void loadItemsTable()
        {
            SqlConnection sqlcon = new SqlConnection(@"Data Source=CLAB1-19\SQLEXPRESS;Initial Catalog=CoffeeKo;Integrated Security=True");
            sqlcon.Open();
            SqlCommand cmd = new SqlCommand("select * from Items", sqlcon);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dtbl = new DataTable();
            sda.Fill(dtbl);
            dgv_Items.DataSource = dtbl;
        }
        private void dtg_Items_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            orderIdArrayList.Add(dgv_Items.Rows[e.RowIndex].Cells[0].Value.ToString());
            orderNameArrayList.Add(dgv_Items.Rows[e.RowIndex].Cells[1].Value.ToString());
            priceArrayList.Add(dgv_Items.Rows[e.RowIndex].Cells[2].Value.ToString());

            lbl_LastItemAdded.Text = dgv_Items.Rows[e.RowIndex].Cells[1].Value.ToString();

            refreshListView();
        }

        private void btn_BuyNow_Click(object sender, EventArgs e)
        {
            DateTime currentDateTime = DateTime.Now;
            string formattedDateTime = currentDateTime.ToString("yyyy-MM-dd HH:mm:ss.fff");

            SqlConnection sqlcon = new SqlConnection(@"Data Source=CLAB1-19\SQLEXPRESS;Initial Catalog=CoffeeKo;Integrated Security=True");
            sqlcon.Open();
            SqlCommand cmd = new SqlCommand("insert into Orders(Customer_ID,TotalQuantity,TotalPrice,Timestamp) VALUES(@Customer_ID, @TotalQuantity, @TotalPrice, @Timestamp); SELECT SCOPE_IDENTITY()", sqlcon);
            cmd.Parameters.AddWithValue("@Customer_ID", id);
            cmd.Parameters.AddWithValue("@TotalQuantity", lbl_TotalItems.Text.ToString());
            cmd.Parameters.AddWithValue("@TotalPrice", lbl_TotalPrice.Text.ToString());
            cmd.Parameters.AddWithValue("@Timestamp", formattedDateTime);
            int orderId = Convert.ToInt32(cmd.ExecuteScalar());
            sqlcon.Close();

            foreach (String x in orderIdArrayList)
            {
                sqlcon.Open();
                SqlCommand cmd2 = new SqlCommand("insert into Carts(Order_Id,Item_Id) values (@Order_Id, @Item_Id)", sqlcon);
                cmd2.Parameters.AddWithValue("@Order_Id", orderId);
                cmd2.Parameters.AddWithValue("@Item_Id", x);
                cmd2.ExecuteNonQuery();
                sqlcon.Close();
            }
            MessageBox.Show("Successfully Saved");

            pnl_Shop.Visible = false;
            pnl_MyOrders.Visible = true;
            clearArrayLists();
            refreshListView();
        }

        private double getTotalPrice()
        {
            float price = 0;
            foreach (String x in priceArrayList)
            {
                price = price + float.Parse(x);
            }
            return price;
        }

        private void refreshListView()
        {
            totalItems = orderIdArrayList.Count;
            totalPrice = getTotalPrice();
            lbl_TotalItems.Text = totalItems.ToString();
            lbl_TotalPrice.Text = totalPrice.ToString();

            lv_OrdersList.Items.Clear();
            for (int i = 0; i<orderIdArrayList.Count; i++) {
                String[] data = {orderNameArrayList[i].ToString() +" - P"+priceArrayList[i].ToString()};
                ListViewItem lvi = new ListViewItem(data);
                lv_OrdersList.Items.Add(lvi);

            }
        }
        private void lv_OrdersList_DoubleClick(object sender, EventArgs e)
        {
            orderNameArrayList.RemoveAt(lv_OrdersList.SelectedIndices[0]);
            orderIdArrayList.RemoveAt(lv_OrdersList.SelectedIndices[0]);
            priceArrayList.RemoveAt(lv_OrdersList.SelectedIndices[0]);
            refreshListView();
        }

// EDIT PROFILE FUNCTIONS ##############
        private void getProfile(){
            SqlConnection sqlcon = new SqlConnection(@"Data Source=CLAB1-19\SQLEXPRESS;Initial Catalog=CoffeeKo;Integrated Security=True");
            string query = "Select * from Accounts where Id='"+id+"'";
            
            SqlDataAdapter sda = new SqlDataAdapter(query, sqlcon);

            DataTable dtbl = new DataTable();
            sda.Fill(dtbl);
            if (dtbl.Rows.Count == 1)
            {
                foreach (DataRow row in dtbl.Rows)
                {
                    firstname = row["Firstname"].ToString();
                    lastname = row["Lastname"].ToString();
                    age = row["Age"].ToString();
                    gender = row["Gender"].ToString();
                    email = row["Email"].ToString();
                    username = row["Username"].ToString();
                    password = row["Password"].ToString();
                }
                txt_Firstname.Text = firstname;
                txt_Lastname.Text = lastname;
                txt_Age.Text = age;
                txt_Gender.Text = gender;
                txt_Email.Text = email;
            }
        }
                
        private void btn_SaveChanges_Click(object sender, EventArgs e)
        {
            

            if (txt_Firstname.Text == "" || txt_Lastname.Text == "" || txt_Age.Text == "" || txt_Gender.Text == "" || txt_Email.Text == "")
            {
                MessageBox.Show("Invalid Empty Lines!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (txt_NewPassword.Text != txt_NewPassword2.Text)
            {
                MessageBox.Show("Passwords does not match!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (txt_OldPassword.Text != password && txt_OldPassword.Text != "" && txt_NewPassword.Text == "")
            {
                MessageBox.Show("Passwords does not match!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            SqlConnection sqlcon = new SqlConnection(@"Data Source=CLAB1-19\SQLEXPRESS;Initial Catalog=CoffeeKo;Integrated Security=True");
            sqlcon.Open();
            SqlCommand cmd = new SqlCommand("Update Accounts set Firstname=@Firstname, Lastname=@Lastname, Age=@Age, Gender=@Gender, Email=@Email, Username=@Username, Password=@Password Where ID='" + id + "'", sqlcon);
            if (txt_NewPassword.Text == "")
            {
                cmd.Parameters.AddWithValue("@Firstname", txt_Firstname.Text);
                cmd.Parameters.AddWithValue("@Lastname", txt_Lastname.Text);
                cmd.Parameters.AddWithValue("@Age", txt_Age.Text);
                cmd.Parameters.AddWithValue("@Gender", txt_Gender.Text);
                cmd.Parameters.AddWithValue("@Email", txt_Email.Text);
                cmd.Parameters.AddWithValue("@Username", username);
                cmd.Parameters.AddWithValue("@Password", password);
            }
            else
            {
                cmd.Parameters.AddWithValue("@Firstname", txt_Firstname.Text);
                cmd.Parameters.AddWithValue("@Lastname", txt_Lastname.Text);
                cmd.Parameters.AddWithValue("@Age", txt_Age.Text);
                cmd.Parameters.AddWithValue("@Gender", txt_Gender.Text);
                cmd.Parameters.AddWithValue("@Email", txt_Email.Text);
                cmd.Parameters.AddWithValue("@Username", username);
                cmd.Parameters.AddWithValue("@Password", txt_NewPassword.Text);
            }
            
            cmd.ExecuteNonQuery();

            sqlcon.Close();

            MessageBox.Show("Successfully Updated");
        }

 // My Oder FUNCTIONS ##############

        public void loadMyOrders()
        {
            dgv_MyOrders.Rows.Clear();
            SqlConnection sqlcon = new SqlConnection(@"Data Source=CLAB1-19\SQLEXPRESS;Initial Catalog=CoffeeKo;Integrated Security=True");
            sqlcon.Open();
            SqlCommand cmd = new SqlCommand("select * from Orders where Customer_Id='"+id+"'", sqlcon);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dtbl = new DataTable();
            sda.Fill(dtbl);

            if (dtbl.Rows.Count >= 1)
            {
                foreach (DataRow row in dtbl.Rows)
                {
                    dgv_MyOrders.Rows.Add(row["Id"].ToString(), row["TotalQuantity"].ToString(), row["TotalPrice"].ToString(), row["Timestamp"].ToString());
                }
            }
            else
            {
                dgv_MyOrders.Rows.Add("No Data", "No Data", "No Data", "No Data");
            }
        }
        private void dgv_MyOrders_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            SqlConnection sqlcon = new SqlConnection(@"Data Source=CLAB1-19\SQLEXPRESS;Initial Catalog=CoffeeKo;Integrated Security=True");
            sqlcon.Open();
            SqlCommand cmd = new SqlCommand("select Items.ItemName, Items.ItemPrice from Carts inner join Items on Items.Id = Carts.Item_Id where Carts.Order_ID = '" + dgv_MyOrders.Rows[e.RowIndex].Cells[0].Value.ToString() + "'", sqlcon);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dtbl = new DataTable();
            sda.Fill(dtbl);

            lv_MyOrders.Items.Clear();
            if (dtbl.Rows.Count >= 1)
            {
                foreach (DataRow row in dtbl.Rows)
                {
                    ListViewItem lvi = new ListViewItem();
                    lvi.SubItems.Add(row["ItemName"].ToString());
                    lvi.SubItems.Add("P" + row["ItemPrice"].ToString());
                    lv_MyOrders.Items.Add(lvi);
                }
            }
            else
            {
                ListViewItem lvi = new ListViewItem();
                lvi.SubItems.Add("No Data");
                lvi.SubItems.Add("No Data");
                lv_MyOrders.Items.Add(lvi);
            }
        }
        private void btn_Reset_Click(object sender, EventArgs e)
        {
            txt_Firstname.Text = firstname;
            txt_Lastname.Text = lastname;
            txt_Age.Text = age;
            txt_Gender.Text = gender;
            txt_Email.Text = email;
        }
        private void btn_Logout_Click(object sender, EventArgs e)
        {
            MainPage objFormMain = new MainPage();
            this.Hide();
            objFormMain.Show();
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                loadItemsTable();
            }
            else
            {
                SqlConnection sqlcon = new SqlConnection(@"Data Source=CLAB1-19\SQLEXPRESS;Initial Catalog=CoffeeKo;Integrated Security=True");
                sqlcon.Open();
                SqlCommand cmd = new SqlCommand("select * from Items where ItemName like '%"+textBox1.Text.ToString()+"%'", sqlcon);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dtbl = new DataTable();
                sda.Fill(dtbl);
                dgv_Items.DataSource = dtbl;
            }
        }
    }
}
