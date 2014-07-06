namespace Xprema_Project.EmployeeApi
{
    partial class frmEmployee
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
            System.Windows.Forms.Label employeeNameLabel;
            System.Windows.Forms.Label employeeGenderLabel;
            System.Windows.Forms.Label employeejobNumberLabel;
            System.Windows.Forms.Label mobilenumberLabel;
            System.Windows.Forms.Label phoneNumberLabel;
            System.Windows.Forms.Label emailLabel;
            System.Windows.Forms.Label employeeNationalNumberLabel;
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn1 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn1 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn2 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn3 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn4 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn5 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn6 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn7 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn8 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            this.visualStudio2012LightTheme1 = new Telerik.WinControls.Themes.VisualStudio2012LightTheme();
            this.userSystemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.radCollapsiblePanel1 = new Telerik.WinControls.UI.RadCollapsiblePanel();
            this.employeeNationalNumberTextBox = new System.Windows.Forms.TextBox();
            this.employeeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mobilenumberTextBox = new System.Windows.Forms.TextBox();
            this.employeejobNumberTextBox = new System.Windows.Forms.TextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.employeeGenderComboBox = new System.Windows.Forms.ComboBox();
            this.phoneNumberTextBox = new System.Windows.Forms.TextBox();
            this.iDTextBox = new System.Windows.Forms.TextBox();
            this.employeeNameTextBox = new System.Windows.Forms.TextBox();
            this.employeeRadGridView = new Telerik.WinControls.UI.RadGridView();
            this.employeecontextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btnNew = new System.Windows.Forms.ToolStripMenuItem();
            this.btnSave = new System.Windows.Forms.ToolStripMenuItem();
            this.btrEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.btnDel = new System.Windows.Forms.ToolStripMenuItem();
            iDLabel = new System.Windows.Forms.Label();
            employeeNameLabel = new System.Windows.Forms.Label();
            employeeGenderLabel = new System.Windows.Forms.Label();
            employeejobNumberLabel = new System.Windows.Forms.Label();
            mobilenumberLabel = new System.Windows.Forms.Label();
            phoneNumberLabel = new System.Windows.Forms.Label();
            emailLabel = new System.Windows.Forms.Label();
            employeeNationalNumberLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.userSystemBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radCollapsiblePanel1)).BeginInit();
            this.radCollapsiblePanel1.PanelContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeRadGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeRadGridView.MasterTemplate)).BeginInit();
            this.employeecontextMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // iDLabel
            // 
            iDLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            iDLabel.AutoSize = true;
            iDLabel.Location = new System.Drawing.Point(1090, 36);
            iDLabel.Name = "iDLabel";
            iDLabel.Size = new System.Drawing.Size(21, 13);
            iDLabel.TabIndex = 1;
            iDLabel.Text = "ID:";
            // 
            // employeeNameLabel
            // 
            employeeNameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            employeeNameLabel.AutoSize = true;
            employeeNameLabel.Location = new System.Drawing.Point(874, 36);
            employeeNameLabel.Name = "employeeNameLabel";
            employeeNameLabel.Size = new System.Drawing.Size(91, 13);
            employeeNameLabel.TabIndex = 1;
            employeeNameLabel.Text = "Employee Name:";
            // 
            // employeeGenderLabel
            // 
            employeeGenderLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            employeeGenderLabel.AutoSize = true;
            employeeGenderLabel.Location = new System.Drawing.Point(601, 36);
            employeeGenderLabel.Name = "employeeGenderLabel";
            employeeGenderLabel.Size = new System.Drawing.Size(100, 13);
            employeeGenderLabel.TabIndex = 1;
            employeeGenderLabel.Text = "Employee Gender:";
            // 
            // employeejobNumberLabel
            // 
            employeejobNumberLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            employeejobNumberLabel.AutoSize = true;
            employeejobNumberLabel.Location = new System.Drawing.Point(350, 36);
            employeejobNumberLabel.Name = "employeejobNumberLabel";
            employeejobNumberLabel.Size = new System.Drawing.Size(120, 13);
            employeejobNumberLabel.TabIndex = 1;
            employeejobNumberLabel.Text = "Employeejob Number:";
            // 
            // mobilenumberLabel
            // 
            mobilenumberLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            mobilenumberLabel.AutoSize = true;
            mobilenumberLabel.Location = new System.Drawing.Point(745, 82);
            mobilenumberLabel.Name = "mobilenumberLabel";
            mobilenumberLabel.Size = new System.Drawing.Size(86, 13);
            mobilenumberLabel.TabIndex = 1;
            mobilenumberLabel.Text = "Mobilenumber:";
            // 
            // phoneNumberLabel
            // 
            phoneNumberLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            phoneNumberLabel.AutoSize = true;
            phoneNumberLabel.Location = new System.Drawing.Point(1027, 82);
            phoneNumberLabel.Name = "phoneNumberLabel";
            phoneNumberLabel.Size = new System.Drawing.Size(87, 13);
            phoneNumberLabel.TabIndex = 1;
            phoneNumberLabel.Text = "Phone Number:";
            // 
            // emailLabel
            // 
            emailLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            emailLabel.AutoSize = true;
            emailLabel.Location = new System.Drawing.Point(491, 82);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new System.Drawing.Size(37, 13);
            emailLabel.TabIndex = 1;
            emailLabel.Text = "Email:";
            // 
            // employeeNationalNumberLabel
            // 
            employeeNationalNumberLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            employeeNationalNumberLabel.AutoSize = true;
            employeeNationalNumberLabel.Location = new System.Drawing.Point(149, 82);
            employeeNationalNumberLabel.Name = "employeeNationalNumberLabel";
            employeeNationalNumberLabel.Size = new System.Drawing.Size(150, 13);
            employeeNationalNumberLabel.TabIndex = 1;
            employeeNationalNumberLabel.Text = "Employee National Number:";
            // 
            // userSystemBindingSource
            // 
            this.userSystemBindingSource.DataSource = typeof(Xprema.Data.UserSystem);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1124, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 537);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1124, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // radCollapsiblePanel1
            // 
            this.radCollapsiblePanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.radCollapsiblePanel1.Location = new System.Drawing.Point(0, 24);
            this.radCollapsiblePanel1.Name = "radCollapsiblePanel1";
            this.radCollapsiblePanel1.OwnerBoundsCache = new System.Drawing.Rectangle(0, 24, 872, 147);
            // 
            // radCollapsiblePanel1.PanelContainer
            // 
            this.radCollapsiblePanel1.PanelContainer.Controls.Add(this.employeeNationalNumberTextBox);
            this.radCollapsiblePanel1.PanelContainer.Controls.Add(this.mobilenumberTextBox);
            this.radCollapsiblePanel1.PanelContainer.Controls.Add(iDLabel);
            this.radCollapsiblePanel1.PanelContainer.Controls.Add(mobilenumberLabel);
            this.radCollapsiblePanel1.PanelContainer.Controls.Add(employeeGenderLabel);
            this.radCollapsiblePanel1.PanelContainer.Controls.Add(employeejobNumberLabel);
            this.radCollapsiblePanel1.PanelContainer.Controls.Add(employeeNationalNumberLabel);
            this.radCollapsiblePanel1.PanelContainer.Controls.Add(this.employeejobNumberTextBox);
            this.radCollapsiblePanel1.PanelContainer.Controls.Add(this.emailTextBox);
            this.radCollapsiblePanel1.PanelContainer.Controls.Add(employeeNameLabel);
            this.radCollapsiblePanel1.PanelContainer.Controls.Add(emailLabel);
            this.radCollapsiblePanel1.PanelContainer.Controls.Add(this.employeeGenderComboBox);
            this.radCollapsiblePanel1.PanelContainer.Controls.Add(this.phoneNumberTextBox);
            this.radCollapsiblePanel1.PanelContainer.Controls.Add(phoneNumberLabel);
            this.radCollapsiblePanel1.PanelContainer.Controls.Add(this.iDTextBox);
            this.radCollapsiblePanel1.PanelContainer.Controls.Add(this.employeeNameTextBox);
            this.radCollapsiblePanel1.PanelContainer.Dock = System.Windows.Forms.DockStyle.Right;
            this.radCollapsiblePanel1.PanelContainer.Location = new System.Drawing.Point(-1, 1);
            this.radCollapsiblePanel1.PanelContainer.Size = new System.Drawing.Size(1124, 150);
            this.radCollapsiblePanel1.Size = new System.Drawing.Size(1124, 178);
            this.radCollapsiblePanel1.TabIndex = 2;
            this.radCollapsiblePanel1.Text = "radCollapsiblePanel1";
            // 
            // employeeNationalNumberTextBox
            // 
            this.employeeNationalNumberTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.employeeNationalNumberTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeeBindingSource, "EmployeeNationalNumber", true));
            this.employeeNationalNumberTextBox.Location = new System.Drawing.Point(5, 80);
            this.employeeNationalNumberTextBox.Name = "employeeNationalNumberTextBox";
            this.employeeNationalNumberTextBox.Size = new System.Drawing.Size(146, 20);
            this.employeeNationalNumberTextBox.TabIndex = 2;
            // 
            // employeeBindingSource
            // 
            this.employeeBindingSource.DataSource = typeof(Xprema.Data.Employee);
            // 
            // mobilenumberTextBox
            // 
            this.mobilenumberTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.mobilenumberTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeeBindingSource, "Mobilenumber", true));
            this.mobilenumberTextBox.Location = new System.Drawing.Point(551, 79);
            this.mobilenumberTextBox.Name = "mobilenumberTextBox";
            this.mobilenumberTextBox.Size = new System.Drawing.Size(188, 20);
            this.mobilenumberTextBox.TabIndex = 2;
            // 
            // employeejobNumberTextBox
            // 
            this.employeejobNumberTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.employeejobNumberTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeeBindingSource, "EmployeejobNumber", true));
            this.employeejobNumberTextBox.Location = new System.Drawing.Point(218, 33);
            this.employeejobNumberTextBox.Name = "employeejobNumberTextBox";
            this.employeejobNumberTextBox.Size = new System.Drawing.Size(126, 20);
            this.employeejobNumberTextBox.TabIndex = 2;
            // 
            // emailTextBox
            // 
            this.emailTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.emailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeeBindingSource, "Email", true));
            this.emailTextBox.Location = new System.Drawing.Point(305, 79);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(180, 20);
            this.emailTextBox.TabIndex = 2;
            // 
            // employeeGenderComboBox
            // 
            this.employeeGenderComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.employeeGenderComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeeBindingSource, "EmployeeGender", true));
            this.employeeGenderComboBox.FormattingEnabled = true;
            this.employeeGenderComboBox.Location = new System.Drawing.Point(474, 33);
            this.employeeGenderComboBox.Name = "employeeGenderComboBox";
            this.employeeGenderComboBox.Size = new System.Drawing.Size(121, 21);
            this.employeeGenderComboBox.TabIndex = 2;
            // 
            // phoneNumberTextBox
            // 
            this.phoneNumberTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.phoneNumberTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeeBindingSource, "PhoneNumber", true));
            this.phoneNumberTextBox.Location = new System.Drawing.Point(852, 79);
            this.phoneNumberTextBox.Name = "phoneNumberTextBox";
            this.phoneNumberTextBox.Size = new System.Drawing.Size(169, 20);
            this.phoneNumberTextBox.TabIndex = 2;
            // 
            // iDTextBox
            // 
            this.iDTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeeBindingSource, "ID", true));
            this.iDTextBox.Location = new System.Drawing.Point(979, 33);
            this.iDTextBox.Name = "iDTextBox";
            this.iDTextBox.Size = new System.Drawing.Size(100, 20);
            this.iDTextBox.TabIndex = 2;
            // 
            // employeeNameTextBox
            // 
            this.employeeNameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.employeeNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeeBindingSource, "EmployeeName", true));
            this.employeeNameTextBox.Location = new System.Drawing.Point(719, 33);
            this.employeeNameTextBox.Name = "employeeNameTextBox";
            this.employeeNameTextBox.Size = new System.Drawing.Size(149, 20);
            this.employeeNameTextBox.TabIndex = 2;
            // 
            // employeeRadGridView
            // 
            this.employeeRadGridView.BackColor = System.Drawing.SystemColors.Control;
            this.employeeRadGridView.Cursor = System.Windows.Forms.Cursors.Default;
            this.employeeRadGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.employeeRadGridView.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.employeeRadGridView.ForeColor = System.Drawing.SystemColors.ControlText;
            this.employeeRadGridView.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.employeeRadGridView.Location = new System.Drawing.Point(0, 202);
            // 
            // employeeRadGridView
            // 
            this.employeeRadGridView.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            gridViewDecimalColumn1.DataType = typeof(int);
            gridViewDecimalColumn1.EnableExpressionEditor = false;
            gridViewDecimalColumn1.FieldName = "ID";
            gridViewDecimalColumn1.HeaderText = "ID";
            gridViewDecimalColumn1.IsAutoGenerated = true;
            gridViewDecimalColumn1.Name = "ID";
            gridViewDecimalColumn1.Width = 139;
            gridViewTextBoxColumn1.EnableExpressionEditor = false;
            gridViewTextBoxColumn1.FieldName = "EmployeeName";
            gridViewTextBoxColumn1.HeaderText = "EmployeeName";
            gridViewTextBoxColumn1.IsAutoGenerated = true;
            gridViewTextBoxColumn1.Name = "EmployeeName";
            gridViewTextBoxColumn1.Width = 139;
            gridViewTextBoxColumn2.EnableExpressionEditor = false;
            gridViewTextBoxColumn2.FieldName = "EmployeejobNumber";
            gridViewTextBoxColumn2.HeaderText = "EmployeejobNumber";
            gridViewTextBoxColumn2.IsAutoGenerated = true;
            gridViewTextBoxColumn2.Name = "EmployeejobNumber";
            gridViewTextBoxColumn2.Width = 139;
            gridViewTextBoxColumn3.EnableExpressionEditor = false;
            gridViewTextBoxColumn3.FieldName = "EmployeeGender";
            gridViewTextBoxColumn3.HeaderText = "EmployeeGender";
            gridViewTextBoxColumn3.IsAutoGenerated = true;
            gridViewTextBoxColumn3.Name = "EmployeeGender";
            gridViewTextBoxColumn3.Width = 139;
            gridViewTextBoxColumn4.EnableExpressionEditor = false;
            gridViewTextBoxColumn4.FieldName = "EmployeeNationalNumber";
            gridViewTextBoxColumn4.HeaderText = "EmployeeNationalNumber";
            gridViewTextBoxColumn4.IsAutoGenerated = true;
            gridViewTextBoxColumn4.Name = "EmployeeNationalNumber";
            gridViewTextBoxColumn4.Width = 139;
            gridViewTextBoxColumn5.EnableExpressionEditor = false;
            gridViewTextBoxColumn5.FieldName = "PhoneNumber";
            gridViewTextBoxColumn5.HeaderText = "PhoneNumber";
            gridViewTextBoxColumn5.IsAutoGenerated = true;
            gridViewTextBoxColumn5.Name = "PhoneNumber";
            gridViewTextBoxColumn5.Width = 139;
            gridViewTextBoxColumn6.EnableExpressionEditor = false;
            gridViewTextBoxColumn6.FieldName = "Mobilenumber";
            gridViewTextBoxColumn6.HeaderText = "Mobilenumber";
            gridViewTextBoxColumn6.IsAutoGenerated = true;
            gridViewTextBoxColumn6.Name = "Mobilenumber";
            gridViewTextBoxColumn6.Width = 139;
            gridViewTextBoxColumn7.EnableExpressionEditor = false;
            gridViewTextBoxColumn7.FieldName = "Email";
            gridViewTextBoxColumn7.HeaderText = "Email";
            gridViewTextBoxColumn7.IsAutoGenerated = true;
            gridViewTextBoxColumn7.Name = "Email";
            gridViewTextBoxColumn7.Width = 140;
            gridViewTextBoxColumn8.DataType = typeof(System.Collections.Generic.ICollection<Xprema.Data.Contract>);
            gridViewTextBoxColumn8.EnableExpressionEditor = false;
            gridViewTextBoxColumn8.FieldName = "Contracts";
            gridViewTextBoxColumn8.HeaderText = "Contracts";
            gridViewTextBoxColumn8.IsAutoGenerated = true;
            gridViewTextBoxColumn8.IsVisible = false;
            gridViewTextBoxColumn8.Name = "Contracts";
            gridViewTextBoxColumn8.Width = 66;
            this.employeeRadGridView.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewDecimalColumn1,
            gridViewTextBoxColumn1,
            gridViewTextBoxColumn2,
            gridViewTextBoxColumn3,
            gridViewTextBoxColumn4,
            gridViewTextBoxColumn5,
            gridViewTextBoxColumn6,
            gridViewTextBoxColumn7,
            gridViewTextBoxColumn8});
            this.employeeRadGridView.MasterTemplate.DataSource = this.employeeBindingSource;
            this.employeeRadGridView.Name = "employeeRadGridView";
            this.employeeRadGridView.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.employeeRadGridView.Size = new System.Drawing.Size(1124, 335);
            this.employeeRadGridView.TabIndex = 3;
            this.employeeRadGridView.Text = "radGridView1";
            this.employeeRadGridView.ThemeName = "VisualStudio2012Light";
            // 
            // employeecontextMenuStrip
            // 
            this.employeecontextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnNew,
            this.btnSave,
            this.btrEdit,
            this.btnDel});
            this.employeecontextMenuStrip.Name = "employeecontextMenuStrip";
            this.employeecontextMenuStrip.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.employeecontextMenuStrip.Size = new System.Drawing.Size(154, 114);
            // 
            // btnNew
            // 
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(153, 22);
            this.btnNew.Text = "جديد     Ctrl+N";
            // 
            // btnSave
            // 
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(153, 22);
            this.btnSave.Text = "حفظ     Ctrl+S";
            // 
            // btrEdit
            // 
            this.btrEdit.Name = "btrEdit";
            this.btrEdit.Size = new System.Drawing.Size(153, 22);
            this.btrEdit.Text = "تعديل     Ctrl+U";
            // 
            // btnDel
            // 
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(153, 22);
            this.btnDel.Text = "حذف     Ctrl+D";
            // 
            // frmEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1124, 559);
            this.ContextMenuStrip = this.employeecontextMenuStrip;
            this.Controls.Add(this.employeeRadGridView);
            this.Controls.Add(this.radCollapsiblePanel1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmEmployee";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Text = "frmEmployee";
            ((System.ComponentModel.ISupportInitialize)(this.userSystemBindingSource)).EndInit();
            this.radCollapsiblePanel1.PanelContainer.ResumeLayout(false);
            this.radCollapsiblePanel1.PanelContainer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radCollapsiblePanel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeRadGridView.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeRadGridView)).EndInit();
            this.employeecontextMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource userSystemBindingSource;
        private Telerik.WinControls.Themes.VisualStudio2012LightTheme visualStudio2012LightTheme1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private Telerik.WinControls.UI.RadCollapsiblePanel radCollapsiblePanel1;
        private System.Windows.Forms.TextBox iDTextBox;
        private System.Windows.Forms.BindingSource employeeBindingSource;
        private System.Windows.Forms.TextBox employeeNameTextBox;
        private System.Windows.Forms.ComboBox employeeGenderComboBox;
        private System.Windows.Forms.TextBox employeejobNumberTextBox;
        private System.Windows.Forms.TextBox mobilenumberTextBox;
        private System.Windows.Forms.TextBox phoneNumberTextBox;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.TextBox employeeNationalNumberTextBox;
        private Telerik.WinControls.UI.RadGridView employeeRadGridView;
        private System.Windows.Forms.ContextMenuStrip employeecontextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem btnNew;
        private System.Windows.Forms.ToolStripMenuItem btnSave;
        private System.Windows.Forms.ToolStripMenuItem btrEdit;
        private System.Windows.Forms.ToolStripMenuItem btnDel;
    }
}