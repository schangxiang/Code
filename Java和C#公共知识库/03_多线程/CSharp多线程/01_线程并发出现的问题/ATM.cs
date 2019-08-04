using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SecureAcount
{
    class ATM
    {
        //账号
        public Account account;

        //存款
        public void Deposit(float amount)
        {
            account.Deposit(amount);
        }

        //取款
        public void WithDraw(float amount)
        {
            account.Withdraw(amount);
        }

        //获取余额
        public float GetBalance() 
        {
            return account.CheckBalance();
        }
    }
}
