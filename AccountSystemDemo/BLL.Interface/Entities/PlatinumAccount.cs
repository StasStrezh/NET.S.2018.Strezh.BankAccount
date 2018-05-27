using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Interface.Entities
{
    public class PlatinumAccount : Account
    {
        public PlatinumAccount(string id, string firstName, string lastName, decimal amount, int points)
        : base(id, firstName, lastName, amount, points)
        {
            BonusValue = 3;
        }

        public override string ToString() => "Platimun Account" + base.ToString();

        public override int CalculatePointsForDeposit(int bonusValue) => 30 * bonusValue + 30;
        public override int CalculatePointsForWithdraw(int bonusValue) => 30 * bonusValue + 10;

        protected override bool IsValidBalance(decimal value)
            => value >= -10000;
    }
}
