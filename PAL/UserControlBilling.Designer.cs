namespace Autogaragemanagment2.PAL
{
    partial class UserControlBilling
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControlBilling));
            this.label4 = new System.Windows.Forms.Label();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtPartPrice = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPartName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBillNo = new System.Windows.Forms.TextBox();
            this.lbl_name = new System.Windows.Forms.Label();
            this.txtTotalPrice = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPartQuantity = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.db_BillCardsDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.db_BillCardsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ds_BillCards = new Autogaragemanagment2.ds_BillCards();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.db_BillCardsBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.db_BillCardsBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.db_BillCardsTableAdapter = new Autogaragemanagment2.ds_BillCardsTableAdapters.db_BillCardsTableAdapter();
            this.tableAdapterManager = new Autogaragemanagment2.ds_BillCardsTableAdapters.TableAdapterManager();
            this.txtGrandTotal = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.db_BillCardsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_BillCardsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds_BillCards)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_BillCardsBindingNavigator)).BeginInit();
            this.db_BillCardsBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DarkOrange;
            this.label4.Location = new System.Drawing.Point(46, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(234, 28);
            this.label4.TabIndex = 60;
            this.label4.Text = "BILLING INFORMATION";
            // 
            // btnRemove
            // 
            this.btnRemove.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnRemove.BackColor = System.Drawing.Color.ForestGreen;
            this.btnRemove.FlatAppearance.BorderSize = 0;
            this.btnRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemove.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemove.ForeColor = System.Drawing.Color.White;
            this.btnRemove.Location = new System.Drawing.Point(373, 134);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(92, 31);
            this.btnRemove.TabIndex = 58;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = false;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(67)))), ((int)(((byte)(108)))));
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(274, 134);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(93, 31);
            this.btnAdd.TabIndex = 57;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtPartPrice
            // 
            this.txtPartPrice.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPartPrice.Location = new System.Drawing.Point(479, 96);
            this.txtPartPrice.Name = "txtPartPrice";
            this.txtPartPrice.Size = new System.Drawing.Size(191, 22);
            this.txtPartPrice.TabIndex = 56;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(475, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 19);
            this.label2.TabIndex = 55;
            this.label2.Text = "Part Price";
            // 
            // txtPartName
            // 
            this.txtPartName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPartName.Location = new System.Drawing.Point(274, 96);
            this.txtPartName.Name = "txtPartName";
            this.txtPartName.Size = new System.Drawing.Size(191, 22);
            this.txtPartName.TabIndex = 54;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(270, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 19);
            this.label1.TabIndex = 53;
            this.label1.Text = "Part Name:";
            // 
            // txtBillNo
            // 
            this.txtBillNo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtBillNo.Location = new System.Drawing.Point(76, 96);
            this.txtBillNo.Name = "txtBillNo";
            this.txtBillNo.Size = new System.Drawing.Size(191, 22);
            this.txtBillNo.TabIndex = 52;
            // 
            // lbl_name
            // 
            this.lbl_name.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_name.AutoSize = true;
            this.lbl_name.BackColor = System.Drawing.Color.White;
            this.lbl_name.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold);
            this.lbl_name.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbl_name.Location = new System.Drawing.Point(72, 74);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(62, 19);
            this.lbl_name.TabIndex = 51;
            this.lbl_name.Text = "Bill No. :";
            // 
            // txtTotalPrice
            // 
            this.txtTotalPrice.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtTotalPrice.Location = new System.Drawing.Point(479, 143);
            this.txtTotalPrice.Name = "txtTotalPrice";
            this.txtTotalPrice.Size = new System.Drawing.Size(191, 22);
            this.txtTotalPrice.TabIndex = 66;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(475, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 19);
            this.label3.TabIndex = 65;
            this.label3.Text = "Total Price";
            // 
            // txtPartQuantity
            // 
            this.txtPartQuantity.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPartQuantity.Location = new System.Drawing.Point(76, 143);
            this.txtPartQuantity.Name = "txtPartQuantity";
            this.txtPartQuantity.Size = new System.Drawing.Size(191, 22);
            this.txtPartQuantity.TabIndex = 62;
            this.txtPartQuantity.TextChanged += new System.EventHandler(this.txtPartQuantity_TextChanged);
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label6.Location = new System.Drawing.Point(72, 121);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 19);
            this.label6.TabIndex = 61;
            this.label6.Text = "Part Quantity";
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BackColor = System.Drawing.Color.DarkGray;
            this.panel1.Controls.Add(this.db_BillCardsDataGridView);
            this.panel1.Location = new System.Drawing.Point(18, 171);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(703, 255);
            this.panel1.TabIndex = 67;
            // 
            // db_BillCardsDataGridView
            // 
            this.db_BillCardsDataGridView.AllowUserToAddRows = false;
            this.db_BillCardsDataGridView.AutoGenerateColumns = false;
            this.db_BillCardsDataGridView.BackgroundColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.OrangeRed;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.db_BillCardsDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.db_BillCardsDataGridView.ColumnHeadersHeight = 40;
            this.db_BillCardsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.db_BillCardsDataGridView.DataSource = this.db_BillCardsBindingSource;
            this.db_BillCardsDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.db_BillCardsDataGridView.EnableHeadersVisualStyles = false;
            this.db_BillCardsDataGridView.GridColor = System.Drawing.Color.Silver;
            this.db_BillCardsDataGridView.Location = new System.Drawing.Point(0, 0);
            this.db_BillCardsDataGridView.Name = "db_BillCardsDataGridView";
            this.db_BillCardsDataGridView.RowHeadersVisible = false;
            this.db_BillCardsDataGridView.RowHeadersWidth = 51;
            this.db_BillCardsDataGridView.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.db_BillCardsDataGridView.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.LightSalmon;
            this.db_BillCardsDataGridView.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Roboto", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.db_BillCardsDataGridView.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.db_BillCardsDataGridView.RowTemplate.Height = 35;
            this.db_BillCardsDataGridView.Size = new System.Drawing.Size(703, 255);
            this.db_BillCardsDataGridView.TabIndex = 0;
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
            this.dataGridViewTextBoxColumn2.DataPropertyName = "BillNo";
            this.dataGridViewTextBoxColumn2.HeaderText = "Bill No";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "PartName";
            this.dataGridViewTextBoxColumn3.HeaderText = "Part Name";
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
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "PartQty";
            this.dataGridViewTextBoxColumn5.HeaderText = "Part Quantity";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 125;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "TotalPrice";
            this.dataGridViewTextBoxColumn6.HeaderText = "Total Price";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 125;
            // 
            // db_BillCardsBindingSource
            // 
            this.db_BillCardsBindingSource.DataMember = "db_BillCards";
            this.db_BillCardsBindingSource.DataSource = this.ds_BillCards;
            // 
            // ds_BillCards
            // 
            this.ds_BillCards.DataSetName = "ds_BillCards";
            this.ds_BillCards.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnSave
            // 
            this.btnSave.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSave.BackColor = System.Drawing.Color.DeepPink;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(274, 420);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(191, 31);
            this.btnSave.TabIndex = 69;
            this.btnSave.Text = "Save Bill";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCalculate
            // 
            this.btnCalculate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCalculate.BackColor = System.Drawing.Color.Olive;
            this.btnCalculate.FlatAppearance.BorderSize = 0;
            this.btnCalculate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalculate.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculate.ForeColor = System.Drawing.Color.White;
            this.btnCalculate.Location = new System.Drawing.Point(76, 420);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(191, 31);
            this.btnCalculate.TabIndex = 68;
            this.btnCalculate.Text = "Calculate Bill";
            this.btnCalculate.UseVisualStyleBackColor = false;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // txtID
            // 
            this.txtID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtID.Location = new System.Drawing.Point(667, 31);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(54, 22);
            this.txtID.TabIndex = 71;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label5.Location = new System.Drawing.Point(695, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(26, 19);
            this.label5.TabIndex = 70;
            this.label5.Text = "ID:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // db_BillCardsBindingNavigator
            // 
            this.db_BillCardsBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.db_BillCardsBindingNavigator.BindingSource = this.db_BillCardsBindingSource;
            this.db_BillCardsBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.db_BillCardsBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.db_BillCardsBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.db_BillCardsBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.db_BillCardsBindingNavigatorSaveItem});
            this.db_BillCardsBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.db_BillCardsBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.db_BillCardsBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.db_BillCardsBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.db_BillCardsBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.db_BillCardsBindingNavigator.Name = "db_BillCardsBindingNavigator";
            this.db_BillCardsBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.db_BillCardsBindingNavigator.Size = new System.Drawing.Size(747, 31);
            this.db_BillCardsBindingNavigator.TabIndex = 72;
            this.db_BillCardsBindingNavigator.Text = "bindingNavigator1";
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
            // db_BillCardsBindingNavigatorSaveItem
            // 
            this.db_BillCardsBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.db_BillCardsBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("db_BillCardsBindingNavigatorSaveItem.Image")));
            this.db_BillCardsBindingNavigatorSaveItem.Name = "db_BillCardsBindingNavigatorSaveItem";
            this.db_BillCardsBindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 28);
            this.db_BillCardsBindingNavigatorSaveItem.Text = "Save Data";
            this.db_BillCardsBindingNavigatorSaveItem.Click += new System.EventHandler(this.db_BillCardsBindingNavigatorSaveItem_Click);
            // 
            // db_BillCardsTableAdapter
            // 
            this.db_BillCardsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.db_BillCardsTableAdapter = this.db_BillCardsTableAdapter;
            this.tableAdapterManager.UpdateOrder = Autogaragemanagment2.ds_BillCardsTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // txtGrandTotal
            // 
            this.txtGrandTotal.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtGrandTotal.Location = new System.Drawing.Point(546, 429);
            this.txtGrandTotal.Name = "txtGrandTotal";
            this.txtGrandTotal.Size = new System.Drawing.Size(175, 22);
            this.txtGrandTotal.TabIndex = 74;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.White;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label7.Location = new System.Drawing.Point(465, 432);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 19);
            this.label7.TabIndex = 73;
            this.label7.Text = "Grand Total:";
            // 
            // UserControlBilling
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtGrandTotal);
            this.Controls.Add(this.db_BillCardsBindingNavigator);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtTotalPrice);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtPartQuantity);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtPartPrice);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtPartName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBillNo);
            this.Controls.Add(this.lbl_name);
            this.Name = "UserControlBilling";
            this.Size = new System.Drawing.Size(747, 464);
            this.Load += new System.EventHandler(this.UserControlBilling_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.db_BillCardsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_BillCardsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds_BillCards)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_BillCardsBindingNavigator)).EndInit();
            this.db_BillCardsBindingNavigator.ResumeLayout(false);
            this.db_BillCardsBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtPartPrice;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPartName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBillNo;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.TextBox txtTotalPrice;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPartQuantity;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label5;
        private ds_BillCards ds_BillCards;
        private System.Windows.Forms.BindingSource db_BillCardsBindingSource;
        private ds_BillCardsTableAdapters.db_BillCardsTableAdapter db_BillCardsTableAdapter;
        private ds_BillCardsTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator db_BillCardsBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton db_BillCardsBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        public System.Windows.Forms.DataGridView db_BillCardsDataGridView;
        private System.Windows.Forms.TextBox txtGrandTotal;
        private System.Windows.Forms.Label label7;
    }
}
