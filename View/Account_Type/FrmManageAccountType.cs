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

namespace MoneyManager.View.Account_Type
{
    public partial class FrmManageAccountType : Form
    {
        /* Singleton
        private static FrmManageAccountType self; */

        public FrmManageAccountType()
        {
            InitializeComponent();
        }
        /*
        public static FrmManageAccountType GetSelf()
        {
            if (self == null)
            {
                self = new FrmManageAccountType();
            }
            return self;
        }*/

        
        private void FrmManageAccountType_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
