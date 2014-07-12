using System;
using System.Linq;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.Data;
using Telerik.WinControls.UI;
using Xprema.Data;
using Xprema.Data.CommandClass;
using System.IO;
using System.Reflection;
using Telerik.WinControls.Primitives; 

namespace Xprema_Project.UserGroupApi
{
    public partial class frmUserSystem : Form
    {
        private dbContainer db = new dbContainer();
        private xUsersSystem xUser = new xUsersSystem();

        public frmUserSystem()
        {
            this.InitializeComponent();
        }
           xUsersSystem cmd = new xUsersSystem();
            void PopulateTree()
            {
                // Abu Ehab Code :
                xUsersSystem UsersCmd = new xUsersSystem();
                var AllUsers = UsersCmd.GetAllUsers();
                var AllGroups = UsersCmd.GetAllGroups();
                var AllElements = (from u in AllUsers
                                   join g in AllGroups
                                   on u.UserGroup.Id equals (g.Id)
                                   select u).ToList();

                UsersTree.Nodes.Clear();
                UsersTree.Nodes.Add("Abu Ehab", "المستخدمين");
                int i = 0;
                foreach (var Usr in AllElements)
                {
                    UsersTree.Nodes[0].Nodes.Add("", Usr.UserName);
                    UsersTree.Nodes[0].Nodes[i].Nodes.Add("", Usr.Password);
                    UsersTree.Nodes[0].Nodes[i].Nodes.Add("", Usr.UserGroup.GroupName);
                    i++;

                }
            }
        public void UserGroupComoBoxUpdate()
        {
            this.userGroupBindingSource.DataSource = this.db.UserGroups.ToList();
            this.userGroupRadMultiColumnComboBox.AutoFilter = true;
            this.userGroupRadMultiColumnComboBox.ValueMember = "Id";
            this.userGroupRadMultiColumnComboBox.DisplayMember = "GroupName";
            FilterDescriptor filter = new FilterDescriptor();
            filter.PropertyName = this.userGroupRadMultiColumnComboBox.DisplayMember;
            filter.Operator = FilterOperator.Contains;
            this.userGroupRadMultiColumnComboBox.EditorControl.MasterTemplate.FilterDescriptors.Clear();
            this.userGroupRadMultiColumnComboBox.EditorControl.MasterTemplate.FilterDescriptors.Add(filter);
        }

        private void frmUserSystem_Load(object sender, EventArgs e)
        {
            try
            {
                PopulateTree ();
                this.Cursor = Cursors.WaitCursor;
                this.UserGroupComoBoxUpdate();
                dbContainer db = new dbContainer();
                this.userSystemBindingSource.DataSource = db.UserSystems.ToList();
                Application.DoEvents();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }
        }

        private void UpdatePanelInfo(GridViewRowInfo currentRow, int i)
        {
            if (currentRow != null && !(currentRow is GridViewNewRowInfo))
            {
                this.IDBox.Text = currentRow.Cells["Id"].Value.ToString(); 
                this.userNameTextBox.Text = currentRow.Cells["UserName"].Value.ToString();
                this.passwordTextBox.Text = currentRow.Cells["Password"].Value.ToString();
                this.userGroupRadMultiColumnComboBox.Text = currentRow.Cells["UserGroup"].Value.ToString();
            }
        }
        
        private void btnSave_Click(object sender, EventArgs e)
        {
           
            //MessageBox.Show(this.userGroupRadMultiColumnComboBox.SelectedValue.ToString());
            int gId = int.Parse(this.userGroupRadMultiColumnComboBox.SelectedValue.ToString());

            try
            {
                this.Cursor = Cursors.WaitCursor;
                UserSystem user = new UserSystem()
                {
                    UserName = this.userNameTextBox.Text,
                    Password = this.passwordTextBox.Text,
                };
                
                cmd.AddUser(user,gId );
                MessageBox.Show("Save ");
                frmUserSystem_Load(sender, e);
                
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            foreach (Control item in this.radCollapsiblePanel1.PanelContainer.Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";
                    userNameTextBox.Focus();
                }
            }
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            if (RadMessageBox.Show(Operations.SaveMessage, "رساله نبيه", MessageBoxButtons.YesNo, RadMessageIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
                try
                {

                    int gId = int.Parse(this.userGroupRadMultiColumnComboBox.SelectedValue.ToString());
                    int userId = int.Parse(this.IDBox.Text);
                    //UserGroup g = this.db.UserGroups.Where(p => p.Id == gId).SingleOrDefault();
                    //UserSystem u = db.UserSystems.Where(p => p.Id == userId).SingleOrDefault();

                    //u.UserName = this.userNameTextBox.Text;
                    //u.Password = this.passwordTextBox.Text;
                    //u.UserGroup = g;
                    //db.SaveChanges();
                                                         
                    cmd.UpDateUser(userId,userNameTextBox.Text,passwordTextBox.Text,gId);

                    MessageBox.Show("Saved ");
                    frmUserSystem_Load(sender, e);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }
        private void BtnDel_Click(object sender, EventArgs e)
        {
            if (RadMessageBox.Show(Operations.DeleteMessage, "رساله تنبيه!", MessageBoxButtons.YesNo, RadMessageIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
                try
                {
                    this.Cursor = Cursors.WaitCursor;

                    xUsersSystem cmd = new xUsersSystem();
                    int ID = int.Parse(this.IDBox.Text);
                    if (cmd.DeleteUser(ID))
                    {
                        this.Cursor = Cursors.Default;
                        MessageBox.Show("Ok");
                    }
                    else
                    {
                        this.Cursor = Cursors.Default;
                        MessageBox.Show("Not Ok");
                    }
                }
                catch (Exception ex)
                {
                    throw ex;
                }
                finally
                {
                    this.Cursor = Cursors.Default;
                }
            }
        }

        private void userSystemRadGridView_CurrentRowChanged(object sender, CurrentRowChangedEventArgs e)
        {
           
        }

        private void userSystemRadGridView_DoubleClick(object sender, EventArgs e)
        {
            UpdatePanelInfo(this.userSystemRadGridView.CurrentRow, 5);
        }

        private void ExpanedBtn_Click(object sender, EventArgs e)
        {
            if (UsersTree.Nodes.Count != 0) { UsersTree.ExpandAll(); }
        }

        private void CollaspBtn_Click(object sender, EventArgs e)
        {
            if (UsersTree.Nodes.Count != 0) { UsersTree.CollapseAll (); }
        }
    }
}