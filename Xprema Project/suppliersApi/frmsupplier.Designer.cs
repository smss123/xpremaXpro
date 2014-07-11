namespace Xprema_Project.suppliersApi
{
    partial class frmsupplier
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
            System.Windows.Forms.Label iDLabel;
            System.Windows.Forms.Label nameLabel;
            System.Windows.Forms.Label suppliersNaturalLabel;
            System.Windows.Forms.Label phoneNumberLabel;
            System.Windows.Forms.Label faxLabel;
            System.Windows.Forms.Label emailLabel;
            System.Windows.Forms.Label adderssLabel;
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn1 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn1 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn2 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn3 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn4 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn5 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn6 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.Data.SortDescriptor sortDescriptor1 = new Telerik.WinControls.Data.SortDescriptor();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.جديدToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.اضافةToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.حفظToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.حذفToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.خروجToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.خروجToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.radCollapsiblePanel1 = new Telerik.WinControls.UI.RadCollapsiblePanel();
            this.iDTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.suppliersNaturalTextBox = new System.Windows.Forms.TextBox();
            this.phoneNumberTextBox = new System.Windows.Forms.TextBox();
            this.faxTextBox = new System.Windows.Forms.TextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.adderssTextBox = new System.Windows.Forms.TextBox();
            this.supplierRadGridView = new Telerik.WinControls.UI.RadGridView();
            this.supplierBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.suppliercontextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btnNew = new System.Windows.Forms.ToolStripMenuItem();
            this.btnSave = new System.Windows.Forms.ToolStripMenuItem();
            this.btnEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.btnDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.visualStudio2012LightTheme1 = new Telerik.WinControls.Themes.VisualStudio2012LightTheme();
            iDLabel = new System.Windows.Forms.Label();
            nameLabel = new System.Windows.Forms.Label();
            suppliersNaturalLabel = new System.Windows.Forms.Label();
            phoneNumberLabel = new System.Windows.Forms.Label();
            faxLabel = new System.Windows.Forms.Label();
            emailLabel = new System.Windows.Forms.Label();
            adderssLabel = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radCollapsiblePanel1)).BeginInit();
            this.radCollapsiblePanel1.PanelContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.supplierRadGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.supplierRadGridView.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.supplierBindingSource)).BeginInit();
            this.suppliercontextMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // iDLabel
            // 
            iDLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            iDLabel.AutoSize = true;
            iDLabel.Location = new System.Drawing.Point(916, 26);
            iDLabel.Name = "iDLabel";
            iDLabel.Size = new System.Drawing.Size(55, 13);
            iDLabel.TabIndex = 800;
            iDLabel.Text = "رقم الموَرد";
            // 
            // nameLabel
            // 
            nameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            nameLabel.AutoSize = true;
            nameLabel.Location = new System.Drawing.Point(915, 50);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(57, 13);
            nameLabel.TabIndex = 800;
            nameLabel.Text = "اسم الموَرد";
            // 
            // suppliersNaturalLabel
            // 
            suppliersNaturalLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            suppliersNaturalLabel.AutoSize = true;
            suppliersNaturalLabel.Location = new System.Drawing.Point(916, 76);
            suppliersNaturalLabel.Name = "suppliersNaturalLabel";
            suppliersNaturalLabel.Size = new System.Drawing.Size(65, 13);
            suppliersNaturalLabel.TabIndex = 800;
            suppliersNaturalLabel.Text = "طبيعة العمل";
            // 
            // phoneNumberLabel
            // 
            phoneNumberLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            phoneNumberLabel.AutoSize = true;
            phoneNumberLabel.Location = new System.Drawing.Point(328, 25);
            phoneNumberLabel.Name = "phoneNumberLabel";
            phoneNumberLabel.Size = new System.Drawing.Size(57, 13);
            phoneNumberLabel.TabIndex = 1800;
            phoneNumberLabel.Text = "رقم الهاتف";
            // 
            // faxLabel
            // 
            faxLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            faxLabel.AutoSize = true;
            faxLabel.Location = new System.Drawing.Point(332, 75);
            faxLabel.Name = "faxLabel";
            faxLabel.Size = new System.Drawing.Size(35, 13);
            faxLabel.TabIndex = 1800;
            faxLabel.Text = "فاكس";
            // 
            // emailLabel
            // 
            emailLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            emailLabel.AutoSize = true;
            emailLabel.Location = new System.Drawing.Point(332, 51);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new System.Drawing.Size(84, 13);
            emailLabel.TabIndex = 18000;
            emailLabel.Text = "البريد الالكتروني";
            // 
            // adderssLabel
            // 
            adderssLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            adderssLabel.AutoSize = true;
            adderssLabel.Location = new System.Drawing.Point(649, 98);
            adderssLabel.Name = "adderssLabel";
            adderssLabel.Size = new System.Drawing.Size(40, 13);
            adderssLabel.TabIndex = 1800;
            adderssLabel.Text = "العنوان";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.جديدToolStripMenuItem,
            this.اضافةToolStripMenuItem,
            this.حفظToolStripMenuItem,
            this.حذفToolStripMenuItem,
            this.خروجToolStripMenuItem,
            this.خروجToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(988, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // جديدToolStripMenuItem
            // 
            this.جديدToolStripMenuItem.Name = "جديدToolStripMenuItem";
            this.جديدToolStripMenuItem.Size = new System.Drawing.Size(42, 20);
            this.جديدToolStripMenuItem.Text = "جديد";
            // 
            // اضافةToolStripMenuItem
            // 
            this.اضافةToolStripMenuItem.Name = "اضافةToolStripMenuItem";
            this.اضافةToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.اضافةToolStripMenuItem.Text = "اضافة";
            // 
            // حفظToolStripMenuItem
            // 
            this.حفظToolStripMenuItem.Name = "حفظToolStripMenuItem";
            this.حفظToolStripMenuItem.Size = new System.Drawing.Size(42, 20);
            this.حفظToolStripMenuItem.Text = "حفظ";
            // 
            // حذفToolStripMenuItem
            // 
            this.حذفToolStripMenuItem.Name = "حذفToolStripMenuItem";
            this.حذفToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.حذفToolStripMenuItem.Text = "حذف";
            // 
            // خروجToolStripMenuItem
            // 
            this.خروجToolStripMenuItem.Name = "خروجToolStripMenuItem";
            this.خروجToolStripMenuItem.Size = new System.Drawing.Size(77, 20);
            this.خروجToolStripMenuItem.Text = "طباعة تقرير";
            // 
            // خروجToolStripMenuItem1
            // 
            this.خروجToolStripMenuItem1.Name = "خروجToolStripMenuItem1";
            this.خروجToolStripMenuItem1.Size = new System.Drawing.Size(44, 20);
            this.خروجToolStripMenuItem1.Text = "خروج";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 557);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(988, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // radCollapsiblePanel1
            // 
            this.radCollapsiblePanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.radCollapsiblePanel1.Location = new System.Drawing.Point(0, 24);
            this.radCollapsiblePanel1.Name = "radCollapsiblePanel1";
            this.radCollapsiblePanel1.OwnerBoundsCache = new System.Drawing.Rectangle(0, 24, 848, 200);
            // 
            // radCollapsiblePanel1.PanelContainer
            // 
            this.radCollapsiblePanel1.PanelContainer.Controls.Add(iDLabel);
            this.radCollapsiblePanel1.PanelContainer.Controls.Add(this.iDTextBox);
            this.radCollapsiblePanel1.PanelContainer.Controls.Add(nameLabel);
            this.radCollapsiblePanel1.PanelContainer.Controls.Add(this.nameTextBox);
            this.radCollapsiblePanel1.PanelContainer.Controls.Add(suppliersNaturalLabel);
            this.radCollapsiblePanel1.PanelContainer.Controls.Add(this.suppliersNaturalTextBox);
            this.radCollapsiblePanel1.PanelContainer.Controls.Add(phoneNumberLabel);
            this.radCollapsiblePanel1.PanelContainer.Controls.Add(this.phoneNumberTextBox);
            this.radCollapsiblePanel1.PanelContainer.Controls.Add(faxLabel);
            this.radCollapsiblePanel1.PanelContainer.Controls.Add(this.faxTextBox);
            this.radCollapsiblePanel1.PanelContainer.Controls.Add(emailLabel);
            this.radCollapsiblePanel1.PanelContainer.Controls.Add(this.emailTextBox);
            this.radCollapsiblePanel1.PanelContainer.Controls.Add(adderssLabel);
            this.radCollapsiblePanel1.PanelContainer.Controls.Add(this.adderssTextBox);
            this.radCollapsiblePanel1.PanelContainer.Dock = System.Windows.Forms.DockStyle.Right;
            this.radCollapsiblePanel1.PanelContainer.Location = new System.Drawing.Point(3, 1);
            this.radCollapsiblePanel1.PanelContainer.Size = new System.Drawing.Size(984, 192);
            this.radCollapsiblePanel1.PanelContainer.Paint += new System.Windows.Forms.PaintEventHandler(this.radCollapsiblePanel1_PanelContainer_Paint);
            this.radCollapsiblePanel1.Size = new System.Drawing.Size(988, 222);
            this.radCollapsiblePanel1.TabIndex = 2;
            this.radCollapsiblePanel1.Text = "radCollapsiblePanel1";
            this.radCollapsiblePanel1.ThemeName = "VisualStudio2012Light";
            // 
            // iDTextBox
            // 
            this.iDTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iDTextBox.Location = new System.Drawing.Point(684, 22);
            this.iDTextBox.Name = "iDTextBox";
            this.iDTextBox.ReadOnly = true;
            this.iDTextBox.Size = new System.Drawing.Size(226, 20);
            this.iDTextBox.TabIndex = 2;
            // 
            // nameTextBox
            // 
            this.nameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.nameTextBox.Location = new System.Drawing.Point(684, 48);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(226, 20);
            this.nameTextBox.TabIndex = 1;
            // 
            // suppliersNaturalTextBox
            // 
            this.suppliersNaturalTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.suppliersNaturalTextBox.Location = new System.Drawing.Point(684, 74);
            this.suppliersNaturalTextBox.Name = "suppliersNaturalTextBox";
            this.suppliersNaturalTextBox.Size = new System.Drawing.Size(226, 20);
            this.suppliersNaturalTextBox.TabIndex = 2;
            // 
            // phoneNumberTextBox
            // 
            this.phoneNumberTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.phoneNumberTextBox.Location = new System.Drawing.Point(63, 22);
            this.phoneNumberTextBox.Name = "phoneNumberTextBox";
            this.phoneNumberTextBox.Size = new System.Drawing.Size(263, 20);
            this.phoneNumberTextBox.TabIndex = 3;
            // 
            // faxTextBox
            // 
            this.faxTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.faxTextBox.Location = new System.Drawing.Point(63, 72);
            this.faxTextBox.Name = "faxTextBox";
            this.faxTextBox.Size = new System.Drawing.Size(263, 20);
            this.faxTextBox.TabIndex = 5;
            // 
            // emailTextBox
            // 
            this.emailTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.emailTextBox.Location = new System.Drawing.Point(63, 48);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(263, 20);
            this.emailTextBox.TabIndex = 4;
            // 
            // adderssTextBox
            // 
            this.adderssTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.adderssTextBox.Location = new System.Drawing.Point(366, 95);
            this.adderssTextBox.Multiline = true;
            this.adderssTextBox.Name = "adderssTextBox";
            this.adderssTextBox.Size = new System.Drawing.Size(280, 65);
            this.adderssTextBox.TabIndex = 6;
            // 
            // supplierRadGridView
            // 
            this.supplierRadGridView.BackColor = System.Drawing.SystemColors.Control;
            this.supplierRadGridView.Cursor = System.Windows.Forms.Cursors.Default;
            this.supplierRadGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.supplierRadGridView.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.supplierRadGridView.ForeColor = System.Drawing.SystemColors.ControlText;
            this.supplierRadGridView.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.supplierRadGridView.Location = new System.Drawing.Point(0, 246);
            // 
            // supplierRadGridView
            // 
            this.supplierRadGridView.MasterTemplate.AutoGenerateColumns = false;
            this.supplierRadGridView.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            gridViewDecimalColumn1.DataType = typeof(int);
            gridViewDecimalColumn1.EnableExpressionEditor = false;
            gridViewDecimalColumn1.FieldName = "ID";
            gridViewDecimalColumn1.HeaderText = "رقم الموَرد";
            gridViewDecimalColumn1.IsAutoGenerated = true;
            gridViewDecimalColumn1.Name = "ID";
            gridViewDecimalColumn1.Width = 111;
            gridViewTextBoxColumn1.EnableExpressionEditor = false;
            gridViewTextBoxColumn1.FieldName = "name";
            gridViewTextBoxColumn1.HeaderText = "اسم الموَرد";
            gridViewTextBoxColumn1.IsAutoGenerated = true;
            gridViewTextBoxColumn1.Name = "name";
            gridViewTextBoxColumn1.Width = 201;
            gridViewTextBoxColumn2.EnableExpressionEditor = false;
            gridViewTextBoxColumn2.FieldName = "SuppliersNatural";
            gridViewTextBoxColumn2.HeaderText = "طبيعة العمل";
            gridViewTextBoxColumn2.IsAutoGenerated = true;
            gridViewTextBoxColumn2.Name = "SuppliersNatural";
            gridViewTextBoxColumn2.SortOrder = Telerik.WinControls.UI.RadSortOrder.Ascending;
            gridViewTextBoxColumn2.Width = 173;
            gridViewTextBoxColumn3.EnableExpressionEditor = false;
            gridViewTextBoxColumn3.FieldName = "PhoneNumber";
            gridViewTextBoxColumn3.HeaderText = "رقم الهاتف";
            gridViewTextBoxColumn3.IsAutoGenerated = true;
            gridViewTextBoxColumn3.Name = "PhoneNumber";
            gridViewTextBoxColumn3.Width = 175;
            gridViewTextBoxColumn4.EnableExpressionEditor = false;
            gridViewTextBoxColumn4.FieldName = "Fax";
            gridViewTextBoxColumn4.HeaderText = "فاكس";
            gridViewTextBoxColumn4.IsAutoGenerated = true;
            gridViewTextBoxColumn4.Name = "Fax";
            gridViewTextBoxColumn4.Width = 124;
            gridViewTextBoxColumn5.EnableExpressionEditor = false;
            gridViewTextBoxColumn5.FieldName = "Email";
            gridViewTextBoxColumn5.HeaderText = "البريد الالكتروني";
            gridViewTextBoxColumn5.IsAutoGenerated = true;
            gridViewTextBoxColumn5.Name = "Email";
            gridViewTextBoxColumn5.Width = 79;
            gridViewTextBoxColumn6.EnableExpressionEditor = false;
            gridViewTextBoxColumn6.FieldName = "Adderss";
            gridViewTextBoxColumn6.HeaderText = "العنوان";
            gridViewTextBoxColumn6.IsAutoGenerated = true;
            gridViewTextBoxColumn6.Name = "Adderss";
            gridViewTextBoxColumn6.Width = 113;
            this.supplierRadGridView.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewDecimalColumn1,
            gridViewTextBoxColumn1,
            gridViewTextBoxColumn2,
            gridViewTextBoxColumn3,
            gridViewTextBoxColumn4,
            gridViewTextBoxColumn5,
            gridViewTextBoxColumn6});
            this.supplierRadGridView.MasterTemplate.DataSource = this.supplierBindingSource;
            sortDescriptor1.PropertyName = "SuppliersNatural";
            this.supplierRadGridView.MasterTemplate.SortDescriptors.AddRange(new Telerik.WinControls.Data.SortDescriptor[] {
            sortDescriptor1});
            this.supplierRadGridView.Name = "supplierRadGridView";
            this.supplierRadGridView.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.supplierRadGridView.Size = new System.Drawing.Size(988, 311);
            this.supplierRadGridView.TabIndex = 3;
            this.supplierRadGridView.Text = "radGridView1";
            this.supplierRadGridView.ThemeName = "VisualStudio2012Light";
            this.supplierRadGridView.DoubleClick += new System.EventHandler(this.MasterTemplate_DoubleClick);
            // 
            // supplierBindingSource
            // 
            this.supplierBindingSource.DataSource = typeof(Xprema.Data.Supplier);
            // 
            // suppliercontextMenuStrip
            // 
            this.suppliercontextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnNew,
            this.btnSave,
            this.btnEdit,
            this.btnDelete});
            this.suppliercontextMenuStrip.Name = "suppliercontextMenuStrip";
            this.suppliercontextMenuStrip.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.suppliercontextMenuStrip.Size = new System.Drawing.Size(154, 92);
            // 
            // btnNew
            // 
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(153, 22);
            this.btnNew.Text = "جديد     Ctrl+N";
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnSave
            // 
            this.btnSave.Enabled = false;
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(153, 22);
            this.btnSave.Text = "حفظ     Ctrl+S";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Enabled = false;
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(153, 22);
            this.btnEdit.Text = "تعديل     Ctrl+U";
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Enabled = false;
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(153, 22);
            this.btnDelete.Text = "حذف     Ctrl+D";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // frmsupplier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(988, 579);
            this.ContextMenuStrip = this.suppliercontextMenuStrip;
            this.Controls.Add(this.supplierRadGridView);
            this.Controls.Add(this.radCollapsiblePanel1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximumSize = new System.Drawing.Size(1004, 618);
            this.MinimumSize = new System.Drawing.Size(1004, 618);
            this.Name = "frmsupplier";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "الموَردين";
            this.Load += new System.EventHandler(this.frmsupplier_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.radCollapsiblePanel1.PanelContainer.ResumeLayout(false);
            this.radCollapsiblePanel1.PanelContainer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radCollapsiblePanel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.supplierRadGridView.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.supplierRadGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.supplierBindingSource)).EndInit();
            this.suppliercontextMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private Telerik.WinControls.UI.RadCollapsiblePanel radCollapsiblePanel1;
        private System.Windows.Forms.TextBox iDTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox suppliersNaturalTextBox;
        private System.Windows.Forms.TextBox phoneNumberTextBox;
        private System.Windows.Forms.TextBox faxTextBox;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.TextBox adderssTextBox;
        private System.Windows.Forms.ToolStripMenuItem جديدToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem اضافةToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem حفظToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem حذفToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem خروجToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem خروجToolStripMenuItem1;
        private Telerik.WinControls.UI.RadGridView supplierRadGridView;
        private System.Windows.Forms.ContextMenuStrip suppliercontextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem btnNew;
        private System.Windows.Forms.ToolStripMenuItem btnSave;
        private System.Windows.Forms.ToolStripMenuItem btnEdit;
        private System.Windows.Forms.ToolStripMenuItem btnDelete;
        private Telerik.WinControls.Themes.VisualStudio2012LightTheme visualStudio2012LightTheme1;
        private System.Windows.Forms.BindingSource supplierBindingSource;
    }
}