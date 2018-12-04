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
            UpdateGrid();
        }

        /// <summary>
        /// Updates the GridView to match the List<T>
        /// </summary>
        private void UpdateGrid()
        {
            accountTypeGridView.Rows.Clear();

            foreach (Model.Account_Type at in accounts)
            {
                int index = accountTypeGridView.Rows.Add();
                accountTypeGridView.Rows[index].Cells[0].Value = at.idAccount_Type;
                accountTypeGridView.Rows[index].Cells[1].Value = at.nameAccount_Type;
            }
        }
        
        private void FrmManageAccountType_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
