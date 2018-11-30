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
    public partial class FrmManageAccount : Form
    {
        // Singleton
        private static FrmManageAccount self;

        private FrmManageAccount()
        {
            InitializeComponent();
        }

        public static FrmManageAccount GetForm()
        {
            if (self == null)
            {
                self = new FrmManageAccount();
            }
            return self;
        }

        
    }
}
