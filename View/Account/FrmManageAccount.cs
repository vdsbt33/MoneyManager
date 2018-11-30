using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using MoneyManager.View.Account_Type;

namespace MoneyManager.View.Account
{
    public partial class FrmManageAccount : Form
    {
        // Singleton
        private static FrmManageAccount self;

        private FrmManageAccount()
        {
            InitializeComponent();
        }

        public static FrmManageAccount GetSelf()
        {
            if (self == null)
            {
                self = new FrmManageAccount();
            }
            return self;
        }

        private void accountTypeBtn_Click(object sender, EventArgs e)
        {
            FrmManageAccountType form = new FrmManageAccountType();
            this.Hide();
            if (form.ShowDialog() == DialogResult.Cancel)
            {
                this.Show();
            }
        }
    }
}
