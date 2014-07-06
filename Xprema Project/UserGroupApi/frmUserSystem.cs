using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Xprema.Data;

namespace Xprema_Project.UserGroupApi
{
    public partial class frmUserSystem : Form
    {
        public frmUserSystem()
        {
            InitializeComponent();
        }
        private dbContainer db = new dbContainer();
        private void frmUserSystem_Load(object sender, EventArgs e)
        {
            userGroupBindingSource.DataSource = db.UserGroups.ToList();
        }
    }
}
