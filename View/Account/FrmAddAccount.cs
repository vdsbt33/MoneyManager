using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MoneyManager.View
{
    public partial class FrmAddAccount : Form
    {
        // Singleton
        private static FrmAddAccount self;

        private FrmAddAccount()
        {
            InitializeComponent();
        }

        public static FrmAddAccount GetForm()
        {
            if (self == null)
            {
                self = new FrmAddAccount();
            }
            return self;
        }


    }
}
