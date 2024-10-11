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

namespace Autogaragemanagment2.PAL
{
    public partial class FormLogin : Form
    {   
        Connection conn = new Connection();
        public FormLogin()
        {
            InitializeComponent();
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void maskedTextBox2_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void picClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void EmptyBox() { 
            txtUsername.Clear();
            txtPassword.Clear();
        }

        private void picShow_Click(object sender, EventArgs e)
        {
            if(picShow.Visible == true)
            {
                txtPassword.UseSystemPasswordChar = false;
                picShow.Visible = false;
                picHide.Visible = true;
            }
        }

        private void picHide_Click(object sender, EventArgs e)
        {
            if(picHide.Visible == true)
            {
                txtPassword.UseSystemPasswordChar = true;
                picShow.Visible=true;
                picHide.Visible=false;
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if(txtUsername.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Please enter user name.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else if(txtPassword.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Please enter password.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                bool check = CheckLogin(txtUsername.Text.Trim(), txtPassword.Text.Trim());
                if (check)
                {   
                    FormMain formMain = new FormMain();
                    formMain.ShowDialog();
                    EmptyBox();
                }
                else
                {
                    MessageBox.Show("Username or password is incorrect.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void lblForgotPassword_Click(object sender, EventArgs e)
        {
            FormForgotPassword formForgotPassword = new FormForgotPassword();
            formForgotPassword.ShowDialog();
        }

        private bool CheckLogin(string username, string password)
        {
            using (SqlConnection connection = new SqlConnection(conn.db))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT COUNT(1) FROM Users WHERE Users_Name=@Username AND Users_Password=@Password"; // Adjust table and column names as needed
                    SqlCommand cmd = new SqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@Username", username);
                    cmd.Parameters.AddWithValue("@Password", password);

                    int count = Convert.ToInt32(cmd.ExecuteScalar());
                    return count == 1;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                    return false;
                }
            }
        }
    }
}
