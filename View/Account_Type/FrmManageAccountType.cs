using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using MoneyManager.Model;
using MoneyManager.Controller;

using MoneyManager.View.Account;

namespace MoneyManager.View.Account_Type
{
    public partial class FrmManageAccountType : Form
    {
        // Variables
        List<Model.Account_Type> accounts;

        public FrmManageAccountType()
        {
            InitializeComponent();

            accounts = Account_TypeDAO.GetSelf().GetAccountAll();
            UpdateList();
        }

        private void accountTypeGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (accountTypeGridView.SelectedRows.Count > 0 && accountTypeGridView.SelectedRows[0].Cells[0].Value != null)
            {
                editAccountTypeBtn.Enabled = true;
                deleteAccountTypeBtn.Enabled = true;
            }
            else
            {
                editAccountTypeBtn.Enabled = false;
                deleteAccountTypeBtn.Enabled = false;
            }
        }

        /// <summary>
        /// Updates the GridView to match the List<T>
        /// </summary>
        private void UpdateList()
        {
            accounts = Account_TypeDAO.GetSelf().GetAccountAll();

            if (accounts.Count > 0) {
                // Update GridView
                accountTypeGridView.Rows.Clear();

                foreach (Model.Account_Type at in accounts)
                {
                    int index = accountTypeGridView.Rows.Add();
                    accountTypeGridView.Rows[index].Cells[0].Value = at.idAccount_Type;
                    accountTypeGridView.Rows[index].Cells[1].Value = at.nameAccount_Type;
                }
            }
        }
        
        private void FrmManageAccountType_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        // Adds Account_Type
        private void addAccountTypeBtn_Click(object sender, EventArgs e)
        {
            FrmAddAccountType form = new FrmAddAccountType();
            if (form.ShowDialog() == DialogResult.OK)
            {
                UpdateList();
            }
        }

        // Edit Account Type
        private void editAccountTypeBtn_Click(object sender, EventArgs e)
        {

        }

        // Delete Account Type
        private void deleteAccountTypeBtn_Click(object sender, EventArgs e)
        {
            if (accountTypeGridView.SelectedRows[0].Cells[0].Value != null)
            {
                // Verifies if Account Type is not being used at the moment
                int useAmount = Account_TypeDAO.GetSelf().GetAccount_TypeCount(accounts[accountTypeGridView.SelectedRows[0].Index]);
                if (useAmount <= 0)
                {
                    if (MessageBox.Show("Are you sure you want to remove the Account Type " + accounts[accountTypeGridView.SelectedRows[0].Index].nameAccount_Type + "?", "Alert", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        if (Account_TypeDAO.GetSelf().RemoveAccount_Type(accounts[accountTypeGridView.SelectedRows[0].Index]) == true)
                        {
                            accounts.Remove(accounts[accountTypeGridView.SelectedRows[0].Index]);
                            UpdateList();
                            MessageBox.Show("Account Type removed sucessfully.");
                        }
                        else
                        {
                            MessageBox.Show("It was not possible to remove the selected account.");
                        }
                    }

                }
                else
                {
                    // If Account Type is being used
                    MessageBox.Show("There are " + useAmount + " Account(s) using this Account Type. Change them before removing this type.", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

    }
}
