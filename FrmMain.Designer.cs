namespace MoneyManager
{
    partial class FrmMain
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
            this.accountManagementButton = new System.Windows.Forms.Button();
            this.ExpensesButton = new System.Windows.Forms.Button();
            this.incomesButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(408, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Money Manager";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.accountManagementButton, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.ExpensesButton, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.incomesButton, 1, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(15, 54);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(405, 133);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // accountManagementButton
            // 
            this.accountManagementButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.accountManagementButton.Location = new System.Drawing.Point(136, 3);
            this.accountManagementButton.Name = "accountManagementButton";
            this.accountManagementButton.Size = new System.Drawing.Size(132, 38);
            this.accountManagementButton.TabIndex = 1;
            this.accountManagementButton.TabStop = false;
            this.accountManagementButton.Text = "Account Management";
            this.accountManagementButton.UseVisualStyleBackColor = true;
            this.accountManagementButton.Click += new System.EventHandler(this.accountManagementButton_Click);
            // 
            // ExpensesButton
            // 
            this.ExpensesButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ExpensesButton.Location = new System.Drawing.Point(136, 91);
            this.ExpensesButton.Name = "ExpensesButton";
            this.ExpensesButton.Size = new System.Drawing.Size(132, 38);
            this.ExpensesButton.TabIndex = 3;
            this.ExpensesButton.TabStop = false;
            this.ExpensesButton.Text = "Expenses";
            this.ExpensesButton.UseVisualStyleBackColor = true;
            // 
            // incomesButton
            // 
            this.incomesButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.incomesButton.Location = new System.Drawing.Point(136, 47);
            this.incomesButton.Name = "incomesButton";
            this.incomesButton.Size = new System.Drawing.Size(132, 38);
            this.incomesButton.TabIndex = 2;
            this.incomesButton.TabStop = false;
            this.incomesButton.Text = "Incomes";
            this.incomesButton.UseVisualStyleBackColor = true;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 258);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.label1);
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Money Manager";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button accountManagementButton;
        private System.Windows.Forms.Button ExpensesButton;
        private System.Windows.Forms.Button incomesButton;
    }
}

