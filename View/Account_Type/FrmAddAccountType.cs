using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MoneyManager.View.Account_Type
{
    public partial class FrmAddAccountType : Form
    {

        public FrmAddAccountType()
        {
            InitializeComponent();
        }

        // Clear fields
        private void ClearFields()
        {
            nameAccount_Type.Clear();
        }

        /// Adds account to database
        private void addAccountTypeBtn_Click(object sender, EventArgs e)
        {
            if (nameAccount_Type.Text.Count() > 0)
            {
                Model.Account_Type accountType = new Model.Account_Type(nameAccount_Type.Text);
                Exception error = Controller.Account_TypeDAO.GetSelf().InsertAccount_Type(accountType);
                if (error == null)
                {
                    ClearFields();
                    MessageBox.Show("Account Type added sucessfully.");
                    this.DialogResult = DialogResult.OK;
                } else
                {
                    ClearFields();
                    this.DialogResult = DialogResult.Cancel;
                }
            }
            
        }

        /// Cancels adding account to database
        private void cancelAccountTypeBtn_Click(object sender, EventArgs e)
        {
            ClearFields();
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
