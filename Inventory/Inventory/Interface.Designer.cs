namespace Inventory
{
    partial class MainInterface
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            this.loggedinuserLBL = new System.Windows.Forms.Label();
            this.guna2TabControl1 = new Guna.UI2.WinForms.Guna2TabControl();
            this.InventoryTab = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.InventoryTable = new System.Windows.Forms.DataGridView();
            this.CustomersTab = new System.Windows.Forms.TabPage();
            this.customersLBL = new System.Windows.Forms.Label();
            this.customersTable = new System.Windows.Forms.DataGridView();
            this.SellTab = new System.Windows.Forms.TabPage();
            this.LogsTab = new System.Windows.Forms.TabPage();
            this.SettingsTab = new System.Windows.Forms.TabPage();
            this.minimizeBTN = new Guna.UI2.WinForms.Guna2CircleButton();
            this.exitBTN = new Guna.UI2.WinForms.Guna2CircleButton();
            this.itemsCountLBL = new System.Windows.Forms.Label();
            this.totalmoneyLBL = new System.Windows.Forms.Label();
            this.guna2TabControl1.SuspendLayout();
            this.InventoryTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.InventoryTable)).BeginInit();
            this.CustomersTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customersTable)).BeginInit();
            this.SuspendLayout();
            // 
            // loggedinuserLBL
            // 
            this.loggedinuserLBL.AutoSize = true;
            this.loggedinuserLBL.BackColor = System.Drawing.Color.Transparent;
            this.loggedinuserLBL.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loggedinuserLBL.Font = new System.Drawing.Font("Leelawadee UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.loggedinuserLBL.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.loggedinuserLBL.Location = new System.Drawing.Point(8, 9);
            this.loggedinuserLBL.Margin = new System.Windows.Forms.Padding(0);
            this.loggedinuserLBL.Name = "loggedinuserLBL";
            this.loggedinuserLBL.Size = new System.Drawing.Size(43, 15);
            this.loggedinuserLBL.TabIndex = 0;
            this.loggedinuserLBL.Text = "Admin";
            this.loggedinuserLBL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.loggedinuserLBL.Click += new System.EventHandler(this.label1_Click);
            // 
            // guna2TabControl1
            // 
            this.guna2TabControl1.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.guna2TabControl1.Controls.Add(this.InventoryTab);
            this.guna2TabControl1.Controls.Add(this.CustomersTab);
            this.guna2TabControl1.Controls.Add(this.SellTab);
            this.guna2TabControl1.Controls.Add(this.LogsTab);
            this.guna2TabControl1.Controls.Add(this.SettingsTab);
            this.guna2TabControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.guna2TabControl1.ItemSize = new System.Drawing.Size(180, 40);
            this.guna2TabControl1.Location = new System.Drawing.Point(0, 31);
            this.guna2TabControl1.Name = "guna2TabControl1";
            this.guna2TabControl1.SelectedIndex = 0;
            this.guna2TabControl1.Size = new System.Drawing.Size(1005, 610);
            this.guna2TabControl1.TabButtonHoverState.BorderColor = System.Drawing.Color.Empty;
            this.guna2TabControl1.TabButtonHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(52)))), ((int)(((byte)(70)))));
            this.guna2TabControl1.TabButtonHoverState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.guna2TabControl1.TabButtonHoverState.ForeColor = System.Drawing.Color.White;
            this.guna2TabControl1.TabButtonHoverState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(52)))), ((int)(((byte)(70)))));
            this.guna2TabControl1.TabButtonIdleState.BorderColor = System.Drawing.Color.Empty;
            this.guna2TabControl1.TabButtonIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.guna2TabControl1.TabButtonIdleState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.guna2TabControl1.TabButtonIdleState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(160)))), ((int)(((byte)(167)))));
            this.guna2TabControl1.TabButtonIdleState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.guna2TabControl1.TabButtonSelectedState.BorderColor = System.Drawing.Color.Empty;
            this.guna2TabControl1.TabButtonSelectedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(37)))), ((int)(((byte)(49)))));
            this.guna2TabControl1.TabButtonSelectedState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.guna2TabControl1.TabButtonSelectedState.ForeColor = System.Drawing.Color.White;
            this.guna2TabControl1.TabButtonSelectedState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(132)))), ((int)(((byte)(255)))));
            this.guna2TabControl1.TabButtonSize = new System.Drawing.Size(180, 40);
            this.guna2TabControl1.TabIndex = 8;
            this.guna2TabControl1.TabMenuBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.guna2TabControl1.Selected += new System.Windows.Forms.TabControlEventHandler(this.guna2TabControl1_Selected);
            // 
            // InventoryTab
            // 
            this.InventoryTab.Controls.Add(this.label1);
            this.InventoryTab.Controls.Add(this.InventoryTable);
            this.InventoryTab.Location = new System.Drawing.Point(184, 4);
            this.InventoryTab.Name = "InventoryTab";
            this.InventoryTab.Padding = new System.Windows.Forms.Padding(3);
            this.InventoryTab.Size = new System.Drawing.Size(817, 602);
            this.InventoryTab.TabIndex = 0;
            this.InventoryTab.Text = "Inventory";
            this.InventoryTab.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Gadugi", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(343, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "Inventory";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // InventoryTable
            // 
            this.InventoryTable.AllowUserToAddRows = false;
            this.InventoryTable.AllowUserToDeleteRows = false;
            this.InventoryTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.InventoryTable.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.InventoryTable.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            this.InventoryTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.InventoryTable.Location = new System.Drawing.Point(9, 44);
            this.InventoryTable.Name = "InventoryTable";
            this.InventoryTable.ReadOnly = true;
            this.InventoryTable.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Gadugi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(242)))), ((int)(((byte)(241)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(131)))), ((int)(((byte)(149)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(124)))), ((int)(((byte)(90)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.InventoryTable.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.InventoryTable.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.InventoryTable.RowTemplate.Height = 25;
            this.InventoryTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.InventoryTable.Size = new System.Drawing.Size(800, 360);
            this.InventoryTable.TabIndex = 0;
            // 
            // CustomersTab
            // 
            this.CustomersTab.Controls.Add(this.customersLBL);
            this.CustomersTab.Controls.Add(this.customersTable);
            this.CustomersTab.Location = new System.Drawing.Point(184, 4);
            this.CustomersTab.Name = "CustomersTab";
            this.CustomersTab.Size = new System.Drawing.Size(817, 602);
            this.CustomersTab.TabIndex = 2;
            this.CustomersTab.Text = "Customers";
            this.CustomersTab.UseVisualStyleBackColor = true;
            // 
            // customersLBL
            // 
            this.customersLBL.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.customersLBL.AutoSize = true;
            this.customersLBL.Font = new System.Drawing.Font("Gadugi", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.customersLBL.Location = new System.Drawing.Point(343, 7);
            this.customersLBL.Name = "customersLBL";
            this.customersLBL.Size = new System.Drawing.Size(139, 31);
            this.customersLBL.TabIndex = 2;
            this.customersLBL.Text = "Customers";
            // 
            // customersTable
            // 
            this.customersTable.AllowUserToAddRows = false;
            this.customersTable.AllowUserToDeleteRows = false;
            this.customersTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.customersTable.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.customersTable.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            this.customersTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.customersTable.Location = new System.Drawing.Point(9, 44);
            this.customersTable.Name = "customersTable";
            this.customersTable.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(242)))), ((int)(((byte)(241)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Gadugi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(131)))), ((int)(((byte)(149)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.customersTable.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.customersTable.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.customersTable.RowTemplate.Height = 25;
            this.customersTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.customersTable.Size = new System.Drawing.Size(800, 360);
            this.customersTable.TabIndex = 1;
            this.customersTable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.customersTable_CellContentClick);
            // 
            // SellTab
            // 
            this.SellTab.Location = new System.Drawing.Point(184, 4);
            this.SellTab.Name = "SellTab";
            this.SellTab.Size = new System.Drawing.Size(817, 602);
            this.SellTab.TabIndex = 4;
            this.SellTab.Text = "Sell";
            this.SellTab.UseVisualStyleBackColor = true;
            // 
            // LogsTab
            // 
            this.LogsTab.Location = new System.Drawing.Point(184, 4);
            this.LogsTab.Name = "LogsTab";
            this.LogsTab.Padding = new System.Windows.Forms.Padding(3);
            this.LogsTab.Size = new System.Drawing.Size(817, 602);
            this.LogsTab.TabIndex = 1;
            this.LogsTab.Text = "Logs";
            this.LogsTab.UseVisualStyleBackColor = true;
            // 
            // SettingsTab
            // 
            this.SettingsTab.Location = new System.Drawing.Point(184, 4);
            this.SettingsTab.Name = "SettingsTab";
            this.SettingsTab.Size = new System.Drawing.Size(817, 602);
            this.SettingsTab.TabIndex = 3;
            this.SettingsTab.Text = "Settings";
            this.SettingsTab.UseVisualStyleBackColor = true;
            // 
            // minimizeBTN
            // 
            this.minimizeBTN.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.minimizeBTN.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.minimizeBTN.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.minimizeBTN.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.minimizeBTN.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.minimizeBTN.FillColor = System.Drawing.Color.Transparent;
            this.minimizeBTN.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.minimizeBTN.ForeColor = System.Drawing.Color.White;
            this.minimizeBTN.Image = global::Inventory.Properties.Resources.minimize;
            this.minimizeBTN.Location = new System.Drawing.Point(946, 3);
            this.minimizeBTN.Name = "minimizeBTN";
            this.minimizeBTN.ShadowDecoration.CustomizableEdges = customizableEdges3;
            this.minimizeBTN.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.minimizeBTN.Size = new System.Drawing.Size(24, 24);
            this.minimizeBTN.TabIndex = 9;
            this.minimizeBTN.Click += new System.EventHandler(this.minimizeBTN_Click);
            // 
            // exitBTN
            // 
            this.exitBTN.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.exitBTN.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.exitBTN.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.exitBTN.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.exitBTN.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.exitBTN.FillColor = System.Drawing.Color.Transparent;
            this.exitBTN.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.exitBTN.ForeColor = System.Drawing.Color.White;
            this.exitBTN.Image = global::Inventory.Properties.Resources.ed;
            this.exitBTN.Location = new System.Drawing.Point(973, 3);
            this.exitBTN.Name = "exitBTN";
            this.exitBTN.ShadowDecoration.CustomizableEdges = customizableEdges4;
            this.exitBTN.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.exitBTN.Size = new System.Drawing.Size(24, 24);
            this.exitBTN.TabIndex = 9;
            this.exitBTN.Click += new System.EventHandler(this.exitBTN_Click);
            // 
            // itemsCountLBL
            // 
            this.itemsCountLBL.AutoSize = true;
            this.itemsCountLBL.Font = new System.Drawing.Font("Gadugi", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.itemsCountLBL.ForeColor = System.Drawing.Color.White;
            this.itemsCountLBL.Location = new System.Drawing.Point(107, 9);
            this.itemsCountLBL.Name = "itemsCountLBL";
            this.itemsCountLBL.Size = new System.Drawing.Size(38, 14);
            this.itemsCountLBL.TabIndex = 10;
            this.itemsCountLBL.Text = "label2";
            // 
            // totalmoneyLBL
            // 
            this.totalmoneyLBL.AutoSize = true;
            this.totalmoneyLBL.Font = new System.Drawing.Font("Gadugi", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.totalmoneyLBL.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(155)))), ((int)(((byte)(121)))));
            this.totalmoneyLBL.Location = new System.Drawing.Point(184, 9);
            this.totalmoneyLBL.Name = "totalmoneyLBL";
            this.totalmoneyLBL.Size = new System.Drawing.Size(38, 14);
            this.totalmoneyLBL.TabIndex = 11;
            this.totalmoneyLBL.Text = "label2";
            // 
            // MainInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            this.ClientSize = new System.Drawing.Size(1005, 641);
            this.Controls.Add(this.totalmoneyLBL);
            this.Controls.Add(this.itemsCountLBL);
            this.Controls.Add(this.exitBTN);
            this.Controls.Add(this.minimizeBTN);
            this.Controls.Add(this.guna2TabControl1);
            this.Controls.Add(this.loggedinuserLBL);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(1090, 641);
            this.MinimumSize = new System.Drawing.Size(1005, 641);
            this.Name = "MainInterface";
            this.Text = "Interface";
            this.Load += new System.EventHandler(this.Interface_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Interface_MouseDown);
            this.guna2TabControl1.ResumeLayout(false);
            this.InventoryTab.ResumeLayout(false);
            this.InventoryTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.InventoryTable)).EndInit();
            this.CustomersTab.ResumeLayout(false);
            this.CustomersTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customersTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label loggedinuserLBL;
        private Guna.UI2.WinForms.Guna2TabControl guna2TabControl1;
        private TabPage InventoryTab;
        private TabPage LogsTab;
        private Guna.UI2.WinForms.Guna2CircleButton minimizeBTN;
        private DataGridView InventoryTable;
        private TabPage CustomersTab;
        private TabPage SellTab;
        private TabPage SettingsTab;
        private Guna.UI2.WinForms.Guna2CircleButton exitBTN;
        private Guna.UI2.WinForms.Guna2CircleButton resizeBTN;
        private Label label1;
        private DataGridView customersTable;
        private Label customersLBL;
        private Label itemsCountLBL;
        private Label totalmoneyLBL;
    }
}