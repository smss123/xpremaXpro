﻿namespace Xprema_Project.suppliersApi
{
    partial class frmFinancier
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
            System.Windows.Forms.Label financiernameLabel;
            System.Windows.Forms.Label agentNameLabel;
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
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn7 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.radCollapsiblePanel1 = new Telerik.WinControls.UI.RadCollapsiblePanel();
            this.iDTextBox = new System.Windows.Forms.TextBox();
            this.thefinancierBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.financiernameTextBox = new System.Windows.Forms.TextBox();
            this.agentNameTextBox = new System.Windows.Forms.TextBox();
            this.phoneNumberTextBox = new System.Windows.Forms.TextBox();
            this.faxTextBox = new System.Windows.Forms.TextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.adderssTextBox = new System.Windows.Forms.TextBox();
            this.thefinancierRadGridView = new Telerik.WinControls.UI.RadGridView();
            this.visualStudio2012LightTheme1 = new Telerik.WinControls.Themes.VisualStudio2012LightTheme();
            this.FinancierMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btnNew = new System.Windows.Forms.ToolStripMenuItem();
            this.btnSave = new System.Windows.Forms.ToolStripMenuItem();
            this.btnedit = new System.Windows.Forms.ToolStripMenuItem();
            this.btnDel = new System.Windows.Forms.ToolStripMenuItem();
            iDLabel = new System.Windows.Forms.Label();
            financiernameLabel = new System.Windows.Forms.Label();
            agentNameLabel = new System.Windows.Forms.Label();
            phoneNumberLabel = new System.Windows.Forms.Label();
            faxLabel = new System.Windows.Forms.Label();
            emailLabel = new System.Windows.Forms.Label();
            adderssLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.radCollapsiblePanel1)).BeginInit();
            this.radCollapsiblePanel1.PanelContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.thefinancierBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.thefinancierRadGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.thefinancierRadGridView.MasterTemplate)).BeginInit();
            this.FinancierMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // iDLabel
            // 
            iDLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            iDLabel.AutoSize = true;
            iDLabel.Location = new System.Drawing.Point(921, 23);
            iDLabel.Name = "iDLabel";
            iDLabel.Size = new System.Drawing.Size(27, 13);
            iDLabel.TabIndex = 1;
            iDLabel.Text = "الرقم:";
            // 
            // financiernameLabel
            // 
            financiernameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            financiernameLabel.AutoSize = true;
            financiernameLabel.Location = new System.Drawing.Point(749, 23);
            financiernameLabel.Name = "financiernameLabel";
            financiernameLabel.Size = new System.Drawing.Size(51, 13);
            financiernameLabel.TabIndex = 1;
            financiernameLabel.Text = "اسم الممول:";
            // 
            // agentNameLabel
            // 
            agentNameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            agentNameLabel.AutoSize = true;
            agentNameLabel.Location = new System.Drawing.Point(473, 24);
            agentNameLabel.Name = "agentNameLabel";
            agentNameLabel.Size = new System.Drawing.Size(50, 13);
            agentNameLabel.TabIndex = 1;
            agentNameLabel.Text = "اسم الوكيل:";
            // 
            // phoneNumberLabel
            // 
            phoneNumberLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            phoneNumberLabel.AutoSize = true;
            phoneNumberLabel.Location = new System.Drawing.Point(180, 23);
            phoneNumberLabel.Name = "phoneNumberLabel";
            phoneNumberLabel.Size = new System.Drawing.Size(49, 13);
            phoneNumberLabel.TabIndex = 1;
            phoneNumberLabel.Text = "رقم الهاتف:";
            // 
            // faxLabel
            // 
            faxLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            faxLabel.AutoSize = true;
            faxLabel.Location = new System.Drawing.Point(908, 70);
            faxLabel.Name = "faxLabel";
            faxLabel.Size = new System.Drawing.Size(34, 13);
            faxLabel.TabIndex = 1;
            faxLabel.Text = "الفاكس:";
            // 
            // emailLabel
            // 
            emailLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            emailLabel.AutoSize = true;
            emailLabel.Location = new System.Drawing.Point(588, 67);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new System.Drawing.Size(71, 13);
            emailLabel.TabIndex = 1;
            emailLabel.Text = "البريد الالكتروني:";
            emailLabel.Click += new System.EventHandler(this.emailLabel_Click);
            // 
            // adderssLabel
            // 
            adderssLabel.AutoSize = true;
            adderssLabel.Location = new System.Drawing.Point(331, 68);
            adderssLabel.Name = "adderssLabel";
            adderssLabel.Size = new System.Drawing.Size(36, 13);
            adderssLabel.TabIndex = 1;
            adderssLabel.Text = "العنوان:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(960, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 490);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(960, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // radCollapsiblePanel1
            // 
            this.radCollapsiblePanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.radCollapsiblePanel1.Location = new System.Drawing.Point(0, 24);
            this.radCollapsiblePanel1.Name = "radCollapsiblePanel1";
            this.radCollapsiblePanel1.OwnerBoundsCache = new System.Drawing.Rectangle(0, 24, 820, 200);
            // 
            // radCollapsiblePanel1.PanelContainer
            // 
            this.radCollapsiblePanel1.PanelContainer.Controls.Add(iDLabel);
            this.radCollapsiblePanel1.PanelContainer.Controls.Add(this.iDTextBox);
            this.radCollapsiblePanel1.PanelContainer.Controls.Add(financiernameLabel);
            this.radCollapsiblePanel1.PanelContainer.Controls.Add(this.financiernameTextBox);
            this.radCollapsiblePanel1.PanelContainer.Controls.Add(agentNameLabel);
            this.radCollapsiblePanel1.PanelContainer.Controls.Add(this.agentNameTextBox);
            this.radCollapsiblePanel1.PanelContainer.Controls.Add(phoneNumberLabel);
            this.radCollapsiblePanel1.PanelContainer.Controls.Add(this.phoneNumberTextBox);
            this.radCollapsiblePanel1.PanelContainer.Controls.Add(faxLabel);
            this.radCollapsiblePanel1.PanelContainer.Controls.Add(this.faxTextBox);
            this.radCollapsiblePanel1.PanelContainer.Controls.Add(emailLabel);
            this.radCollapsiblePanel1.PanelContainer.Controls.Add(this.emailTextBox);
            this.radCollapsiblePanel1.PanelContainer.Controls.Add(adderssLabel);
            this.radCollapsiblePanel1.PanelContainer.Controls.Add(this.adderssTextBox);
            this.radCollapsiblePanel1.PanelContainer.Dock = System.Windows.Forms.DockStyle.Right;
            this.radCollapsiblePanel1.PanelContainer.Location = new System.Drawing.Point(0, 1);
            this.radCollapsiblePanel1.PanelContainer.Size = new System.Drawing.Size(959, 112);
            this.radCollapsiblePanel1.Size = new System.Drawing.Size(960, 142);
            this.radCollapsiblePanel1.TabIndex = 2;
            this.radCollapsiblePanel1.Text = "radCollapsiblePanel1";
            this.radCollapsiblePanel1.ThemeName = "VisualStudio2012Light";
            // 
            // iDTextBox
            // 
            this.iDTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.thefinancierBindingSource, "ID", true));
            this.iDTextBox.Location = new System.Drawing.Point(818, 20);
            this.iDTextBox.Name = "iDTextBox";
            this.iDTextBox.Size = new System.Drawing.Size(97, 20);
            this.iDTextBox.TabIndex = 2;
            // 
            // thefinancierBindingSource
            // 
            this.thefinancierBindingSource.DataSource = typeof(Xprema.Data.Thefinancier);
            // 
            // financiernameTextBox
            // 
            this.financiernameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.financiernameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.thefinancierBindingSource, "financiername", true));
            this.financiernameTextBox.Location = new System.Drawing.Point(554, 21);
            this.financiernameTextBox.Name = "financiernameTextBox";
            this.financiernameTextBox.Size = new System.Drawing.Size(189, 20);
            this.financiernameTextBox.TabIndex = 2;
            // 
            // agentNameTextBox
            // 
            this.agentNameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.agentNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.thefinancierBindingSource, "agentName", true));
            this.agentNameTextBox.Location = new System.Drawing.Point(250, 21);
            this.agentNameTextBox.Name = "agentNameTextBox";
            this.agentNameTextBox.Size = new System.Drawing.Size(217, 20);
            this.agentNameTextBox.TabIndex = 2;
            // 
            // phoneNumberTextBox
            // 
            this.phoneNumberTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.phoneNumberTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.thefinancierBindingSource, "PhoneNumber", true));
            this.phoneNumberTextBox.Location = new System.Drawing.Point(27, 20);
            this.phoneNumberTextBox.Name = "phoneNumberTextBox";
            this.phoneNumberTextBox.Size = new System.Drawing.Size(147, 20);
            this.phoneNumberTextBox.TabIndex = 2;
            // 
            // faxTextBox
            // 
            this.faxTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.faxTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.thefinancierBindingSource, "Fax", true));
            this.faxTextBox.Location = new System.Drawing.Point(685, 64);
            this.faxTextBox.Name = "faxTextBox";
            this.faxTextBox.Size = new System.Drawing.Size(217, 20);
            this.faxTextBox.TabIndex = 2;
            // 
            // emailTextBox
            // 
            this.emailTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.emailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.thefinancierBindingSource, "Email", true));
            this.emailTextBox.Location = new System.Drawing.Point(380, 64);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(202, 20);
            this.emailTextBox.TabIndex = 2;
            this.emailTextBox.TextChanged += new System.EventHandler(this.emailTextBox_TextChanged);
            // 
            // adderssTextBox
            // 
            this.adderssTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.thefinancierBindingSource, "Adderss", true));
            this.adderssTextBox.Location = new System.Drawing.Point(83, 65);
            this.adderssTextBox.Name = "adderssTextBox";
            this.adderssTextBox.Size = new System.Drawing.Size(240, 20);
            this.adderssTextBox.TabIndex = 2;
            // 
            // thefinancierRadGridView
            // 
            this.thefinancierRadGridView.BackColor = System.Drawing.SystemColors.Control;
            this.thefinancierRadGridView.Cursor = System.Windows.Forms.Cursors.Default;
            this.thefinancierRadGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.thefinancierRadGridView.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.thefinancierRadGridView.ForeColor = System.Drawing.SystemColors.ControlText;
            this.thefinancierRadGridView.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.thefinancierRadGridView.Location = new System.Drawing.Point(0, 166);
            // 
            // thefinancierRadGridView
            // 
            this.thefinancierRadGridView.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            gridViewDecimalColumn1.DataType = typeof(int);
            gridViewDecimalColumn1.EnableExpressionEditor = false;
            gridViewDecimalColumn1.FieldName = "ID";
            gridViewDecimalColumn1.HeaderText = "الرقم";
            gridViewDecimalColumn1.IsAutoGenerated = true;
            gridViewDecimalColumn1.Name = "ID";
            gridViewDecimalColumn1.Width = 118;
            gridViewTextBoxColumn1.EnableExpressionEditor = false;
            gridViewTextBoxColumn1.FieldName = "financiername";
            gridViewTextBoxColumn1.HeaderText = "اسم الممول";
            gridViewTextBoxColumn1.IsAutoGenerated = true;
            gridViewTextBoxColumn1.Name = "financiername";
            gridViewTextBoxColumn1.Width = 118;
            gridViewTextBoxColumn2.EnableExpressionEditor = false;
            gridViewTextBoxColumn2.FieldName = "PhoneNumber";
            gridViewTextBoxColumn2.HeaderText = "رقم الهاتف";
            gridViewTextBoxColumn2.IsAutoGenerated = true;
            gridViewTextBoxColumn2.Name = "PhoneNumber";
            gridViewTextBoxColumn2.Width = 118;
            gridViewTextBoxColumn3.EnableExpressionEditor = false;
            gridViewTextBoxColumn3.FieldName = "agentName";
            gridViewTextBoxColumn3.HeaderText = "اسم الوكيل";
            gridViewTextBoxColumn3.IsAutoGenerated = true;
            gridViewTextBoxColumn3.Name = "agentName";
            gridViewTextBoxColumn3.Width = 118;
            gridViewTextBoxColumn4.EnableExpressionEditor = false;
            gridViewTextBoxColumn4.FieldName = "Fax";
            gridViewTextBoxColumn4.HeaderText = "الفاكس";
            gridViewTextBoxColumn4.IsAutoGenerated = true;
            gridViewTextBoxColumn4.Name = "Fax";
            gridViewTextBoxColumn4.Width = 118;
            gridViewTextBoxColumn5.EnableExpressionEditor = false;
            gridViewTextBoxColumn5.FieldName = "Email";
            gridViewTextBoxColumn5.HeaderText = "البريد الالكتروني";
            gridViewTextBoxColumn5.IsAutoGenerated = true;
            gridViewTextBoxColumn5.Name = "Email";
            gridViewTextBoxColumn5.Width = 118;
            gridViewTextBoxColumn6.EnableExpressionEditor = false;
            gridViewTextBoxColumn6.FieldName = "Adderss";
            gridViewTextBoxColumn6.HeaderText = "العنوان";
            gridViewTextBoxColumn6.IsAutoGenerated = true;
            gridViewTextBoxColumn6.Name = "Adderss";
            gridViewTextBoxColumn6.Width = 118;
            gridViewTextBoxColumn7.DataType = typeof(Xprema.Data.ProjectProfile);
            gridViewTextBoxColumn7.EnableExpressionEditor = false;
            gridViewTextBoxColumn7.FieldName = "ProjectProfile";
            gridViewTextBoxColumn7.HeaderText = "ProjectProfile";
            gridViewTextBoxColumn7.IsAutoGenerated = true;
            gridViewTextBoxColumn7.Name = "ProjectProfile";
            gridViewTextBoxColumn7.Width = 123;
            this.thefinancierRadGridView.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewDecimalColumn1,
            gridViewTextBoxColumn1,
            gridViewTextBoxColumn2,
            gridViewTextBoxColumn3,
            gridViewTextBoxColumn4,
            gridViewTextBoxColumn5,
            gridViewTextBoxColumn6,
            gridViewTextBoxColumn7});
            this.thefinancierRadGridView.MasterTemplate.DataSource = this.thefinancierBindingSource;
            this.thefinancierRadGridView.Name = "thefinancierRadGridView";
            this.thefinancierRadGridView.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.thefinancierRadGridView.Size = new System.Drawing.Size(960, 324);
            this.thefinancierRadGridView.TabIndex = 3;
            this.thefinancierRadGridView.Text = "radGridView1";
            this.thefinancierRadGridView.ThemeName = "VisualStudio2012Light";
            // 
            // FinancierMenuStrip
            // 
            this.FinancierMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnNew,
            this.btnSave,
            this.btnedit,
            this.btnDel});
            this.FinancierMenuStrip.Name = "FinancierMenuStrip";
            this.FinancierMenuStrip.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.FinancierMenuStrip.Size = new System.Drawing.Size(150, 92);
            // 
            // btnNew
            // 
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(149, 22);
            this.btnNew.Text = "جديد     Ctrl+N";
            // 
            // btnSave
            // 
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(149, 22);
            this.btnSave.Text = "حفظ     Ctrl+S";
            // 
            // btnedit
            // 
            this.btnedit.Name = "btnedit";
            this.btnedit.Size = new System.Drawing.Size(149, 22);
            this.btnedit.Text = "تعديل     Ctrl+U";
            // 
            // btnDel
            // 
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(149, 22);
            this.btnDel.Text = "حذف     Ctrl+D";
            // 
            // frmFinancier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(960, 512);
            this.Controls.Add(this.thefinancierRadGridView);
            this.Controls.Add(this.radCollapsiblePanel1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmFinancier";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "الممولين";
            this.Load += new System.EventHandler(this.frmFinancier_Load);
            this.radCollapsiblePanel1.PanelContainer.ResumeLayout(false);
            this.radCollapsiblePanel1.PanelContainer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radCollapsiblePanel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.thefinancierBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.thefinancierRadGridView.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.thefinancierRadGridView)).EndInit();
            this.FinancierMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private Telerik.WinControls.UI.RadCollapsiblePanel radCollapsiblePanel1;
        private System.Windows.Forms.TextBox iDTextBox;
        private System.Windows.Forms.BindingSource thefinancierBindingSource;
        private System.Windows.Forms.TextBox financiernameTextBox;
        private System.Windows.Forms.TextBox agentNameTextBox;
        private System.Windows.Forms.TextBox phoneNumberTextBox;
        private System.Windows.Forms.TextBox faxTextBox;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.TextBox adderssTextBox;
        private Telerik.WinControls.UI.RadGridView thefinancierRadGridView;
        private Telerik.WinControls.Themes.VisualStudio2012LightTheme visualStudio2012LightTheme1;
        private System.Windows.Forms.ContextMenuStrip FinancierMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem btnNew;
        private System.Windows.Forms.ToolStripMenuItem btnSave;
        private System.Windows.Forms.ToolStripMenuItem btnedit;
        private System.Windows.Forms.ToolStripMenuItem btnDel;
    }
}