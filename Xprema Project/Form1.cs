using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Xprema_Project.UserGroupApi;
using Xprema_Project.EmployeeApi;
using Xprema_Project.suppliersApi;

namespace Xprema_Project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmUserGroup frGroup = new frmUserGroup();
            frGroup.ShowDialog();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmUserSystem fruser = new frmUserSystem();
            fruser.ShowDialog();
        }
        
        private void button3_Click(object sender, EventArgs e)
        {
            frmEmployee fremplyee = new frmEmployee();
            fremplyee.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            frmsupplier frmsup = new frmsupplier();
            frmsup.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            frmFinancier frmfinc = new frmFinancier();
            frmfinc.ShowDialog();
        }
    }
}
