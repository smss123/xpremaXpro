using System;
using System.Linq;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.UI;
using Xprema.Data;
using Xprema.Data.CommandClass;

namespace Xprema_Project.suppliersApi
{
    public partial class frmsupplier : Form
    {
        private xSuppliers cmd = new xSuppliers();
        private dbContainer db = new dbContainer();

        public frmsupplier()
        {
            this.InitializeComponent();
        }

        private void radCollapsiblePanel1_PanelContainer_Paint(object sender, PaintEventArgs e)
        {
        }

        private void frmsupplier_Load(object sender, EventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;
                this.supplierBindingSource.DataSource = this.db.Suppliers.ToList();
                this.Cursor = Cursors.Default;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            foreach (Control item in this.radCollapsiblePanel1.PanelContainer.Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";
                    nameTextBox.Focus();

                }
                btnSave.Enabled = true;
                btnEdit.Enabled = false;
                btnDelete.Enabled = false;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
           
            try
            {
                this.Cursor = Cursors.WaitCursor;
                Supplier sup = new Supplier()
                {
                    Adderss = this.adderssTextBox.Text,
                    Email = this.emailTextBox.Text,
                    Fax = this.faxTextBox.Text,
                    name = this.nameTextBox.Text,
                    PhoneNumber = this.phoneNumberTextBox.Text,
                    SuppliersNatural = this.suppliersNaturalTextBox.Text
                   
                };
                
               

                if (this.cmd.AddNewSupplier(sup))
                {
                    this.Cursor = Cursors.Default;

                    MessageBox.Show("ok");
                    btnSave.Enabled = false;
                    btnEdit.Enabled = false;
                    btnDelete.Enabled = false;
                }
                else
                {
                    this.Cursor = Cursors.Default;
                    MessageBox.Show("Not Ok");
                }

                this.Cursor = Cursors.Default;
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

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (RadMessageBox.Show(Operations.SaveMessage, "رساله نبيه", MessageBoxButtons.YesNo, RadMessageIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
                var Id = int.Parse(iDTextBox.Text);
                Supplier sup = new Supplier()
                {
                    ID = Id,
                    Adderss = this.adderssTextBox.Text,
                    Email = this.emailTextBox.Text,
                    Fax = this.faxTextBox.Text,
                    name = this.nameTextBox.Text,
                    PhoneNumber = this.phoneNumberTextBox.Text,
                    SuppliersNatural = this.suppliersNaturalTextBox.Text,
                };
                try
                {
                    Cursor = Cursors.WaitCursor;

                    if (cmd.EditSupplier(sup))
                    {
                        Cursor = Cursors.Default;
                        MessageBox.Show("Ok");
                        btnSave.Enabled = false;
                        btnEdit.Enabled = false;
                        btnDelete.Enabled = false;
                    }
                    else
                    {
                        Cursor = Cursors.Default;
                        MessageBox.Show("Not Ok");
                    }

                }
                catch (Exception ex)
                {

                    throw ex;
                }
                finally
                {
                    Cursor = Cursors.Default;
                }
            }
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if(RadMessageBox.Show(Operations.DeleteMessage,"رساله تنبيه",MessageBoxButtons.YesNo,RadMessageIcon.Question)==System.Windows.Forms.DialogResult.Yes)
            {
                int id= int.Parse(iDTextBox.Text);
                if (cmd.DeleteSupplier(id))
                {
                    MessageBox.Show("Ok");
                    btnSave.Enabled = false;
                    btnEdit.Enabled = false;
                    btnDelete.Enabled = false;
                }
                else
                {
                    MessageBox.Show("No Ok");
                }
            
            }
        }

        private void MasterTemplate_DoubleClick(object sender, EventArgs e)
        {
            
            UpdatePanelInfo(this.supplierRadGridView.CurrentRow, 5);
            btnSave.Enabled = false;
            btnEdit.Enabled = true;
            btnDelete.Enabled = true;
        }

        private void UpdatePanelInfo(GridViewRowInfo currentRow, int i)
        {
            if (currentRow != null && !(currentRow is GridViewNewRowInfo))
            {
                this.iDTextBox.Text = currentRow.Cells[0].Value.ToString();
                this.nameTextBox.Text = currentRow.Cells[1].Value.ToString();
                this.suppliersNaturalTextBox.Text = currentRow.Cells[2].Value.ToString();
                this.phoneNumberTextBox.Text = currentRow.Cells[3].Value.ToString();
                this.faxTextBox.Text = currentRow.Cells[4].Value.ToString();
                this.emailTextBox.Text = currentRow.Cells[5].Value.ToString();
                this.adderssTextBox.Text = currentRow.Cells[6].Value.ToString();
            }
        }
    }
}