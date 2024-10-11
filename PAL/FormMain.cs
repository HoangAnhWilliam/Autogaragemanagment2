using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Autogaragemanagment2.PAL
{
    public partial class FormMain : Form
    {
        public string name = "{?}";
        public FormMain()
        {
            InitializeComponent();
        }

        private void MovePanel(Control btn)
        {
            pnlMove.Top = btn.Top;
            pnlMove.Height = btn.Height;
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            lblUsername.Text = name;
            timerDateAndTime.Start();

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you want to logout?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                MovePanel(btnClose);
                timerDateAndTime.Stop();
                Close();
            }
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            MovePanel(btnDashboard);
            userControlDashboard1.Visible = true;
            userControlVehicle1.Visible = false;
            userControlEmployee1.Visible = false;
            userControlVehicle21.Visible = false;
            userControlBilling1.Visible = false;
            userControlStock1.Visible = false;
        }

        private void btnBrand_Click(object sender, EventArgs e)
        {
            MovePanel(btnVehicle);
            userControlDashboard1.Visible = false;
            //userControlVehicle1.EmptyBox();
            userControlVehicle21.Visible = true;
            userControlEmployee1.Visible = false;
            userControlBilling1.Visible = false;
            userControlStock1.Visible = false;
        }

        private void btnCategory_Click(object sender, EventArgs e)
        {
            MovePanel(btnCategory);
            userControlDashboard1.Visible = false;
            userControlVehicle1.Visible = false;
            userControlEmployee1.Visible = false;
            userControlVehicle21.Visible = false;
            userControlBilling1.Visible = false;
            userControlStock1.Visible = true;
        }

        private void btnEmployee_Click(object sender, EventArgs e)
        {
            MovePanel(btnEmployee);
            userControlDashboard1.Visible = false;
            userControlVehicle1.Visible = false;
            userControlEmployee1.Visible = true;
            userControlVehicle21.Visible = false;
            userControlBilling1.Visible = false;
            userControlStock1.Visible = false;
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            MovePanel(btnReport);
            userControlDashboard1.Visible = false;
            userControlVehicle1.Visible = false;
            userControlEmployee1.Visible = false;
            userControlVehicle21.Visible = false;
            userControlBilling1.Visible = false;
            userControlStock1.Visible = false;
            FormReport formReport = new FormReport();
            formReport.ShowDialog();
        }

        private void btnBilling_Click(object sender, EventArgs e)
        {
            MovePanel(btnBilling);
            userControlDashboard1.Visible = false;
            userControlVehicle1.Visible = false;
            userControlEmployee1.Visible = false;
            userControlVehicle21.Visible = false;
            userControlBilling1.Visible = true;
            userControlStock1.Visible = false;
        }

        private void timerDateAndTime_Tick(object sender, EventArgs e)
        {
            lblTimeAndDate.Text = DateTime.Now.ToString("dd-MM-yyyy HH:mm:ss tt");
        }

        private void userControlVehicle1_Load(object sender, EventArgs e)
        {

        }
    }
}
