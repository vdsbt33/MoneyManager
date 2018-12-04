namespace MoneyManager.View.Account
{
    partial class FrmManageAccount
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.accountGridView = new System.Windows.Forms.DataGridView();
            this.idAccount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameAccount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.balanceAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.memoAccount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.accountType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.deleteAccountBtn = new System.Windows.Forms.Button();
            this.editAccountBtn = new System.Windows.Forms.Button();
            this.addAccountBtn = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.accountTypeBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.accountGridView)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(518, 30);
            this.label1.TabIndex = 1;
            this.label1.Text = "Manage Account";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // accountGridView
            // 
            this.accountGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.accountGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.accountGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idAccount,
            this.nameAccount,
            this.balanceAmount,
            this.memoAccount,
            this.accountType});
            this.accountGridView.Location = new System.Drawing.Point(15, 94);
            this.accountGridView.MultiSelect = false;
            this.accountGridView.Name = "accountGridView";
            this.accountGridView.ReadOnly = true;
            this.accountGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.accountGridView.Size = new System.Drawing.Size(515, 209);
            this.accountGridView.TabIndex = 0;
            this.accountGridView.TabStop = false;
            // 
            // idAccount
            // 
            this.idAccount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.idAccount.FillWeight = 44.50533F;
            this.idAccount.HeaderText = "ID";
            this.idAccount.Name = "idAccount";
            this.idAccount.ReadOnly = true;
            // 
            // nameAccount
            // 
            this.nameAccount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nameAccount.FillWeight = 131.655F;
            this.nameAccount.HeaderText = "Name";
            this.nameAccount.Name = "nameAccount";
            this.nameAccount.ReadOnly = true;
            // 
            // balanceAmount
            // 
            this.balanceAmount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.balanceAmount.FillWeight = 98.46803F;
            this.balanceAmount.HeaderText = "Balance";
            this.balanceAmount.Name = "balanceAmount";
            this.balanceAmount.ReadOnly = true;
            // 
            // memoAccount
            // 
            this.memoAccount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.memoAccount.FillWeight = 126.9036F;
            this.memoAccount.HeaderText = "Memo";
            this.memoAccount.Name = "memoAccount";
            this.memoAccount.ReadOnly = true;
            // 
            // accountType
            // 
            this.accountType.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.accountType.FillWeight = 98.46803F;
            this.accountType.HeaderText = "Account Type";
            this.accountType.Name = "accountType";
            this.accountType.ReadOnly = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.deleteAccountBtn, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.editAccountBtn, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.addAccountBtn, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(15, 57);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(515, 31);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // deleteAccountBtn
            // 
            this.deleteAccountBtn.Location = new System.Drawing.Point(302, 4);
            this.deleteAccountBtn.Name = "deleteAccountBtn";
            this.deleteAccountBtn.Size = new System.Drawing.Size(75, 23);
            this.deleteAccountBtn.TabIndex = 3;
            this.deleteAccountBtn.Text = "Delete";
            this.deleteAccountBtn.UseVisualStyleBackColor = true;
            // 
            // editAccountBtn
            // 
            this.editAccountBtn.Location = new System.Drawing.Point(220, 4);
            this.editAccountBtn.Name = "editAccountBtn";
            this.editAccountBtn.Size = new System.Drawing.Size(75, 23);
            this.editAccountBtn.TabIndex = 2;
            this.editAccountBtn.Text = "Edit";
            this.editAccountBtn.UseVisualStyleBackColor = true;
            // 
            // addAccountBtn
            // 
            this.addAccountBtn.Location = new System.Drawing.Point(138, 4);
            this.addAccountBtn.Name = "addAccountBtn";
            this.addAccountBtn.Size = new System.Drawing.Size(75, 23);
            this.addAccountBtn.TabIndex = 1;
            this.addAccountBtn.Text = "Add";
            this.addAccountBtn.UseVisualStyleBackColor = true;
            this.addAccountBtn.Click += new System.EventHandler(this.addAccountBtn_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.00001F));
            this.tableLayoutPanel2.Controls.Add(this.accountTypeBtn, 1, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(15, 309);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(515, 29);
            this.tableLayoutPanel2.TabIndex = 4;
            // 
            // accountTypeBtn
            // 
            this.accountTypeBtn.Location = new System.Drawing.Point(192, 3);
            this.accountTypeBtn.Name = "accountTypeBtn";
            this.accountTypeBtn.Size = new System.Drawing.Size(130, 23);
            this.accountTypeBtn.TabIndex = 4;
            this.accountTypeBtn.Text = "Manage Account Types";
            this.accountTypeBtn.UseVisualStyleBackColor = true;
            this.accountTypeBtn.Click += new System.EventHandler(this.accountTypeBtn_Click);
            // 
            // FrmManageAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(542, 350);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.accountGridView);
            this.Controls.Add(this.label1);
            this.MinimumSize = new System.Drawing.Size(558, 329);
            this.Name = "FrmManageAccount";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Money Manager - Manage Account";
            ((System.ComponentModel.ISupportInitialize)(this.accountGridView)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView accountGridView;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button deleteAccountBtn;
        private System.Windows.Forms.Button editAccountBtn;
        private System.Windows.Forms.Button addAccountBtn;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button accountTypeBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idAccount;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameAccount;
        private System.Windows.Forms.DataGridViewTextBoxColumn balanceAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn memoAccount;
        private System.Windows.Forms.DataGridViewTextBoxColumn accountType;
    }
}