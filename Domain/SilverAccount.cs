using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{

    internal class SilverAccount : AccountBase
    {
        /// <summary>
        /// 1 point for each $10 deposited
        /// </summary>
        /// <param name="amount"></param>
        /// <returns></returns>
        public override int CalculateRewardPoints(decimal amount)
        {
            return (int)decimal.Floor(amount / SilverTransactionCostPerPoint);
        }

        private const int SilverTransactionCostPerPoint = 10;
    }
}
