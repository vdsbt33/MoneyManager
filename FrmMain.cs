using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using MoneyManager.View;

namespace MoneyManager
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void accountManagementButton_Click(object sender, EventArgs e)
        {
            FrmManageAccount.GetForm().ShowDialog();
        }
    }
}
