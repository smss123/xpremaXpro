﻿namespace Xprema_Project.suppliersApi
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
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn8 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn50 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn51 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn52 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn53 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn54 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn55 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn56 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.Data.SortDescriptor sortDescriptor8 = new Telerik.WinControls.Data.SortDescriptor();
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
            this.supplierBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.suppliersNaturalTextBox = new System.Windows.Forms.TextBox();
            this.phoneNumberTextBox = new System.Windows.Forms.TextBox();
            this.faxTextBox = new System.Windows.Forms.TextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.adderssTextBox = new System.Windows.Forms.TextBox();
            this.supplierRadGridView = new Telerik.WinControls.UI.RadGridView();
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
            ((System.ComponentModel.ISupportInitialize)(this.supplierBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.supplierRadGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.supplierRadGridView.MasterTemplate)).BeginInit();
            this.suppliercontextMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // iDLabel
            // 
            iDLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            iDLabel.AutoSize = true;
            iDLabel.Location = new System.Drawing.Point(916, 26);
            iDLabel.Name = "iDLabel";
            iDLabel.Size = new System.Drawing.Size(45, 13);
            iDLabel.TabIndex = 800;
            iDLabel.Text = "رقم الموَرد";
            // 
            // nameLabel
            // 
            nameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            nameLabel.AutoSize = true;
            nameLabel.Location = new System.Drawing.Point(915, 50);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(47, 13);
            nameLabel.TabIndex = 800;
            nameLabel.Text = "اسم الموَرد";
            // 
            // suppliersNaturalLabel
            // 
            suppliersNaturalLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            suppliersNaturalLabel.AutoSize = true;
            suppliersNaturalLabel.Location = new System.Drawing.Point(916, 76);
            suppliersNaturalLabel.Name = "suppliersNaturalLabel";
            suppliersNaturalLabel.Size = new System.Drawing.Size(51, 13);
            suppliersNaturalLabel.TabIndex = 800;
            suppliersNaturalLabel.Text = "طبيعة المواد";
            // 
            // phoneNumberLabel
            // 
            phoneNumberLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            phoneNumberLabel.AutoSize = true;
            phoneNumberLabel.Location = new System.Drawing.Point(328, 25);
            phoneNumberLabel.Name = "phoneNumberLabel";
            phoneNumberLabel.Size = new System.Drawing.Size(46, 13);
            phoneNumberLabel.TabIndex = 1800;
            phoneNumberLabel.Text = "رقم الهاتف";
            // 
            // faxLabel
            // 
            faxLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            faxLabel.AutoSize = true;
            faxLabel.Location = new System.Drawing.Point(332, 75);
            faxLabel.Name = "faxLabel";
            faxLabel.Size = new System.Drawing.Size(26, 13);
            faxLabel.TabIndex = 1800;
            faxLabel.Text = "فاكس";
            // 
            // emailLabel
            // 
            emailLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            emailLabel.AutoSize = true;
            emailLabel.Location = new System.Drawing.Point(332, 51);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new System.Drawing.Size(68, 13);
            emailLabel.TabIndex = 18000;
            emailLabel.Text = "البريد الالكتروني";
            // 
            // adderssLabel
            // 
            adderssLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            adderssLabel.AutoSize = true;
            adderssLabel.Location = new System.Drawing.Point(649, 98);
            adderssLabel.Name = "adderssLabel";
            adderssLabel.Size = new System.Drawing.Size(33, 13);
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
            this.جديدToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
            this.جديدToolStripMenuItem.Text = "جديد";
            // 
            // اضافةToolStripMenuItem
            // 
            this.اضافةToolStripMenuItem.Name = "اضافةToolStripMenuItem";
            this.اضافةToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.اضافةToolStripMenuItem.Text = "اضافة";
            // 
            // حفظToolStripMenuItem
            // 
            this.حفظToolStripMenuItem.Name = "حفظToolStripMenuItem";
            this.حفظToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.حفظToolStripMenuItem.Text = "حفظ";
            // 
            // حذفToolStripMenuItem
            // 
            this.حذفToolStripMenuItem.Name = "حذفToolStripMenuItem";
            this.حذفToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
            this.حذفToolStripMenuItem.Text = "حذف";
            // 
            // خروجToolStripMenuItem
            // 
            this.خروجToolStripMenuItem.Name = "خروجToolStripMenuItem";
            this.خروجToolStripMenuItem.Size = new System.Drawing.Size(75, 20);
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
            this.statusStrip1.Location = new System.Drawing.Point(0, 558);
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
            this.radCollapsiblePanel1.PanelContainer.Size = new System.Drawing.Size(984, 154);
            this.radCollapsiblePanel1.PanelContainer.Paint += new System.Windows.Forms.PaintEventHandler(this.radCollapsiblePanel1_PanelContainer_Paint);
            this.radCollapsiblePanel1.Size = new System.Drawing.Size(988, 184);
            this.radCollapsiblePanel1.TabIndex = 2;
            this.radCollapsiblePanel1.Text = "radCollapsiblePanel1";
            this.radCollapsiblePanel1.ThemeName = "VisualStudio2012Light";
            // 
            // iDTextBox
            // 
            this.iDTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.supplierBindingSource, "ID", true));
            this.iDTextBox.Location = new System.Drawing.Point(684, 22);
            this.iDTextBox.Name = "iDTextBox";
            this.iDTextBox.ReadOnly = true;
            this.iDTextBox.Size = new System.Drawing.Size(226, 20);
            this.iDTextBox.TabIndex = 2;
            // 
            // supplierBindingSource
            // 
            this.supplierBindingSource.DataSource = typeof(Xprema.Data.Supplier);
            // 
            // nameTextBox
            // 
            this.nameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.supplierBindingSource, "name", true));
            this.nameTextBox.Location = new System.Drawing.Point(684, 48);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(226, 20);
            this.nameTextBox.TabIndex = 1;
            // 
            // suppliersNaturalTextBox
            // 
            this.suppliersNaturalTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.suppliersNaturalTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.supplierBindingSource, "SuppliersNatural", true));
            this.suppliersNaturalTextBox.Location = new System.Drawing.Point(684, 74);
            this.suppliersNaturalTextBox.Name = "suppliersNaturalTextBox";
            this.suppliersNaturalTextBox.Size = new System.Drawing.Size(226, 20);
            this.suppliersNaturalTextBox.TabIndex = 2;
            // 
            // phoneNumberTextBox
            // 
            this.phoneNumberTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.phoneNumberTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.supplierBindingSource, "PhoneNumber", true));
            this.phoneNumberTextBox.Location = new System.Drawing.Point(63, 22);
            this.phoneNumberTextBox.Name = "phoneNumberTextBox";
            this.phoneNumberTextBox.Size = new System.Drawing.Size(263, 20);
            this.phoneNumberTextBox.TabIndex = 4;
            // 
            // faxTextBox
            // 
            this.faxTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.faxTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.supplierBindingSource, "Fax", true));
            this.faxTextBox.Location = new System.Drawing.Point(63, 72);
            this.faxTextBox.Name = "faxTextBox";
            this.faxTextBox.Size = new System.Drawing.Size(263, 20);
            this.faxTextBox.TabIndex = 6;
            // 
            // emailTextBox
            // 
            this.emailTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.emailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.supplierBindingSource, "Email", true));
            this.emailTextBox.Location = new System.Drawing.Point(63, 48);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(263, 20);
            this.emailTextBox.TabIndex = 5;
            // 
            // adderssTextBox
            // 
            this.adderssTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.adderssTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.supplierBindingSource, "Adderss", true));
            this.adderssTextBox.Location = new System.Drawing.Point(366, 95);
            this.adderssTextBox.Multiline = true;
            this.adderssTextBox.Name = "adderssTextBox";
            this.adderssTextBox.Size = new System.Drawing.Size(280, 44);
            this.adderssTextBox.TabIndex = 3;
            // 
            // supplierRadGridView
            // 
            this.supplierRadGridView.BackColor = System.Drawing.SystemColors.Control;
            this.supplierRadGridView.Cursor = System.Windows.Forms.Cursors.Default;
            this.supplierRadGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.supplierRadGridView.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.supplierRadGridView.ForeColor = System.Drawing.SystemColors.ControlText;
            this.supplierRadGridView.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.supplierRadGridView.Location = new System.Drawing.Point(0, 208);
            // 
            // supplierRadGridView
            // 
            this.supplierRadGridView.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            gridViewDecimalColumn8.DataType = typeof(int);
            gridViewDecimalColumn8.EnableExpressionEditor = false;
            gridViewDecimalColumn8.FieldName = "ID";
            gridViewDecimalColumn8.HeaderText = "رقم الموَرد";
            gridViewDecimalColumn8.IsAutoGenerated = true;
            gridViewDecimalColumn8.Name = "ID";
            gridViewDecimalColumn8.Width = 101;
            gridViewTextBoxColumn50.EnableExpressionEditor = false;
            gridViewTextBoxColumn50.FieldName = "name";
            gridViewTextBoxColumn50.HeaderText = "اسم الموَرد";
            gridViewTextBoxColumn50.IsAutoGenerated = true;
            gridViewTextBoxColumn50.Name = "name";
            gridViewTextBoxColumn50.Width = 184;
            gridViewTextBoxColumn51.EnableExpressionEditor = false;
            gridViewTextBoxColumn51.FieldName = "PhoneNumber";
            gridViewTextBoxColumn51.HeaderText = "رقم الهاتف";
            gridViewTextBoxColumn51.IsAutoGenerated = true;
            gridViewTextBoxColumn51.Name = "PhoneNumber";
            gridViewTextBoxColumn51.Width = 160;
            gridViewTextBoxColumn52.EnableExpressionEditor = false;
            gridViewTextBoxColumn52.FieldName = "Adderss";
            gridViewTextBoxColumn52.HeaderText = "العنوان";
            gridViewTextBoxColumn52.IsAutoGenerated = true;
            gridViewTextBoxColumn52.Name = "Adderss";
            gridViewTextBoxColumn52.Width = 104;
            gridViewTextBoxColumn53.EnableExpressionEditor = false;
            gridViewTextBoxColumn53.FieldName = "SuppliersNatural";
            gridViewTextBoxColumn53.HeaderText = "طبيعة المواد الموَردة";
            gridViewTextBoxColumn53.IsAutoGenerated = true;
            gridViewTextBoxColumn53.Name = "SuppliersNatural";
            gridViewTextBoxColumn53.SortOrder = Telerik.WinControls.UI.RadSortOrder.Ascending;
            gridViewTextBoxColumn53.Width = 120;
            gridViewTextBoxColumn54.EnableExpressionEditor = false;
            gridViewTextBoxColumn54.FieldName = "Fax";
            gridViewTextBoxColumn54.HeaderText = "فاكس";
            gridViewTextBoxColumn54.IsAutoGenerated = true;
            gridViewTextBoxColumn54.Name = "Fax";
            gridViewTextBoxColumn54.Width = 136;
            gridViewTextBoxColumn55.EnableExpressionEditor = false;
            gridViewTextBoxColumn55.FieldName = "Email";
            gridViewTextBoxColumn55.HeaderText = "البريد الالكتروني";
            gridViewTextBoxColumn55.IsAutoGenerated = true;
            gridViewTextBoxColumn55.Name = "Email";
            gridViewTextBoxColumn55.Width = 141;
            gridViewTextBoxColumn56.DataType = typeof(Xprema.Data.ProjectExpens);
            gridViewTextBoxColumn56.EnableExpressionEditor = false;
            gridViewTextBoxColumn56.FieldName = "ProjectExpen";
            gridViewTextBoxColumn56.HeaderText = "ProjectExpen";
            gridViewTextBoxColumn56.IsAutoGenerated = true;
            gridViewTextBoxColumn56.Name = "ProjectExpen";
            gridViewTextBoxColumn56.Width = 31;
            this.supplierRadGridView.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewDecimalColumn8,
            gridViewTextBoxColumn50,
            gridViewTextBoxColumn51,
            gridViewTextBoxColumn52,
            gridViewTextBoxColumn53,
            gridViewTextBoxColumn54,
            gridViewTextBoxColumn55,
            gridViewTextBoxColumn56});
            this.supplierRadGridView.MasterTemplate.DataSource = this.supplierBindingSource;
            sortDescriptor8.PropertyName = "SuppliersNatural";
            this.supplierRadGridView.MasterTemplate.SortDescriptors.AddRange(new Telerik.WinControls.Data.SortDescriptor[] {
            sortDescriptor8});
            this.supplierRadGridView.Name = "supplierRadGridView";
            this.supplierRadGridView.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.supplierRadGridView.Size = new System.Drawing.Size(988, 350);
            this.supplierRadGridView.TabIndex = 3;
            this.supplierRadGridView.Text = "radGridView1";
            this.supplierRadGridView.ThemeName = "VisualStudio2012Light";
            // 
            // suppliercontextMenuStrip
            // 
            this.suppliercontextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnNew,
            this.btnSave,
            this.btnEdit,
            this.btnDelete});
            this.suppliercontextMenuStrip.Name = "suppliercontextMenuStrip";
            this.suppliercontextMenuStrip.Size = new System.Drawing.Size(150, 92);
            // 
            // btnNew
            // 
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(152, 22);
            this.btnNew.Text = "جديد     Ctrl+N";
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnSave
            // 
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(152, 22);
            this.btnSave.Text = "حفظ     Ctrl+S";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(152, 22);
            this.btnEdit.Text = "تعديل     Ctrl+U";
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(152, 22);
            this.btnDelete.Text = "حذف     Ctrl+D";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // frmsupplier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(988, 580);
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
            ((System.ComponentModel.ISupportInitialize)(this.supplierBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.supplierRadGridView.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.supplierRadGridView)).EndInit();
            this.suppliercontextMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private Telerik.WinControls.UI.RadCollapsiblePanel radCollapsiblePanel1;
        private System.Windows.Forms.TextBox iDTextBox;
        private System.Windows.Forms.BindingSource supplierBindingSource;
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
    }
}