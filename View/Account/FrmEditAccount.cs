using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MoneyManager.View.Account
{
    public partial class FrmEditAccount : Form
    {
        // Singleton
        private static FrmEditAccount self;

        private FrmEditAccount()
        {
            InitializeComponent();
        }

        public static FrmEditAccount GetForm()
        {
            if (self == null)
            {
                self = new FrmEditAccount();
            }
            return self;
        }


    }
}
