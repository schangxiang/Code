using ESTM.Common.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESTM.Service.IBLL
{
    public interface IServiceUser
    {
        List<DTO_USERS> GetAllUser();

        void AddUser(DTO_USERS oUser);
    }
}
