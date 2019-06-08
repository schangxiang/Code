using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_实现构造注入
{
    class UserService : IUserService
    {
        public IUserDao IUserDao;

        public UserService(IUserDao UserDao)
        {
            this.IUserDao = UserDao;
        }

        public void MyDisplay(string msg)
        {
            Console.WriteLine("Service输出Dao的内容:" +IUserDao.Display(msg));
        }
    }
}
