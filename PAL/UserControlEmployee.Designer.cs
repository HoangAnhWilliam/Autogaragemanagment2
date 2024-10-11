namespace Autogaragemanagment2.PAL
{
    partial class UserControlEmployee
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControlEmployee));
            this.txtEmployeeName = new System.Windows.Forms.TextBox();
            this.lbl_name = new System.Windows.Forms.Label();
            this.txtEmployeeEducation = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtEmployeeAddress = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbEmployeeGender = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.db_EmployeesDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.db_EmployeesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ds_Employees = new Autogaragemanagment2.ds_Employees();
            this.btnInsert = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse2 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse3 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.txtID = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.db_EmployeesTableAdapter = new Autogaragemanagment2.ds_EmployeesTableAdapters.db_EmployeesTableAdapter();
            this.tableAdapterManager = new Autogaragemanagment2.ds_EmployeesTableAdapters.TableAdapterManager();
            this.db_EmployeesBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.db_EmployeesBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.db_EmployeesDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_EmployeesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds_Employees)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_EmployeesBindingNavigator)).BeginInit();
            this.db_EmployeesBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtEmployeeName
            // 
            this.txtEmployeeName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtEmployeeName.Location = new System.Drawing.Point(31, 79);
            this.txtEmployeeName.Name = "txtEmployeeName";
            this.txtEmployeeName.Size = new System.Drawing.Size(191, 22);
            this.txtEmployeeName.TabIndex = 4;
            this.txtEmployeeName.TextChanged += new System.EventHandler(this.txtVehicleID_TextChanged);
            // 
            // lbl_name
            // 
            this.lbl_name.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_name.AutoSize = true;
            this.lbl_name.BackColor = System.Drawing.Color.White;
            this.lbl_name.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold);
            this.lbl_name.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbl_name.Location = new System.Drawing.Point(27, 57);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(113, 19);
            this.lbl_name.TabIndex = 3;
            this.lbl_name.Text = "Employee Name:";
            this.lbl_name.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtEmployeeEducation
            // 
            this.txtEmployeeEducation.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtEmployeeEducation.Location = new System.Drawing.Point(229, 79);
            this.txtEmployeeEducation.Name = "txtEmployeeEducation";
            this.txtEmployeeEducation.Size = new System.Drawing.Size(191, 22);
            this.txtEmployeeEducation.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(225, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 19);
            this.label1.TabIndex = 5;
            this.label1.Text = "Employee Education:";
            // 
            // txtEmployeeAddress
            // 
            this.txtEmployeeAddress.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtEmployeeAddress.Location = new System.Drawing.Point(427, 79);
            this.txtEmployeeAddress.Name = "txtEmployeeAddress";
            this.txtEmployeeAddress.Size = new System.Drawing.Size(291, 22);
            this.txtEmployeeAddress.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(423, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 19);
            this.label2.TabIndex = 7;
            this.label2.Text = "Employee Address:";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(27, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 19);
            this.label3.TabIndex = 9;
            this.label3.Text = "Employee Gender:";
            // 
            // cmbEmployeeGender
            // 
            this.cmbEmployeeGender.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbEmployeeGender.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbEmployeeGender.FormattingEnabled = true;
            this.cmbEmployeeGender.Items.AddRange(new object[] {
            "---SELECT---",
            "MALE",
            "FEMALE",
            "OTHER"});
            this.cmbEmployeeGender.Location = new System.Drawing.Point(31, 126);
            this.cmbEmployeeGender.Name = "cmbEmployeeGender";
            this.cmbEmployeeGender.Size = new System.Drawing.Size(191, 36);
            this.cmbEmployeeGender.TabIndex = 11;
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.Controls.Add(this.db_EmployeesDataGridView);
            this.panel1.Location = new System.Drawing.Point(31, 168);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(698, 323);
            this.panel1.TabIndex = 12;
            // 
            // db_EmployeesDataGridView
            // 
            this.db_EmployeesDataGridView.AllowUserToAddRows = false;
            this.db_EmployeesDataGridView.AutoGenerateColumns = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Gold;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.db_EmployeesDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.db_EmployeesDataGridView.ColumnHeadersHeight = 40;
            this.db_EmployeesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.db_EmployeesDataGridView.DataSource = this.db_EmployeesBindingSource;
            this.db_EmployeesDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.db_EmployeesDataGridView.EnableHeadersVisualStyles = false;
            this.db_EmployeesDataGridView.Location = new System.Drawing.Point(0, 0);
            this.db_EmployeesDataGridView.Name = "db_EmployeesDataGridView";
            this.db_EmployeesDataGridView.RowHeadersVisible = false;
            this.db_EmployeesDataGridView.RowHeadersWidth = 51;
            this.db_EmployeesDataGridView.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.db_EmployeesDataGridView.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.DarkGray;
            this.db_EmployeesDataGridView.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.db_EmployeesDataGridView.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.db_EmployeesDataGridView.RowTemplate.Height = 35;
            this.db_EmployeesDataGridView.Size = new System.Drawing.Size(698, 323);
            this.db_EmployeesDataGridView.TabIndex = 0;
            this.db_EmployeesDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.db_EmployeesDataGridView_CellClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "EName";
            this.dataGridViewTextBoxColumn2.HeaderText = "Employee Name";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 225;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "EEducation";
            this.dataGridViewTextBoxColumn3.HeaderText = "Employee Education";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 225;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "EAddress";
            this.dataGridViewTextBoxColumn4.HeaderText = "Employee Address";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 225;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "EGender";
            this.dataGridViewTextBoxColumn5.HeaderText = "Employee Gender";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 225;
            // 
            // db_EmployeesBindingSource
            // 
            this.db_EmployeesBindingSource.DataMember = "db_Employees";
            this.db_EmployeesBindingSource.DataSource = this.ds_Employees;
            // 
            // ds_Employees
            // 
            this.ds_Employees.DataSetName = "ds_Employees";
            this.ds_Employees.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnInsert
            // 
            this.btnInsert.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnInsert.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(67)))), ((int)(((byte)(108)))));
            this.btnInsert.FlatAppearance.BorderSize = 0;
            this.btnInsert.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInsert.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsert.ForeColor = System.Drawing.Color.White;
            this.btnInsert.Location = new System.Drawing.Point(272, 131);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(134, 31);
            this.btnInsert.TabIndex = 13;
            this.btnInsert.Text = "Insert";
            this.btnInsert.UseVisualStyleBackColor = false;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnUpdate.BackColor = System.Drawing.Color.ForestGreen;
            this.btnUpdate.FlatAppearance.BorderSize = 0;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Location = new System.Drawing.Point(427, 131);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(134, 31);
            this.btnUpdate.TabIndex = 14;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDelete.BackColor = System.Drawing.Color.Crimson;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(584, 131);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(134, 31);
            this.btnDelete.TabIndex = 15;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DarkOrange;
            this.label4.Location = new System.Drawing.Point(3, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(216, 28);
            this.label4.TabIndex = 16;
            this.label4.Text = "ADD NEW EMPLOYEE";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.TargetControl = this.btnInsert;
            // 
            // guna2Elipse2
            // 
            this.guna2Elipse2.TargetControl = this.btnUpdate;
            // 
            // guna2Elipse3
            // 
            this.guna2Elipse3.TargetControl = this.btnDelete;
            // 
            // txtID
            // 
            this.txtID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtID.Location = new System.Drawing.Point(555, 40);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(174, 22);
            this.txtID.TabIndex = 18;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label5.Location = new System.Drawing.Point(703, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(26, 19);
            this.label5.TabIndex = 17;
            this.label5.Text = "ID:";
            // 
            // db_EmployeesTableAdapter
            // 
            this.db_EmployeesTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.db_EmployeesTableAdapter = this.db_EmployeesTableAdapter;
            this.tableAdapterManager.UpdateOrder = Autogaragemanagment2.ds_EmployeesTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // db_EmployeesBindingNavigator
            // 
            this.db_EmployeesBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.db_EmployeesBindingNavigator.BindingSource = this.db_EmployeesBindingSource;
            this.db_EmployeesBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.db_EmployeesBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.db_EmployeesBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.db_EmployeesBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.db_EmployeesBindingNavigatorSaveItem});
            this.db_EmployeesBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.db_EmployeesBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.db_EmployeesBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.db_EmployeesBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.db_EmployeesBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.db_EmployeesBindingNavigator.Name = "db_EmployeesBindingNavigator";
            this.db_EmployeesBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.db_EmployeesBindingNavigator.Size = new System.Drawing.Size(747, 31);
            this.db_EmployeesBindingNavigator.TabIndex = 19;
            this.db_EmployeesBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(45, 28);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 31);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 31);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 31);
            // 
            // db_EmployeesBindingNavigatorSaveItem
            // 
            this.db_EmployeesBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.db_EmployeesBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("db_EmployeesBindingNavigatorSaveItem.Image")));
            this.db_EmployeesBindingNavigatorSaveItem.Name = "db_EmployeesBindingNavigatorSaveItem";
            this.db_EmployeesBindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 28);
            this.db_EmployeesBindingNavigatorSaveItem.Text = "Save Data";
            this.db_EmployeesBindingNavigatorSaveItem.Click += new System.EventHandler(this.db_EmployeesBindingNavigatorSaveItem_Click);
            // 
            // UserControlEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.db_EmployeesBindingNavigator);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.cmbEmployeeGender);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtEmployeeAddress);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtEmployeeEducation);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtEmployeeName);
            this.Controls.Add(this.lbl_name);
            this.Name = "UserControlEmployee";
            this.Size = new System.Drawing.Size(747, 482);
            this.Load += new System.EventHandler(this.UserControlEmployee_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.db_EmployeesDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_EmployeesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds_Employees)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_EmployeesBindingNavigator)).EndInit();
            this.db_EmployeesBindingNavigator.ResumeLayout(false);
            this.db_EmployeesBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtEmployeeName;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.TextBox txtEmployeeEducation;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtEmployeeAddress;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbEmployeeGender;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse2;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse3;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label5;
        private ds_Employees ds_Employees;
        private System.Windows.Forms.BindingSource db_EmployeesBindingSource;
        private ds_EmployeesTableAdapters.db_EmployeesTableAdapter db_EmployeesTableAdapter;
        private ds_EmployeesTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator db_EmployeesBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton db_EmployeesBindingNavigatorSaveItem;
        public System.Windows.Forms.DataGridView db_EmployeesDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
    }
}
