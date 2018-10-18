using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    internal class GoldAccount : AccountBase
    {
        /// <summary>
        /// 1 point for each $5 deposited
        /// 1 point for each $2,000 in account balance
        /// </summary>
        /// <param name="amount"></param>
        /// <returns></returns>
        public override int CalculateRewardPoints(decimal amount)
        {
            return (int)decimal.Floor((Balance / GoldBalanceCostPerPoint) + (amount / GoldTransactionCostPerPoint));
        }

        private const int GoldTransactionCostPerPoint = 5;
        private const int GoldBalanceCostPerPoint = 2000;
    }
}
