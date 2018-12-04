using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using MoneyManager.View.Account;

namespace MoneyManager
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();

            // Initialize Controllers
            Controller.AccountDAO.GetSelf();
            Controller.Account_TypeDAO.GetSelf();
            Controller.Database_Controller.GetSelf();
        }

        private void accountManagementButton_Click(object sender, EventArgs e)
        {
            FrmManageAccount form = new FrmManageAccount();
            form.Show();
        }
    }
}
