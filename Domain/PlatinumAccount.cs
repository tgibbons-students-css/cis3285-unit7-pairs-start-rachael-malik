using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    internal class PlatinumAccount : AccountBase
    {
        /// <summary>
        /// 1 point for each $2 deposited
        /// 1 point for each $1,000 in account balance
        /// </summary>
        /// <param name="amount"></param>
        /// <returns></returns>
        public override int CalculateRewardPoints(decimal amount)
        {
            return Math.Max((int)decimal.Ceiling((Balance / PlatinumBalanceCostPerPoint) + (amount / PlatinumTransactionCostPerPoint)), 0);
        }

        private const int PlatinumTransactionCostPerPoint = 2;
        private const int PlatinumBalanceCostPerPoint = 1000;
    }
}
