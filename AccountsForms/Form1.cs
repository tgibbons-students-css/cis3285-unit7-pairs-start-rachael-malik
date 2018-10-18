using Domain;
using Services;
using System;
using System.Windows.Forms;

namespace AccountsForms
{
    /// <summary>
    /// This is the main GUI form for the accounts
    /// </summary>
    public partial class Form1 : Form
    {
        /// <summary>
        /// accService is the link to the accounts through the 
        /// IAccountServices interface
        /// </summary>
        IAccountServices accService = new AccountService();
        public Form1()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Create a new account button 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAddAccount_Click(object sender, EventArgs e)
        {
            string accountName = txtAccountName.Text;
            listBoxAccounts.Items.Add(accountName);
            txtAccountName.Text = ""; 

            accService.CreateAccount(accountName, AccountType.Silver);
        }
        /// <summary>
        /// Account listbox item selected
        /// Find the account and update the balance displayed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void listBoxAccounts_SelectedIndexChanged(object sender, EventArgs e)
        {
            string accName = listBoxAccounts.SelectedItem.ToString();
            decimal balance = accService.GetAccountBalance(accName);
            string reward = accService.GetRewardPoints(accName).ToString();

            txtBalance.Text = balance.ToString();
            pointstxt.Text = reward.ToString();
        }
        //As a user, I want to be able to select the account I want, so that I can deposit or withdraw money to a specific account.


        private void txtBalance_TextChanged(object sender, EventArgs e)
        {

        }

        private void pointstxt_TextChanged(object sender, EventArgs e)
        {
           
        }

        //As a user, I want to be able to deposit an amount, so that I have money in my account.
        private void btnDeposit_Click(object sender, EventArgs e)
        {
            Decimal amount = Decimal.Parse(txtDepositAmount.Text);
            string accName = listBoxAccounts.SelectedItem.ToString();
            accService.Deposit(accName, amount);
            txtDepositAmount.Text = "";

            Decimal bal = accService.GetAccountBalance(accName);
            txtBalance.Text = bal.ToString();
        }

        //As a user, I want to be able to withdraw money, so that I can purchase items.
        private void btnWithDrawal_Click(object sender, EventArgs e)
        {
            Decimal amount = Decimal.Parse(txtWithdrawalAmount.Text);
            string accName = listBoxAccounts.SelectedItem.ToString();
            accService.Withdrawal(accName, amount);
            txtWithdrawalAmount.Text = "";

            Decimal bal = accService.GetAccountBalance(accName);
            txtBalance.Text = bal.ToString();
        }

        //As a user, I want to be able to input the exact amount I want to deposit, so that I don't have to visit the bank.
        private void txtDepositAmount_TextChanged(object sender, EventArgs e)
        {

        }


        //As a user, I want to be able to input the exact amount of money I want to withdraw, so that I can receive the amount of money I need.
        private void txtWithdrawalAmount_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
