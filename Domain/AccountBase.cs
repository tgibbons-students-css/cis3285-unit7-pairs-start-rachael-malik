using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public abstract class AccountBase
    {   /// <summary>
        /// Factory method to create the correct type of account
        /// given the account type.
        /// </summary>
        /// <param name="type"></param>
        /// <returns></returns>
        public static AccountBase CreateAccount(AccountType type)
        {
            AccountBase account = null;
            switch(type)
            {
                case AccountType.Silver:
                    account = new SilverAccount();
                    break;
                case AccountType.Gold:
                    account = new GoldAccount();
                    break;
                case AccountType.Platinum:
                    account = new PlatinumAccount();
                    break;
            }
            return account;
        }

        public decimal Balance
        {
            get;
            private set;
        }

        public int RewardPoints
        {
            get;
            private set;
        }
        /// <summary>
        /// Used to add a deposit or subtract a withdrawal from
        /// the account. Withdrawals will have negative amount
        /// </summary>
        /// <param name="amount"></param>
        public void AddTransaction(decimal amount)
        {
            // only award reward points on deposit
            if (amount>0) RewardPoints += CalculateRewardPoints(amount);
            // always update balance
            Balance += amount;
        }
        /// <summary>
        /// Implemented in the child classes
        /// </summary>
        /// <param name="amount"></param>
        /// <returns></returns>
        public abstract int CalculateRewardPoints(decimal amount);
    }
}
