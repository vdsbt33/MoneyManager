﻿namespace MoneyManager.View.Account_Type
{
    partial class FrmManageAccountType
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.deleteAccountTypeBtn = new System.Windows.Forms.Button();
            this.editAccountTypeBtn = new System.Windows.Forms.Button();
            this.addAccountTypeBtn = new System.Windows.Forms.Button();
            this.accountTypeGridView = new System.Windows.Forms.DataGridView();
            this.idAccount_Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameAccount_Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.accountTypeGridView)).BeginInit();
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
            this.label1.TabIndex = 2;
            this.label1.Text = "Manage Account Type";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.tableLayoutPanel1.Controls.Add(this.deleteAccountTypeBtn, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.editAccountTypeBtn, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.addAccountTypeBtn, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(15, 57);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(515, 31);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // deleteAccountTypeBtn
            // 
            this.deleteAccountTypeBtn.Location = new System.Drawing.Point(302, 4);
            this.deleteAccountTypeBtn.Name = "deleteAccountTypeBtn";
            this.deleteAccountTypeBtn.Size = new System.Drawing.Size(75, 23);
            this.deleteAccountTypeBtn.TabIndex = 1;
            this.deleteAccountTypeBtn.Text = "Delete";
            this.deleteAccountTypeBtn.UseVisualStyleBackColor = true;
            this.deleteAccountTypeBtn.Click += new System.EventHandler(this.deleteAccountTypeBtn_Click);
            // 
            // editAccountTypeBtn
            // 
            this.editAccountTypeBtn.Location = new System.Drawing.Point(220, 4);
            this.editAccountTypeBtn.Name = "editAccountTypeBtn";
            this.editAccountTypeBtn.Size = new System.Drawing.Size(75, 23);
            this.editAccountTypeBtn.TabIndex = 2;
            this.editAccountTypeBtn.Text = "Edit";
            this.editAccountTypeBtn.UseVisualStyleBackColor = true;
            this.editAccountTypeBtn.Click += new System.EventHandler(this.editAccountTypeBtn_Click);
            // 
            // addAccountTypeBtn
            // 
            this.addAccountTypeBtn.Location = new System.Drawing.Point(138, 4);
            this.addAccountTypeBtn.Name = "addAccountTypeBtn";
            this.addAccountTypeBtn.Size = new System.Drawing.Size(75, 23);
            this.addAccountTypeBtn.TabIndex = 0;
            this.addAccountTypeBtn.Text = "Add";
            this.addAccountTypeBtn.UseVisualStyleBackColor = true;
            this.addAccountTypeBtn.Click += new System.EventHandler(this.addAccountTypeBtn_Click);
            // 
            // accountTypeGridView
            // 
            this.accountTypeGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.accountTypeGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.accountTypeGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idAccount_Type,
            this.nameAccount_Type});
            this.accountTypeGridView.Location = new System.Drawing.Point(15, 94);
            this.accountTypeGridView.MultiSelect = false;
            this.accountTypeGridView.Name = "accountTypeGridView";
            this.accountTypeGridView.ReadOnly = true;
            this.accountTypeGridView.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.accountTypeGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.accountTypeGridView.Size = new System.Drawing.Size(515, 244);
            this.accountTypeGridView.TabIndex = 5;
            this.accountTypeGridView.SelectionChanged += new System.EventHandler(this.accountTypeGridView_SelectionChanged);
            // 
            // idAccount_Type
            // 
            this.idAccount_Type.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.idAccount_Type.FillWeight = 20.30457F;
            this.idAccount_Type.HeaderText = "ID";
            this.idAccount_Type.Name = "idAccount_Type";
            this.idAccount_Type.ReadOnly = true;
            // 
            // nameAccount_Type
            // 
            this.nameAccount_Type.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nameAccount_Type.FillWeight = 179.6954F;
            this.nameAccount_Type.HeaderText = "Name";
            this.nameAccount_Type.Name = "nameAccount_Type";
            this.nameAccount_Type.ReadOnly = true;
            // 
            // FrmManageAccountType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(542, 350);
            this.Controls.Add(this.accountTypeGridView);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.label1);
            this.Name = "FrmManageAccountType";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Money Manager - Manage Account Type";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmManageAccountType_FormClosing);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.accountTypeGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button deleteAccountTypeBtn;
        private System.Windows.Forms.Button editAccountTypeBtn;
        private System.Windows.Forms.Button addAccountTypeBtn;
        private System.Windows.Forms.DataGridView accountTypeGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn idAccount_Type;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameAccount_Type;
    }
}