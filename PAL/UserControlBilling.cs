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
using System.Security.Cryptography;

namespace Autogaragemanagment2.PAL
{
    public partial class UserControlBilling : UserControl
    {   
        Connection connection = new Connection();
        double totalPrice;
        
        public UserControlBilling()
        {
            InitializeComponent();
        }

        public static string getUniqueKey(int maxSize)
        {
            char[] chars = new char[62];
            chars = "1234567890".ToCharArray();
            byte[] data = new byte[1];

            RNGCryptoServiceProvider crypto = new RNGCryptoServiceProvider();
            crypto.GetNonZeroBytes(data);
            data = new byte[maxSize];
            crypto.GetNonZeroBytes(data);

            StringBuilder result = new StringBuilder(maxSize);
            foreach(byte b in data)
            {
                result.Append(chars[b % (chars.Length)]);
            }
            return result.ToString();
        }

        public void autoBillNo()
        {
            txtBillNo.Text = "" + getUniqueKey(6);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtID.Text == "")
                {
                    MessageBox.Show("Please enter your ID","Try again", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtID.Focus();
                }
                else if (txtBillNo.Text == "")
                {
                    MessageBox.Show("Please enter your bill no", "Try again", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtBillNo.Focus();
                }
                else if (txtPartName.Text == "")
                {
                    MessageBox.Show("Please enter your part name", "Try again", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtPartName.Focus();
                }
                else if (txtPartPrice.Text == "")
                {
                    MessageBox.Show("Please enter your part price", "Try again", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtPartPrice.Focus();
                }
                else if (txtPartQuantity.Text == "")
                {
                    MessageBox.Show("Please enter your part quantity", "Try again", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtPartQuantity.Focus();
                }
                else if (txtTotalPrice.Text == "")
                {
                    MessageBox.Show("Please enter your total price", "Try again", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtTotalPrice.Focus();
                }
                else if (txtGrandTotal.Text == "")
                {
                    MessageBox.Show("Please enter your grand total", "Try again", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtGrandTotal.Focus();
                }
                else
                {
                    SqlConnection con = new SqlConnection(connection.db);
                    con.Open();
                    String str = "INSERT INTO db_Bills(Id,BillNo,PartName,PartPrice,PartQty,TotalPrice) VALUES('" + txtID.Text + "','" + txtBillNo.Text + "', '" + txtPartName.Text + "', '" + txtPartQuantity.Text + "', '"+txtPartPrice.Text+"', '"+txtGrandTotal.Text+"')";
                    SqlCommand cmd = new SqlCommand(str, con);
                    cmd.ExecuteNonQuery();
                    String str1 = "SELECT MAX(BillNo) FROM db_Bills";
                    SqlCommand cmd2 = new SqlCommand(str1, con);
                    SqlDataReader da = cmd2.ExecuteReader();

                    if (da.Read())
                    {
                        Clear();
                        showData();
                        billCalculation();
                        autoBillNo();
                    }
                    else
                    {
                        MessageBox.Show("Your information is inserted unsuccessfully!", "Try again!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void billCalculation()
        {
            int A = 0; int B = 0;
            for(A = 0; A > db_BillCardsDataGridView.Rows.Count; ++A)
            {
                B += Convert.ToInt32(db_BillCardsDataGridView.Rows[A].Cells[4].Value);
            };

            txtGrandTotal.Text = B.ToString();
        }

        private void showData()
        {
            SqlConnection con = new SqlConnection(connection.db);
            con.Open();
            String str = "SELECT * FROM BillCards";
            SqlCommand cmd = new SqlCommand(str, con);
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            db_BillCardsDataGridView.DataSource = dt;
            con.Close();
        }

        private void Clear()
        {
            txtID.Clear();
            txtPartName.Clear();
            txtPartPrice.Clear();
            txtPartQuantity.Clear();
            txtPartName.Focus();
        }

        private void ClearAll()
        {
            txtID.Clear();
            txtPartName.Clear();
            txtPartPrice.Clear();
            txtPartQuantity.Clear();
            txtTotalPrice.Clear();
            txtPartName.Focus();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(connection.db);
                con.Open();
                String str = "DELETE FROM db_BillCards WHERE BillNo = '" + txtBillNo.Text + "'";
                SqlCommand cmd = new SqlCommand(str, con);
                cmd.ExecuteNonQuery();
                String str1 = "SELECT MAX(BillNo) FROM db_BillCards";
                SqlCommand cmd2 = new SqlCommand(str1, con);
                SqlDataReader da = cmd2.ExecuteReader();

                if (da.Read())
                {
                    Clear();
                    showData();
                    billCalculation();
                }
                else
                {
                    MessageBox.Show("Your information is inserted unsuccessfully!", "Try again!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void db_BillCardsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.db_BillCardsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.ds_BillCards);

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtID.Text == "")
                {
                    MessageBox.Show("Please enter your ID", "Try again", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtID.Focus();
                }
                else if (txtBillNo.Text == "")
                {
                    MessageBox.Show("Please enter your ID", "Try again", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtBillNo.Focus();
                }
                else if (txtPartName.Text == "")
                {
                    MessageBox.Show("Please enter your ID", "Try again", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtPartName.Focus();
                }
                else if (txtPartPrice.Text == "")
                {
                    MessageBox.Show("Please enter your ID", "Try again", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtPartPrice.Focus();
                }
                else if (txtPartQuantity.Text == "")
                {
                    MessageBox.Show("Please enter your ID", "Try again", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtPartQuantity.Focus();
                }
                else
                {
                    SqlConnection con = new SqlConnection(connection.db);
                    con.Open();
                    String str = "INSERT INTO db_Bills(Id,BillNo,PartName,PartPrice,PartQty,TotalPrice) VALUES('" + txtID.Text + "','" + txtBillNo.Text + "', '" + txtPartName.Text + "', '" + txtPartQuantity.Text + "', '"+txtTotalPrice.Text+"')";
                    SqlCommand cmd = new SqlCommand(str, con);
                    cmd.ExecuteNonQuery();
                    String str1 = "SELECT MAX(BillNo) FROM db_Vehicles";
                    SqlCommand cmd2 = new SqlCommand(str1, con);
                    SqlDataReader da = cmd2.ExecuteReader();

                    if (da.Read())
                    {   
                        MessageBox.Show("Your bill is saved successfully", "Thank you!", MessageBoxButtons.OK,MessageBoxIcon.Information);
                        Clear();
                        showData();
                        billCalculation();
                    }
                    else
                    {
                        MessageBox.Show("Your information is inserted unsuccessfully!", "Try again!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void txtPartQuantity_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtPartQuantity.Text == "")
                {
                    txtPartQuantity.Clear();
                }
                else if(txtPartName.Text == "")
                {
                    MessageBox.Show("Please, Enter part name", "Try again", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtPartName.Focus();
                }
                else
                {
                    
                    totalPrice = double.Parse(txtPartPrice.Text) * double.Parse(txtPartQuantity.Text);
                    txtTotalPrice.Text = totalPrice.ToString();
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            billCalculation();
        }

        private void UserControlBilling_Load(object sender, EventArgs e)
        {
            autoBillNo();
        }
    }
}
