namespace Autogaragemanagment2.PAL
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnBilling = new System.Windows.Forms.Button();
            this.btnReport = new System.Windows.Forms.Button();
            this.btnEmployee = new System.Windows.Forms.Button();
            this.btnCategory = new System.Windows.Forms.Button();
            this.btnVehicle = new System.Windows.Forms.Button();
            this.btnDashboard = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnlMove = new System.Windows.Forms.Panel();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblTimeAndDate = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.pnlCenter = new System.Windows.Forms.Panel();
            this.timerDateAndTime = new System.Windows.Forms.Timer(this.components);
            this.userControlStock1 = new Autogaragemanagment2.PAL.UserControlStock();
            this.userControlBilling1 = new Autogaragemanagment2.PAL.UserControlBilling();
            this.userControlVehicle21 = new Autogaragemanagment2.PAL.UserControlVehicle2();
            this.userControlEmployee1 = new Autogaragemanagment2.PAL.UserControlEmployee();
            this.userControlVehicle1 = new Autogaragemanagment2.PAL.UserControlVehicle();
            this.userControlDashboard1 = new Autogaragemanagment2.PAL.UserControlDashboard();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.pnlCenter.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Controls.Add(this.btnBilling);
            this.panel1.Controls.Add(this.btnReport);
            this.panel1.Controls.Add(this.btnEmployee);
            this.panel1.Controls.Add(this.btnCategory);
            this.panel1.Controls.Add(this.btnVehicle);
            this.panel1.Controls.Add(this.btnDashboard);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(234, 560);
            this.panel1.TabIndex = 0;
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Image = global::Autogaragemanagment2.Properties.Resources.turn_off;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(20, 517);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(200, 38);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "Logout";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnBilling
            // 
            this.btnBilling.FlatAppearance.BorderSize = 0;
            this.btnBilling.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBilling.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBilling.ForeColor = System.Drawing.Color.White;
            this.btnBilling.Image = global::Autogaragemanagment2.Properties.Resources.bill;
            this.btnBilling.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBilling.Location = new System.Drawing.Point(17, 417);
            this.btnBilling.Name = "btnBilling";
            this.btnBilling.Size = new System.Drawing.Size(200, 38);
            this.btnBilling.TabIndex = 0;
            this.btnBilling.Text = "Billing";
            this.btnBilling.UseVisualStyleBackColor = true;
            this.btnBilling.Click += new System.EventHandler(this.btnBilling_Click);
            // 
            // btnReport
            // 
            this.btnReport.FlatAppearance.BorderSize = 0;
            this.btnReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReport.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReport.ForeColor = System.Drawing.Color.White;
            this.btnReport.Image = global::Autogaragemanagment2.Properties.Resources.targeting;
            this.btnReport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReport.Location = new System.Drawing.Point(17, 373);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(200, 38);
            this.btnReport.TabIndex = 0;
            this.btnReport.Text = "Report";
            this.btnReport.UseVisualStyleBackColor = true;
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // btnEmployee
            // 
            this.btnEmployee.FlatAppearance.BorderSize = 0;
            this.btnEmployee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmployee.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmployee.ForeColor = System.Drawing.Color.White;
            this.btnEmployee.Image = global::Autogaragemanagment2.Properties.Resources.employee;
            this.btnEmployee.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEmployee.Location = new System.Drawing.Point(20, 329);
            this.btnEmployee.Name = "btnEmployee";
            this.btnEmployee.Size = new System.Drawing.Size(200, 38);
            this.btnEmployee.TabIndex = 0;
            this.btnEmployee.Text = "Employee";
            this.btnEmployee.UseVisualStyleBackColor = true;
            this.btnEmployee.Click += new System.EventHandler(this.btnEmployee_Click);
            // 
            // btnCategory
            // 
            this.btnCategory.FlatAppearance.BorderSize = 0;
            this.btnCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCategory.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCategory.ForeColor = System.Drawing.Color.White;
            this.btnCategory.Image = global::Autogaragemanagment2.Properties.Resources.categories;
            this.btnCategory.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCategory.Location = new System.Drawing.Point(20, 285);
            this.btnCategory.Name = "btnCategory";
            this.btnCategory.Size = new System.Drawing.Size(200, 38);
            this.btnCategory.TabIndex = 0;
            this.btnCategory.Text = "Category";
            this.btnCategory.UseVisualStyleBackColor = true;
            this.btnCategory.Click += new System.EventHandler(this.btnCategory_Click);
            // 
            // btnVehicle
            // 
            this.btnVehicle.FlatAppearance.BorderSize = 0;
            this.btnVehicle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVehicle.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVehicle.ForeColor = System.Drawing.Color.White;
            this.btnVehicle.Image = global::Autogaragemanagment2.Properties.Resources.hatchback;
            this.btnVehicle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVehicle.Location = new System.Drawing.Point(20, 241);
            this.btnVehicle.Name = "btnVehicle";
            this.btnVehicle.Size = new System.Drawing.Size(200, 38);
            this.btnVehicle.TabIndex = 0;
            this.btnVehicle.Text = "Vehicle";
            this.btnVehicle.UseVisualStyleBackColor = true;
            this.btnVehicle.Click += new System.EventHandler(this.btnBrand_Click);
            // 
            // btnDashboard
            // 
            this.btnDashboard.FlatAppearance.BorderSize = 0;
            this.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDashboard.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDashboard.ForeColor = System.Drawing.Color.White;
            this.btnDashboard.Image = global::Autogaragemanagment2.Properties.Resources.dashboard__1_;
            this.btnDashboard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDashboard.Location = new System.Drawing.Point(20, 197);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Size = new System.Drawing.Size(200, 38);
            this.btnDashboard.TabIndex = 0;
            this.btnDashboard.Text = "Dashboard";
            this.btnDashboard.UseVisualStyleBackColor = true;
            this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(205, 28);
            this.label2.TabIndex = 0;
            this.label2.Text = "Management System";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(42, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Auto Garage";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Autogaragemanagment2.Properties.Resources._3d_car;
            this.pictureBox1.Location = new System.Drawing.Point(82, 22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(65, 56);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pnlMove
            // 
            this.pnlMove.Location = new System.Drawing.Point(15, 197);
            this.pnlMove.Name = "pnlMove";
            this.pnlMove.Size = new System.Drawing.Size(6, 38);
            this.pnlMove.TabIndex = 0;
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 3;
            this.guna2Elipse1.TargetControl = this.pnlMove;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.panel2.Controls.Add(this.lblTimeAndDate);
            this.panel2.Controls.Add(this.lblUsername);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(234, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(747, 61);
            this.panel2.TabIndex = 0;
            // 
            // lblTimeAndDate
            // 
            this.lblTimeAndDate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTimeAndDate.AutoSize = true;
            this.lblTimeAndDate.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.lblTimeAndDate.ForeColor = System.Drawing.Color.White;
            this.lblTimeAndDate.Location = new System.Drawing.Point(700, 21);
            this.lblTimeAndDate.Name = "lblTimeAndDate";
            this.lblTimeAndDate.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblTimeAndDate.Size = new System.Drawing.Size(35, 28);
            this.lblTimeAndDate.TabIndex = 0;
            this.lblTimeAndDate.Text = "{?}";
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.lblUsername.ForeColor = System.Drawing.Color.White;
            this.lblUsername.Location = new System.Drawing.Point(176, 21);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblUsername.Size = new System.Drawing.Size(35, 28);
            this.lblUsername.TabIndex = 0;
            this.lblUsername.Text = "{?}";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(69, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 28);
            this.label3.TabIndex = 0;
            this.label3.Text = "Welcome:";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.panel3.Controls.Add(this.label4);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(234, 525);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(747, 35);
            this.panel3.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(6, 10);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label4.Size = new System.Drawing.Size(443, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "copyright © 2024. All rights reserved. Nguyen Gia Hoang Anh";
            // 
            // pnlCenter
            // 
            this.pnlCenter.Controls.Add(this.userControlStock1);
            this.pnlCenter.Controls.Add(this.userControlBilling1);
            this.pnlCenter.Controls.Add(this.userControlVehicle21);
            this.pnlCenter.Controls.Add(this.userControlEmployee1);
            this.pnlCenter.Controls.Add(this.userControlVehicle1);
            this.pnlCenter.Controls.Add(this.userControlDashboard1);
            this.pnlCenter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCenter.Location = new System.Drawing.Point(234, 61);
            this.pnlCenter.Name = "pnlCenter";
            this.pnlCenter.Size = new System.Drawing.Size(747, 464);
            this.pnlCenter.TabIndex = 0;
            // 
            // timerDateAndTime
            // 
            this.timerDateAndTime.Tick += new System.EventHandler(this.timerDateAndTime_Tick);
            // 
            // userControlStock1
            // 
            this.userControlStock1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userControlStock1.Location = new System.Drawing.Point(0, 0);
            this.userControlStock1.Name = "userControlStock1";
            this.userControlStock1.Size = new System.Drawing.Size(747, 464);
            this.userControlStock1.TabIndex = 7;
            // 
            // userControlBilling1
            // 
            this.userControlBilling1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userControlBilling1.Location = new System.Drawing.Point(0, 0);
            this.userControlBilling1.Name = "userControlBilling1";
            this.userControlBilling1.Size = new System.Drawing.Size(747, 464);
            this.userControlBilling1.TabIndex = 6;
            // 
            // userControlVehicle21
            // 
            this.userControlVehicle21.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userControlVehicle21.Location = new System.Drawing.Point(0, 0);
            this.userControlVehicle21.Name = "userControlVehicle21";
            this.userControlVehicle21.Size = new System.Drawing.Size(747, 464);
            this.userControlVehicle21.TabIndex = 5;
            // 
            // userControlEmployee1
            // 
            this.userControlEmployee1.BackColor = System.Drawing.Color.White;
            this.userControlEmployee1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userControlEmployee1.Location = new System.Drawing.Point(0, 0);
            this.userControlEmployee1.Name = "userControlEmployee1";
            this.userControlEmployee1.Size = new System.Drawing.Size(747, 464);
            this.userControlEmployee1.TabIndex = 4;
            // 
            // userControlVehicle1
            // 
            this.userControlVehicle1.BackColor = System.Drawing.Color.White;
            this.userControlVehicle1.Location = new System.Drawing.Point(0, 0);
            this.userControlVehicle1.Name = "userControlVehicle1";
            this.userControlVehicle1.Size = new System.Drawing.Size(747, 464);
            this.userControlVehicle1.TabIndex = 0;
            this.userControlVehicle1.Visible = false;
            this.userControlVehicle1.Load += new System.EventHandler(this.userControlVehicle1_Load);
            // 
            // userControlDashboard1
            // 
            this.userControlDashboard1.BackColor = System.Drawing.Color.White;
            this.userControlDashboard1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userControlDashboard1.Location = new System.Drawing.Point(0, 0);
            this.userControlDashboard1.Name = "userControlDashboard1";
            this.userControlDashboard1.Size = new System.Drawing.Size(747, 464);
            this.userControlDashboard1.TabIndex = 0;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(981, 560);
            this.Controls.Add(this.pnlCenter);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pnlMove);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Auto Garage Management System";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.pnlCenter.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDashboard;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnVehicle;
        private System.Windows.Forms.Button btnCategory;
        private System.Windows.Forms.Button btnEmployee;
        private System.Windows.Forms.Button btnReport;
        private System.Windows.Forms.Button btnBilling;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Panel pnlMove;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblTimeAndDate;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel pnlCenter;
        private System.Windows.Forms.Timer timerDateAndTime;
        private UserControlDashboard userControlDashboard1;
        private UserControlVehicle userControlVehicle1;
        private UserControlEmployee userControlEmployee1;
        private UserControlVehicle2 userControlVehicle21;
        private UserControlBilling userControlBilling1;
        private UserControlStock userControlStock1;
    }
}