using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_配置文件注册
{
    class UserDao:IUserDao
    {
        public string Display(string msg)
        {
            return msg;
        }
    }
}
