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
    public partial class UserControlStock : UserControl
    {
        Connection connection = new Connection();
        public UserControlStock()
        {
            InitializeComponent();
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
                else if (cmbPartName.Text == "")
                {
                    MessageBox.Show("Please, Enter your part name", "Try Again", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cmbPartName.Focus();
                }
                else if (txtPartQty.Text == "")
                {
                    MessageBox.Show("Please, Enter your part quantity", "Try Again", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtPartQty.Focus();
                }
                else if (txtPartPrice.Text == "")
                {
                    MessageBox.Show("Please, Enter your part price", "Try Again", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtPartPrice.Focus();
                }
                else
                {
                    SqlConnection con = new SqlConnection(connection.db);
                    con.Open();
                    String str = "INSERT INTO db_Stocks(Id,PartName,PartQut,PartPrice) VALUES('" + txtID.Text + "','" + cmbPartName.Text + "', '" + txtPartQty.Text + "', '" + txtPartPrice.Text + "')";
                    SqlCommand cmd = new SqlCommand(str, con);
                    cmd.ExecuteNonQuery();
                    String str1 = "SELECT MAX(PartName) FROM db_Stocks";
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
                String str = "SELECT * FROM db_Stocks";
                SqlCommand cmd = new SqlCommand(str, con);
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                db_StocksDataGridView.DataSource = dt;
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
            cmbPartName.Text = "";
            txtPartQty.Clear();
            txtPartPrice.Clear();
        }

        private void db_StocksBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.db_StocksBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.ds_Stocks);

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
                else if (cmbPartName.Text == "")
                {
                    MessageBox.Show("Please, Enter your part name", "Try Again", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cmbPartName.Focus();
                }
                else if (txtPartQty.Text == "")
                {
                    MessageBox.Show("Please, Enter your part quantity", "Try Again", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtPartQty.Focus();
                }
                else if (txtPartPrice.Text == "")
                {
                    MessageBox.Show("Please, Enter your part price", "Try Again", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtPartPrice.Focus();
                }
                else
                {
                    SqlConnection con = new SqlConnection(connection.db);
                    con.Open();
                    String str = "UPDATE db_Stocks SET Id = '"+txtID.Text+"', PartQut = '"+txtPartQty.Text+"', PartPrice = '"+txtPartPrice.Text+"' WHERE PartName = '"+cmbPartName.Text+"'";
                    SqlCommand cmd = new SqlCommand(str, con);
                    cmd.ExecuteNonQuery();
                    String str1 = "SELECT MAX(PartName) FROM db_Stocks";
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
                String str = "DELETE FROM db_Stocks WHERE PartName = '" + cmbPartName.Text + "'";
                SqlCommand cmd = new SqlCommand(str, con);
                cmd.ExecuteNonQuery();
                String str1 = "SELECT MAX(PartName) FROM db_Stocks";
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
            catch(Exception ex) { 
                MessageBox.Show(ex.Message);
            }
        }

        private void db_StocksDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index;
            index = e.RowIndex;
            DataGridViewRow dgvr = db_StocksDataGridView.Rows[index];
            txtID.Text = dgvr.Cells[0].Value.ToString();
            cmbPartName.Text = dgvr.Cells[1].Value.ToString();
            txtPartQty.Text = dgvr.Cells[2].Value.ToString();
            txtPartPrice.Text = dgvr.Cells[3].Value.ToString();
        }
    }
}
