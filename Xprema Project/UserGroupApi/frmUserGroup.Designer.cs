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
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn1 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn1 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn2 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn3 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn4 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
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
            this.userGroupBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupNameTextBox = new System.Windows.Forms.TextBox();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.userGroupRadGridView = new Telerik.WinControls.UI.RadGridView();
            groupDescriptionLabel = new System.Windows.Forms.Label();
            groupNameLabel = new System.Windows.Forms.Label();
            idLabel = new System.Windows.Forms.Label();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radCollapsiblePanel1)).BeginInit();
            this.radCollapsiblePanel1.PanelContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userGroupBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userGroupRadGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userGroupRadGridView.MasterTemplate)).BeginInit();
            this.SuspendLayout();
            // 
            // groupDescriptionLabel
            // 
            groupDescriptionLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            groupDescriptionLabel.AutoSize = true;
            groupDescriptionLabel.Location = new System.Drawing.Point(695, 122);
            groupDescriptionLabel.Name = "groupDescriptionLabel";
            groupDescriptionLabel.Size = new System.Drawing.Size(105, 13);
            groupDescriptionLabel.TabIndex = 1;
            groupDescriptionLabel.Text = "Group Description:";
            // 
            // groupNameLabel
            // 
            groupNameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            groupNameLabel.AutoSize = true;
            groupNameLabel.Location = new System.Drawing.Point(695, 78);
            groupNameLabel.Name = "groupNameLabel";
            groupNameLabel.Size = new System.Drawing.Size(75, 13);
            groupNameLabel.TabIndex = 3;
            groupNameLabel.Text = "Group Name:";
            // 
            // idLabel
            // 
            idLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            idLabel.AutoSize = true;
            idLabel.Location = new System.Drawing.Point(695, 32);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(20, 13);
            idLabel.TabIndex = 5;
            idLabel.Text = "Id:";
            // 
            // PermessioncheckedListBox
            // 
            this.PermessioncheckedListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PermessioncheckedListBox.FormattingEnabled = true;
            this.PermessioncheckedListBox.Location = new System.Drawing.Point(31, 32);
            this.PermessioncheckedListBox.Name = "PermessioncheckedListBox";
            this.PermessioncheckedListBox.Size = new System.Drawing.Size(367, 123);
            this.PermessioncheckedListBox.TabIndex = 8;
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
            this.contextMenuStrip1.Size = new System.Drawing.Size(154, 92);
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
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(153, 22);
            this.btnEdit.Text = "تعديل     Ctrl+U";
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
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
            this.statusStrip1.Location = new System.Drawing.Point(0, 580);
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
            this.radCollapsiblePanel1.PanelContainer.Size = new System.Drawing.Size(813, 160);
            this.radCollapsiblePanel1.Size = new System.Drawing.Size(815, 190);
            this.radCollapsiblePanel1.TabIndex = 13;
            this.radCollapsiblePanel1.Text = "radCollapsiblePanel1";
            this.radCollapsiblePanel1.ThemeName = "VisualStudio2012Light";
            // 
            // groupDescriptionTextBox
            // 
            this.groupDescriptionTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupDescriptionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userGroupBindingSource, "GroupDescription", true));
            this.groupDescriptionTextBox.Location = new System.Drawing.Point(488, 119);
            this.groupDescriptionTextBox.Name = "groupDescriptionTextBox";
            this.groupDescriptionTextBox.Size = new System.Drawing.Size(188, 20);
            this.groupDescriptionTextBox.TabIndex = 2;
            // 
            // userGroupBindingSource
            // 
            this.userGroupBindingSource.DataSource = typeof(Xprema.Data.UserGroup);
            // 
            // groupNameTextBox
            // 
            this.groupNameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userGroupBindingSource, "GroupName", true));
            this.groupNameTextBox.Location = new System.Drawing.Point(488, 78);
            this.groupNameTextBox.Name = "groupNameTextBox";
            this.groupNameTextBox.Size = new System.Drawing.Size(188, 20);
            this.groupNameTextBox.TabIndex = 4;
            // 
            // idTextBox
            // 
            this.idTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userGroupBindingSource, "Id", true));
            this.idTextBox.Location = new System.Drawing.Point(488, 32);
            this.idTextBox.Name = "idTextBox";
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
            this.userGroupRadGridView.Location = new System.Drawing.Point(0, 214);
            // 
            // userGroupRadGridView
            // 
            this.userGroupRadGridView.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            gridViewDecimalColumn1.DataType = typeof(int);
            gridViewDecimalColumn1.EnableExpressionEditor = false;
            gridViewDecimalColumn1.FieldName = "Id";
            gridViewDecimalColumn1.HeaderText = "Id";
            gridViewDecimalColumn1.IsAutoGenerated = true;
            gridViewDecimalColumn1.Name = "Id";
            gridViewDecimalColumn1.Width = 266;
            gridViewTextBoxColumn1.EnableExpressionEditor = false;
            gridViewTextBoxColumn1.FieldName = "GroupName";
            gridViewTextBoxColumn1.HeaderText = "GroupName";
            gridViewTextBoxColumn1.IsAutoGenerated = true;
            gridViewTextBoxColumn1.Name = "GroupName";
            gridViewTextBoxColumn1.Width = 266;
            gridViewTextBoxColumn2.EnableExpressionEditor = false;
            gridViewTextBoxColumn2.FieldName = "GroupDescription";
            gridViewTextBoxColumn2.HeaderText = "GroupDescription";
            gridViewTextBoxColumn2.IsAutoGenerated = true;
            gridViewTextBoxColumn2.Name = "GroupDescription";
            gridViewTextBoxColumn2.Width = 267;
            gridViewTextBoxColumn3.DataType = typeof(System.Collections.Generic.ICollection<Xprema.Data.UserSystem>);
            gridViewTextBoxColumn3.EnableExpressionEditor = false;
            gridViewTextBoxColumn3.FieldName = "UserSystems";
            gridViewTextBoxColumn3.HeaderText = "UserSystems";
            gridViewTextBoxColumn3.IsAutoGenerated = true;
            gridViewTextBoxColumn3.IsVisible = false;
            gridViewTextBoxColumn3.Name = "UserSystems";
            gridViewTextBoxColumn3.Width = 121;
            gridViewTextBoxColumn4.DataType = typeof(System.Collections.Generic.ICollection<Xprema.Data.GroupPermession>);
            gridViewTextBoxColumn4.EnableExpressionEditor = false;
            gridViewTextBoxColumn4.FieldName = "GroupPermessions";
            gridViewTextBoxColumn4.HeaderText = "GroupPermessions";
            gridViewTextBoxColumn4.IsAutoGenerated = true;
            gridViewTextBoxColumn4.IsVisible = false;
            gridViewTextBoxColumn4.Name = "GroupPermessions";
            gridViewTextBoxColumn4.Width = 152;
            this.userGroupRadGridView.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewDecimalColumn1,
            gridViewTextBoxColumn1,
            gridViewTextBoxColumn2,
            gridViewTextBoxColumn3,
            gridViewTextBoxColumn4});
            this.userGroupRadGridView.MasterTemplate.DataSource = this.userGroupBindingSource;
            this.userGroupRadGridView.Name = "userGroupRadGridView";
            this.userGroupRadGridView.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.userGroupRadGridView.Size = new System.Drawing.Size(815, 366);
            this.userGroupRadGridView.TabIndex = 13;
            this.userGroupRadGridView.Text = "radGridView1";
            this.userGroupRadGridView.ThemeName = "VisualStudio2012Light";
            // 
            // frmUserGroup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(815, 602);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.userGroupRadGridView);
            this.Controls.Add(this.radCollapsiblePanel1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmUserGroup";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "frmUserGroup";
            this.Load += new System.EventHandler(this.frmUserGroup_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.radCollapsiblePanel1.PanelContainer.ResumeLayout(false);
            this.radCollapsiblePanel1.PanelContainer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radCollapsiblePanel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userGroupBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userGroupRadGridView.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userGroupRadGridView)).EndInit();
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
        private System.Windows.Forms.BindingSource userGroupBindingSource;
        private System.Windows.Forms.TextBox groupNameTextBox;
        private System.Windows.Forms.TextBox idTextBox;
        private Telerik.WinControls.UI.RadGridView userGroupRadGridView;
    }
}