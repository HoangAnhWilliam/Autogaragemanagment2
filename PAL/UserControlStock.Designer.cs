namespace Autogaragemanagment2.PAL
{
    partial class UserControlStock
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControlStock));
            this.txtPartPrice = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPartQty = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_name = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnInsert = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.db_StocksDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.db_StocksBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ds_Stocks = new Autogaragemanagment2.ds_Stocks();
            this.cmbPartName = new System.Windows.Forms.ComboBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.db_StocksTableAdapter = new Autogaragemanagment2.ds_StocksTableAdapters.db_StocksTableAdapter();
            this.tableAdapterManager = new Autogaragemanagment2.ds_StocksTableAdapters.TableAdapterManager();
            this.db_StocksBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.db_StocksBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.db_StocksDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_StocksBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds_Stocks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_StocksBindingNavigator)).BeginInit();
            this.db_StocksBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtPartPrice
            // 
            this.txtPartPrice.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPartPrice.Location = new System.Drawing.Point(21, 156);
            this.txtPartPrice.Name = "txtPartPrice";
            this.txtPartPrice.Size = new System.Drawing.Size(191, 22);
            this.txtPartPrice.TabIndex = 46;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(17, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 19);
            this.label2.TabIndex = 45;
            this.label2.Text = "Part Price:";
            // 
            // txtPartQty
            // 
            this.txtPartQty.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPartQty.Location = new System.Drawing.Point(21, 103);
            this.txtPartQty.Name = "txtPartQty";
            this.txtPartQty.Size = new System.Drawing.Size(191, 22);
            this.txtPartQty.TabIndex = 44;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(17, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 19);
            this.label1.TabIndex = 43;
            this.label1.Text = "Part Quantity:";
            // 
            // lbl_name
            // 
            this.lbl_name.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_name.AutoSize = true;
            this.lbl_name.BackColor = System.Drawing.Color.White;
            this.lbl_name.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold);
            this.lbl_name.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbl_name.Location = new System.Drawing.Point(17, 32);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(78, 19);
            this.lbl_name.TabIndex = 41;
            this.lbl_name.Text = "Part Name:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DarkOrange;
            this.label4.Location = new System.Drawing.Point(335, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(248, 28);
            this.label4.TabIndex = 47;
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
            this.btnDelete.Location = new System.Drawing.Point(377, 140);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(134, 31);
            this.btnDelete.TabIndex = 50;
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
            this.btnUpdate.Location = new System.Drawing.Point(377, 100);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(134, 31);
            this.btnUpdate.TabIndex = 49;
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
            this.btnInsert.Location = new System.Drawing.Point(377, 63);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(134, 31);
            this.btnInsert.TabIndex = 48;
            this.btnInsert.Text = "Insert";
            this.btnInsert.UseVisualStyleBackColor = false;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.Controls.Add(this.db_StocksDataGridView);
            this.panel1.Location = new System.Drawing.Point(21, 184);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(723, 313);
            this.panel1.TabIndex = 51;
            // 
            // db_StocksDataGridView
            // 
            this.db_StocksDataGridView.AllowUserToAddRows = false;
            this.db_StocksDataGridView.AutoGenerateColumns = false;
            this.db_StocksDataGridView.BackgroundColor = System.Drawing.Color.Silver;
            this.db_StocksDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Khaki;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.db_StocksDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.db_StocksDataGridView.ColumnHeadersHeight = 40;
            this.db_StocksDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.db_StocksDataGridView.DataSource = this.db_StocksBindingSource;
            this.db_StocksDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.db_StocksDataGridView.EnableHeadersVisualStyles = false;
            this.db_StocksDataGridView.GridColor = System.Drawing.Color.Silver;
            this.db_StocksDataGridView.Location = new System.Drawing.Point(0, 0);
            this.db_StocksDataGridView.Name = "db_StocksDataGridView";
            this.db_StocksDataGridView.RowHeadersVisible = false;
            this.db_StocksDataGridView.RowHeadersWidth = 51;
            this.db_StocksDataGridView.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.db_StocksDataGridView.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.LemonChiffon;
            this.db_StocksDataGridView.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.db_StocksDataGridView.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.db_StocksDataGridView.RowTemplate.Height = 35;
            this.db_StocksDataGridView.Size = new System.Drawing.Size(723, 313);
            this.db_StocksDataGridView.TabIndex = 0;
            this.db_StocksDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.db_StocksDataGridView_CellClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "PartName";
            this.dataGridViewTextBoxColumn2.HeaderText = "Part Name";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "PartQut";
            this.dataGridViewTextBoxColumn3.HeaderText = "Part Quantity";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "PartPrice";
            this.dataGridViewTextBoxColumn4.HeaderText = "Part Price";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // db_StocksBindingSource
            // 
            this.db_StocksBindingSource.DataMember = "db_Stocks";
            this.db_StocksBindingSource.DataSource = this.ds_Stocks;
            // 
            // ds_Stocks
            // 
            this.ds_Stocks.DataSetName = "ds_Stocks";
            this.ds_Stocks.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cmbPartName
            // 
            this.cmbPartName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbPartName.FormattingEnabled = true;
            this.cmbPartName.Items.AddRange(new object[] {
            "--SELECT--",
            "Oil Filter",
            "Air Filter",
            "Fuel Filter",
            "Engine Oil",
            "Transmission Oil",
            "Brake Pads",
            "Brake Discs",
            "Battery",
            "Spark Plugs",
            "Belts",
            "Tires",
            "Spare Tire",
            "Fuses and Relays",
            "Suspension System",
            "Lighting System"});
            this.cmbPartName.Location = new System.Drawing.Point(21, 54);
            this.cmbPartName.Name = "cmbPartName";
            this.cmbPartName.Size = new System.Drawing.Size(191, 24);
            this.cmbPartName.TabIndex = 52;
            // 
            // txtID
            // 
            this.txtID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtID.Location = new System.Drawing.Point(681, 81);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(46, 22);
            this.txtID.TabIndex = 54;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(652, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 19);
            this.label3.TabIndex = 53;
            this.label3.Text = "ID";
            // 
            // db_StocksTableAdapter
            // 
            this.db_StocksTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.db_StocksTableAdapter = this.db_StocksTableAdapter;
            this.tableAdapterManager.UpdateOrder = Autogaragemanagment2.ds_StocksTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // db_StocksBindingNavigator
            // 
            this.db_StocksBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.db_StocksBindingNavigator.BindingSource = this.db_StocksBindingSource;
            this.db_StocksBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.db_StocksBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.db_StocksBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.db_StocksBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.db_StocksBindingNavigatorSaveItem});
            this.db_StocksBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.db_StocksBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.db_StocksBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.db_StocksBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.db_StocksBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.db_StocksBindingNavigator.Name = "db_StocksBindingNavigator";
            this.db_StocksBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.db_StocksBindingNavigator.Size = new System.Drawing.Size(747, 31);
            this.db_StocksBindingNavigator.TabIndex = 55;
            this.db_StocksBindingNavigator.Text = "bindingNavigator1";
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
            // db_StocksBindingNavigatorSaveItem
            // 
            this.db_StocksBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.db_StocksBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("db_StocksBindingNavigatorSaveItem.Image")));
            this.db_StocksBindingNavigatorSaveItem.Name = "db_StocksBindingNavigatorSaveItem";
            this.db_StocksBindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 28);
            this.db_StocksBindingNavigatorSaveItem.Text = "Save Data";
            this.db_StocksBindingNavigatorSaveItem.Click += new System.EventHandler(this.db_StocksBindingNavigatorSaveItem_Click);
            // 
            // UserControlStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.db_StocksBindingNavigator);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbPartName);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtPartPrice);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtPartQty);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_name);
            this.Name = "UserControlStock";
            this.Size = new System.Drawing.Size(747, 486);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.db_StocksDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_StocksBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds_Stocks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_StocksBindingNavigator)).EndInit();
            this.db_StocksBindingNavigator.ResumeLayout(false);
            this.db_StocksBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPartPrice;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPartQty;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cmbPartName;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label3;
        private ds_Stocks ds_Stocks;
        private System.Windows.Forms.BindingSource db_StocksBindingSource;
        private ds_StocksTableAdapters.db_StocksTableAdapter db_StocksTableAdapter;
        private ds_StocksTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator db_StocksBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton db_StocksBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView db_StocksDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
    }
}
