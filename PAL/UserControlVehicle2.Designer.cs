namespace Autogaragemanagment2.PAL
{
    partial class UserControlVehicle2
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControlVehicle2));
            this.txtOwnerName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtVehicleColor = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnInsert = new System.Windows.Forms.Button();
            this.txtVehicleModel = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtVehicleBrand = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtVehicleID = new System.Windows.Forms.TextBox();
            this.lbl_name = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.db_VehiclesDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.db_VehiclesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ds_Vehicles = new Autogaragemanagment2.ds_Vehicles();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.db_VehiclesTableAdapter = new Autogaragemanagment2.ds_VehiclesTableAdapters.db_VehiclesTableAdapter();
            this.tableAdapterManager = new Autogaragemanagment2.ds_VehiclesTableAdapters.TableAdapterManager();
            this.db_VehiclesBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.db_VehiclesBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.db_VehiclesDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_VehiclesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds_Vehicles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_VehiclesBindingNavigator)).BeginInit();
            this.db_VehiclesBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtOwnerName
            // 
            this.txtOwnerName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtOwnerName.Location = new System.Drawing.Point(490, 120);
            this.txtOwnerName.Name = "txtOwnerName";
            this.txtOwnerName.Size = new System.Drawing.Size(188, 22);
            this.txtOwnerName.TabIndex = 50;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label6.Location = new System.Drawing.Point(486, 98);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 19);
            this.label6.TabIndex = 49;
            this.label6.Text = "Owner Name:";
            // 
            // txtVehicleColor
            // 
            this.txtVehicleColor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtVehicleColor.Location = new System.Drawing.Point(291, 120);
            this.txtVehicleColor.Name = "txtVehicleColor";
            this.txtVehicleColor.Size = new System.Drawing.Size(186, 22);
            this.txtVehicleColor.TabIndex = 48;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label5.Location = new System.Drawing.Point(287, 98);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 19);
            this.label5.TabIndex = 47;
            this.label5.Text = "Vehicle Color";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(74, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 19);
            this.label3.TabIndex = 45;
            this.label3.Text = "Date";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DarkOrange;
            this.label4.Location = new System.Drawing.Point(3, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(248, 28);
            this.label4.TabIndex = 44;
            this.label4.Text = "VEHICLES INFORMATION";
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDelete.BackColor = System.Drawing.Color.Crimson;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(517, 148);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(134, 31);
            this.btnDelete.TabIndex = 43;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnUpdate.BackColor = System.Drawing.Color.ForestGreen;
            this.btnUpdate.FlatAppearance.BorderSize = 0;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Location = new System.Drawing.Point(315, 148);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(134, 31);
            this.btnUpdate.TabIndex = 42;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnInsert
            // 
            this.btnInsert.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnInsert.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(67)))), ((int)(((byte)(108)))));
            this.btnInsert.FlatAppearance.BorderSize = 0;
            this.btnInsert.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInsert.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsert.ForeColor = System.Drawing.Color.White;
            this.btnInsert.Location = new System.Drawing.Point(104, 148);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(134, 31);
            this.btnInsert.TabIndex = 41;
            this.btnInsert.Text = "Insert";
            this.btnInsert.UseVisualStyleBackColor = false;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // txtVehicleModel
            // 
            this.txtVehicleModel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtVehicleModel.Location = new System.Drawing.Point(487, 73);
            this.txtVehicleModel.Name = "txtVehicleModel";
            this.txtVehicleModel.Size = new System.Drawing.Size(191, 22);
            this.txtVehicleModel.TabIndex = 40;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(483, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 19);
            this.label2.TabIndex = 39;
            this.label2.Text = "Vehicle Model";
            // 
            // txtVehicleBrand
            // 
            this.txtVehicleBrand.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtVehicleBrand.Location = new System.Drawing.Point(286, 73);
            this.txtVehicleBrand.Name = "txtVehicleBrand";
            this.txtVehicleBrand.Size = new System.Drawing.Size(191, 22);
            this.txtVehicleBrand.TabIndex = 38;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(282, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 19);
            this.label1.TabIndex = 37;
            this.label1.Text = "Vehicle Brand:";
            // 
            // txtVehicleID
            // 
            this.txtVehicleID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtVehicleID.Location = new System.Drawing.Point(78, 73);
            this.txtVehicleID.Name = "txtVehicleID";
            this.txtVehicleID.Size = new System.Drawing.Size(191, 22);
            this.txtVehicleID.TabIndex = 36;
            // 
            // lbl_name
            // 
            this.lbl_name.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_name.AutoSize = true;
            this.lbl_name.BackColor = System.Drawing.Color.White;
            this.lbl_name.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold);
            this.lbl_name.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbl_name.Location = new System.Drawing.Point(74, 51);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(87, 19);
            this.lbl_name.TabIndex = 35;
            this.lbl_name.Text = "Vehicle No. :";
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BackColor = System.Drawing.Color.DarkGray;
            this.panel1.Controls.Add(this.db_VehiclesDataGridView);
            this.panel1.Location = new System.Drawing.Point(8, 185);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(736, 322);
            this.panel1.TabIndex = 51;
            // 
            // db_VehiclesDataGridView
            // 
            this.db_VehiclesDataGridView.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.DarkOrange;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Roboto Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            this.db_VehiclesDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.db_VehiclesDataGridView.AutoGenerateColumns = false;
            this.db_VehiclesDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DarkOrange;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.db_VehiclesDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.db_VehiclesDataGridView.ColumnHeadersHeight = 40;
            this.db_VehiclesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7});
            this.db_VehiclesDataGridView.DataSource = this.db_VehiclesBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.DarkOrange;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.db_VehiclesDataGridView.DefaultCellStyle = dataGridViewCellStyle3;
            this.db_VehiclesDataGridView.EnableHeadersVisualStyles = false;
            this.db_VehiclesDataGridView.GridColor = System.Drawing.Color.Silver;
            this.db_VehiclesDataGridView.Location = new System.Drawing.Point(0, 0);
            this.db_VehiclesDataGridView.Name = "db_VehiclesDataGridView";
            this.db_VehiclesDataGridView.RowHeadersVisible = false;
            this.db_VehiclesDataGridView.RowHeadersWidth = 51;
            this.db_VehiclesDataGridView.RowTemplate.Height = 24;
            this.db_VehiclesDataGridView.Size = new System.Drawing.Size(733, 308);
            this.db_VehiclesDataGridView.TabIndex = 0;
            this.db_VehiclesDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.db_VehiclesDataGridView_CellClick);
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
            this.dataGridViewTextBoxColumn2.DataPropertyName = "VehicleNo";
            this.dataGridViewTextBoxColumn2.HeaderText = "Vehicle ID";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "VehicleBrand";
            this.dataGridViewTextBoxColumn3.HeaderText = "Vehicle Brand";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "VehicleModel";
            this.dataGridViewTextBoxColumn4.HeaderText = "Vehicle Model";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Date";
            this.dataGridViewTextBoxColumn5.HeaderText = "Date";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 125;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "VehicleColor";
            this.dataGridViewTextBoxColumn6.HeaderText = "Vehicle Color";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 125;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "OwnerName";
            this.dataGridViewTextBoxColumn7.HeaderText = "Owner Name";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.Width = 125;
            // 
            // db_VehiclesBindingSource
            // 
            this.db_VehiclesBindingSource.DataMember = "db_Vehicles";
            this.db_VehiclesBindingSource.DataSource = this.ds_Vehicles;
            // 
            // ds_Vehicles
            // 
            this.ds_Vehicles.DataSetName = "ds_Vehicles";
            this.ds_Vehicles.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dtpDate
            // 
            this.dtpDate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtpDate.CalendarFont = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDate.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDate.Location = new System.Drawing.Point(78, 116);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(191, 25);
            this.dtpDate.TabIndex = 52;
            // 
            // db_VehiclesTableAdapter
            // 
            this.db_VehiclesTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.db_VehiclesTableAdapter = this.db_VehiclesTableAdapter;
            this.tableAdapterManager.UpdateOrder = Autogaragemanagment2.ds_VehiclesTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // db_VehiclesBindingNavigator
            // 
            this.db_VehiclesBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.db_VehiclesBindingNavigator.BindingSource = this.db_VehiclesBindingSource;
            this.db_VehiclesBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.db_VehiclesBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.db_VehiclesBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.db_VehiclesBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.db_VehiclesBindingNavigatorSaveItem});
            this.db_VehiclesBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.db_VehiclesBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.db_VehiclesBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.db_VehiclesBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.db_VehiclesBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.db_VehiclesBindingNavigator.Name = "db_VehiclesBindingNavigator";
            this.db_VehiclesBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.db_VehiclesBindingNavigator.Size = new System.Drawing.Size(747, 31);
            this.db_VehiclesBindingNavigator.TabIndex = 53;
            this.db_VehiclesBindingNavigator.Text = "bindingNavigator1";
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
            // db_VehiclesBindingNavigatorSaveItem
            // 
            this.db_VehiclesBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.db_VehiclesBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("db_VehiclesBindingNavigatorSaveItem.Image")));
            this.db_VehiclesBindingNavigatorSaveItem.Name = "db_VehiclesBindingNavigatorSaveItem";
            this.db_VehiclesBindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 28);
            this.db_VehiclesBindingNavigatorSaveItem.Text = "Save Data";
            this.db_VehiclesBindingNavigatorSaveItem.Click += new System.EventHandler(this.db_VehiclesBindingNavigatorSaveItem_Click);
            // 
            // txtID
            // 
            this.txtID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtID.Location = new System.Drawing.Point(554, 30);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(191, 22);
            this.txtID.TabIndex = 55;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.White;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label7.Location = new System.Drawing.Point(550, 8);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(26, 19);
            this.label7.TabIndex = 54;
            this.label7.Text = "ID:";
            // 
            // UserControlVehicle2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.db_VehiclesBindingNavigator);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtOwnerName);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtVehicleColor);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.txtVehicleModel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtVehicleBrand);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtVehicleID);
            this.Controls.Add(this.lbl_name);
            this.Name = "UserControlVehicle2";
            this.Size = new System.Drawing.Size(747, 493);
            this.Load += new System.EventHandler(this.UserControlVehicle2_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.db_VehiclesDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_VehiclesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds_Vehicles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_VehiclesBindingNavigator)).EndInit();
            this.db_VehiclesBindingNavigator.ResumeLayout(false);
            this.db_VehiclesBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtOwnerName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtVehicleColor;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.TextBox txtVehicleModel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtVehicleBrand;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtVehicleID;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private ds_Vehicles ds_Vehicles;
        private System.Windows.Forms.BindingSource db_VehiclesBindingSource;
        private ds_VehiclesTableAdapters.db_VehiclesTableAdapter db_VehiclesTableAdapter;
        private ds_VehiclesTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator db_VehiclesBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton db_VehiclesBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView db_VehiclesDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label7;
    }
}
