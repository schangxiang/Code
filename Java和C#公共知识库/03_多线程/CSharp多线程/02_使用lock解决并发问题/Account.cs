using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SecureAcount
{
    class Account
    {
        //持有人
        private string _holderName;
        public string HolderName
        {
            get { return _holderName; }
            set { _holderName = value; }
        }

        //密码
        private string _password;
        public string Password
        {
            get { return _password; }
            set { _password = value; }
        }

        //账号余额
        private float _amount;
        public float Amount
        {
            get { return _amount; }
            set { _amount = value; }
        }

        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="holdderName"></param>
        /// <param name="password"></param>
        /// <param name="amount"></param>
        public Account(string holdderName, string password, float amount)
        {
            this._holderName = holdderName;
            this._password = password;
            this._amount = amount;
        }

        //存款
        public void Deposit(float amount)
        {
            if (amount > 0)
            {
                this._amount = this._amount + amount;
            }
        }

        //取款
        public void Withdraw(float amount)
        {
            if (this._amount >= amount && amount > 0)
            {
                this._amount = this._amount - amount;
            }
        }
        //获取余额
        public float CheckBalance()
        {
            return this._amount;
        }
    }
}
