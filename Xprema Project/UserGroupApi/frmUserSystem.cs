using System;
using System.Linq;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.Data;
using Xprema.Data;
using Xprema.Data.CommandClass;

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

        public void UserGroupComoBoxUpdate()
        {
            this.userGroupBindingSource.DataSource = this.db.UserGroups.ToList();
            this.userGroupRadMultiColumnComboBox.AutoFilter = true;
            this.userGroupRadMultiColumnComboBox.ValueMember = "Id";
            this.userGroupRadMultiColumnComboBox.DisplayMember = "GroupName";
            FilterDescriptor filter = new FilterDescriptor();
            filter.PropertyName = this.userGroupRadMultiColumnComboBox.DisplayMember;
            filter.Operator = FilterOperator.Contains;
            this.userGroupRadMultiColumnComboBox.EditorControl.MasterTemplate.FilterDescriptors.Add(filter);
        }

        private void frmUserSystem_Load(object sender, EventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;
                this.UserGroupComoBoxUpdate();
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

        private void btnSave_Click(object sender, EventArgs e)
        {
            xUsersSystem cmd = new xUsersSystem();
            //MessageBox.Show(this.userGroupRadMultiColumnComboBox.SelectedValue.ToString());
            int gId = int.Parse(this.userGroupRadMultiColumnComboBox.SelectedValue.ToString());
    

            try
            {
                this.Cursor = Cursors.WaitCursor;
                UserGroup g = new UserGroup();
                g = this.db.UserGroups.Where(p => p.Id == gId).SingleOrDefault();

                UserSystem user = new UserSystem()
                {
                    UserName = this.userNameTextBox.Text,
                    Password = this.passwordTextBox.Text,
                };
                g.UserSystems.Add(user);
                db.SaveChanges();

                //if (cmd.AddUserSystems(user))
                //{
                //    this.Cursor = Cursors.Default;
                //    MessageBox.Show("Ok");
                //}
                //else
                //{
                //    this.Cursor = Cursors.Default;
                //    MessageBox.Show("Not Ok");
                //}
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
            foreach (Control item in this.radCollapsiblePanel1.Controls)
            {
                if (item is TextBox)
                {
                    item.Text = ""; 
                }
            }
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                xUsersSystem cmd = new xUsersSystem();
                int gId = int.Parse(this.userGroupRadMultiColumnComboBox.SelectedValue.ToString());
                int userId = int.Parse(this.idTextBox.Text);
                UserSystem user = new UserSystem()
                {
                    UserName = this.userNameTextBox.Text,
                    Password = this.passwordTextBox.Text,
                   // UserGroup = this.db.UserGroups.Where(p => p.Id == gId).SingleOrDefault(),
                    Id = userId
                };
                if (cmd.EditUserSystems(user))
                {
                }
            }
            catch (Exception ex)
            {
                throw ex;
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
                    int ID = int.Parse(this.idTextBox.Text);
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
    }
}