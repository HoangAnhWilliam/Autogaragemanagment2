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
    public partial class UserControlVehicle2 : UserControl
    {   
        Connection connection = new Connection();
        public UserControlVehicle2()
        {
            InitializeComponent();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            try
            {   
                if(txtID.Text == "")
                {
                    MessageBox.Show("Please, Enter your ID", "Try again", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtID.Focus();
                }
                else if (txtVehicleID.Text == "")
                {
                    MessageBox.Show("Please, Enter your vehicle ID", "Try again", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtVehicleID.Focus();
                }
                else if (txtVehicleBrand.Text == "")
                {
                    MessageBox.Show("Please, Enter your vehicle brand", "Try again", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtVehicleBrand.Focus();
                }
                else if (txtVehicleModel.Text == "")
                {
                    MessageBox.Show("Please, Enter your vehicle model", "Try again", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtVehicleModel.Focus();
                }
                else if (txtVehicleColor.Text == "")
                {
                    MessageBox.Show("Please, Enter your vehicle color", "Try again", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtVehicleColor.Focus();
                }
                else if (txtOwnerName.Text == "")
                {
                    MessageBox.Show("Please, Enter your name", "Try again", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtOwnerName.Focus();
                }
                else
                {
                    SqlConnection con = new SqlConnection(connection.db);
                    con.Open();
                    String str = "INSERT INTO db_Vehicles(Id,VehicleNo,VehicleBrand,VehicleModel,Date,VehicleColor,OwnerName) VALUES('"+txtID.Text+"','" + txtVehicleID.Text + "', '" + txtVehicleBrand.Text + "', '" + txtVehicleModel.Text + "', '" + dtpDate.Text + "', '" + txtVehicleColor.Text + "', '" + txtOwnerName.Text + "')";
                    SqlCommand cmd = new SqlCommand(str, con);
                    cmd.ExecuteNonQuery();
                    String str1 = "SELECT MAX(VehicleNo) FROM db_Vehicles";
                    SqlCommand cmd2 = new SqlCommand(str1, con);
                    SqlDataReader da = cmd2.ExecuteReader();

                    if (da.Read())
                    {
                        MessageBox.Show("Your information is inserted successfully!","Thank you!",MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Clear();
                        showData();
                    }
                    else
                    {
                        MessageBox.Show("Your information is inserted unsuccessfully!", "Try again!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void Clear()
        {
            txtOwnerName.Clear();
            txtVehicleID.Clear();
            txtVehicleBrand.Clear();
            txtVehicleModel.Clear();
            txtVehicleColor.Clear();
            txtID.Clear();
            dtpDate.Text = ""; 
        }
        private void UserControlVehicle2_Load(object sender, EventArgs e)
        {
            showData();
        }

        private void showData()
        {
            try
            {
                SqlConnection con = new SqlConnection(connection.db);
                con.Open();
                String str = "SELECT * FROM db_Vehicles";
                SqlCommand cmd = new SqlCommand(str,con);
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                db_VehiclesDataGridView.DataSource = dt;
                con.Close();
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtID.Text == "")
                {
                    MessageBox.Show("Please, Enter your ID", "Try again", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtID.Focus();
                }
                else if (txtVehicleID.Text == "")
                {
                    MessageBox.Show("Please, Enter your vehicle ID", "Try again", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtVehicleID.Focus();
                }
                else if (txtVehicleBrand.Text == "")
                {
                    MessageBox.Show("Please, Enter your vehicle brand", "Try again", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtVehicleBrand.Focus();
                }
                else if (txtVehicleModel.Text == "")
                {
                    MessageBox.Show("Please, Enter your vehicle model", "Try again", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtVehicleModel.Focus();
                }
                else if (txtVehicleColor.Text == "")
                {
                    MessageBox.Show("Please, Enter your vehicle color", "Try again", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtVehicleColor.Focus();
                }
                else if (txtOwnerName.Text == "")
                {
                    MessageBox.Show("Please, Enter your name", "Try again", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtOwnerName.Focus();
                }
                else
                {
                    SqlConnection con = new SqlConnection(connection.db);
                    con.Open();
                    String str = "UPDATE db_Vehicles SET VehicleNo = '"+txtID.Text+"', VehicleBrand = '"+txtVehicleBrand.Text+"', VehicleModel = '"+txtVehicleModel.Text+"', Date = '"+dtpDate.Text+"', VehicleColor ='"+txtVehicleColor.Text+"', OwnerName = '"+txtOwnerName.Text+"' WHERE Id = '"+txtID.Text+"'";
                    SqlCommand cmd = new SqlCommand(str, con);
                    cmd.ExecuteNonQuery();
                    String str1 = "SELECT MAX(VehicleNo) FROM db_Vehicles";
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
                    String str = "DELETE FROM db_Vehicles WHERE VehicleNo = '"+txtVehicleID.Text+"'";
                    SqlCommand cmd = new SqlCommand(str, con);
                    cmd.ExecuteNonQuery();
                    String str1 = "SELECT MAX(VehicleNo) FROM db_Vehicles";
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
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void db_VehiclesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.db_VehiclesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.ds_Vehicles);

        }

        private void db_VehiclesDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int index;
                index = e.RowIndex;
                DataGridViewRow dgvr = db_VehiclesDataGridView.Rows[index];
                txtID.Text = dgvr.Cells[0].Value.ToString();
                txtVehicleID.Text = dgvr.Cells[1].Value.ToString();
                txtVehicleBrand.Text = dgvr.Cells[2].Value.ToString();
                txtVehicleModel.Text = dgvr.Cells[3].Value.ToString();
                dtpDate.Text = dgvr.Cells[4].Value.ToString();
                txtVehicleColor.Text = dgvr.Cells[5].Value.ToString();
                txtOwnerName.Text = dgvr.Cells[6].Value.ToString();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
