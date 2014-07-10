namespace Xprema_Project.UserGroupApi
{
    partial class frmUserGroup
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
            System.Windows.Forms.Label groupDescriptionLabel;
            System.Windows.Forms.Label groupNameLabel;
            System.Windows.Forms.Label idLabel;
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn2 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn5 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn6 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn7 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn8 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.Data.SortDescriptor sortDescriptor2 = new Telerik.WinControls.Data.SortDescriptor();
            this.PermessioncheckedListBox = new System.Windows.Forms.CheckedListBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btnNew = new System.Windows.Forms.ToolStripMenuItem();
            this.btnSave = new System.Windows.Forms.ToolStripMenuItem();
            this.btnEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.btnDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.visualStudio2012LightTheme1 = new Telerik.WinControls.Themes.VisualStudio2012LightTheme();
            this.radCollapsiblePanel1 = new Telerik.WinControls.UI.RadCollapsiblePanel();
            this.groupDescriptionTextBox = new System.Windows.Forms.TextBox();
            this.groupNameTextBox = new System.Windows.Forms.TextBox();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.userGroupRadGridView = new Telerik.WinControls.UI.RadGridView();
            this.userGroupBindingSource = new System.Windows.Forms.BindingSource(this.components);
            groupDescriptionLabel = new System.Windows.Forms.Label();
            groupNameLabel = new System.Windows.Forms.Label();
            idLabel = new System.Windows.Forms.Label();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radCollapsiblePanel1)).BeginInit();
            this.radCollapsiblePanel1.PanelContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userGroupRadGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userGroupRadGridView.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userGroupBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupDescriptionLabel
            // 
            groupDescriptionLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            groupDescriptionLabel.AutoSize = true;
            groupDescriptionLabel.Location = new System.Drawing.Point(682, 87);
            groupDescriptionLabel.Name = "groupDescriptionLabel";
            groupDescriptionLabel.Size = new System.Drawing.Size(35, 13);
            groupDescriptionLabel.TabIndex = 1;
            groupDescriptionLabel.Text = "وصف";
            // 
            // groupNameLabel
            // 
            groupNameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            groupNameLabel.AutoSize = true;
            groupNameLabel.Location = new System.Drawing.Point(682, 61);
            groupNameLabel.Name = "groupNameLabel";
            groupNameLabel.Size = new System.Drawing.Size(71, 13);
            groupNameLabel.TabIndex = 3;
            groupNameLabel.Text = "اسم المجموعة";
            // 
            // idLabel
            // 
            idLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            idLabel.AutoSize = true;
            idLabel.Location = new System.Drawing.Point(682, 35);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(69, 13);
            idLabel.TabIndex = 5;
            idLabel.Text = "رقم المجموعة";
            // 
            // PermessioncheckedListBox
            // 
            this.PermessioncheckedListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PermessioncheckedListBox.FormattingEnabled = true;
            this.PermessioncheckedListBox.Location = new System.Drawing.Point(31, 32);
            this.PermessioncheckedListBox.Name = "PermessioncheckedListBox";
            this.PermessioncheckedListBox.Size = new System.Drawing.Size(367, 140);
            this.PermessioncheckedListBox.TabIndex = 3;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnNew,
            this.btnSave,
            this.btnEdit,
            this.btnDelete});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.contextMenuStrip1.Size = new System.Drawing.Size(154, 114);
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
            // menuStrip1
            // 
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(815, 24);
            this.menuStrip1.TabIndex = 10;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 579);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(815, 22);
            this.statusStrip1.TabIndex = 12;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // radCollapsiblePanel1
            // 
            this.radCollapsiblePanel1.Cursor = System.Windows.Forms.Cursors.Default;
            this.radCollapsiblePanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.radCollapsiblePanel1.Location = new System.Drawing.Point(0, 24);
            this.radCollapsiblePanel1.Name = "radCollapsiblePanel1";
            this.radCollapsiblePanel1.OwnerBoundsCache = new System.Drawing.Rectangle(0, 24, 795, 146);
            // 
            // radCollapsiblePanel1.PanelContainer
            // 
            this.radCollapsiblePanel1.PanelContainer.Controls.Add(this.PermessioncheckedListBox);
            this.radCollapsiblePanel1.PanelContainer.Controls.Add(groupDescriptionLabel);
            this.radCollapsiblePanel1.PanelContainer.Controls.Add(this.groupDescriptionTextBox);
            this.radCollapsiblePanel1.PanelContainer.Controls.Add(groupNameLabel);
            this.radCollapsiblePanel1.PanelContainer.Controls.Add(this.groupNameTextBox);
            this.radCollapsiblePanel1.PanelContainer.Controls.Add(idLabel);
            this.radCollapsiblePanel1.PanelContainer.Controls.Add(this.idTextBox);
            this.radCollapsiblePanel1.PanelContainer.Dock = System.Windows.Forms.DockStyle.Right;
            this.radCollapsiblePanel1.PanelContainer.Size = new System.Drawing.Size(813, 211);
            this.radCollapsiblePanel1.Size = new System.Drawing.Size(815, 241);
            this.radCollapsiblePanel1.TabIndex = 13;
            this.radCollapsiblePanel1.Text = "radCollapsiblePanel1";
            this.radCollapsiblePanel1.ThemeName = "VisualStudio2012Light";
            // 
            // groupDescriptionTextBox
            // 
            this.groupDescriptionTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupDescriptionTextBox.Location = new System.Drawing.Point(488, 84);
            this.groupDescriptionTextBox.Multiline = true;
            this.groupDescriptionTextBox.Name = "groupDescriptionTextBox";
            this.groupDescriptionTextBox.Size = new System.Drawing.Size(188, 55);
            this.groupDescriptionTextBox.TabIndex = 2;
            // 
            // groupNameTextBox
            // 
            this.groupNameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupNameTextBox.Location = new System.Drawing.Point(488, 58);
            this.groupNameTextBox.Name = "groupNameTextBox";
            this.groupNameTextBox.Size = new System.Drawing.Size(188, 20);
            this.groupNameTextBox.TabIndex = 1;
            // 
            // idTextBox
            // 
            this.idTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.idTextBox.Location = new System.Drawing.Point(488, 32);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.ReadOnly = true;
            this.idTextBox.Size = new System.Drawing.Size(188, 20);
            this.idTextBox.TabIndex = 6;
            // 
            // userGroupRadGridView
            // 
            this.userGroupRadGridView.BackColor = System.Drawing.SystemColors.Control;
            this.userGroupRadGridView.Cursor = System.Windows.Forms.Cursors.Default;
            this.userGroupRadGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userGroupRadGridView.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.userGroupRadGridView.ForeColor = System.Drawing.SystemColors.ControlText;
            this.userGroupRadGridView.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.userGroupRadGridView.Location = new System.Drawing.Point(0, 265);
            // 
            // userGroupRadGridView
            // 
            this.userGroupRadGridView.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            gridViewDecimalColumn2.DataType = typeof(int);
            gridViewDecimalColumn2.EnableExpressionEditor = false;
            gridViewDecimalColumn2.FieldName = "Id";
            gridViewDecimalColumn2.HeaderText = "Id";
            gridViewDecimalColumn2.IsAutoGenerated = true;
            gridViewDecimalColumn2.Name = "Id";
            gridViewDecimalColumn2.Width = 266;
            gridViewTextBoxColumn5.EnableExpressionEditor = false;
            gridViewTextBoxColumn5.FieldName = "GroupName";
            gridViewTextBoxColumn5.HeaderText = "اسم المجموعة";
            gridViewTextBoxColumn5.IsAutoGenerated = true;
            gridViewTextBoxColumn5.Name = "GroupName";
            gridViewTextBoxColumn5.Width = 266;
            gridViewTextBoxColumn6.EnableExpressionEditor = false;
            gridViewTextBoxColumn6.FieldName = "GroupDescription";
            gridViewTextBoxColumn6.HeaderText = "الوصف";
            gridViewTextBoxColumn6.IsAutoGenerated = true;
            gridViewTextBoxColumn6.Name = "GroupDescription";
            gridViewTextBoxColumn6.SortOrder = Telerik.WinControls.UI.RadSortOrder.Descending;
            gridViewTextBoxColumn6.Width = 267;
            gridViewTextBoxColumn7.DataType = typeof(System.Collections.Generic.ICollection<Xprema.Data.GroupPermession>);
            gridViewTextBoxColumn7.EnableExpressionEditor = false;
            gridViewTextBoxColumn7.FieldName = "GroupPermessions";
            gridViewTextBoxColumn7.HeaderText = "GroupPermessions";
            gridViewTextBoxColumn7.IsAutoGenerated = true;
            gridViewTextBoxColumn7.IsVisible = false;
            gridViewTextBoxColumn7.Name = "GroupPermessions";
            gridViewTextBoxColumn7.Width = 152;
            gridViewTextBoxColumn8.DataType = typeof(System.Collections.Generic.ICollection<Xprema.Data.UserSystem>);
            gridViewTextBoxColumn8.EnableExpressionEditor = false;
            gridViewTextBoxColumn8.FieldName = "UserSystems";
            gridViewTextBoxColumn8.HeaderText = "UserSystems";
            gridViewTextBoxColumn8.IsAutoGenerated = true;
            gridViewTextBoxColumn8.IsVisible = false;
            gridViewTextBoxColumn8.Name = "UserSystems";
            gridViewTextBoxColumn8.Width = 122;
            this.userGroupRadGridView.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewDecimalColumn2,
            gridViewTextBoxColumn5,
            gridViewTextBoxColumn6,
            gridViewTextBoxColumn7,
            gridViewTextBoxColumn8});
            this.userGroupRadGridView.MasterTemplate.DataSource = this.userGroupBindingSource;
            sortDescriptor2.Direction = System.ComponentModel.ListSortDirection.Descending;
            sortDescriptor2.PropertyName = "GroupDescription";
            this.userGroupRadGridView.MasterTemplate.SortDescriptors.AddRange(new Telerik.WinControls.Data.SortDescriptor[] {
            sortDescriptor2});
            this.userGroupRadGridView.Name = "userGroupRadGridView";
            this.userGroupRadGridView.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.userGroupRadGridView.Size = new System.Drawing.Size(815, 314);
            this.userGroupRadGridView.TabIndex = 13;
            this.userGroupRadGridView.Text = "radGridView1";
            this.userGroupRadGridView.ThemeName = "VisualStudio2012Light";
            this.userGroupRadGridView.DoubleClick += new System.EventHandler(this.userGroupRadGridView_DoubleClick);
            // 
            // userGroupBindingSource
            // 
            this.userGroupBindingSource.DataSource = typeof(Xprema.Data.UserGroup);
            // 
            // frmUserGroup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(815, 601);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.userGroupRadGridView);
            this.Controls.Add(this.radCollapsiblePanel1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximumSize = new System.Drawing.Size(831, 640);
            this.MinimumSize = new System.Drawing.Size(831, 640);
            this.Name = "frmUserGroup";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "المجموعات";
            this.Load += new System.EventHandler(this.frmUserGroup_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.radCollapsiblePanel1.PanelContainer.ResumeLayout(false);
            this.radCollapsiblePanel1.PanelContainer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radCollapsiblePanel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userGroupRadGridView.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userGroupRadGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userGroupBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox PermessioncheckedListBox;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem btnNew;
        private System.Windows.Forms.ToolStripMenuItem btnSave;
        private System.Windows.Forms.ToolStripMenuItem btnDelete;
        private System.Windows.Forms.ToolStripMenuItem btnEdit;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private Telerik.WinControls.Themes.VisualStudio2012LightTheme visualStudio2012LightTheme1;
        private Telerik.WinControls.UI.RadCollapsiblePanel radCollapsiblePanel1;
        private System.Windows.Forms.TextBox groupDescriptionTextBox;
        private System.Windows.Forms.TextBox groupNameTextBox;
        private System.Windows.Forms.TextBox idTextBox;
        private Telerik.WinControls.UI.RadGridView userGroupRadGridView;
        private System.Windows.Forms.BindingSource userGroupBindingSource;
    }
}