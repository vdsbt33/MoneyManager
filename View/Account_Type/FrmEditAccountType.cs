using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using MoneyManager.Controller;

namespace MoneyManager.View.Account_Type
{
    public partial class FrmEditAccountType : Form
    {
        Model.Account_Type accountType;

        // Constructor
        public FrmEditAccountType(Model.Account_Type accountType)
        {
            InitializeComponent();
            this.accountType = accountType;

            nameAccount_Type.Text = accountType.nameAccount_Type;
        }

        // Clears fields
        private void ClearFields()
        {
            nameAccount_Type.Clear();
        }

        // Save button
        private void saveAccountTypeBtn_Click(object sender, EventArgs e)
        {
            if (Account_TypeDAO.GetSelf().UpdateAccount_Type(new Model.Account_Type(nameAccount_Type.Text)) == true)
            {
                ClearFields();
                MessageBox.Show("Account Type saved sucessfully.");
                this.DialogResult = DialogResult.OK;
            }
        }

        // Cancel button
        private void cancelAccountTypeBtn_Click(object sender, EventArgs e)
        {
            ClearFields();
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
