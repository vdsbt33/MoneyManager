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
using MoneyManager.Model;
using MoneyManager.Controller;

namespace MoneyManager.View.Account
{
    public partial class FrmManageAccount : Form
    {
        private List<Model.Account> accounts;
       
        public FrmManageAccount()
        {
            InitializeComponent();

            UpdateList();
        }

        /// <summary>
        /// Updates accounts List<T>
        /// </summary>
        private void UpdateList()
        {
            accounts = AccountDAO.GetSelf().GetAllAccounts();

            if (accounts.Count > 0) {
                // Update GridView
                accountGridView.Rows.Clear();

                foreach (Model.Account at in accounts)
                {
                    int index = accountGridView.Rows.Add();
                    accountGridView.Rows[index].Cells[0].Value = at.idAccount;
                    accountGridView.Rows[index].Cells[1].Value = at.nameAccount;
                    accountGridView.Rows[index].Cells[2].Value = at.balanceAccount;
                    accountGridView.Rows[index].Cells[3].Value = at.memoAccount;
                    accountGridView.Rows[index].Cells[4].Value = at.accountType.nameAccount_Type;

                }
            }
        }

        private void accountTypeBtn_Click(object sender, EventArgs e)
        {
            FrmManageAccountType form = new FrmManageAccountType();
            this.Hide();
            if (form.ShowDialog() == DialogResult.Cancel)
            {
                this.Show();
                UpdateList();
            }
        }

        private void addAccountBtn_Click(object sender, EventArgs e)
        {
            FrmAddAccount form = new FrmAddAccount(accounts);
            if (form.ShowDialog() == DialogResult.OK)
            {
                UpdateList();
            }
        }

        private void editAccountBtn_Click(object sender, EventArgs e)
        {
            FrmEditAccount form = new FrmEditAccount(accounts[accountGridView.SelectedRows[0].Index]);
            if (form.ShowDialog() == DialogResult.OK)
            {
                UpdateList();
            }
        }

        private void accountGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (accountGridView.SelectedRows.Count > 0 && accountGridView.SelectedRows[0].Cells[0].Value != null)
            {
                editAccountBtn.Enabled = true;
                deleteAccountBtn.Enabled = true;
            } else
            {
                editAccountBtn.Enabled = false;
                deleteAccountBtn.Enabled = false;
            }
        }

        private void deleteAccountBtn_Click(object sender, EventArgs e)
        {
            if (accountGridView.SelectedRows[0].Cells[0].Value != null)
            {

                if (MessageBox.Show("Are you sure you want to remove the account " + accounts[accountGridView.SelectedRows[0].Index].nameAccount + "?", "Alert", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (AccountDAO.GetSelf().RemoveAccount(accounts[accountGridView.SelectedRows[0].Index]) == true)
                    {
                        accounts.Remove(accounts[accountGridView.SelectedRows[0].Index]);
                        UpdateList();
                    } else
                    {
                        MessageBox.Show("It was not possible to remove the selected account.");
                    }
                }
            }
        }
    }
}
