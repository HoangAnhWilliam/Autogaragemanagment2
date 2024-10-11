using Microsoft.Reporting.WinForms;
using Microsoft.ReportingServices.Diagnostics.Internal;
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
    public partial class FormReport : Form
    {   
        Connection connection = new Connection();
        public FormReport()
        {
            InitializeComponent();
        }
        
        private void FormReport_Load(object sender, EventArgs e)
        {
            try
            {
                reportViewer1.LocalReport.ReportEmbeddedResource = "Autogaragemanagment2.Report1.rdlc";
                ReportDataSource reportDataSource = new ReportDataSource();
                reportDataSource.Name = "DataSet2";
                reportDataSource.Value = getAllBills();
                reportViewer1.LocalReport.DataSources.Add(reportDataSource);
                this.reportViewer1.RefreshReport();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
        //private DataTable getAllBills()
        //{
        //    SqlConnection con = new SqlConnection(connection.db);
        //    con.Open();
        //    String str = "SELECT * FROM Bills";
        //    SqlCommand cmd = new SqlCommand(str, con);
        //    cmd.ExecuteNonQuery();
        //    DataTable dt = new DataTable();
        //    SqlDataAdapter da = new SqlDataAdapter(cmd);
        //    da.Fill(dt);
        //    con.Close();
        //    return dt;
        //}
        private DataTable getAllBills()
        {
            DataTable billsTable = new DataTable();

            try
            {
                using (SqlConnection conn = new SqlConnection(connection.db))
                {
                    conn.Open();
                    string query = "SELECT * FROM db_Bills"; // Thay thế bằng truy vấn thực tế của bạn
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                        {
                            adapter.Fill(billsTable);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

            return billsTable;
        }
    }
}
