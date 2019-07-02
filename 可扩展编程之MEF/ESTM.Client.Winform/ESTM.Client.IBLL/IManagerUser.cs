using ESTM.Common.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESTM.Client.IBLL
{
    public interface IManagerUser
    {
        List<DTO_USERS> GetAllUser();
    }
}
