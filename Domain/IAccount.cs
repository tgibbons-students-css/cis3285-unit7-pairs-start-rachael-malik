﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
     public interface IAccount
    {
        decimal Balance
        {
            get;
            set;
        }

        int RewardPoints
        {
            get;
            set;
        }
        /// <summary>
        /// Used to add a deposit or subtract a withdrawal from
        /// the account. Withdrawals will have negative amount
        /// </summary>
        /// <param name="amount"></param>
        void AddTransaction(decimal amount);
        
        /// <summary>
        /// Implemented in the child classes
        /// </summary>
        /// <param name="amount"></param>
        /// <returns></returns>
        int CalculateRewardPoints(decimal amount);

        
    }
}
