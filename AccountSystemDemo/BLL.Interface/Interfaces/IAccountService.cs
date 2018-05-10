using BLL.Interface.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Interface.Interfaces
{
    public interface IAccountService
    {
        Account CreateAccount(AccountType accountType, string firstName, string lastName, decimal amount, string email);
        void AddMoney(Account account, decimal money);
        void AddMoney(string account, decimal money);
        void DivMoney(Account account, decimal money);
        void DivMoney(string accountId, decimal money);
        void CloseAccout(Account account);
        void CloseAccout(string accountId);
        string GetAccount(string accountId);
    }
}
