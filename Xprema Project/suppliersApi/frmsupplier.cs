using System;
using System.Linq;
using System.Windows.Forms;
using Telerik.WinControls;
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
            foreach (Control item in this.radCollapsiblePanel1.Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";
                }
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
                    PhoneNumber = this.nameTextBox.Text,
                    SuppliersNatural = this.suppliersNaturalTextBox.Text
                   
                };
                
               

                if (this.cmd.AddNewSupplier(sup))
                {
                    this.Cursor = Cursors.Default;

                    MessageBox.Show("ok");
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
            var Id =int.Parse(iDTextBox.Text);
            Supplier sup = new Supplier()
            {             
                ID=Id,
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

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if(RadMessageBox.Show(Operations.DeleteMessage,"رساله تنبيه",MessageBoxButtons.YesNo,RadMessageIcon.Question)==System.Windows.Forms.DialogResult.Yes)
            {
                int id= int.Parse(iDTextBox.Text);
                if (cmd.DeleteSupplier(id))
                {
                    MessageBox.Show("Ok");
                }
                else
                {
                    MessageBox.Show("No Ok");
                }
            
            }
        }
    }
}