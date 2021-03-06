﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.UI;
using Xprema.Data;

namespace Xprema_Project.UserGroupApi
{
    public partial class frmUserGroup : Form
    {

        private dbContainer db = new dbContainer();

        public frmUserGroup()
        {
            InitializeComponent();
        }

        private void frmUserGroup_Load(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            try
            {
                LoadPermession();
                userGroupBindingSource.DataSource = db.UserGroups.ToList();

            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally {
                this.Cursor = Cursors.Default;
            
            }
            
            
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            UserGroup g = new UserGroup()
            {
                GroupName = groupNameTextBox.Text,
                GroupDescription = groupDescriptionTextBox.Text
            };

            for (int i = 0; i < PermessioncheckedListBox.Items.Count; i++)
            {
                string per = PermessioncheckedListBox.Items[i].ToString();
                SystemPermession q = db.SystemPermessions.Where(p => p.PermessionName == (per)).SingleOrDefault(); //(from ix in db.SystemPermessions where ix.PermessionName.Contains(per) select i).SingleOrDefault(); // 

                g.GroupPermessions.Add(new GroupPermession()
                {
                    SystemPermession = q,
                    permessionValue = PermessioncheckedListBox.GetItemChecked(i)
                });
            }
            AddNewGroup(g);
            MessageBox.Show("Ok");
            btnSave.Enabled = false;
            btnEdit.Enabled = false;
            btnDelete.Enabled = false;
        }


        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (RadMessageBox.Show(Operations.SaveMessage, "رساله نبيه", MessageBoxButtons.YesNo, RadMessageIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
                int id = int.Parse(idTextBox.Text);
                UserGroup q = new UserGroup();
                q.Id = id;
                q.GroupName = groupNameTextBox.Text;
                q.GroupDescription = groupDescriptionTextBox.Text;
                for (int i = 0; i < PermessioncheckedListBox.Items.Count; i++)
                {
                    string per = PermessioncheckedListBox.Items[i].ToString();
                    SystemPermession groupPer = db.SystemPermessions.Where(p => p.PermessionName == (per)).SingleOrDefault(); //(from ix in db.SystemPermessions where ix.PermessionName.Contains(per) select i).SingleOrDefault(); // 

                    q.GroupPermessions.Add(new GroupPermession()
                    {
                        SystemPermession = groupPer,
                        permessionValue = PermessioncheckedListBox.GetItemChecked(i)
                    });
                }

                EditGroup(q);
                MessageBox.Show("Edit");
            }
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (RadMessageBox.Show(Operations.DeleteMessage, "رساله نبيه", MessageBoxButtons.YesNo, RadMessageIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
                int id = int.Parse(idTextBox.Text);
                DeleteGroup(id);
            }
        }

        //-------------------------------------------
        private void LoadPermession()
        {
            var q = db.SystemPermessions.ToList();
            foreach (var item in q)
            {
                PermessioncheckedListBox.Items.Add(item.PermessionName, true);
            }

        }


        private bool AddNewGroup( UserGroup g)
        {
            try
            {
                 db.UserGroups.Add(g);
                 db.SaveChanges();
                 return true;
            }
            catch (Exception ex)
            {
                
                throw ex;
            }
        }

        private bool EditGroup(UserGroup g) {

            try
            {
                var q = (db.UserGroups.Where(p=>p.Id==g.Id)).SingleOrDefault();
                if (q != null)
                {
                    q.GroupDescription = g.GroupDescription;
                    q.GroupName = g.GroupName;
                    for (int i = 0; i < q.GroupPermessions.Count; i++)
                    {
                        q.GroupPermessions.ToList()[i].permessionValue = g.GroupPermessions.ToList()[i].permessionValue;


                    }
                    db.SaveChanges();
                    btnEdit.Enabled = false;
                    btnDelete.Enabled = false;

                    return true;
                }
                return false;

            }
            catch (Exception ex)
            {
                
                throw ex;
            }
        
        }

        private bool DeleteGroup(int id)
        {
            try
            {
                var q = (db.UserGroups.Where(p => p.Id == id)).SingleOrDefault();
                db.UserGroups.Remove(q);
                db.SaveChanges();
                btnEdit.Enabled = false;
                btnDelete.Enabled = false;
                return true;
            }
            catch (Exception ex)
            {
                
                throw ex;
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            
        }

        private void userGroupRadGridView_DoubleClick(object sender, EventArgs e)
        {
            btnSave.Enabled = false;
            btnEdit.Enabled = true;
            btnDelete.Enabled = true;
            UpdatePanelInfo(this.userGroupRadGridView.CurrentRow, 5);
        }




        private void UpdatePanelInfo(GridViewRowInfo currentRow, int i)
        {

            if (currentRow != null && !(currentRow is GridViewNewRowInfo))
            {
                this.idTextBox.Text = currentRow.Cells[0].Value.ToString();
                this.groupNameTextBox.Text = currentRow.Cells[1].Value.ToString();
                this.groupDescriptionTextBox.Text = currentRow.Cells[2].Value.ToString();
               

            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            foreach (Control item in this.radCollapsiblePanel1.PanelContainer.Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";
                }
            }
            btnSave.Enabled = true;
            btnEdit.Enabled = false;
            btnDelete.Enabled = false;
        }

      
    }
}
