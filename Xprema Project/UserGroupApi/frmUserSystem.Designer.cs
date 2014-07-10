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
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn7 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn22 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn23 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn24 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn25 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn8 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn26 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn27 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn28 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.Data.SortDescriptor sortDescriptor4 = new Telerik.WinControls.Data.SortDescriptor();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.radCollapsiblePanel1 = new Telerik.WinControls.UI.RadCollapsiblePanel();
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
            this.userSystemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            idLabel = new System.Windows.Forms.Label();
            passwordLabel = new System.Windows.Forms.Label();
            userGroupLabel = new System.Windows.Forms.Label();
            userNameLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.radCollapsiblePanel1)).BeginInit();
            this.radCollapsiblePanel1.PanelContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userGroupRadMultiColumnComboBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userGroupRadMultiColumnComboBox.EditorControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userGroupRadMultiColumnComboBox.EditorControl.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userGroupBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userSystemRadGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userSystemRadGridView.MasterTemplate)).BeginInit();
            this.SysUsercontextMenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userSystemBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // idLabel
            // 
            idLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            idLabel.AutoSize = true;
            idLabel.Location = new System.Drawing.Point(819, 19);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(70, 13);
            idLabel.TabIndex = 800;
            idLabel.Text = "رقم المستخدم";
            // 
            // passwordLabel
            // 
            passwordLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            passwordLabel.AutoSize = true;
            passwordLabel.Location = new System.Drawing.Point(338, 22);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new System.Drawing.Size(60, 13);
            passwordLabel.TabIndex = 800;
            passwordLabel.Text = "كلمة المرور";
            // 
            // userGroupLabel
            // 
            userGroupLabel.AutoSize = true;
            userGroupLabel.Location = new System.Drawing.Point(338, 49);
            userGroupLabel.Name = "userGroupLabel";
            userGroupLabel.Size = new System.Drawing.Size(85, 13);
            userGroupLabel.TabIndex = 800;
            userGroupLabel.Text = "التبعية/المجموعة";
            // 
            // userNameLabel
            // 
            userNameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            userNameLabel.AutoSize = true;
            userNameLabel.Location = new System.Drawing.Point(819, 45);
            userNameLabel.Name = "userNameLabel";
            userNameLabel.Size = new System.Drawing.Size(72, 13);
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
            this.statusStrip1.Location = new System.Drawing.Point(0, 423);
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
            // idTextBox
            // 
            this.idTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.idTextBox.Location = new System.Drawing.Point(626, 16);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.ReadOnly = true;
            this.idTextBox.Size = new System.Drawing.Size(187, 20);
            this.idTextBox.TabIndex = 800;
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.passwordTextBox.Location = new System.Drawing.Point(145, 19);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(187, 20);
            this.passwordTextBox.TabIndex = 2;
            // 
            // userGroupRadMultiColumnComboBox
            // 
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
            gridViewDecimalColumn7.DataType = typeof(int);
            gridViewDecimalColumn7.EnableExpressionEditor = false;
            gridViewDecimalColumn7.FieldName = "Id";
            gridViewDecimalColumn7.HeaderText = "Id";
            gridViewDecimalColumn7.IsAutoGenerated = true;
            gridViewDecimalColumn7.IsVisible = false;
            gridViewDecimalColumn7.Name = "Id";
            gridViewTextBoxColumn22.EnableExpressionEditor = false;
            gridViewTextBoxColumn22.FieldName = "GroupName";
            gridViewTextBoxColumn22.HeaderText = "اسم المجموعة";
            gridViewTextBoxColumn22.IsAutoGenerated = true;
            gridViewTextBoxColumn22.Name = "GroupName";
            gridViewTextBoxColumn22.Width = 131;
            gridViewTextBoxColumn23.EnableExpressionEditor = false;
            gridViewTextBoxColumn23.FieldName = "GroupDescription";
            gridViewTextBoxColumn23.HeaderText = "الوصف";
            gridViewTextBoxColumn23.IsAutoGenerated = true;
            gridViewTextBoxColumn23.Name = "GroupDescription";
            gridViewTextBoxColumn23.Width = 190;
            gridViewTextBoxColumn24.DataType = typeof(System.Collections.Generic.ICollection<Xprema.Data.UserSystem>);
            gridViewTextBoxColumn24.EnableExpressionEditor = false;
            gridViewTextBoxColumn24.FieldName = "UserSystems";
            gridViewTextBoxColumn24.HeaderText = "UserSystems";
            gridViewTextBoxColumn24.IsAutoGenerated = true;
            gridViewTextBoxColumn24.IsVisible = false;
            gridViewTextBoxColumn24.Name = "UserSystems";
            gridViewTextBoxColumn25.DataType = typeof(System.Collections.Generic.ICollection<Xprema.Data.GroupPermession>);
            gridViewTextBoxColumn25.EnableExpressionEditor = false;
            gridViewTextBoxColumn25.FieldName = "GroupPermessions";
            gridViewTextBoxColumn25.HeaderText = "GroupPermessions";
            gridViewTextBoxColumn25.IsAutoGenerated = true;
            gridViewTextBoxColumn25.IsVisible = false;
            gridViewTextBoxColumn25.Name = "GroupPermessions";
            this.userGroupRadMultiColumnComboBox.EditorControl.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewDecimalColumn7,
            gridViewTextBoxColumn22,
            gridViewTextBoxColumn23,
            gridViewTextBoxColumn24,
            gridViewTextBoxColumn25});
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
            gridViewDecimalColumn8.DataType = typeof(int);
            gridViewDecimalColumn8.EnableExpressionEditor = false;
            gridViewDecimalColumn8.FieldName = "Id";
            gridViewDecimalColumn8.HeaderText = "الرقم";
            gridViewDecimalColumn8.IsAutoGenerated = true;
            gridViewDecimalColumn8.Name = "Id";
            gridViewDecimalColumn8.Width = 225;
            gridViewTextBoxColumn26.EnableExpressionEditor = false;
            gridViewTextBoxColumn26.FieldName = "UserName";
            gridViewTextBoxColumn26.HeaderText = "اسم المستخدم";
            gridViewTextBoxColumn26.IsAutoGenerated = true;
            gridViewTextBoxColumn26.Name = "UserName";
            gridViewTextBoxColumn26.Width = 225;
            gridViewTextBoxColumn27.EnableExpressionEditor = false;
            gridViewTextBoxColumn27.FieldName = "Password";
            gridViewTextBoxColumn27.HeaderText = "كلمة المرور";
            gridViewTextBoxColumn27.IsAutoGenerated = true;
            gridViewTextBoxColumn27.Name = "Password";
            gridViewTextBoxColumn27.SortOrder = Telerik.WinControls.UI.RadSortOrder.Ascending;
            gridViewTextBoxColumn27.Width = 225;
            gridViewTextBoxColumn28.EnableExpressionEditor = false;
            gridViewTextBoxColumn28.FieldName = "UserGroup.GroupName";
            gridViewTextBoxColumn28.HeaderText = "المجموعة/التبعية";
            gridViewTextBoxColumn28.IsAutoGenerated = true;
            gridViewTextBoxColumn28.Name = "UserGroup";
            gridViewTextBoxColumn28.Width = 228;
            this.userSystemRadGridView.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewDecimalColumn8,
            gridViewTextBoxColumn26,
            gridViewTextBoxColumn27,
            gridViewTextBoxColumn28});
            this.userSystemRadGridView.MasterTemplate.DataSource = this.userSystemBindingSource;
            sortDescriptor4.PropertyName = "Password";
            this.userSystemRadGridView.MasterTemplate.SortDescriptors.AddRange(new Telerik.WinControls.Data.SortDescriptor[] {
            sortDescriptor4});
            this.userSystemRadGridView.Name = "userSystemRadGridView";
            this.userSystemRadGridView.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.userSystemRadGridView.Size = new System.Drawing.Size(918, 256);
            this.userSystemRadGridView.TabIndex = 3;
            this.userSystemRadGridView.Text = "radGridView1";
            this.userSystemRadGridView.ThemeName = "VisualStudio2012Light";
            this.userSystemRadGridView.CurrentRowChanged += new Telerik.WinControls.UI.CurrentRowChangedEventHandler(this.userSystemRadGridView_CurrentRowChanged);
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
            this.SysUsercontextMenuStrip.Size = new System.Drawing.Size(154, 92);
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
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(153, 22);
            this.btnSave.Text = "حفظ     Ctrl+S";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // BtnEdit
            // 
            this.BtnEdit.Name = "BtnEdit";
            this.BtnEdit.Size = new System.Drawing.Size(153, 22);
            this.BtnEdit.Text = "تعديل     Ctrl+U";
            this.BtnEdit.Click += new System.EventHandler(this.BtnEdit_Click);
            // 
            // BtnDel
            // 
            this.BtnDel.Name = "BtnDel";
            this.BtnDel.Size = new System.Drawing.Size(153, 22);
            this.BtnDel.Text = "حذف     Ctrl+D";
            this.BtnDel.Click += new System.EventHandler(this.BtnDel_Click);
            // 
            // userSystemBindingSource
            // 
            this.userSystemBindingSource.DataSource = typeof(Xprema.Data.UserSystem);
            // 
            // frmUserSystem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(918, 445);
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
            ((System.ComponentModel.ISupportInitialize)(this.userGroupRadMultiColumnComboBox.EditorControl.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userGroupRadMultiColumnComboBox.EditorControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userGroupRadMultiColumnComboBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userGroupBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userSystemRadGridView.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userSystemRadGridView)).EndInit();
            this.SysUsercontextMenuStrip.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.userSystemBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private Telerik.WinControls.UI.RadCollapsiblePanel radCollapsiblePanel1;
        private System.Windows.Forms.TextBox idTextBox;
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
        private System.Windows.Forms.BindingSource userSystemBindingSource;

    }
}