namespace Xprema_Project.UserGroupApi
{
    partial class frmUserSystem
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
            System.Windows.Forms.Label idLabel;
            System.Windows.Forms.Label passwordLabel;
            System.Windows.Forms.Label userGroupLabel;
            System.Windows.Forms.Label userNameLabel;
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn1 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn1 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn2 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn3 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn4 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn2 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn5 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn6 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn7 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.Data.SortDescriptor sortDescriptor1 = new Telerik.WinControls.Data.SortDescriptor();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.radCollapsiblePanel1 = new Telerik.WinControls.UI.RadCollapsiblePanel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.userSystemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.userGroupRadMultiColumnComboBox = new Telerik.WinControls.UI.RadMultiColumnComboBox();
            this.userGroupBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.userNameTextBox = new System.Windows.Forms.TextBox();
            this.userSystemRadGridView = new Telerik.WinControls.UI.RadGridView();
            this.visualStudio2012LightTheme1 = new Telerik.WinControls.Themes.VisualStudio2012LightTheme();
            this.SysUsercontextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btnNew = new System.Windows.Forms.ToolStripMenuItem();
            this.btnSave = new System.Windows.Forms.ToolStripMenuItem();
            this.BtnEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.BtnDel = new System.Windows.Forms.ToolStripMenuItem();
            idLabel = new System.Windows.Forms.Label();
            passwordLabel = new System.Windows.Forms.Label();
            userGroupLabel = new System.Windows.Forms.Label();
            userNameLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.radCollapsiblePanel1)).BeginInit();
            this.radCollapsiblePanel1.PanelContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userSystemBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userGroupRadMultiColumnComboBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userGroupRadMultiColumnComboBox.EditorControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userGroupRadMultiColumnComboBox.EditorControl.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userGroupBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userSystemRadGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userSystemRadGridView.MasterTemplate)).BeginInit();
            this.SysUsercontextMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // idLabel
            // 
            idLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            idLabel.AutoSize = true;
            idLabel.Location = new System.Drawing.Point(819, 19);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(55, 13);
            idLabel.TabIndex = 800;
            idLabel.Text = "رقم المستخدم";
            // 
            // passwordLabel
            // 
            passwordLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            passwordLabel.AutoSize = true;
            passwordLabel.Location = new System.Drawing.Point(338, 22);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new System.Drawing.Size(48, 13);
            passwordLabel.TabIndex = 800;
            passwordLabel.Text = "كلمة المرور";
            // 
            // userGroupLabel
            // 
            userGroupLabel.AutoSize = true;
            userGroupLabel.Location = new System.Drawing.Point(338, 49);
            userGroupLabel.Name = "userGroupLabel";
            userGroupLabel.Size = new System.Drawing.Size(67, 13);
            userGroupLabel.TabIndex = 800;
            userGroupLabel.Text = "التبعية/المجموعة";
            // 
            // userNameLabel
            // 
            userNameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            userNameLabel.AutoSize = true;
            userNameLabel.Location = new System.Drawing.Point(819, 45);
            userNameLabel.Name = "userNameLabel";
            userNameLabel.Size = new System.Drawing.Size(57, 13);
            userNameLabel.TabIndex = 800;
            userNameLabel.Text = "اسم المستخدم";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(918, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 424);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(918, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // radCollapsiblePanel1
            // 
            this.radCollapsiblePanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.radCollapsiblePanel1.Location = new System.Drawing.Point(0, 24);
            this.radCollapsiblePanel1.Name = "radCollapsiblePanel1";
            this.radCollapsiblePanel1.OwnerBoundsCache = new System.Drawing.Rectangle(0, 24, 838, 200);
            // 
            // radCollapsiblePanel1.PanelContainer
            // 
            this.radCollapsiblePanel1.PanelContainer.Controls.Add(this.textBox1);
            this.radCollapsiblePanel1.PanelContainer.Controls.Add(idLabel);
            this.radCollapsiblePanel1.PanelContainer.Controls.Add(this.idTextBox);
            this.radCollapsiblePanel1.PanelContainer.Controls.Add(passwordLabel);
            this.radCollapsiblePanel1.PanelContainer.Controls.Add(this.passwordTextBox);
            this.radCollapsiblePanel1.PanelContainer.Controls.Add(userGroupLabel);
            this.radCollapsiblePanel1.PanelContainer.Controls.Add(this.userGroupRadMultiColumnComboBox);
            this.radCollapsiblePanel1.PanelContainer.Controls.Add(userNameLabel);
            this.radCollapsiblePanel1.PanelContainer.Controls.Add(this.userNameTextBox);
            this.radCollapsiblePanel1.PanelContainer.Dock = System.Windows.Forms.DockStyle.Right;
            this.radCollapsiblePanel1.PanelContainer.Size = new System.Drawing.Size(916, 113);
            this.radCollapsiblePanel1.Size = new System.Drawing.Size(918, 143);
            this.radCollapsiblePanel1.TabIndex = 2;
            this.radCollapsiblePanel1.Text = "radCollapsiblePanel1";
            this.radCollapsiblePanel1.ThemeName = "VisualStudio2012Light";
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userSystemBindingSource, "UserName", true));
            this.textBox1.Location = new System.Drawing.Point(145, 71);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(187, 20);
            this.textBox1.TabIndex = 801;
            // 
            // userSystemBindingSource
            // 
            this.userSystemBindingSource.DataSource = typeof(Xprema.Data.UserSystem);
            // 
            // idTextBox
            // 
            this.idTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userSystemBindingSource, "Id", true));
            this.idTextBox.Location = new System.Drawing.Point(626, 16);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.ReadOnly = true;
            this.idTextBox.Size = new System.Drawing.Size(187, 20);
            this.idTextBox.TabIndex = 800;
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.passwordTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userSystemBindingSource, "Password", true));
            this.passwordTextBox.Location = new System.Drawing.Point(145, 19);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(187, 20);
            this.passwordTextBox.TabIndex = 2;
            // 
            // userGroupRadMultiColumnComboBox
            // 
            this.userGroupRadMultiColumnComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userSystemBindingSource, "UserGroup", true));
            this.userGroupRadMultiColumnComboBox.DataSource = this.userGroupBindingSource;
            // 
            // userGroupRadMultiColumnComboBox.NestedRadGridView
            // 
            this.userGroupRadMultiColumnComboBox.EditorControl.BackColor = System.Drawing.SystemColors.Window;
            this.userGroupRadMultiColumnComboBox.EditorControl.Cursor = System.Windows.Forms.Cursors.Default;
            this.userGroupRadMultiColumnComboBox.EditorControl.Font = new System.Drawing.Font("Tahoma", 8F);
            this.userGroupRadMultiColumnComboBox.EditorControl.ForeColor = System.Drawing.SystemColors.ControlText;
            this.userGroupRadMultiColumnComboBox.EditorControl.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.userGroupRadMultiColumnComboBox.EditorControl.Location = new System.Drawing.Point(0, 0);
            // 
            // 
            // 
            this.userGroupRadMultiColumnComboBox.EditorControl.MasterTemplate.AllowAddNewRow = false;
            this.userGroupRadMultiColumnComboBox.EditorControl.MasterTemplate.AllowCellContextMenu = false;
            this.userGroupRadMultiColumnComboBox.EditorControl.MasterTemplate.AllowColumnChooser = false;
            gridViewDecimalColumn1.DataType = typeof(int);
            gridViewDecimalColumn1.EnableExpressionEditor = false;
            gridViewDecimalColumn1.FieldName = "Id";
            gridViewDecimalColumn1.HeaderText = "Id";
            gridViewDecimalColumn1.IsAutoGenerated = true;
            gridViewDecimalColumn1.Name = "Id";
            gridViewTextBoxColumn1.EnableExpressionEditor = false;
            gridViewTextBoxColumn1.FieldName = "GroupName";
            gridViewTextBoxColumn1.HeaderText = "GroupName";
            gridViewTextBoxColumn1.IsAutoGenerated = true;
            gridViewTextBoxColumn1.Name = "GroupName";
            gridViewTextBoxColumn2.EnableExpressionEditor = false;
            gridViewTextBoxColumn2.FieldName = "GroupDescription";
            gridViewTextBoxColumn2.HeaderText = "GroupDescription";
            gridViewTextBoxColumn2.IsAutoGenerated = true;
            gridViewTextBoxColumn2.Name = "GroupDescription";
            gridViewTextBoxColumn3.DataType = typeof(System.Collections.Generic.ICollection<Xprema.Data.UserSystem>);
            gridViewTextBoxColumn3.EnableExpressionEditor = false;
            gridViewTextBoxColumn3.FieldName = "UserSystems";
            gridViewTextBoxColumn3.HeaderText = "UserSystems";
            gridViewTextBoxColumn3.IsAutoGenerated = true;
            gridViewTextBoxColumn3.IsVisible = false;
            gridViewTextBoxColumn3.Name = "UserSystems";
            gridViewTextBoxColumn4.DataType = typeof(System.Collections.Generic.ICollection<Xprema.Data.GroupPermession>);
            gridViewTextBoxColumn4.EnableExpressionEditor = false;
            gridViewTextBoxColumn4.FieldName = "GroupPermessions";
            gridViewTextBoxColumn4.HeaderText = "GroupPermessions";
            gridViewTextBoxColumn4.IsAutoGenerated = true;
            gridViewTextBoxColumn4.IsVisible = false;
            gridViewTextBoxColumn4.Name = "GroupPermessions";
            this.userGroupRadMultiColumnComboBox.EditorControl.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewDecimalColumn1,
            gridViewTextBoxColumn1,
            gridViewTextBoxColumn2,
            gridViewTextBoxColumn3,
            gridViewTextBoxColumn4});
            this.userGroupRadMultiColumnComboBox.EditorControl.MasterTemplate.DataSource = this.userGroupBindingSource;
            this.userGroupRadMultiColumnComboBox.EditorControl.MasterTemplate.EnableFiltering = true;
            this.userGroupRadMultiColumnComboBox.EditorControl.MasterTemplate.EnableGrouping = false;
            this.userGroupRadMultiColumnComboBox.EditorControl.MasterTemplate.ShowFilteringRow = false;
            this.userGroupRadMultiColumnComboBox.EditorControl.Name = "NestedRadGridView";
            this.userGroupRadMultiColumnComboBox.EditorControl.ReadOnly = true;
            this.userGroupRadMultiColumnComboBox.EditorControl.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.userGroupRadMultiColumnComboBox.EditorControl.ShowGroupPanel = false;
            this.userGroupRadMultiColumnComboBox.EditorControl.Size = new System.Drawing.Size(240, 150);
            this.userGroupRadMultiColumnComboBox.EditorControl.TabIndex = 0;
            this.userGroupRadMultiColumnComboBox.Location = new System.Drawing.Point(145, 45);
            this.userGroupRadMultiColumnComboBox.Name = "userGroupRadMultiColumnComboBox";
            this.userGroupRadMultiColumnComboBox.Size = new System.Drawing.Size(187, 20);
            this.userGroupRadMultiColumnComboBox.TabIndex = 3;
            this.userGroupRadMultiColumnComboBox.TabStop = false;
            this.userGroupRadMultiColumnComboBox.ThemeName = "VisualStudio2012Light";
            // 
            // userGroupBindingSource
            // 
            this.userGroupBindingSource.DataSource = typeof(Xprema.Data.UserGroup);
            // 
            // userNameTextBox
            // 
            this.userNameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.userNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userSystemBindingSource, "UserName", true));
            this.userNameTextBox.Location = new System.Drawing.Point(626, 42);
            this.userNameTextBox.Name = "userNameTextBox";
            this.userNameTextBox.Size = new System.Drawing.Size(187, 20);
            this.userNameTextBox.TabIndex = 1;
            // 
            // userSystemRadGridView
            // 
            this.userSystemRadGridView.BackColor = System.Drawing.SystemColors.Control;
            this.userSystemRadGridView.Cursor = System.Windows.Forms.Cursors.Default;
            this.userSystemRadGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userSystemRadGridView.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.userSystemRadGridView.ForeColor = System.Drawing.SystemColors.ControlText;
            this.userSystemRadGridView.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.userSystemRadGridView.Location = new System.Drawing.Point(0, 167);
            // 
            // userSystemRadGridView
            // 
            this.userSystemRadGridView.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            gridViewDecimalColumn2.DataType = typeof(int);
            gridViewDecimalColumn2.EnableExpressionEditor = false;
            gridViewDecimalColumn2.FieldName = "Id";
            gridViewDecimalColumn2.HeaderText = "رقم المستخدم";
            gridViewDecimalColumn2.IsAutoGenerated = true;
            gridViewDecimalColumn2.Name = "Id";
            gridViewDecimalColumn2.ReadOnly = true;
            gridViewDecimalColumn2.SortOrder = Telerik.WinControls.UI.RadSortOrder.Descending;
            gridViewDecimalColumn2.Width = 84;
            gridViewTextBoxColumn5.EnableExpressionEditor = false;
            gridViewTextBoxColumn5.FieldName = "UserName";
            gridViewTextBoxColumn5.HeaderText = "اسم المستخدم";
            gridViewTextBoxColumn5.IsAutoGenerated = true;
            gridViewTextBoxColumn5.Name = "UserName";
            gridViewTextBoxColumn5.Width = 281;
            gridViewTextBoxColumn6.EnableExpressionEditor = false;
            gridViewTextBoxColumn6.FieldName = "Password";
            gridViewTextBoxColumn6.HeaderText = "كلمة المرور";
            gridViewTextBoxColumn6.IsAutoGenerated = true;
            gridViewTextBoxColumn6.Name = "Password";
            gridViewTextBoxColumn6.Width = 251;
            gridViewTextBoxColumn7.EnableExpressionEditor = false;
            gridViewTextBoxColumn7.FieldName = "UserGroup.GroupName";
            gridViewTextBoxColumn7.HeaderText = "التبعيه/المجموعه";
            gridViewTextBoxColumn7.IsAutoGenerated = true;
            gridViewTextBoxColumn7.Name = "UserGroup";
            gridViewTextBoxColumn7.Width = 287;
            this.userSystemRadGridView.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewDecimalColumn2,
            gridViewTextBoxColumn5,
            gridViewTextBoxColumn6,
            gridViewTextBoxColumn7});
            this.userSystemRadGridView.MasterTemplate.DataSource = this.userSystemBindingSource;
            sortDescriptor1.Direction = System.ComponentModel.ListSortDirection.Descending;
            sortDescriptor1.PropertyName = "Id";
            this.userSystemRadGridView.MasterTemplate.SortDescriptors.AddRange(new Telerik.WinControls.Data.SortDescriptor[] {
            sortDescriptor1});
            this.userSystemRadGridView.Name = "userSystemRadGridView";
            this.userSystemRadGridView.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.userSystemRadGridView.Size = new System.Drawing.Size(918, 257);
            this.userSystemRadGridView.TabIndex = 3;
            this.userSystemRadGridView.Text = "radGridView1";
            this.userSystemRadGridView.ThemeName = "VisualStudio2012Light";
            // 
            // SysUsercontextMenuStrip
            // 
            this.SysUsercontextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnNew,
            this.btnSave,
            this.BtnEdit,
            this.BtnDel});
            this.SysUsercontextMenuStrip.Name = "SysUsercontextMenuStrip";
            this.SysUsercontextMenuStrip.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.SysUsercontextMenuStrip.Size = new System.Drawing.Size(150, 92);
            // 
            // btnNew
            // 
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(149, 22);
            this.btnNew.Text = "جديد     Ctrl+N";
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnSave
            // 
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(149, 22);
            this.btnSave.Text = "حفظ     Ctrl+S";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // BtnEdit
            // 
            this.BtnEdit.Name = "BtnEdit";
            this.BtnEdit.Size = new System.Drawing.Size(149, 22);
            this.BtnEdit.Text = "تعديل     Ctrl+U";
            this.BtnEdit.Click += new System.EventHandler(this.BtnEdit_Click);
            // 
            // BtnDel
            // 
            this.BtnDel.Name = "BtnDel";
            this.BtnDel.Size = new System.Drawing.Size(149, 22);
            this.BtnDel.Text = "حذف     Ctrl+D";
            this.BtnDel.Click += new System.EventHandler(this.BtnDel_Click);
            // 
            // frmUserSystem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(918, 446);
            this.ContextMenuStrip = this.SysUsercontextMenuStrip;
            this.Controls.Add(this.userSystemRadGridView);
            this.Controls.Add(this.radCollapsiblePanel1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximumSize = new System.Drawing.Size(934, 484);
            this.MinimumSize = new System.Drawing.Size(934, 484);
            this.Name = "frmUserSystem";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "المستخدمين";
            this.Load += new System.EventHandler(this.frmUserSystem_Load);
            this.radCollapsiblePanel1.PanelContainer.ResumeLayout(false);
            this.radCollapsiblePanel1.PanelContainer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radCollapsiblePanel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userSystemBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userGroupRadMultiColumnComboBox.EditorControl.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userGroupRadMultiColumnComboBox.EditorControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userGroupRadMultiColumnComboBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userGroupBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userSystemRadGridView.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userSystemRadGridView)).EndInit();
            this.SysUsercontextMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private Telerik.WinControls.UI.RadCollapsiblePanel radCollapsiblePanel1;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.BindingSource userSystemBindingSource;
        private System.Windows.Forms.TextBox passwordTextBox;
        private Telerik.WinControls.UI.RadMultiColumnComboBox userGroupRadMultiColumnComboBox;
        private System.Windows.Forms.BindingSource userGroupBindingSource;
        private System.Windows.Forms.TextBox userNameTextBox;
        private Telerik.WinControls.UI.RadGridView userSystemRadGridView;
        private Telerik.WinControls.Themes.VisualStudio2012LightTheme visualStudio2012LightTheme1;
        private System.Windows.Forms.ContextMenuStrip SysUsercontextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem btnNew;
        private System.Windows.Forms.ToolStripMenuItem btnSave;
        private System.Windows.Forms.ToolStripMenuItem BtnEdit;
        private System.Windows.Forms.ToolStripMenuItem BtnDel;
        private System.Windows.Forms.TextBox textBox1;

    }
}