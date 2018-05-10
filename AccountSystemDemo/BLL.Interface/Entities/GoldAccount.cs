using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Interface.Entities
{
    public class GoldAccount : Account
    {
        public GoldAccount(string id, string firstName, string lastName, decimal amount, int points, string email)
        : base(id, firstName, lastName, amount, points, email)
        {
            BonusValue = 2;
        }

        public override string ToString() => "Gold Account" + base.ToString();

        public override int CalculatePointsForDeposit(int bonusValue) => 20 * bonusValue + 15;
        public override int CalculatePointsForWithdraw(int bonusValue) => 20 * bonusValue + 5;

        protected override bool IsValidBalance(decimal value)
            => value >= -1000;
    }
}
