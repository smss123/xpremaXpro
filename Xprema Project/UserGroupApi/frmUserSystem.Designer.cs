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
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn11 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn41 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn42 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn43 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn44 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn12 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn45 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn46 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn47 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn48 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.radCollapsiblePanel1 = new Telerik.WinControls.UI.RadCollapsiblePanel();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.userSystemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.userGroupRadMultiColumnComboBox = new Telerik.WinControls.UI.RadMultiColumnComboBox();
            this.userGroupBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.userNameTextBox = new System.Windows.Forms.TextBox();
            this.userSystemRadGridView = new Telerik.WinControls.UI.RadGridView();
            this.visualStudio2012LightTheme1 = new Telerik.WinControls.Themes.VisualStudio2012LightTheme();
            this.SysUsercontextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.جديدCtrlNToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.حفظCtrlSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.تعديلCtrlUToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.حذفCtrlDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            idLabel.Size = new System.Drawing.Size(20, 13);
            idLabel.TabIndex = 1;
            idLabel.Text = "Id:";
            // 
            // passwordLabel
            // 
            passwordLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            passwordLabel.AutoSize = true;
            passwordLabel.Location = new System.Drawing.Point(810, 57);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new System.Drawing.Size(59, 13);
            passwordLabel.TabIndex = 1;
            passwordLabel.Text = "Password:";
            // 
            // userGroupLabel
            // 
            userGroupLabel.AutoSize = true;
            userGroupLabel.Location = new System.Drawing.Point(806, 128);
            userGroupLabel.Name = "userGroupLabel";
            userGroupLabel.Size = new System.Drawing.Size(69, 13);
            userGroupLabel.TabIndex = 1;
            userGroupLabel.Text = "User Group:";
            // 
            // userNameLabel
            // 
            userNameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            userNameLabel.AutoSize = true;
            userNameLabel.Location = new System.Drawing.Point(810, 92);
            userNameLabel.Name = "userNameLabel";
            userNameLabel.Size = new System.Drawing.Size(65, 13);
            userNameLabel.TabIndex = 1;
            userNameLabel.Text = "User Name:";
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
            this.statusStrip1.Location = new System.Drawing.Point(0, 589);
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
            this.radCollapsiblePanel1.PanelContainer.Size = new System.Drawing.Size(916, 190);
            this.radCollapsiblePanel1.Size = new System.Drawing.Size(918, 220);
            this.radCollapsiblePanel1.TabIndex = 2;
            this.radCollapsiblePanel1.Text = "radCollapsiblePanel1";
            this.radCollapsiblePanel1.ThemeName = "VisualStudio2012Light";
            // 
            // idTextBox
            // 
            this.idTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userSystemBindingSource, "Id", true));
            this.idTextBox.Location = new System.Drawing.Point(626, 16);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(187, 20);
            this.idTextBox.TabIndex = 2;
            // 
            // userSystemBindingSource
            // 
            this.userSystemBindingSource.DataSource = typeof(Xprema.Data.UserSystem);
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.passwordTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userSystemBindingSource, "Password", true));
            this.passwordTextBox.Location = new System.Drawing.Point(626, 57);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(178, 20);
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
            gridViewDecimalColumn11.DataType = typeof(int);
            gridViewDecimalColumn11.EnableExpressionEditor = false;
            gridViewDecimalColumn11.FieldName = "Id";
            gridViewDecimalColumn11.HeaderText = "Id";
            gridViewDecimalColumn11.IsAutoGenerated = true;
            gridViewDecimalColumn11.Name = "Id";
            gridViewTextBoxColumn41.EnableExpressionEditor = false;
            gridViewTextBoxColumn41.FieldName = "GroupName";
            gridViewTextBoxColumn41.HeaderText = "GroupName";
            gridViewTextBoxColumn41.IsAutoGenerated = true;
            gridViewTextBoxColumn41.Name = "GroupName";
            gridViewTextBoxColumn42.EnableExpressionEditor = false;
            gridViewTextBoxColumn42.FieldName = "GroupDescription";
            gridViewTextBoxColumn42.HeaderText = "GroupDescription";
            gridViewTextBoxColumn42.IsAutoGenerated = true;
            gridViewTextBoxColumn42.Name = "GroupDescription";
            gridViewTextBoxColumn43.DataType = typeof(System.Collections.Generic.ICollection<Xprema.Data.UserSystem>);
            gridViewTextBoxColumn43.EnableExpressionEditor = false;
            gridViewTextBoxColumn43.FieldName = "UserSystems";
            gridViewTextBoxColumn43.HeaderText = "UserSystems";
            gridViewTextBoxColumn43.IsAutoGenerated = true;
            gridViewTextBoxColumn43.IsVisible = false;
            gridViewTextBoxColumn43.Name = "UserSystems";
            gridViewTextBoxColumn44.DataType = typeof(System.Collections.Generic.ICollection<Xprema.Data.GroupPermession>);
            gridViewTextBoxColumn44.EnableExpressionEditor = false;
            gridViewTextBoxColumn44.FieldName = "GroupPermessions";
            gridViewTextBoxColumn44.HeaderText = "GroupPermessions";
            gridViewTextBoxColumn44.IsAutoGenerated = true;
            gridViewTextBoxColumn44.IsVisible = false;
            gridViewTextBoxColumn44.Name = "GroupPermessions";
            this.userGroupRadMultiColumnComboBox.EditorControl.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewDecimalColumn11,
            gridViewTextBoxColumn41,
            gridViewTextBoxColumn42,
            gridViewTextBoxColumn43,
            gridViewTextBoxColumn44});
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
            this.userGroupRadMultiColumnComboBox.Location = new System.Drawing.Point(511, 128);
            this.userGroupRadMultiColumnComboBox.Name = "userGroupRadMultiColumnComboBox";
            this.userGroupRadMultiColumnComboBox.Size = new System.Drawing.Size(289, 20);
            this.userGroupRadMultiColumnComboBox.TabIndex = 2;
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
            this.userNameTextBox.Location = new System.Drawing.Point(626, 89);
            this.userNameTextBox.Name = "userNameTextBox";
            this.userNameTextBox.Size = new System.Drawing.Size(178, 20);
            this.userNameTextBox.TabIndex = 2;
            // 
            // userSystemRadGridView
            // 
            this.userSystemRadGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userSystemRadGridView.Location = new System.Drawing.Point(0, 244);
            // 
            // userSystemRadGridView
            // 
            this.userSystemRadGridView.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            gridViewDecimalColumn12.DataType = typeof(int);
            gridViewDecimalColumn12.FieldName = "Id";
            gridViewDecimalColumn12.HeaderText = "Id";
            gridViewDecimalColumn12.IsAutoGenerated = true;
            gridViewDecimalColumn12.Name = "Id";
            gridViewDecimalColumn12.Width = 181;
            gridViewTextBoxColumn45.FieldName = "UserName";
            gridViewTextBoxColumn45.HeaderText = "UserName";
            gridViewTextBoxColumn45.IsAutoGenerated = true;
            gridViewTextBoxColumn45.Name = "UserName";
            gridViewTextBoxColumn45.Width = 181;
            gridViewTextBoxColumn46.FieldName = "Password";
            gridViewTextBoxColumn46.HeaderText = "Password";
            gridViewTextBoxColumn46.IsAutoGenerated = true;
            gridViewTextBoxColumn46.Name = "Password";
            gridViewTextBoxColumn46.Width = 181;
            gridViewTextBoxColumn47.DataType = typeof(Xprema.Data.UserGroup);
            gridViewTextBoxColumn47.FieldName = "UserGroup";
            gridViewTextBoxColumn47.HeaderText = "UserGroup";
            gridViewTextBoxColumn47.IsAutoGenerated = true;
            gridViewTextBoxColumn47.Name = "UserGroup";
            gridViewTextBoxColumn47.Width = 181;
            gridViewTextBoxColumn48.DataType = typeof(System.Collections.Generic.ICollection<Xprema.Data.Contract>);
            gridViewTextBoxColumn48.FieldName = "Contracts";
            gridViewTextBoxColumn48.HeaderText = "Contracts";
            gridViewTextBoxColumn48.IsAutoGenerated = true;
            gridViewTextBoxColumn48.Name = "Contracts";
            gridViewTextBoxColumn48.Width = 180;
            this.userSystemRadGridView.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewDecimalColumn12,
            gridViewTextBoxColumn45,
            gridViewTextBoxColumn46,
            gridViewTextBoxColumn47,
            gridViewTextBoxColumn48});
            this.userSystemRadGridView.MasterTemplate.DataSource = this.userSystemBindingSource;
            this.userSystemRadGridView.Name = "userSystemRadGridView";
            this.userSystemRadGridView.Size = new System.Drawing.Size(918, 345);
            this.userSystemRadGridView.TabIndex = 3;
            this.userSystemRadGridView.Text = "radGridView1";
            this.userSystemRadGridView.ThemeName = "VisualStudio2012Light";
            // 
            // SysUsercontextMenuStrip
            // 
            this.SysUsercontextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.جديدCtrlNToolStripMenuItem,
            this.حفظCtrlSToolStripMenuItem,
            this.تعديلCtrlUToolStripMenuItem,
            this.حذفCtrlDToolStripMenuItem});
            this.SysUsercontextMenuStrip.Name = "SysUsercontextMenuStrip";
            this.SysUsercontextMenuStrip.Size = new System.Drawing.Size(154, 92);
            // 
            // جديدCtrlNToolStripMenuItem
            // 
            this.جديدCtrlNToolStripMenuItem.Name = "جديدCtrlNToolStripMenuItem";
            this.جديدCtrlNToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.جديدCtrlNToolStripMenuItem.Text = "جديد     Ctrl+N";
            // 
            // حفظCtrlSToolStripMenuItem
            // 
            this.حفظCtrlSToolStripMenuItem.Name = "حفظCtrlSToolStripMenuItem";
            this.حفظCtrlSToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.حفظCtrlSToolStripMenuItem.Text = "حفظ     Ctrl+S";
            // 
            // تعديلCtrlUToolStripMenuItem
            // 
            this.تعديلCtrlUToolStripMenuItem.Name = "تعديلCtrlUToolStripMenuItem";
            this.تعديلCtrlUToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.تعديلCtrlUToolStripMenuItem.Text = "تعديل     Ctrl+U";
            // 
            // حذفCtrlDToolStripMenuItem
            // 
            this.حذفCtrlDToolStripMenuItem.Name = "حذفCtrlDToolStripMenuItem";
            this.حذفCtrlDToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.حذفCtrlDToolStripMenuItem.Text = "حذف     Ctrl+D";
            // 
            // frmUserSystem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(918, 611);
            this.ContextMenuStrip = this.SysUsercontextMenuStrip;
            this.Controls.Add(this.userSystemRadGridView);
            this.Controls.Add(this.radCollapsiblePanel1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmUserSystem";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Text = "frmUserSystem";
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
        private System.Windows.Forms.ToolStripMenuItem جديدCtrlNToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem حفظCtrlSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem تعديلCtrlUToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem حذفCtrlDToolStripMenuItem;

    }
}