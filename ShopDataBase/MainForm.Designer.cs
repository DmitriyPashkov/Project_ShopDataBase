namespace ShopDataBase
{
    partial class MainForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ColumnHash = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnIndex = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnShopNames = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnShopAdresses = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.buttonSearchShop = new System.Windows.Forms.Button();
            this.buttonRemoveShop = new System.Windows.Forms.Button();
            this.buttonAddShop = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.NamePriceHashColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ComponentNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ComponentPriceColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.buttonSearchNamePrice = new System.Windows.Forms.Button();
            this.buttonRemoveNamePrice = new System.Windows.Forms.Button();
            this.buttonAddNamePrice = new System.Windows.Forms.Button();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.ColumnShopName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnShopAdress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnComponentName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnComponentPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonGeneralPriceSearch = new System.Windows.Forms.Button();
            this.buttonGeneralShopSearch = new System.Windows.Forms.Button();
            this.buttonGeneralDel = new System.Windows.Forms.Button();
            this.buttonGeneralAdd = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(780, 557);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.White;
            this.tabPage1.Controls.Add(this.splitContainer1);
            this.tabPage1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tabPage1.Location = new System.Drawing.Point(4, 33);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(772, 520);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Магазины";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(3, 3);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.dataGridView1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.textBox2);
            this.splitContainer1.Panel2.Controls.Add(this.textBox1);
            this.splitContainer1.Panel2.Controls.Add(this.buttonSearchShop);
            this.splitContainer1.Panel2.Controls.Add(this.buttonRemoveShop);
            this.splitContainer1.Panel2.Controls.Add(this.buttonAddShop);
            this.splitContainer1.Panel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.splitContainer1.Size = new System.Drawing.Size(766, 514);
            this.splitContainer1.SplitterDistance = 448;
            this.splitContainer1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnHash,
            this.ColumnIndex,
            this.ColumnShopNames,
            this.ColumnShopAdresses});
            this.dataGridView1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 40;
            this.dataGridView1.Size = new System.Drawing.Size(766, 448);
            this.dataGridView1.TabIndex = 0;
            // 
            // ColumnHash
            // 
            this.ColumnHash.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ColumnHash.FillWeight = 39.91816F;
            this.ColumnHash.HeaderText = "Хэш";
            this.ColumnHash.MinimumWidth = 8;
            this.ColumnHash.Name = "ColumnHash";
            this.ColumnHash.ReadOnly = true;
            this.ColumnHash.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ColumnHash.Width = 71;
            // 
            // ColumnIndex
            // 
            this.ColumnIndex.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ColumnIndex.FillWeight = 66.60746F;
            this.ColumnIndex.HeaderText = "Индекс";
            this.ColumnIndex.MinimumWidth = 2;
            this.ColumnIndex.Name = "ColumnIndex";
            this.ColumnIndex.ReadOnly = true;
            this.ColumnIndex.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ColumnIndex.Width = 2;
            // 
            // ColumnShopNames
            // 
            this.ColumnShopNames.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ColumnShopNames.HeaderText = "Название";
            this.ColumnShopNames.MinimumWidth = 8;
            this.ColumnShopNames.Name = "ColumnShopNames";
            this.ColumnShopNames.ReadOnly = true;
            this.ColumnShopNames.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ColumnShopNames.Width = 122;
            // 
            // ColumnShopAdresses
            // 
            this.ColumnShopAdresses.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnShopAdresses.FillWeight = 193.4744F;
            this.ColumnShopAdresses.HeaderText = "Адрес";
            this.ColumnShopAdresses.MinimumWidth = 8;
            this.ColumnShopAdresses.Name = "ColumnShopAdresses";
            this.ColumnShopAdresses.ReadOnly = true;
            this.ColumnShopAdresses.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // textBox2
            // 
            this.textBox2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.textBox2.Location = new System.Drawing.Point(576, 33);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(190, 29);
            this.textBox2.TabIndex = 4;
            this.textBox2.Text = "Введите адрес";
            this.textBox2.Enter += new System.EventHandler(this.textBox2_Enter);
            this.textBox2.Leave += new System.EventHandler(this.textBox2_Leave);
            this.textBox2.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.textBox2_MouseDoubleClick);
            // 
            // textBox1
            // 
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.textBox1.Location = new System.Drawing.Point(576, 0);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(190, 29);
            this.textBox1.TabIndex = 3;
            this.textBox1.Text = "Введите название";
            this.textBox1.Enter += new System.EventHandler(this.textBox1_Enter);
            this.textBox1.Leave += new System.EventHandler(this.textBox1_Leave);
            this.textBox1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.textBox1_MouseDoubleClick);
            // 
            // buttonSearchShop
            // 
            this.buttonSearchShop.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSearchShop.Dock = System.Windows.Forms.DockStyle.Left;
            this.buttonSearchShop.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSearchShop.Location = new System.Drawing.Point(384, 0);
            this.buttonSearchShop.Name = "buttonSearchShop";
            this.buttonSearchShop.Size = new System.Drawing.Size(192, 62);
            this.buttonSearchShop.TabIndex = 2;
            this.buttonSearchShop.Text = "Найти";
            this.buttonSearchShop.UseVisualStyleBackColor = true;
            this.buttonSearchShop.Click += new System.EventHandler(this.buttonSearchShop_Click);
            // 
            // buttonRemoveShop
            // 
            this.buttonRemoveShop.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonRemoveShop.Dock = System.Windows.Forms.DockStyle.Left;
            this.buttonRemoveShop.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonRemoveShop.Location = new System.Drawing.Point(192, 0);
            this.buttonRemoveShop.Name = "buttonRemoveShop";
            this.buttonRemoveShop.Size = new System.Drawing.Size(192, 62);
            this.buttonRemoveShop.TabIndex = 1;
            this.buttonRemoveShop.Text = "Удалить";
            this.buttonRemoveShop.UseVisualStyleBackColor = true;
            this.buttonRemoveShop.Click += new System.EventHandler(this.buttonRemoveShop_Click);
            // 
            // buttonAddShop
            // 
            this.buttonAddShop.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAddShop.Dock = System.Windows.Forms.DockStyle.Left;
            this.buttonAddShop.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAddShop.Location = new System.Drawing.Point(0, 0);
            this.buttonAddShop.Name = "buttonAddShop";
            this.buttonAddShop.Size = new System.Drawing.Size(192, 62);
            this.buttonAddShop.TabIndex = 0;
            this.buttonAddShop.Text = "Добавить";
            this.buttonAddShop.UseVisualStyleBackColor = true;
            this.buttonAddShop.Click += new System.EventHandler(this.buttonAddShop_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.splitContainer2);
            this.tabPage3.Location = new System.Drawing.Point(4, 33);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(772, 520);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Цены";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Cursor = System.Windows.Forms.Cursors.Default;
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.IsSplitterFixed = true;
            this.splitContainer2.Location = new System.Drawing.Point(3, 3);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.dataGridView2);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.textBox3);
            this.splitContainer2.Panel2.Controls.Add(this.buttonSearchNamePrice);
            this.splitContainer2.Panel2.Controls.Add(this.buttonRemoveNamePrice);
            this.splitContainer2.Panel2.Controls.Add(this.buttonAddNamePrice);
            this.splitContainer2.Size = new System.Drawing.Size(766, 514);
            this.splitContainer2.SplitterDistance = 448;
            this.splitContainer2.TabIndex = 0;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AllowUserToResizeColumns = false;
            this.dataGridView2.AllowUserToResizeRows = false;
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NamePriceHashColumn,
            this.ComponentNameColumn,
            this.ComponentPriceColumn1});
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dataGridView2.Location = new System.Drawing.Point(0, 0);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersVisible = false;
            this.dataGridView2.RowHeadersWidth = 40;
            this.dataGridView2.Size = new System.Drawing.Size(766, 448);
            this.dataGridView2.TabIndex = 0;
            // 
            // NamePriceHashColumn
            // 
            this.NamePriceHashColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.NamePriceHashColumn.FillWeight = 152.2843F;
            this.NamePriceHashColumn.HeaderText = "Хэш";
            this.NamePriceHashColumn.MinimumWidth = 8;
            this.NamePriceHashColumn.Name = "NamePriceHashColumn";
            this.NamePriceHashColumn.ReadOnly = true;
            this.NamePriceHashColumn.Width = 71;
            // 
            // ComponentNameColumn
            // 
            this.ComponentNameColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ComponentNameColumn.FillWeight = 73.85786F;
            this.ComponentNameColumn.HeaderText = "Наименование";
            this.ComponentNameColumn.MinimumWidth = 8;
            this.ComponentNameColumn.Name = "ComponentNameColumn";
            this.ComponentNameColumn.ReadOnly = true;
            this.ComponentNameColumn.Width = 169;
            // 
            // ComponentPriceColumn1
            // 
            this.ComponentPriceColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ComponentPriceColumn1.FillWeight = 73.85786F;
            this.ComponentPriceColumn1.HeaderText = "Цена";
            this.ComponentPriceColumn1.MinimumWidth = 8;
            this.ComponentPriceColumn1.Name = "ComponentPriceColumn1";
            this.ComponentPriceColumn1.ReadOnly = true;
            // 
            // textBox3
            // 
            this.textBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox3.Location = new System.Drawing.Point(576, 0);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(190, 29);
            this.textBox3.TabIndex = 3;
            this.textBox3.Text = "Введите название";
            this.textBox3.Enter += new System.EventHandler(this.textBox3_Enter);
            this.textBox3.Leave += new System.EventHandler(this.textBox3_Leave);
            this.textBox3.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.textBox3_MouseDoubleClick);
            // 
            // buttonSearchNamePrice
            // 
            this.buttonSearchNamePrice.BackColor = System.Drawing.Color.White;
            this.buttonSearchNamePrice.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSearchNamePrice.Dock = System.Windows.Forms.DockStyle.Left;
            this.buttonSearchNamePrice.Location = new System.Drawing.Point(384, 0);
            this.buttonSearchNamePrice.Name = "buttonSearchNamePrice";
            this.buttonSearchNamePrice.Size = new System.Drawing.Size(192, 62);
            this.buttonSearchNamePrice.TabIndex = 2;
            this.buttonSearchNamePrice.Text = "Найти";
            this.buttonSearchNamePrice.UseVisualStyleBackColor = true;
            this.buttonSearchNamePrice.Click += new System.EventHandler(this.buttonSearchNamePrice_Click);
            // 
            // buttonRemoveNamePrice
            // 
            this.buttonRemoveNamePrice.BackColor = System.Drawing.Color.White;
            this.buttonRemoveNamePrice.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonRemoveNamePrice.Dock = System.Windows.Forms.DockStyle.Left;
            this.buttonRemoveNamePrice.Location = new System.Drawing.Point(192, 0);
            this.buttonRemoveNamePrice.Name = "buttonRemoveNamePrice";
            this.buttonRemoveNamePrice.Size = new System.Drawing.Size(192, 62);
            this.buttonRemoveNamePrice.TabIndex = 1;
            this.buttonRemoveNamePrice.Text = "Удалить";
            this.buttonRemoveNamePrice.UseVisualStyleBackColor = true;
            this.buttonRemoveNamePrice.Click += new System.EventHandler(this.buttonRemoveNamePrice_Click);
            // 
            // buttonAddNamePrice
            // 
            this.buttonAddNamePrice.BackColor = System.Drawing.Color.White;
            this.buttonAddNamePrice.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAddNamePrice.Dock = System.Windows.Forms.DockStyle.Left;
            this.buttonAddNamePrice.Location = new System.Drawing.Point(0, 0);
            this.buttonAddNamePrice.Name = "buttonAddNamePrice";
            this.buttonAddNamePrice.Size = new System.Drawing.Size(192, 62);
            this.buttonAddNamePrice.TabIndex = 0;
            this.buttonAddNamePrice.Text = "Добавить";
            this.buttonAddNamePrice.UseVisualStyleBackColor = true;
            this.buttonAddNamePrice.Click += new System.EventHandler(this.buttonAddNamePrice_Click);
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.splitContainer3);
            this.tabPage4.Location = new System.Drawing.Point(4, 33);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(772, 520);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Общая";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // splitContainer3
            // 
            this.splitContainer3.Cursor = System.Windows.Forms.Cursors.Default;
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.splitContainer3.IsSplitterFixed = true;
            this.splitContainer3.Location = new System.Drawing.Point(3, 3);
            this.splitContainer3.Name = "splitContainer3";
            this.splitContainer3.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.dataGridView3);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.buttonGeneralPriceSearch);
            this.splitContainer3.Panel2.Controls.Add(this.buttonGeneralShopSearch);
            this.splitContainer3.Panel2.Controls.Add(this.buttonGeneralDel);
            this.splitContainer3.Panel2.Controls.Add(this.buttonGeneralAdd);
            this.splitContainer3.Size = new System.Drawing.Size(766, 514);
            this.splitContainer3.SplitterDistance = 448;
            this.splitContainer3.TabIndex = 0;
            // 
            // dataGridView3
            // 
            this.dataGridView3.AllowUserToAddRows = false;
            this.dataGridView3.AllowUserToDeleteRows = false;
            this.dataGridView3.AllowUserToResizeColumns = false;
            this.dataGridView3.AllowUserToResizeRows = false;
            this.dataGridView3.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnShopName,
            this.ColumnShopAdress,
            this.ColumnComponentName,
            this.ColumnComponentPrice});
            this.dataGridView3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView3.Location = new System.Drawing.Point(0, 0);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.ReadOnly = true;
            this.dataGridView3.RowHeadersVisible = false;
            this.dataGridView3.RowHeadersWidth = 40;
            this.dataGridView3.Size = new System.Drawing.Size(766, 448);
            this.dataGridView3.TabIndex = 0;
            // 
            // ColumnShopName
            // 
            this.ColumnShopName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ColumnShopName.HeaderText = "Магазин";
            this.ColumnShopName.MinimumWidth = 8;
            this.ColumnShopName.Name = "ColumnShopName";
            this.ColumnShopName.ReadOnly = true;
            this.ColumnShopName.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ColumnShopName.Width = 112;
            // 
            // ColumnShopAdress
            // 
            this.ColumnShopAdress.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ColumnShopAdress.HeaderText = "Адрес";
            this.ColumnShopAdress.MinimumWidth = 8;
            this.ColumnShopAdress.Name = "ColumnShopAdress";
            this.ColumnShopAdress.ReadOnly = true;
            this.ColumnShopAdress.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ColumnShopAdress.Width = 92;
            // 
            // ColumnComponentName
            // 
            this.ColumnComponentName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ColumnComponentName.HeaderText = "Товар";
            this.ColumnComponentName.MinimumWidth = 8;
            this.ColumnComponentName.Name = "ColumnComponentName";
            this.ColumnComponentName.ReadOnly = true;
            this.ColumnComponentName.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ColumnComponentName.Width = 90;
            // 
            // ColumnComponentPrice
            // 
            this.ColumnComponentPrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ColumnComponentPrice.HeaderText = "Цена";
            this.ColumnComponentPrice.MinimumWidth = 8;
            this.ColumnComponentPrice.Name = "ColumnComponentPrice";
            this.ColumnComponentPrice.ReadOnly = true;
            this.ColumnComponentPrice.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ColumnComponentPrice.Width = 79;
            // 
            // buttonGeneralPriceSearch
            // 
            this.buttonGeneralPriceSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonGeneralPriceSearch.Location = new System.Drawing.Point(575, 0);
            this.buttonGeneralPriceSearch.Name = "buttonGeneralPriceSearch";
            this.buttonGeneralPriceSearch.Size = new System.Drawing.Size(191, 62);
            this.buttonGeneralPriceSearch.TabIndex = 3;
            this.buttonGeneralPriceSearch.Text = "Поиск по товару";
            this.buttonGeneralPriceSearch.UseVisualStyleBackColor = true;
            this.buttonGeneralPriceSearch.Click += new System.EventHandler(this.buttonGeneralPriceSearch_Click);
            // 
            // buttonGeneralShopSearch
            // 
            this.buttonGeneralShopSearch.Dock = System.Windows.Forms.DockStyle.Left;
            this.buttonGeneralShopSearch.Location = new System.Drawing.Point(384, 0);
            this.buttonGeneralShopSearch.Name = "buttonGeneralShopSearch";
            this.buttonGeneralShopSearch.Size = new System.Drawing.Size(191, 62);
            this.buttonGeneralShopSearch.TabIndex = 2;
            this.buttonGeneralShopSearch.Text = "Поиск по магазину";
            this.buttonGeneralShopSearch.UseVisualStyleBackColor = true;
            this.buttonGeneralShopSearch.Click += new System.EventHandler(this.buttonGeneralShopSearch_Click);
            // 
            // buttonGeneralDel
            // 
            this.buttonGeneralDel.Dock = System.Windows.Forms.DockStyle.Left;
            this.buttonGeneralDel.Location = new System.Drawing.Point(192, 0);
            this.buttonGeneralDel.Name = "buttonGeneralDel";
            this.buttonGeneralDel.Size = new System.Drawing.Size(192, 62);
            this.buttonGeneralDel.TabIndex = 1;
            this.buttonGeneralDel.Text = "Удалить";
            this.buttonGeneralDel.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.buttonGeneralDel.UseVisualStyleBackColor = true;
            this.buttonGeneralDel.Click += new System.EventHandler(this.buttonGeneralDel_Click);
            // 
            // buttonGeneralAdd
            // 
            this.buttonGeneralAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonGeneralAdd.Dock = System.Windows.Forms.DockStyle.Left;
            this.buttonGeneralAdd.Location = new System.Drawing.Point(0, 0);
            this.buttonGeneralAdd.Name = "buttonGeneralAdd";
            this.buttonGeneralAdd.Size = new System.Drawing.Size(192, 62);
            this.buttonGeneralAdd.TabIndex = 0;
            this.buttonGeneralAdd.Text = "Добавить";
            this.buttonGeneralAdd.UseVisualStyleBackColor = true;
            this.buttonGeneralAdd.Click += new System.EventHandler(this.buttonGeneralAdd_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(780, 557);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Справочник";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.tabPage4.ResumeLayout(false);
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonAddShop;
        private System.Windows.Forms.Button buttonRemoveShop;
        private System.Windows.Forms.Button buttonSearchShop;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button buttonSearchNamePrice;
        private System.Windows.Forms.Button buttonRemoveNamePrice;
        private System.Windows.Forms.Button buttonAddNamePrice;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnShopName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnShopAdress;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnComponentName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnComponentPrice;
        private System.Windows.Forms.Button buttonGeneralDel;
        private System.Windows.Forms.Button buttonGeneralAdd;
        private System.Windows.Forms.Button buttonGeneralShopSearch;
        private System.Windows.Forms.Button buttonGeneralPriceSearch;
        private System.Windows.Forms.DataGridViewTextBoxColumn NamePriceHashColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ComponentNameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ComponentPriceColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnHash;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnIndex;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnShopNames;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnShopAdresses;
    }
}