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
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn4 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn5 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn6 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.Data.SortDescriptor sortDescriptor2 = new Telerik.WinControls.Data.SortDescriptor();
            this.userGroupBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupDescriptionTextBox = new System.Windows.Forms.TextBox();
            this.groupNameTextBox = new System.Windows.Forms.TextBox();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.userGroupRadGridView = new Telerik.WinControls.UI.RadGridView();
            this.PermessioncheckedListBox = new System.Windows.Forms.CheckedListBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.جديدCtrlNToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnSave = new System.Windows.Forms.ToolStripMenuItem();
            this.btnDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.btnEdit = new System.Windows.Forms.ToolStripMenuItem();
            groupDescriptionLabel = new System.Windows.Forms.Label();
            groupNameLabel = new System.Windows.Forms.Label();
            idLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.userGroupBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userGroupRadGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userGroupRadGridView.MasterTemplate)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupDescriptionLabel
            // 
            groupDescriptionLabel.AutoSize = true;
            groupDescriptionLabel.Location = new System.Drawing.Point(87, 88);
            groupDescriptionLabel.Name = "groupDescriptionLabel";
            groupDescriptionLabel.Size = new System.Drawing.Size(96, 13);
            groupDescriptionLabel.TabIndex = 1;
            groupDescriptionLabel.Text = "Group Description:";
            // 
            // groupNameLabel
            // 
            groupNameLabel.AutoSize = true;
            groupNameLabel.Location = new System.Drawing.Point(87, 114);
            groupNameLabel.Name = "groupNameLabel";
            groupNameLabel.Size = new System.Drawing.Size(70, 13);
            groupNameLabel.TabIndex = 3;
            groupNameLabel.Text = "Group Name:";
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new System.Drawing.Point(87, 140);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(21, 13);
            idLabel.TabIndex = 5;
            idLabel.Text = "Id:";
            // 
            // userGroupBindingSource
            // 
            this.userGroupBindingSource.DataSource = typeof(Xprema.Data.UserGroup);
            // 
            // groupDescriptionTextBox
            // 
            this.groupDescriptionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userGroupBindingSource, "GroupDescription", true));
            this.groupDescriptionTextBox.Location = new System.Drawing.Point(189, 85);
            this.groupDescriptionTextBox.Name = "groupDescriptionTextBox";
            this.groupDescriptionTextBox.Size = new System.Drawing.Size(209, 20);
            this.groupDescriptionTextBox.TabIndex = 2;
            // 
            // groupNameTextBox
            // 
            this.groupNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userGroupBindingSource, "GroupName", true));
            this.groupNameTextBox.Location = new System.Drawing.Point(189, 111);
            this.groupNameTextBox.Name = "groupNameTextBox";
            this.groupNameTextBox.Size = new System.Drawing.Size(209, 20);
            this.groupNameTextBox.TabIndex = 4;
            // 
            // idTextBox
            // 
            this.idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userGroupBindingSource, "Id", true));
            this.idTextBox.Location = new System.Drawing.Point(189, 137);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(209, 20);
            this.idTextBox.TabIndex = 6;
            // 
            // userGroupRadGridView
            // 
            this.userGroupRadGridView.BackColor = System.Drawing.SystemColors.Control;
            this.userGroupRadGridView.Cursor = System.Windows.Forms.Cursors.Default;
            this.userGroupRadGridView.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.userGroupRadGridView.ForeColor = System.Drawing.SystemColors.ControlText;
            this.userGroupRadGridView.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.userGroupRadGridView.Location = new System.Drawing.Point(25, 182);
            // 
            // userGroupRadGridView
            // 
            gridViewDecimalColumn2.DataType = typeof(int);
            gridViewDecimalColumn2.EnableExpressionEditor = false;
            gridViewDecimalColumn2.FieldName = "Id";
            gridViewDecimalColumn2.HeaderText = "Id";
            gridViewDecimalColumn2.IsAutoGenerated = true;
            gridViewDecimalColumn2.Name = "Id";
            gridViewDecimalColumn2.Width = 83;
            gridViewTextBoxColumn4.EnableExpressionEditor = false;
            gridViewTextBoxColumn4.FieldName = "GroupName";
            gridViewTextBoxColumn4.HeaderText = "GroupName";
            gridViewTextBoxColumn4.IsAutoGenerated = true;
            gridViewTextBoxColumn4.Name = "GroupName";
            gridViewTextBoxColumn4.Width = 126;
            gridViewTextBoxColumn5.EnableExpressionEditor = false;
            gridViewTextBoxColumn5.FieldName = "GroupDescription";
            gridViewTextBoxColumn5.HeaderText = "GroupDescription";
            gridViewTextBoxColumn5.IsAutoGenerated = true;
            gridViewTextBoxColumn5.Name = "GroupDescription";
            gridViewTextBoxColumn5.Width = 243;
            gridViewTextBoxColumn6.DataType = typeof(System.Collections.Generic.ICollection<Xprema.Data.UserSystem>);
            gridViewTextBoxColumn6.EnableExpressionEditor = false;
            gridViewTextBoxColumn6.FieldName = "UserSystems";
            gridViewTextBoxColumn6.HeaderText = "UserSystems";
            gridViewTextBoxColumn6.IsAutoGenerated = true;
            gridViewTextBoxColumn6.IsVisible = false;
            gridViewTextBoxColumn6.Name = "UserSystems";
            gridViewTextBoxColumn6.SortOrder = Telerik.WinControls.UI.RadSortOrder.Ascending;
            gridViewTextBoxColumn6.Width = 71;
            this.userGroupRadGridView.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewDecimalColumn2,
            gridViewTextBoxColumn4,
            gridViewTextBoxColumn5,
            gridViewTextBoxColumn6});
            this.userGroupRadGridView.MasterTemplate.DataSource = this.userGroupBindingSource;
            this.userGroupRadGridView.MasterTemplate.EnableFiltering = true;
            sortDescriptor2.PropertyName = "UserSystems";
            this.userGroupRadGridView.MasterTemplate.SortDescriptors.AddRange(new Telerik.WinControls.Data.SortDescriptor[] {
            sortDescriptor2});
            this.userGroupRadGridView.Name = "userGroupRadGridView";
            this.userGroupRadGridView.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.userGroupRadGridView.Size = new System.Drawing.Size(628, 220);
            this.userGroupRadGridView.TabIndex = 7;
            this.userGroupRadGridView.Text = "radGridView1";
            // 
            // PermessioncheckedListBox
            // 
            this.PermessioncheckedListBox.FormattingEnabled = true;
            this.PermessioncheckedListBox.Location = new System.Drawing.Point(423, 28);
            this.PermessioncheckedListBox.Name = "PermessioncheckedListBox";
            this.PermessioncheckedListBox.Size = new System.Drawing.Size(229, 139);
            this.PermessioncheckedListBox.TabIndex = 8;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.جديدCtrlNToolStripMenuItem,
            this.btnSave,
            this.btnDelete,
            this.btnEdit});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(153, 114);
            // 
            // جديدCtrlNToolStripMenuItem
            // 
            this.جديدCtrlNToolStripMenuItem.Name = "جديدCtrlNToolStripMenuItem";
            this.جديدCtrlNToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.جديدCtrlNToolStripMenuItem.Text = "جديد     Ctrl+N";
            // 
            // btnSave
            // 
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(152, 22);
            this.btnSave.Text = "حفظ     Ctrl+S";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(152, 22);
            this.btnDelete.Text = "حذف     Ctrl+D";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(152, 22);
            this.btnEdit.Text = "تعديل     Ctrl+U";
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // frmUserGroup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(665, 422);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.PermessioncheckedListBox);
            this.Controls.Add(this.userGroupRadGridView);
            this.Controls.Add(groupDescriptionLabel);
            this.Controls.Add(this.groupDescriptionTextBox);
            this.Controls.Add(groupNameLabel);
            this.Controls.Add(this.groupNameTextBox);
            this.Controls.Add(idLabel);
            this.Controls.Add(this.idTextBox);
            this.Name = "frmUserGroup";
            this.Text = "frmUserGroup";
            this.Load += new System.EventHandler(this.frmUserGroup_Load);
            ((System.ComponentModel.ISupportInitialize)(this.userGroupBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userGroupRadGridView.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userGroupRadGridView)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource userGroupBindingSource;
        private System.Windows.Forms.TextBox groupDescriptionTextBox;
        private System.Windows.Forms.TextBox groupNameTextBox;
        private System.Windows.Forms.TextBox idTextBox;
        private Telerik.WinControls.UI.RadGridView userGroupRadGridView;
        private System.Windows.Forms.CheckedListBox PermessioncheckedListBox;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem جديدCtrlNToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem btnSave;
        private System.Windows.Forms.ToolStripMenuItem btnDelete;
        private System.Windows.Forms.ToolStripMenuItem btnEdit;
    }
}