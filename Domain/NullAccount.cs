using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class NullAccount : IAccount
    {
        

        public decimal Balance { get; set; }
        public int RewardPoints { get; set; }

        public void AddTransaction(decimal amount) { }

        public int CalculateRewardPoints(decimal amount)
        {
            return 0;
        }
    }
}
