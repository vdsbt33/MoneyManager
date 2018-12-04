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

namespace MoneyManager.View
{
    public partial class FrmAddAccount : Form
    {
        // Accounts variable
        private List<Model.Account> accounts;
        private List<Model.Account_Type> accountTypes;
        
        public FrmAddAccount(List<Model.Account> accountList)
        {
            InitializeComponent();

            accounts = accountList;
            accountTypes = Account_TypeDAO.GetSelf().GetAccountAll();

            foreach (Model.Account_Type at in accountTypes)
            {
                accountType.Items.Add(at.nameAccount_Type);
            }
        }

        /// <summary>
        /// Resets all fields from this form
        /// </summary>
        private void ResetFields()
        {
            nameAccount.Clear();
            accountType.SelectedItem = null;
            balanceAccount.Value = 0;
            memoAccount.Clear();
        }

        private void addAccountBtn_Click(object sender, EventArgs e)
        {
            // Checks fields
            if (nameAccount.Text.Count() > 0 && accountType.SelectedItem != null)
            {
                Model.Account newAccount = new Model.Account(nameAccount.Text, accountTypes[accountType.SelectedIndex], (double)balanceAccount.Value, memoAccount.Text);
                Exception error = AccountDAO.GetSelf().InsertAccount(newAccount);
                if (error == null)
                {
                    accounts.Add(newAccount);
                    ResetFields();
                    MessageBox.Show("Account added to database.", "Alert", MessageBoxButtons.OK);
                    this.DialogResult = DialogResult.OK;
                } else
                {
                    MessageBox.Show(error.Message);
                }
            }
        }

        private void cancelAccountBtn_Click(object sender, EventArgs e)
        {
            ResetFields();
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
