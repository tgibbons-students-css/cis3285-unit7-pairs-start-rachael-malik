using System;
using System.Windows.Forms;
using Services;
using Domain;

namespace WindowsForms
{
    public partial class Form1 : Form
    {

        AccountService acctService = new AccountService();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void btnAddDeposit_Click(object sender, EventArgs e)
        {
            decimal amount = decimal.Parse( txtDeposit.Text );
            string accName = lbAccounts.SelectedItem.ToString();
            acctService.Deposit(accName, amount);
            txtBalance.Text = acctService.GetAccountBalance(accName).ToString();
        }

        private void btnAddAccount_Click(object sender, EventArgs e)
        {
            string accountName = txtAccountName.Text;
            lbAccounts.Items.Add(accountName);
            acctService.CreateAccount(accountName, AccountType.Silver);
        }

        private void lbAccounts_SelectedIndexChanged(object sender, EventArgs e)
        {
            string accName = lbAccounts.SelectedItem.ToString();
            txtAccountName.Text = accName;
            txtBalance.Text = acctService.GetAccountBalance(accName).ToString();

        }
    }
}
