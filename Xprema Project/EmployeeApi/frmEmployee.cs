using System;
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
using Xprema.Data.CommandClass;

namespace Xprema_Project.EmployeeApi
{
    public partial class frmEmployee : Form
    {
        public frmEmployee()
        {
            InitializeComponent();
        }

        private dbContainer db = new dbContainer();
        xEmployees xEmp = new xEmployees();
        Alerts.Alert mesg = new Alerts.Alert();
       
        private void frmEmployee_Load(object sender, EventArgs e)
        {
             this.Cursor = Cursors.WaitCursor;
            try
            {
                employeeBindingSource.DataSource = db.Employees.ToList();
               
               
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
            if (employeeNameTextBox.Text == "")
            {
                mesg.Error("من فضلك ادخل اسم الموظف");
                employeeNameTextBox.Focus();
                return;
            }
            Employee emp = new Employee()
            {
                EmployeeName = employeeNameTextBox.Text,
                EmployeejobNumber = employeejobNumberTextBox.Text,
                EmployeeGender = employeeGenderComboBox.Text,
                EmployeeNationalNumber = employeeNationalNumberTextBox.Text,
                PhoneNumber = phoneNumberTextBox.Text,
                Mobilenumber = mobilenumberTextBox.Text,
                Email = emailTextBox.Text
            };
            xEmp.AddEmployee(emp);
            mesg.Info(Operations.SaveMessageDone);
        }

        private void btrEdit_Click(object sender, EventArgs e)
        {
            if (employeeNameTextBox.Text == "")
            {
                mesg.Error(Operations.EnterName);
                employeeNameTextBox.Focus();
                return;
            }
            int id = int.Parse(iDTextBox.Text);
            
            if (RadMessageBox.Show(Operations.SaveMessage, "رساله نبيه", MessageBoxButtons.YesNo,RadMessageIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
                try
                {
                    Cursor = Cursors.WaitCursor;

                    Employee emp = new Employee();
                    emp.ID = id;
                    emp.EmployeeName = employeeNameTextBox.Text;
                    emp.EmployeejobNumber = employeejobNumberTextBox.Text;
                    emp.EmployeeGender = employeeGenderComboBox.Text;
                    emp.EmployeeNationalNumber = employeeNationalNumberTextBox.Text;
                    emp.PhoneNumber = phoneNumberTextBox.Text;
                    emp.Mobilenumber = mobilenumberTextBox.Text;
                    emp.Email = emailTextBox.Text;
                    xEmp.EditEmployee(emp);
                    mesg.Info(Operations.EditMessage);
                    dbContainer db = new dbContainer();
                    employeeBindingSource.DataSource = db.Employees.ToList();
                    Cursor = Cursors.Default;
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

        private void btnDel_Click(object sender, EventArgs e)
        {
            
            if (RadMessageBox.Show(Operations.DeleteMessage, "", MessageBoxButtons.YesNo, RadMessageIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
                int id = int.Parse(iDTextBox.Text);
                //  xEmp.DeleteEmployee(id);
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            foreach (Control item in this.radCollapsiblePanel1.PanelContainer.Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";
                    employeeNameTextBox.Focus();
                }
            }
        }


        private void UpdatePanelInfo(GridViewRowInfo currentRow, int i)
        {
            if (currentRow != null && !(currentRow is GridViewNewRowInfo))
            {
                this.iDTextBox.Text = currentRow.Cells[0].Value.ToString();
                this.employeeNameTextBox.Text = currentRow.Cells[1].Value.ToString();
                this.employeejobNumberTextBox.Text = currentRow.Cells[2].Value.ToString();
                this.employeeGenderComboBox.Text = currentRow.Cells[3].Value.ToString();
                this.phoneNumberTextBox.Text = currentRow.Cells[4].Value.ToString();
                this.mobilenumberTextBox.Text = currentRow.Cells[5].Value.ToString();
                this.emailTextBox.Text = currentRow.Cells[6].Value.ToString();
                this.employeeNationalNumberTextBox.Text = currentRow.Cells[7].Value.ToString();
            }
        }

        private void MasterTemplate_DoubleClick(object sender, EventArgs e)
        {
            UpdatePanelInfo(this.employeeRadGridView.CurrentRow, 5);
        }
    }
}
    

