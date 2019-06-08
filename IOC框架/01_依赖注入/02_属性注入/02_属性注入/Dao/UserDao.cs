using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_属性注入
{
    class UserDao:IUserDao
    {
        public string Display(string msg)
        {
            return msg;
        }
    }
}
