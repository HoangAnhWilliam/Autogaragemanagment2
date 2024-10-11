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
    public partial class UserControlEmployee : UserControl
    {   
        Connection connection = new Connection();
        public UserControlEmployee()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtVehicleID_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtID.Text == "")
                {
                    MessageBox.Show("Please, Enter your ID", "Try Again", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtID.Focus();
                }
                else if (txtEmployeeName.Text == "")
                {
                    MessageBox.Show("Please, Enter your employee name", "Try Again", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtEmployeeName.Focus();
                }
                else if (txtEmployeeEducation.Text == "")
                {
                    MessageBox.Show("Please, Enter your employee education", "Try Again", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtEmployeeEducation.Focus();
                }
                else if (txtEmployeeAddress.Text == "")
                {
                    MessageBox.Show("Please, Enter your employee address", "Try Again", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtEmployeeAddress.Focus();
                }
                else if (cmbEmployeeGender.Text == "")
                {
                    MessageBox.Show("Please, Select your employee gender", "Try Again", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cmbEmployeeGender.Focus();
                }
                else
                {
                    SqlConnection con = new SqlConnection(connection.db);
                    con.Open();
                    String str = "INSERT INTO db_Employees(Id,EName,EEducation,EAddress,EGender) VALUES('" + txtID.Text + "','" + txtEmployeeName.Text + "', '" + txtEmployeeEducation.Text + "', '" + txtEmployeeAddress.Text + "', '" + cmbEmployeeGender.Text + "')";
                    SqlCommand cmd = new SqlCommand(str, con);
                    cmd.ExecuteNonQuery();
                    String str1 = "SELECT MAX(EName) FROM db_Employees";
                    SqlCommand cmd2 = new SqlCommand(str1, con);
                    SqlDataReader da = cmd2.ExecuteReader();

                    if (da.Read())
                    {
                        MessageBox.Show("Your information is inserted successfully!", "Thank you!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Clear();
                        showData();
                    }
                    else
                    {
                        MessageBox.Show("Your information is inserted unsuccessfully!", "Try again!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void showData()
        {
            try
            {
                SqlConnection con = new SqlConnection(connection.db);
                con.Open();
                String str = "SELECT * FROM db_Employees";
                SqlCommand cmd = new SqlCommand(str, con);
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                db_EmployeesDataGridView.DataSource = dt;
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Clear()
        {
            txtID.Clear();
            txtEmployeeName.Clear();
            txtEmployeeEducation.Clear();
            txtEmployeeAddress.Clear();
            cmbEmployeeGender.Text = "";
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtID.Text == "")
                {
                    MessageBox.Show("Please, Enter your ID", "Try Again", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtID.Focus();
                }
                else if (txtEmployeeName.Text == "")
                {
                    MessageBox.Show("Please, Enter your employee name", "Try Again", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtEmployeeName.Focus();
                }
                else if (txtEmployeeEducation.Text == "")
                {
                    MessageBox.Show("Please, Enter your employee education", "Try Again", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtEmployeeEducation.Focus();
                }
                else if (txtEmployeeAddress.Text == "")
                {
                    MessageBox.Show("Please, Enter your employee address", "Try Again", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtEmployeeAddress.Focus();
                }
                else if (cmbEmployeeGender.Text == "")
                {
                    MessageBox.Show("Please, Select your employee gender", "Try Again", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cmbEmployeeGender.Focus();
                }
                else
                {
                    SqlConnection con = new SqlConnection(connection.db);
                    con.Open();
                    String str = "UPDATE db_Employees SET Id = '"+txtID.Text+"', EEducation = '"+txtEmployeeEducation.Text+"', EAddress = '"+txtEmployeeAddress.Text+"', EGender = '"+cmbEmployeeGender.Text+"' WHERE EName = '"+txtEmployeeName.Text+"'";
                    SqlCommand cmd = new SqlCommand(str, con);
                    cmd.ExecuteNonQuery();
                    String str1 = "SELECT MAX(EName) FROM db_Employees";
                    SqlCommand cmd2 = new SqlCommand(str1, con);
                    SqlDataReader da = cmd2.ExecuteReader();

                    if (da.Read())
                    {
                        MessageBox.Show("Your information is updated successfully!", "Thank you!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Clear();
                        showData();
                    }
                    else
                    {
                        MessageBox.Show("Your information is updated unsuccessfully!", "Try again!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(connection.db);
                con.Open();
                String str = "DELETE FROM db_Employees Where EName = '" + txtEmployeeName.Text + "'";
                SqlCommand cmd = new SqlCommand(str, con);
                cmd.ExecuteNonQuery();
                String str1 = "SELECT MAX(EName) FROM db_Employees";
                SqlCommand cmd2 = new SqlCommand(str1, con);
                SqlDataReader da = cmd2.ExecuteReader();

                if (da.Read())
                {
                    MessageBox.Show("Your information is deleted successfully!", "Thank you!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Clear();
                    showData();
                }
                else
                {
                    MessageBox.Show("Your information is deleted unsuccessfully!", "Try again!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch(Exception ex) {  MessageBox.Show(ex.Message); }
        }

        private void db_EmployeesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.db_EmployeesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.ds_Employees);

        }

        private void db_EmployeesDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index;
            index = e.RowIndex;
            DataGridViewRow dgvr = db_EmployeesDataGridView.Rows[index];
            txtID.Text = dgvr.Cells[0].Value.ToString();
            txtEmployeeName.Text = dgvr.Cells[1].Value.ToString();
            txtEmployeeEducation.Text = dgvr.Cells[2].Value.ToString();
            txtEmployeeAddress.Text = dgvr.Cells[3].Value.ToString();
            cmbEmployeeGender.Text = dgvr.Cells[4].Value.ToString();
        }

        private void UserControlEmployee_Load(object sender, EventArgs e)
        {
            showData();
        }
    }
}
