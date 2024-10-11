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

namespace Autogaragemanagment2.PAL
{
    public partial class FormForgotPassword : Form
    {   
        Connection conn = new Connection();

        public FormForgotPassword()
        {
            InitializeComponent();
        }

        private void picClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnResetPassword_Click(object sender, EventArgs e)
        {
            if(txtUsername.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Please enter user name.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (txtEmail.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Please enter email.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            else
            {
                string pass = RetrievePassword(txtUsername.Text.Trim(), txtEmail.Text.Trim());
                if(pass != string.Empty)
                {
                    MessageBox.Show($"Your password is: {pass}", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Close();
                }
                else
                {
                    MessageBox.Show("Username or email is incorrect.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private string RetrievePassword(string username, string email)
        {
            using (SqlConnection connection = new SqlConnection(conn.db))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT Users_Password FROM Users WHERE Users_Name=@Username AND Users_Email=@Email";
                    SqlCommand cmd = new SqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@Username", username);
                    cmd.Parameters.AddWithValue("@Email", email);

                    object result = cmd.ExecuteScalar();
                    if (result != null)
                    {
                        return result.ToString();
                    }
                    else
                    {
                        return string.Empty;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                    return string.Empty;
                }
            }
        }
    }
}
