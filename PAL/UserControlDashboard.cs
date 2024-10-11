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
    public partial class UserControlDashboard : UserControl
    {   
        Connection connection = new Connection();
        public UserControlDashboard()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
        
        public void Count()
        {
            
        }

        private void UserControlDashboard_Load(object sender, EventArgs e)
        {
            revenue();
            totalVehicle();
            totalSpare();
            totalEmployees();
            
        }

        private void totalRevenue()
        {
            SqlConnection con = new SqlConnection(connection.db);
            con.Open();
            String str = "SELECT * FROM db_Bills";
            SqlCommand cmd = new SqlCommand(str, con);
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            con.Close();
            
        }
        private void revenue()
        {
            totalRevenue();
            int A = 0; int B = 0;
            for (A = 0; A > db_BillsDataGridView.Rows.Count; ++A)
            {
                B += Convert.ToInt32(db_BillsDataGridView.Rows[A].Cells[5].Value);
            };

            lblRevenue.Text = B.ToString();
        }
        private void totalEmployees()
        {
            SqlConnection con = new SqlConnection(connection.db);
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT COUNT(EName) FROM db_Employees";
            Int32 rows_count = Convert.ToInt32(cmd.ExecuteScalar());
            con.Close();
            lblEmployees.Text = rows_count.ToString();
        }

        private void totalSpare()
        {
            SqlConnection con = new SqlConnection(connection.db);
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT COUNT(PartName) FROM db_Stocks";
            Int32 rows_count = Convert.ToInt32(cmd.ExecuteScalar());
            con.Close();
            lblSpare.Text = rows_count.ToString();
        }

        private void totalVehicle()
        {
            SqlConnection con = new SqlConnection(connection.db);
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT COUNT(VehicleNo) FROM db_Vehicles";
            Int32 rows_count = Convert.ToInt32(cmd.ExecuteScalar());
            con.Close();
            lblVehicle.Text = rows_count.ToString();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            revenue();
            totalVehicle();
            totalSpare();
            totalEmployees();
        }

        private void db_BillsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.db_BillsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.ds_Revenue);

        }
    }
}
