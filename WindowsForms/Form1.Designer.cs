namespace WindowsForms
{
    partial class Form1
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
            this.btnAddDeposit = new System.Windows.Forms.Button();
            this.txtDeposit = new System.Windows.Forms.TextBox();
            this.txtBalance = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAddAccount = new System.Windows.Forms.Button();
            this.txtAccountName = new System.Windows.Forms.TextBox();
            this.lbAccounts = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnAddDeposit
            // 
            this.btnAddDeposit.Location = new System.Drawing.Point(212, 80);
            this.btnAddDeposit.Name = "btnAddDeposit";
            this.btnAddDeposit.Size = new System.Drawing.Size(75, 23);
            this.btnAddDeposit.TabIndex = 0;
            this.btnAddDeposit.Text = "Add Deposit";
            this.btnAddDeposit.UseVisualStyleBackColor = true;
            this.btnAddDeposit.Click += new System.EventHandler(this.btnAddDeposit_Click);
            // 
            // txtDeposit
            // 
            this.txtDeposit.Location = new System.Drawing.Point(293, 82);
            this.txtDeposit.Name = "txtDeposit";
            this.txtDeposit.Size = new System.Drawing.Size(100, 20);
            this.txtDeposit.TabIndex = 1;
            // 
            // txtBalance
            // 
            this.txtBalance.Location = new System.Drawing.Point(293, 43);
            this.txtBalance.Name = "txtBalance";
            this.txtBalance.Size = new System.Drawing.Size(100, 20);
            this.txtBalance.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(212, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Balance";
            // 
            // btnAddAccount
            // 
            this.btnAddAccount.Location = new System.Drawing.Point(29, 98);
            this.btnAddAccount.Name = "btnAddAccount";
            this.btnAddAccount.Size = new System.Drawing.Size(114, 23);
            this.btnAddAccount.TabIndex = 4;
            this.btnAddAccount.Text = "Add Account";
            this.btnAddAccount.UseVisualStyleBackColor = true;
            this.btnAddAccount.Click += new System.EventHandler(this.btnAddAccount_Click);
            // 
            // txtAccountName
            // 
            this.txtAccountName.Location = new System.Drawing.Point(29, 61);
            this.txtAccountName.Name = "txtAccountName";
            this.txtAccountName.Size = new System.Drawing.Size(114, 20);
            this.txtAccountName.TabIndex = 5;
            // 
            // lbAccounts
            // 
            this.lbAccounts.FormattingEnabled = true;
            this.lbAccounts.Location = new System.Drawing.Point(28, 154);
            this.lbAccounts.Name = "lbAccounts";
            this.lbAccounts.Size = new System.Drawing.Size(136, 173);
            this.lbAccounts.TabIndex = 6;
            this.lbAccounts.SelectedIndexChanged += new System.EventHandler(this.lbAccounts_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(538, 372);
            this.Controls.Add(this.lbAccounts);
            this.Controls.Add(this.txtAccountName);
            this.Controls.Add(this.btnAddAccount);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBalance);
            this.Controls.Add(this.txtDeposit);
            this.Controls.Add(this.btnAddDeposit);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddDeposit;
        private System.Windows.Forms.TextBox txtDeposit;
        private System.Windows.Forms.TextBox txtBalance;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAddAccount;
        private System.Windows.Forms.TextBox txtAccountName;
        private System.Windows.Forms.ListBox lbAccounts;
    }
}

