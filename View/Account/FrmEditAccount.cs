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

namespace MoneyManager.View.Account
{
    public partial class FrmEditAccount : Form
    {
        Model.Account account;
        List<Model.Account_Type> accountTypes;

        public FrmEditAccount(Model.Account targetAccount)
        {
            InitializeComponent();
            accountTypes = Controller.Account_TypeDAO.GetSelf().GetAccountAll();
            foreach (Model.Account_Type at in accountTypes)
            {
                accountType.Items.Add(at.nameAccount_Type);
            }
            account = targetAccount;
            nameAccount.Text = account.nameAccount;
            accountType.SelectedItem = account.accountType.nameAccount_Type;
            memoAccount.Text = account.memoAccount;
            balanceAccount.Minimum = (long)account.balanceAccount;
            balanceAccount.Maximum = (long)account.balanceAccount;
            balanceAccount.Value = (long) account.balanceAccount;
        }

        // Clears all fields
        /// <summary>
        /// Clears all fields on the Form
        /// </summary>
        private void ClearFields()
        {
            nameAccount.Clear();
            accountType.SelectedItem = null;
            memoAccount.Clear();
            balanceAccount.Minimum = 0;
            balanceAccount.Value = 0;
        }

        private void saveAccountBtn_Click(object sender, EventArgs e)
        {
            // Checks if required fields are filled
            if (nameAccount.Text.Count() > 0 && accountType.SelectedItem != null) {
                account.nameAccount = nameAccount.Text;
                account.accountType = accountTypes[accountType.SelectedIndex];
                account.memoAccount = memoAccount.Text;
                if (AccountDAO.GetSelf().UpdateAccount(account))
                {
                    ClearFields();
                    MessageBox.Show("Account changes saved.");
                    this.DialogResult = DialogResult.OK;
                }
                else
                {
                    MessageBox.Show("Changes were not saved. An error ocurred.");
                    ClearFields();
                    this.DialogResult = DialogResult.Cancel;
                }
            } else
            {
                MessageBox.Show("You must fill all required fields.");
            }
        }

        private void cancelAccountBtn_Click(object sender, EventArgs e)
        {
            ClearFields();
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
