using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Interface.Entities
{
    public class BaseAccount : Account
    {
        public BaseAccount(string id, string firstName, string lastName, decimal amount, int points, string email)
        : base(id, firstName, lastName, amount, points, email)
        {
            BonusValue = 1;
        }

        public override string ToString() => "Base Account" + base.ToString();

        public override int CalculatePointsForDeposit(int bonusValue) => 10 * bonusValue;
        public override int CalculatePointsForWithdraw(int bonusValue) => 10 * bonusValue;

        protected override bool IsValidBalance(decimal value)
            => value >= 0;
    }
}
