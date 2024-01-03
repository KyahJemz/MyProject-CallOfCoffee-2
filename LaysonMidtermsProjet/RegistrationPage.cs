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
    public partial class RegistrationPage : Form
    {
        public RegistrationPage()
        {
            InitializeComponent();
        }

        private void btn_Register_Click(object sender, EventArgs e)
        {
            if (txt_Firstname.Text == "" ||  
                txt_Lastname.Text == "" ||
                txt_Age.Text == "" ||
                txt_Gender.Text == "" ||
                txt_Email.Text == "" ||
                txt_Username.Text == "" ||
                txt_Password.Text == "" ||
                txt_Password2.Text == "")
            {
                MessageBox.Show("Blanks?, Try again!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
           }
            
            if (txt_Password.Text.Trim() == txt_Password2.Text.Trim())
            {
                SqlConnection sqlcon = new SqlConnection(@"Data Source=CLAB1-19\SQLEXPRESS;Initial Catalog=CoffeeKo;Integrated Security=True");
                string query = "Select * from Accounts Where username = '" + txt_Username.Text.Trim() + "'";
                SqlDataAdapter sda = new SqlDataAdapter(query, sqlcon);
                DataTable dtbl = new DataTable();
                sda.Fill(dtbl);
                if (dtbl.Rows.Count == 1)
                {
                    MessageBox.Show("Username already exist, Try again!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txt_Username.Clear();
                    txt_Username.Focus();
                }
                else
                {
                    SqlConnection sqlcon2 = new SqlConnection(@"Data Source=CLAB1-19\SQLEXPRESS;Initial Catalog=CoffeeKo;Integrated Security=True");
                    sqlcon2.Open();
                    SqlCommand cmd = new SqlCommand("insert into Accounts values (@Firstname, @Lastname, @Age, @Gender, @Email, @Username, @Password)", sqlcon2);
                    cmd.Parameters.AddWithValue("@Firstname", (txt_Firstname.Text));
                    cmd.Parameters.AddWithValue("@Lastname", (txt_Lastname.Text));
                    cmd.Parameters.AddWithValue("@Age", (txt_Age.Text));
                    cmd.Parameters.AddWithValue("@Gender", (txt_Gender.Text));
                    cmd.Parameters.AddWithValue("@Email", (txt_Email.Text));
                    cmd.Parameters.AddWithValue("@Username", (txt_Username.Text));
                    cmd.Parameters.AddWithValue("@Password", (txt_Password.Text));
                    cmd.ExecuteNonQuery();
                    sqlcon2.Close();
                    MessageBox.Show("Successfully Created");
                    MainPage objFormMain = new MainPage();
                    this.Hide();
                    objFormMain.Show();
                }
            }
            else
            {
                MessageBox.Show("Password did not match, Try again!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_Password.Clear();
                txt_Password2.Clear();
                txt_Password.Focus();
            }
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            txt_Firstname.Text = "";
            txt_Lastname.Text = "";
            txt_Age.Text = "";
            txt_Gender.Text = "";
            txt_Email.Text = "";
            txt_Username.Text = "";
            txt_Password.Text = "";
            txt_Password2.Text = "";
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            MainPage objFormMain = new MainPage();
            this.Hide();
            objFormMain.Show();
        }
    }
}
