using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_实现构造注入
{
    class UserDao:IUserDao
    {
        public string Display(string msg)
        {
            return msg;
        }
    }
}
